using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using TX.Framework.WindowUI.Forms;
using WJG.bll;
namespace WJG
{
    public partial class FormModifyEmployee : BaseForm
    {
        String name;
        public FormModifyEmployee(String name)
        {
            InitializeComponent();
            this.name = name;
        }

        private void FormModifyEmployee_Load(object sender, EventArgs e)
        {
            string sql = "select * from [skcclocksystem].[dbo].[hp_zd01] where zgxm= '" + name + "'";
            DataSet set = new DataSet();
            set=SqlDiginer.excuteDataset(sql);
            txTextBoxZGBH.Text= set.Tables[0].Rows[0][0].ToString().Trim(); 
            txTextBoxZGXM.Text = set.Tables[0].Rows[0][1].ToString().Trim();
            txTextBoxICID.Text = set.Tables[0].Rows[0][3].ToString().Trim();
            txTextBoxBMMX.Text = set.Tables[0].Rows[0][4].ToString().Trim();
            txTextBoxZGBH.ReadOnly = true;
        }

        private void txButton2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txButton1_Click(object sender, EventArgs e)
        {
            DialogResult DialogResult = TXMessageBoxExtensions.Question("确认修改","您是否确认更新数据？");
            /*提示信息*/
            if (DialogResult== DialogResult.OK){
                String sql = "update [skcclocksystem].[dbo].[hp_zd01] set icid='"+txTextBoxICID.Text+"',bmmx='"+txTextBoxBMMX.Text+ "',zgxm='"+ txTextBoxZGXM .Text+ "' where zgbh='"+txTextBoxZGBH.Text+"'";
                int count = SqlDiginer.ExecuteNoQuery(sql);
                if (count == 1)
                {
                    TXMessageBoxExtensions.Info("提示","更新成功！");
                    this.Close();
                }else
                {
                    TXMessageBoxExtensions.Info("提示", "更新失败！");
                } } 
            else 
                   {
                             TXMessageBoxExtensions.Error("报警","数据未插入！");
                   }
            
           
        }
    }
}
