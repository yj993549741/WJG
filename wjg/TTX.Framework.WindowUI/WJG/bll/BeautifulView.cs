using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WJG.bll
{
    class BeautifulView
    {
        /// <summary>
        /// 美化DataGridView
        /// </summary>
        /// <param name="dgv_Course"></param>
        #region beautifulview
        public static void beautifulViewMethod(DataGridView dgv_Course)
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
            dgv_Course.ReadOnly = true;
            dgv_Course.RowHeadersVisible = true;
            dgv_Course.RowTemplate.Height = 23;




        }
        #endregion

       /// <summary>
       ///    点击事件
       /// </summary>
       /// <param name="sender"></param>
       /// <param name="e"></param>
        #region dataGridView_paint
        private void dataGridView1_Paint(object sender, PaintEventArgs e)
        {
            DataGridView dataGridView = sender as DataGridView;

            ControlPaint.DrawBorder(e.Graphics, dataGridView.ClientRectangle, Color.DeepSkyBlue, 1,

            ButtonBorderStyle.Solid,

            Color.DeepSkyBlue, 1, ButtonBorderStyle.Solid, Color.DeepSkyBlue, 1, ButtonBorderStyle.Solid, Color.DeepSkyBlue, 1, ButtonBorderStyle.Solid);


        }
        #endregion
    }
}
