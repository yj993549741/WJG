using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WJG.bll;
using TX.Framework.WindowUI.Forms;

namespace WJG
{
   
    public unsafe partial class FormModifyPwd : BaseForm
    {
        String login_name;
        public FormModifyPwd(String login_name)
        {
            this.login_name = login_name;
            InitializeComponent();
        }

        private void txButton1_Click(object sender, EventArgs e)
        {
            if (txTextBoxOldpwd.Text ==null ||"".Equals(txTextBoxOldpwd.Text))
            {
                TXMessageBoxExtensions.Info("提示", "旧密码不能为空");
            }
            if (txTextBoxNewpwd.Text.Trim()!= txTextBoxCheckpwd.Text.Trim())
            {
                TXMessageBoxExtensions.Info("提示", "请检查新密码");
            }
            String selectSql = "select * from  [skcclocksystem].[dbo].[administrator] where username='"+login_name+"' and password = '"+ txTextBoxOldpwd .Text.Trim()+ "'";
            if (SqlDiginer.ExecuteNoQuery(selectSql) == 1)
            {
                String updateSql = "update [skcclocksystem].[dbo].[administrator] set password='"+ txTextBoxNewpwd .Text.Trim()+ "' where username='"+login_name+"'";
                int i= SqlDiginer.ExecuteNoQuery(updateSql);
                if (i == 1)
                {
                    TXMessageBoxExtensions.Info("提示", "更新成功");
                }
            }
        }

        private void FormTest_Load(object sender, EventArgs e)
        {

        }
    }
}
