using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
using System.Windows.Forms;
using TX.Framework.WindowUI.Forms;
using WJG.bll;


namespace WJG
{
    public unsafe partial class FromStaff : BaseForm
    {
        public StringBuilder name;     //姓名
        public String sex;      //性别
        public String people;    //民族，护照识别时此项为空
        public String birthday;   //出生日期
        public String address;  //地址，在识别护照时导出的是国籍简码
        public string number;  //地址，在识别护照时导出的是国籍简码
        public string signdate;   //签发日期，在识别护照时导出的是有效期至 
        public string validtermOfStart;  //有效起始日期，在识别护照时为空
        public string validtermOfEnd;  //有效截止日期，在识别护照时为空
        //public Image 
        int iRetUSB = 0, iRetCOM = 0;
        public FromStaff()
        {
            InitializeComponent();
        }

        private void IdCard_Load(object sender, EventArgs e)
        {
            try
            {
                int iPort;
                for (iPort = 1001; iPort <= 1016; iPort++)
                {
                    iRetUSB = CVRSDK.CVR_InitComm(iPort);
                    if (iRetUSB == 1)
                    {
                        break;
                    }
                }
                if (iRetUSB != 1)
                {
                    for (iPort = 1; iPort <= 4; iPort++)
                    {
                        iRetCOM = CVRSDK.CVR_InitComm(iPort);
                        if (iRetCOM == 1)
                        {
                            break;
                        }
                    }
                }
                if ((iRetCOM == 1) || (iRetUSB == 1))
                {
                    this.lablelInitSet.Text = "初始化成功";
                    FillData();
                }
                else
                {
                    this.lablelInitSet.Text = "初始化失败";
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());

            }
            ///<summary>
            ///deptTreedata（）设置了部课数据源，传入的参数是一级目录有多少个，
            ///</summary>
            this.txTreeComboBoxDept.DataSource = SqlDiginer.DeptTreeData(4);
           
            this.txTreeComboBoxDept.MultiLevelDataSourceMember = "lessons";
            this.txTreeComboBoxDept.DisplayMember = "Name";
            this.txTreeComboBoxDept.ValueMember = "Value";
            this.txTreeComboBoxDept.BindData();

        }
        public void FillData()
        {
            try
            {
                pictureBox1.ImageLocation = "C:\\users\\"+Environment.UserName + "\\AppData\\Local\\Temp\\zp.bmp";
                byte[] name = new byte[30];
                int length = 30;
                //得到姓名信息
                CVRSDK.GetPeopleName(ref name[0], ref length);
                //MessageBox.Show();
                byte[] number = new byte[30];
                length = 36;
                CVRSDK.GetPeopleIDCode(ref number[0], ref length);
                byte[] people = new byte[30];
                length = 3;
                CVRSDK.GetPeopleNation(ref people[0], ref length);
                byte[] validtermOfStart = new byte[30];
                length = 16;
                CVRSDK.GetStartDate(ref validtermOfStart[0], ref length);
                byte[] birthday = new byte[30];
                length = 16;
                CVRSDK.GetPeopleBirthday(ref birthday[0], ref length);
                byte[] address = new byte[30];
                length = 70;
                CVRSDK.GetPeopleAddress(ref address[0], ref length);
                byte[] validtermOfEnd = new byte[30];
                length = 16;
                CVRSDK.GetEndDate(ref validtermOfEnd[0], ref length);
                byte[] signdate = new byte[30];
                length = 30;
                CVRSDK.GetDepartment(ref signdate[0], ref length);
                byte[] sex = new byte[30];
                length = 3;
                CVRSDK.GetPeopleSex(ref sex[0], ref length);

                byte[] samid = new byte[32];
                CVRSDK.CVR_GetSAMID(ref samid[0]);

                byte[] jpgdata = new byte[32];
                

                txTextBoxIdcard.Text = System.Text.Encoding.GetEncoding("GB2312").GetString(number).Replace("\0", "").Trim();
                TextBoxName.Text = System.Text.Encoding.GetEncoding("GB2312").GetString(name).Replace("\0", "").Trim();
                TextBoxSex.Text = System.Text.Encoding.GetEncoding("GB2312").GetString(sex).Replace("\0", "").Trim();
                txTextBoxAddress.Text= System.Text.Encoding.GetEncoding("GB2312").GetString(address).Replace("\0", "").Trim();
                //民族
                TextBoxNature.Text = System.Text.Encoding.GetEncoding("GB2312").GetString(people).Replace("\0","").Trim();
                #region 注释sdk中的字段
                //   MessageBox.Show("读取操作正在进行中");

                /*
                                lblAddress.Text = System.Text.Encoding.GetEncoding("GB2312").GetString(address).Replace("\0", "").Trim();
                                lblSex.Text = System.Text.Encoding.GetEncoding("GB2312").GetString(sex).Replace("\0", "").Trim();
                                lblBirthday.Text = System.Text.Encoding.GetEncoding("GB2312").GetString(birthday).Replace("\0", "").Trim();
                                lblDept.Text = System.Text.Encoding.GetEncoding("GB2312").GetString(signdate).Replace("\0", "").Trim();
                                lblIdCard.Text = System.Text.Encoding.GetEncoding("GB2312").GetString(number).Replace("\0", "").Trim();
                                labelName.Text = System.Text.Encoding.GetEncoding("GB2312").GetString(name).Replace("\0", "").Trim();
                                lblNation.Text = System.Text.Encoding.GetEncoding("GB2312").GetString(people).Replace("\0", "").Trim();
                                labelSamID.Text = "安全模块号：" + System.Text.Encoding.GetEncoding("GB2312").GetString(samid).Replace("\0", "").Trim();
                                lblValidDate.Text = System.Text.Encoding.GetEncoding("GB2312").GetString(validtermOfStart).Replace("\0", "").Trim() + "-" + System.Text.Encoding.GetEncoding("GB2312").GetString(validtermOfEnd).Replace("\0", "").Trim();
                */
                #endregion
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
        private void txButton1_Click(object sender, EventArgs e)
        {
            if (TextBoxName.Text == null || "".Equals(TextBoxName.Text))
            {
                MessageBox.Show("姓名未导入");
                return;
            }
            DateTime clktime = DateTime.Now;
            if (TextBoxZgbh.Text == null||"".Equals(TextBoxZgbh.Text))
            {
                MessageBox.Show("工号未填入");
                return;
            }
            try{
                DialogResult result = TXMessageBoxExtensions.Info("提醒", "是否确定提交？");
                if (result == DialogResult.OK)
                {
                    String zgbh = TextBoxZgbh.Text.Trim();
                    String name = TextBoxName.Text.Trim();
                    String sex = TextBoxSex.Text.Trim();
                    String idCard = txTextBoxIdcard.Text.Trim();
                    String creategory = txComboBoxCreatgory.Text.Trim();
                    String nature = TextBoxNature.Text.Trim();
                    String address = txTextBoxAddress.Text.Trim();
                    String pathTj = txTextBoxPathTJ.Text.Trim();
                    String birth = txTextBoxBirth.Text.Trim();
                    String age = txTextBoxAge.Text.Trim();
                    String marry = txComboBoxMarry.Text.Trim();
                    String hasChilder = txComboBoxHaschilder.Text.Trim();
                    String healthResult = txComboBoxHealthResult.Text.Trim();
                    String tel = txTextBoxTel.Text.Trim();
                    String linkman = txTextBoxLinkMan.Text.Trim();
                    String relaption = txComboBoxRelaption.Text.Trim();
                    String linkmanTel = txTextBoxLinkmanTel.Text.Trim();
                    String icid = txTextBoxIcid.Text.Trim();
                    String icidNumber = txTextBoxIcidNumber.Text.Trim();
                    String dept = txTreeComboBoxDept.Text.Trim();
                    String typeStaff = txComboBoxStaff.Text.Trim();
                    String reasonLeave = txTextBoxReasonLeave.Text.Trim();
                    String statusStaff = txComboBoxStatus.Text.Trim();
                    String clockSystem = txComboBoxClockSystem.Text.Trim();
                    String pushCard = txComboBoxPushCard.Text.Trim();
                    String canteenSystem = txComboBoxCanteenSystem.Text.Trim();
                   // String sql = String.Format("insert into stj_staff (zgbh,zgxm,xb,IDCARD,ID_CREATGORY,NATURE,HOUSE_REGISTER,PATH_TJ," +
                   //"BIRTHDAY,AGE,MARRY,HASCHILDER,HEALTH_DAY,HEALTH_RESULT,TEL,LINKMAN,LINKMAN_RELAPTION,LINKMAN_TEL,ICID,ICID_NUMBER," +
                   //"DEPT,LESSON,TYPE_STAFF,TIME_BEGIN,TIME_LEAVE,REASON_LEAVE,STATUS_STAFF,CLOCKSYSTEM,PUNCH_CARD,CANTEEN_SYSTEM) values({0},'{1}','{2}','{3}','{4}','{5}','{6}','{7}','{8}'," +
                   //"'{9}','{10}','{11}','{12}','{13}','{14}','{15}','{16}','{17}','{18}','{19}','{20}',{21},{22},'{23}','{24}','{25}','{26}','{27}','{28}')",
                   //zgbh, name, sex, idCard, creategory, nature, address, pathTj, birth, age, 
                   //marry, hasChilder, healthResult, tel, linkman, relaption, linkmanTel, icid, icidNumber, dept,
                   //dept, txDateTimePickerBegin.Value,txDateTimePickerLeave.Value,typeStaff, reasonLeave,
                   //statusStaff, clockSystem, pushCard, canteenSystem);
                   // SqlDiginer.ExecuteNoQuery(sql);

                    ///<summary>
                    ///-----------------------------------------------------------------------------------------------------------------------------------------------------
                    /// </summary>
                    int a = SqlDiginer.ExecuteNoQuery("  insert into stj_staff (zgbh,zgxm,xb,IDCARD,ID_CREATGORY,NATURE,HOUSE_REGISTER,PATH_TJ," +
                              "BIRTHDAY,AGE,MARRY,HASCHILDER,HEALTH_DAY,HEALTH_RESULT,TEL,LINKMAN,LINKMAN_RELAPTION,LINKMAN_TEL,ICID,ICID_NUMBER," +
                             "DEPT,LESSON,TYPE_STAFF,TIME_BEGIN,TIME_LEAVE,REASON_LEAVE,STATUS_STAFF,CLOCKSYSTEM,PUNCH_CARD,CANTEEN_SYSTEM) values('" + TextBoxZgbh.Text + "','" +
                              TextBoxName.Text + "','" + TextBoxSex.Text + "','" + txTextBoxIdcard.Text + "','" + txComboBoxCreatgory.Text.Trim() + "','" + TextBoxNature.Text + "','" + txTextBoxAddress.Text.Trim() + "','" +
                              txTextBoxPathTJ.Text.Trim() + "','" + txTextBoxBirth.Text.Trim() + "','" + txTextBoxAge.Text.Trim() + "','" + txComboBoxMarry.Text.Trim() + "','" + txComboBoxHaschilder.Text.Trim() + "','" +
                              txDateTimePickerHealth.Value + "','" + txComboBoxHealthResult.Text.Trim() + "','" + txTextBoxTel.Text.Trim() + "','" + txTextBoxLinkMan.Text.Trim() + "','" + txComboBoxRelaption.Text.Trim() + "','" +
                             txTextBoxLinkmanTel.Text.Trim() + "','" + txTextBoxIcid.Text.Trim() + "','" + txTextBoxIcidNumber.Text.Trim() + "','" + txTreeComboBoxDept.Text.Trim() + "','" + txTreeComboBoxDept.Text.Trim() + "','" +
                             txComboBoxStaff.Text.Trim() + "','" + txDateTimePickerBegin.Value + "','" + txDateTimePickerLeave.Value + "','" + txTextBoxReasonLeave.Text.Trim() + "','" + txComboBoxStaff.Text.Trim() + "','" +
                             txComboBoxClockSystem.Text.Trim() + "','" + txComboBoxPushCard.Text.Trim() + "','" + txComboBoxCanteenSystem.Text.Trim()
                              + "') ");

                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
           

            if (txComboBoxClockSystem.Text.Trim() == "Y")
            {
                String zgbh = TextBoxZgbh.Text.Trim();
                String name = TextBoxName.Text.Trim();
                String sex = TextBoxSex.Text.Trim();
                String icid = txTextBoxIcid.Text.Trim();
                String dept = txTreeComboBoxDept.Text.Trim();
                 DateTime clkdate=  DateTime.Now;
                String idcard = txTextBoxIdcard.Text.Trim();
                String sql =string.Format(" insert into hp_zd01 (zgbh,zgxm,xb,icid,bmmx,clkdate,idcard) values('{0}','{1}','{2}',{3},'{4}','{5}','{6}')",zgbh,name,sex,icid,dept,clkdate,idcard);
                SqlDiginer.ExecuteNoQuery(sql);

            }
            
            
            
            TXMessageBoxExtensions.Info("提示信息","信息已提交到数据库中，窗口关闭");
            //this.Close();

        }
     
        /**
         * 校验 手机号码
         */
        public bool IsHandset(string str_handset)
        {
            return System.Text.RegularExpressions.Regex.
                IsMatch(str_handset, @"^[1]+[3,8,5]+\d{9}$");
        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void txTextBoxTel_Leave(object sender, EventArgs e)
        {
            if (!IsHandset(txTextBoxTel.Text))
            {
                TXMessageBoxExtensions.Error("电话号码不正确");
            }
        }

        private void txTextBox1_Leave(object sender, EventArgs e)
        {
            if (!IsHandset(txTextBoxLinkmanTel.Text))
            {
                TXMessageBoxExtensions.Error("电话号码不正确");
            }
        }

        private void TextBoxZgbh_Leave(object sender, EventArgs e)
        {
           /* String zgbh = TextBoxZgbh.Text.Trim();
            
            DataSet set = SqlDiginer.excuteDataset("select  zgbh  from stj_staff");
            for ( int i=0;i<set.Tables[0].Rows.Count;i++)
            {
                if (zgbh ==) { }
            }*/
           
        }

        private void txButton3_Click(object sender, EventArgs e)
        {
            try
            {
                if ((iRetCOM == 1) || (iRetUSB == 1))
                {

                    int authenticate = CVRSDK.CVR_Authenticate();
                    if (authenticate == 1)
                    {
                        int readContent = CVRSDK.CVR_Read_Content(4);
                        if (readContent == 1)
                        {
                            this.lablelInitSet.Text = "读卡操作成功！";
                            FillData();
                        }
                        else
                        {
                            this.lablelInitSet.Text = "读卡操作失败！";
                        }
                    }
                    else
                    {
                        MessageBox.Show("未放卡或卡片放置不正确");
                    }
                }
                else
                {
                    MessageBox.Show("初始化失败！");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

    }
}
