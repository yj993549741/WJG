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
    public partial class FormAttendance :BaseForm
    {
        public FormAttendance()
        {
            InitializeComponent();
        }

        private void Excel_Load(object sender, EventArgs e)
        {
            //this.mf_clockingTableAdapter.Fill(this.skcclocksystemDataSet.mf_clocking); 
            this.dataGridView1.Refresh();
            string top100 = "select top(100) * from [skcclocksystem].[dbo].[mf_clocking]";
            DataSet set = new DataSet();
            set= SqlDiginer.excuteDataset(top100);
            this.dataGridView1.DataSource = set.Tables[0];
            BeautifulView.beautifulViewMethod(this.dataGridView1);
           
        }

        private void 查询_Click(object sender, EventArgs e)
        {
           DataSet set=  new DataSet();
            set= getselectbaseindex(zgxm.Text.Trim(),icid.Text.Trim(),zgbh.Text.Trim());
            this.dataGridView1.DataSource = set.Tables[0];
        }
        public DataSet getselectbaseindex(string zgxm, string icid, string zgbh)
        {
            string condition = "where 1=1";
            if (zgxm != "")
            {
                condition += "and empname='" + zgxm + "'";
            }
            if (icid != "")
            {
                condition += "and icid='" + icid + "'";
            }
            if (zgbh != "")
            {
                condition += "and empno='" + zgbh + "'";
            }
            string SelectString = "select * from mf_clocking " + condition;
            return SqlDiginer.excuteDataset(SelectString);

        }

        private void txButton1_Click(object sender, EventArgs e)
        {
            String sql = "select * from mf_clocking";
            DataSet list = SqlDiginer.excuteDataset(sql);
            this.dataGridView1.DataSource = list.Tables[0];
            BeautifulView.beautifulViewMethod(this.dataGridView1);
        }
    }
}
