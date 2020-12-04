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
using WJG.skcclocksystemDataSetTableAdapters;
using WJG.model;


namespace WJG
{
    public partial class LoginForm : MainForm
    {
        public LoginForm()
        {
            InitializeComponent();

        }

        private void txButton1_Click(object sender, EventArgs e)
        {
            string username = txTextBox1.Text;
            string password = txTextBox2.Text;
            if (string.IsNullOrEmpty(username.Trim())||string.IsNullOrEmpty(password.Trim()))
            {
                TXMessageBoxExtensions.Info("提示","账号或者密码未输入");
                return;

            }
            string MD5password = commandClass.getmd5(password);
            administratorTableAdapter admTb = new administratorTableAdapter();
            DataTable userDt = admTb.GetDataByUsernameAndPassword(username,password) ;
            

            if (userDt.Rows.Count>0)
            {
                main fm = new main(username);
                txTextBox2.Text = "";
                this.Hide();
                fm.Show();
                this.Close();
            }
            else
            {
                txTextBox2.Text = "";
                TXMessageBoxExtensions.Info("用户或者密码错误！");
                txTextBox2.Focus();
            }
        }

        private void txButton2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txButton1_Click_1(object sender, EventArgs e)
        {
            string username = txTextBox1.Text;
            string password = txTextBox2.Text;
            if (string.IsNullOrEmpty(username.Trim()) || string.IsNullOrEmpty(password.Trim()))
            {
                TXMessageBoxExtensions.Info("提示", "账号或者密码未输入");
                return;

            }
            string MD5password = commandClass.getmd5(password);
            administratorTableAdapter admTb = new administratorTableAdapter();
            DataTable userDt = admTb.GetDataByUsernameAndPassword(username, password);


            if (userDt.Rows.Count > 0)
            {
                main fm = new main(username);
                txTextBox2.Text = "";
                this.Hide();
                this.RealHide();
                fm.ShowDialog();
                this.Close();
                
            }
            else
            {
                txTextBox2.Text = "";
                TXMessageBoxExtensions.Info("用户或者密码错误！");
                txTextBox2.Focus();
            }
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {
            char a = '*';
            txTextBox2.PasswordChar =a;
        }
    }
   
}
