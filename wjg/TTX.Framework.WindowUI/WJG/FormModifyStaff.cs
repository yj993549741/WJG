using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TX.Framework.WindowUI.Forms;
using WJG.bll;

namespace WJG
{
    public partial class FormModifyStaff : BaseForm
    {

        String zgbh;
        public FormModifyStaff(String zgbh)
        {
            this.zgbh = zgbh;
            InitializeComponent();
        }

        private void FormModifyStaff_Load(object sender, EventArgs e)
        {
            try {
               
                string sql = "select * from stj_staff where zgbh= '" + zgbh + "'";
                DataSet set = new DataSet();
                set = SqlDiginer.excuteDataset(sql);

                TextBoxZgbh.Text = set.Tables[0].Rows[0][0].ToString().Trim();
                TextBoxName.Text = set.Tables[0].Rows[0][1].ToString().Trim();
                TextBoxSex.Text = set.Tables[0].Rows[0][2].ToString().Trim();
                txTextBoxIdcard.Text = set.Tables[0].Rows[0][3].ToString().Trim();
                txComboBoxCreatgory.Text = set.Tables[0].Rows[0][4].ToString().Trim();
                TextBoxNature.Text = set.Tables[0].Rows[0][5].ToString().Trim();
                txTextBoxAddress.Text = set.Tables[0].Rows[0][6].ToString().Trim();
                txTextBoxPathTJ.Text = set.Tables[0].Rows[0][7].ToString().Trim();
                txTextBoxBirth.Text = set.Tables[0].Rows[0][8].ToString().Trim();
                txTextBoxAge.Text = set.Tables[0].Rows[0][9].ToString().Trim();
                txComboBoxMarry.Text = set.Tables[0].Rows[0][10].ToString().Trim();
                txComboBoxHaschilder.Text = set.Tables[0].Rows[0][11].ToString().Trim();
                //txComboBoxHaschilder.Text = set.Tables[0].Rows[0][12].ToString().Trim();
                txDateTimePickerHealth.Text = set.Tables[0].Rows[0][12].ToString().Trim();
                txComboBoxHealthResult.Text = set.Tables[0].Rows[0][13].ToString().Trim();
                txTextBoxTel.Text = set.Tables[0].Rows[0][14].ToString().Trim();
                txTextBoxLinkMan.Text = set.Tables[0].Rows[0][15].ToString().Trim();
                txComboBoxRelaption.Text = set.Tables[0].Rows[0][16].ToString().Trim();
                txTextBoxLinkmanTel.Text = set.Tables[0].Rows[0][17].ToString().Trim();
                txTextBoxIcid.Text = set.Tables[0].Rows[0][18].ToString().Trim();
                txTextBoxIcidNumber.Text = set.Tables[0].Rows[0][19].ToString().Trim();
                txTreeComboBoxDept.Text = set.Tables[0].Rows[0][20].ToString().Trim();
                txTreeComboBoxDept.Text = set.Tables[0].Rows[0][21].ToString().Trim();
                txComboBoxStaff.Text = set.Tables[0].Rows[0][22].ToString().Trim();
                txDateTimePickerBegin.Text = set.Tables[0].Rows[0][23].ToString().Trim();
                txDateTimePickerLeave.Text = set.Tables[0].Rows[0][24].ToString().Trim();
                txTextBoxReasonLeave.Text = set.Tables[0].Rows[0][25].ToString().Trim();
                txComboBoxStatus.Text = set.Tables[0].Rows[0][26].ToString().Trim();
                txComboBoxClockSystem.Text = set.Tables[0].Rows[0][27].ToString().Trim();
                txComboBoxPushCard.Text = set.Tables[0].Rows[0][28].ToString().Trim();
                txComboBoxCanteenSystem.Text = set.Tables[0].Rows[0][29].ToString().Trim();

                ///<summary>
                ///deptTreedata（）设置了部课数据源，传入的参数是一级目录有多少个，
                ///</summary>
                this.txTreeComboBoxDept.DataSource = SqlDiginer.DeptTreeData(4);

                this.txTreeComboBoxDept.MultiLevelDataSourceMember = "lessons";
                this.txTreeComboBoxDept.DisplayMember = "Name";
                this.txTreeComboBoxDept.ValueMember = "Value";
                this.txTreeComboBoxDept.BindData();

            } catch(Exception ex)
            {
                TXMessageBoxExtensions.Error(ex.ToString());
            }
        }

        private void txButton1_Click(object sender, EventArgs e)
        {
            
        }
    }
}
