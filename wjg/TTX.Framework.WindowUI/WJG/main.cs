using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TX.Framework.WindowUI.Forms;
using WJG.model;
using WJG.bll;
using Microsoft.ApplicationBlocks.Data;

namespace WJG
{   
    public partial class main :MainForm
    {
        public main(String login_name)
        {
            InitializeComponent();
            this.user_name = login_name;
        }
        //定义几个变量，用于form之间传递数值。
        String name;
        String zgbh;
        String user_name;
        

        private void Form1_Load(object sender, EventArgs e)
        {         
            //this.hp_zd01TableAdapter.Fill(this.skcclocksystemDataSet.hp_zd01);
            DataSet set= SqlDiginer.excuteDataset("select top(100)* from stj_staff ");
            dataGridView1.DataSource = set.Tables[0];
            beautifulView(dataGridView1);
           
        }


        #region beautifulview
        public void beautifulView(DataGridView dgv_Course)
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            dgv_Course.AllowUserToAddRows = false;
            dgv_Course.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.LightCyan;
            dgv_Course.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dgv_Course.BackgroundColor = System.Drawing.Color.White;
            dgv_Course.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            dgv_Course.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;//211, 223, 240
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(211)))), ((int)(((byte)(223)))), ((int)(((byte)(240)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Navy;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dgv_Course.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dgv_Course.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv_Course.EnableHeadersVisualStyles = false;
            dgv_Course.GridColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.dataGridView1.ReadOnly = true;
            dgv_Course.RowHeadersVisible = true;
            dgv_Course.RowTemplate.Height = 23;
            



        }
        #endregion

        #region dataGridView1_paint
        private void dataGridView1_Paint(object sender, PaintEventArgs e)
        {
            DataGridView dataGridView = sender as DataGridView;

            ControlPaint.DrawBorder(e.Graphics, dataGridView.ClientRectangle, Color.DeepSkyBlue, 1,

            ButtonBorderStyle.Solid,

            Color.DeepSkyBlue, 1, ButtonBorderStyle.Solid, Color.DeepSkyBlue, 1, ButtonBorderStyle.Solid, Color.DeepSkyBlue, 1, ButtonBorderStyle.Solid);


        }
        #endregion

        private void dataGridView1_RowDividerHeightChanged(object sender, DataGridViewRowEventArgs e)
        {

        }
        /// <summary>
        /// 多条件查询
        /// </summary>
        /// <param name="zgxm">姓名</param>
        /// <param name="icid">卡号</param>
        /// <param name="zgbh">工号</param>
        /// <returns></returns>
        public DataSet getselectbaseindex(string zgxm,string icid,string zgbh)
        {
            string condition = "where 1=1";
            if (zgxm != "")
            {
                condition += "and zgxm='" + zgxm + "'";
            }
            if (icid !="")
            {
                condition += "and icid='"+icid+"'";
            }
            if (zgbh != "")
            {
                condition += "and zgbh='" + zgbh + "'";
            }
            string SelectString ="select * from stj_staff " + condition ;
            return SqlHelper.ExecuteDataset(WJG.dal.sqlhelper.strCn, CommandType.Text, SelectString);
 
        }
        private void txButton1_Click(object sender, EventArgs e)
        {
           
                DataSet list = new DataSet();
                list= getselectbaseindex(txTextBox1.Text, txTextBox2.Text, txTextBox3.Text);
                dataGridView1.DataSource = list.Tables[0];

         
            
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void txButton2_Click(object sender, EventArgs e)
        {
            String sql = "select * from stj_staff ";
            DataSet list = SqlDiginer.excuteDataset(sql);
            this.dataGridView1.DataSource = list.Tables[0];
        }

        private void txButton3_Click(object sender, EventArgs e)
        {
            FromStaff idcard = new FromStaff();
            this.Hide();
            idcard.ShowDialog();

        }
        /// <summary>
        ///  鼠标在datagridview指定的行的取参函数
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public void Mosclick(object sender, DataGridViewCellMouseEventArgs e)
        {
            name = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
            zgbh = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
        }
        private void txButton7_Click(object sender, EventArgs e)
        {
            if (zgbh == null|| "".Equals(zgbh))
            {
                TXMessageBoxExtensions.Info("提示","未选中员工信息");
                return;
            }
            FormModifyStaff formModifyStaff = new FormModifyStaff(zgbh);
            formModifyStaff.ShowDialog();           
        }

        private void txButton8_Click(object sender, EventArgs e)
        {
            if("".Equals(zgbh)||zgbh==null){
                TXMessageBoxExtensions.Info("提示","未选择人员信息！");
            }
            else
            {
                DialogResult DialogResult = TXMessageBoxExtensions.Question("确认修改", "您是否确认删除这个人员信息");
                if (DialogResult==DialogResult.OK)
                {
                     string insertsql = "insert into  [skcclocksystem].[dbo].[turnover] select * from [skcclocksystem].[dbo].[hp_zd01] where zgbh='"+zgbh.Trim()+"' ";
                     SqlDiginer.ExecuteNoQuery(insertsql);
                     string sql = " delete  [skcclocksystem].[dbo].[hp_zd01] where zgbh='" + zgbh.Trim() + "'";
                     int  result=  SqlDiginer.ExecuteNoQuery(sql);
                     TXMessageBoxExtensions.Info("提示", "已删除" + result + "条信息");
                     dataGridView1.Refresh();
                     DataSet refreshSet=   SqlDiginer.excuteDataset("select * from [skcclocksystem].[dbo].[hp_zd01]");
                     dataGridView1.DataSource = refreshSet.Tables[0];

                }
                else
                {
                    TXMessageBoxExtensions.Info("提示","更新取消");
                }

            }
         
        }

        private void txButton4_Click(object sender, EventArgs e)
        {
           
        }

        private void txButton6_Click(object sender, EventArgs e)
        {
            FormModifyPwd modifypwd = new FormModifyPwd(user_name);
            modifypwd.ShowDialog();
        }

        private void txButton5_Click(object sender, EventArgs e)
        {
            FormAttendance formAttendance = new FormAttendance();
            formAttendance.ShowDialog();

        }
    }
}
