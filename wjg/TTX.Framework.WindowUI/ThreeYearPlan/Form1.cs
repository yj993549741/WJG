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
using System.IO;

namespace ThreeYearPlan
{
    public partial class Form1 : BaseForm
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void txButton1_Click(object sender, EventArgs e)
        {
            OpenFileDialog fd = new OpenFileDialog();
            fd.Filter = "(所有文件)|*.*|(jpg图片)|*.jpg|(jpeg)|*.jpeg|(gif图片)|*.gif";
            fd.Multiselect = false;
            if (fd.ShowDialog() == DialogResult.OK)
            {
                
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
