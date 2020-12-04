namespace WJG
{
    partial class FormAttendance
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.empnoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.empnameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.deptDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateinDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.timeinDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateoutDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.timeoutDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clkremarkDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.editusrDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.editdatDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.compcodeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sernoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clkstatusDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.icidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.serno1DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mfclockingBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.skcclocksystemDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.skcclocksystemDataSet = new WJG.skcclocksystemDataSet();
            this.txGroupBox1 = new TX.Framework.WindowUI.Controls.TXGroupBox();
            this.txButton1 = new TX.Framework.WindowUI.Controls.TXButton();
            this.查询 = new TX.Framework.WindowUI.Controls.TXButton();
            this.label1 = new System.Windows.Forms.Label();
            this.zgbh = new TX.Framework.WindowUI.Controls.TXTextBox();
            this.icid = new TX.Framework.WindowUI.Controls.TXTextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.zgxm = new TX.Framework.WindowUI.Controls.TXTextBox();
            this.mf_clockingTableAdapter = new WJG.skcclocksystemDataSetTableAdapters.mf_clockingTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mfclockingBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.skcclocksystemDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.skcclocksystemDataSet)).BeginInit();
            this.txGroupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.empnoDataGridViewTextBoxColumn,
            this.empnameDataGridViewTextBoxColumn,
            this.deptDataGridViewTextBoxColumn,
            this.dateinDataGridViewTextBoxColumn,
            this.timeinDataGridViewTextBoxColumn,
            this.dateoutDataGridViewTextBoxColumn,
            this.timeoutDataGridViewTextBoxColumn,
            this.clkremarkDataGridViewTextBoxColumn,
            this.editusrDataGridViewTextBoxColumn,
            this.editdatDataGridViewTextBoxColumn,
            this.compcodeDataGridViewTextBoxColumn,
            this.sernoDataGridViewTextBoxColumn,
            this.clkstatusDataGridViewTextBoxColumn,
            this.icidDataGridViewTextBoxColumn,
            this.serno1DataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.mfclockingBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(18, 166);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 23;
            this.dataGridView1.Size = new System.Drawing.Size(945, 414);
            this.dataGridView1.TabIndex = 0;
            // 
            // empnoDataGridViewTextBoxColumn
            // 
            this.empnoDataGridViewTextBoxColumn.DataPropertyName = "empno";
            this.empnoDataGridViewTextBoxColumn.HeaderText = "工号";
            this.empnoDataGridViewTextBoxColumn.Name = "empnoDataGridViewTextBoxColumn";
            // 
            // empnameDataGridViewTextBoxColumn
            // 
            this.empnameDataGridViewTextBoxColumn.DataPropertyName = "empname";
            this.empnameDataGridViewTextBoxColumn.HeaderText = "员工姓名";
            this.empnameDataGridViewTextBoxColumn.Name = "empnameDataGridViewTextBoxColumn";
            // 
            // deptDataGridViewTextBoxColumn
            // 
            this.deptDataGridViewTextBoxColumn.DataPropertyName = "dept";
            this.deptDataGridViewTextBoxColumn.HeaderText = "部门";
            this.deptDataGridViewTextBoxColumn.Name = "deptDataGridViewTextBoxColumn";
            // 
            // dateinDataGridViewTextBoxColumn
            // 
            this.dateinDataGridViewTextBoxColumn.DataPropertyName = "datein";
            this.dateinDataGridViewTextBoxColumn.HeaderText = "上班日期";
            this.dateinDataGridViewTextBoxColumn.Name = "dateinDataGridViewTextBoxColumn";
            // 
            // timeinDataGridViewTextBoxColumn
            // 
            this.timeinDataGridViewTextBoxColumn.DataPropertyName = "timein";
            this.timeinDataGridViewTextBoxColumn.HeaderText = "上班时间";
            this.timeinDataGridViewTextBoxColumn.Name = "timeinDataGridViewTextBoxColumn";
            // 
            // dateoutDataGridViewTextBoxColumn
            // 
            this.dateoutDataGridViewTextBoxColumn.DataPropertyName = "dateout";
            this.dateoutDataGridViewTextBoxColumn.HeaderText = "下班日期";
            this.dateoutDataGridViewTextBoxColumn.Name = "dateoutDataGridViewTextBoxColumn";
            // 
            // timeoutDataGridViewTextBoxColumn
            // 
            this.timeoutDataGridViewTextBoxColumn.DataPropertyName = "timeout";
            this.timeoutDataGridViewTextBoxColumn.HeaderText = "下班时间";
            this.timeoutDataGridViewTextBoxColumn.Name = "timeoutDataGridViewTextBoxColumn";
            // 
            // clkremarkDataGridViewTextBoxColumn
            // 
            this.clkremarkDataGridViewTextBoxColumn.DataPropertyName = "clkremark";
            this.clkremarkDataGridViewTextBoxColumn.HeaderText = "clkremark";
            this.clkremarkDataGridViewTextBoxColumn.Name = "clkremarkDataGridViewTextBoxColumn";
            // 
            // editusrDataGridViewTextBoxColumn
            // 
            this.editusrDataGridViewTextBoxColumn.DataPropertyName = "editusr";
            this.editusrDataGridViewTextBoxColumn.HeaderText = "修改人";
            this.editusrDataGridViewTextBoxColumn.Name = "editusrDataGridViewTextBoxColumn";
            // 
            // editdatDataGridViewTextBoxColumn
            // 
            this.editdatDataGridViewTextBoxColumn.DataPropertyName = "editdat";
            this.editdatDataGridViewTextBoxColumn.HeaderText = "修改日期";
            this.editdatDataGridViewTextBoxColumn.Name = "editdatDataGridViewTextBoxColumn";
            // 
            // compcodeDataGridViewTextBoxColumn
            // 
            this.compcodeDataGridViewTextBoxColumn.DataPropertyName = "compcode";
            this.compcodeDataGridViewTextBoxColumn.HeaderText = "公司";
            this.compcodeDataGridViewTextBoxColumn.Name = "compcodeDataGridViewTextBoxColumn";
            // 
            // sernoDataGridViewTextBoxColumn
            // 
            this.sernoDataGridViewTextBoxColumn.DataPropertyName = "serno";
            this.sernoDataGridViewTextBoxColumn.HeaderText = "serno";
            this.sernoDataGridViewTextBoxColumn.Name = "sernoDataGridViewTextBoxColumn";
            // 
            // clkstatusDataGridViewTextBoxColumn
            // 
            this.clkstatusDataGridViewTextBoxColumn.DataPropertyName = "clkstatus";
            this.clkstatusDataGridViewTextBoxColumn.HeaderText = "clkstatus";
            this.clkstatusDataGridViewTextBoxColumn.Name = "clkstatusDataGridViewTextBoxColumn";
            // 
            // icidDataGridViewTextBoxColumn
            // 
            this.icidDataGridViewTextBoxColumn.DataPropertyName = "icid";
            this.icidDataGridViewTextBoxColumn.HeaderText = "卡号";
            this.icidDataGridViewTextBoxColumn.Name = "icidDataGridViewTextBoxColumn";
            // 
            // serno1DataGridViewTextBoxColumn
            // 
            this.serno1DataGridViewTextBoxColumn.DataPropertyName = "serno1";
            this.serno1DataGridViewTextBoxColumn.HeaderText = "serno1";
            this.serno1DataGridViewTextBoxColumn.Name = "serno1DataGridViewTextBoxColumn";
            // 
            // mfclockingBindingSource
            // 
            this.mfclockingBindingSource.DataMember = "mf_clocking";
            this.mfclockingBindingSource.DataSource = this.skcclocksystemDataSetBindingSource;
            // 
            // skcclocksystemDataSetBindingSource
            // 
            this.skcclocksystemDataSetBindingSource.DataSource = this.skcclocksystemDataSet;
            this.skcclocksystemDataSetBindingSource.Position = 0;
            // 
            // skcclocksystemDataSet
            // 
            this.skcclocksystemDataSet.DataSetName = "skcclocksystemDataSet";
            this.skcclocksystemDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // txGroupBox1
            // 
            this.txGroupBox1.AutoSize = true;
            this.txGroupBox1.BackColor = System.Drawing.Color.Transparent;
            this.txGroupBox1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(182)))), ((int)(((byte)(168)))), ((int)(((byte)(192)))));
            this.txGroupBox1.CaptionColor = System.Drawing.Color.Black;
            this.txGroupBox1.CaptionFont = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Bold);
            this.txGroupBox1.Controls.Add(this.txButton1);
            this.txGroupBox1.Controls.Add(this.查询);
            this.txGroupBox1.Controls.Add(this.label1);
            this.txGroupBox1.Controls.Add(this.zgbh);
            this.txGroupBox1.Controls.Add(this.icid);
            this.txGroupBox1.Controls.Add(this.label6);
            this.txGroupBox1.Controls.Add(this.label5);
            this.txGroupBox1.Controls.Add(this.zgxm);
            this.txGroupBox1.Location = new System.Drawing.Point(125, 30);
            this.txGroupBox1.Name = "txGroupBox1";
            this.txGroupBox1.Size = new System.Drawing.Size(739, 121);
            this.txGroupBox1.TabIndex = 19;
            this.txGroupBox1.TabStop = false;
            this.txGroupBox1.Text = "查询";
            this.txGroupBox1.TextMargin = 6;
            // 
            // txButton1
            // 
            this.txButton1.Image = null;
            this.txButton1.Location = new System.Drawing.Point(616, 73);
            this.txButton1.Name = "txButton1";
            this.txButton1.Size = new System.Drawing.Size(100, 28);
            this.txButton1.TabIndex = 25;
            this.txButton1.Text = "刷新";
            this.txButton1.UseVisualStyleBackColor = true;
            this.txButton1.Click += new System.EventHandler(this.txButton1_Click);
            // 
            // 查询
            // 
            this.查询.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.查询.Image = null;
            this.查询.Location = new System.Drawing.Point(616, 20);
            this.查询.Name = "查询";
            this.查询.Size = new System.Drawing.Size(100, 28);
            this.查询.TabIndex = 24;
            this.查询.Text = "查询";
            this.查询.UseVisualStyleBackColor = true;
            this.查询.Click += new System.EventHandler(this.查询_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(52, 73);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 12);
            this.label1.TabIndex = 23;
            this.label1.Text = "工号";
            // 
            // zgbh
            // 
            this.zgbh.BackColor = System.Drawing.Color.Transparent;
            this.zgbh.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(182)))), ((int)(((byte)(168)))), ((int)(((byte)(192)))));
            this.zgbh.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.zgbh.ForeColor = System.Drawing.SystemColors.WindowText;
            this.zgbh.HeightLightBolorColor = System.Drawing.Color.FromArgb(((int)(((byte)(140)))), ((int)(((byte)(67)))), ((int)(((byte)(165)))), ((int)(((byte)(220)))));
            this.zgbh.Image = null;
            this.zgbh.ImageSize = new System.Drawing.Size(0, 0);
            this.zgbh.Location = new System.Drawing.Point(114, 63);
            this.zgbh.Name = "zgbh";
            this.zgbh.Padding = new System.Windows.Forms.Padding(2);
            this.zgbh.PasswordChar = '\0';
            this.zgbh.Required = false;
            this.zgbh.Size = new System.Drawing.Size(180, 22);
            this.zgbh.TabIndex = 22;
            // 
            // icid
            // 
            this.icid.BackColor = System.Drawing.Color.Transparent;
            this.icid.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(182)))), ((int)(((byte)(168)))), ((int)(((byte)(192)))));
            this.icid.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.icid.ForeColor = System.Drawing.SystemColors.WindowText;
            this.icid.HeightLightBolorColor = System.Drawing.Color.FromArgb(((int)(((byte)(140)))), ((int)(((byte)(67)))), ((int)(((byte)(165)))), ((int)(((byte)(220)))));
            this.icid.Image = null;
            this.icid.ImageSize = new System.Drawing.Size(0, 0);
            this.icid.Location = new System.Drawing.Point(359, 20);
            this.icid.Name = "icid";
            this.icid.Padding = new System.Windows.Forms.Padding(2);
            this.icid.PasswordChar = '\0';
            this.icid.Required = false;
            this.icid.Size = new System.Drawing.Size(180, 22);
            this.icid.TabIndex = 21;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(324, 28);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(29, 12);
            this.label6.TabIndex = 20;
            this.label6.Text = "卡号";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(52, 28);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(29, 12);
            this.label5.TabIndex = 19;
            this.label5.Text = "姓名";
            // 
            // zgxm
            // 
            this.zgxm.BackColor = System.Drawing.Color.Transparent;
            this.zgxm.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(182)))), ((int)(((byte)(168)))), ((int)(((byte)(192)))));
            this.zgxm.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.zgxm.ForeColor = System.Drawing.SystemColors.WindowText;
            this.zgxm.HeightLightBolorColor = System.Drawing.Color.FromArgb(((int)(((byte)(140)))), ((int)(((byte)(67)))), ((int)(((byte)(165)))), ((int)(((byte)(220)))));
            this.zgxm.Image = null;
            this.zgxm.ImageSize = new System.Drawing.Size(0, 0);
            this.zgxm.Location = new System.Drawing.Point(114, 22);
            this.zgxm.Name = "zgxm";
            this.zgxm.Padding = new System.Windows.Forms.Padding(2);
            this.zgxm.PasswordChar = '\0';
            this.zgxm.Required = false;
            this.zgxm.Size = new System.Drawing.Size(180, 22);
            this.zgxm.TabIndex = 18;
            // 
            // mf_clockingTableAdapter
            // 
            this.mf_clockingTableAdapter.ClearBeforeFill = true;
            // 
            // FormAttendance
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1066, 687);
            this.Controls.Add(this.txGroupBox1);
            this.Controls.Add(this.dataGridView1);
            this.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Location = new System.Drawing.Point(0, 0);
            this.Name = "FormAttendance";
            this.Text = "考勤";
            this.Load += new System.EventHandler(this.Excel_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mfclockingBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.skcclocksystemDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.skcclocksystemDataSet)).EndInit();
            this.txGroupBox1.ResumeLayout(false);
            this.txGroupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private TX.Framework.WindowUI.Controls.TXGroupBox txGroupBox1;
        private System.Windows.Forms.Label label1;
        private TX.Framework.WindowUI.Controls.TXTextBox zgbh;
        private TX.Framework.WindowUI.Controls.TXTextBox icid;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private TX.Framework.WindowUI.Controls.TXTextBox zgxm;
        private System.Windows.Forms.BindingSource skcclocksystemDataSetBindingSource;
        private skcclocksystemDataSet skcclocksystemDataSet;
        private TX.Framework.WindowUI.Controls.TXButton txButton1;
        private TX.Framework.WindowUI.Controls.TXButton 查询;
        private System.Windows.Forms.BindingSource mfclockingBindingSource;
        private skcclocksystemDataSetTableAdapters.mf_clockingTableAdapter mf_clockingTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn empnoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn empnameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn deptDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateinDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn timeinDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateoutDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn timeoutDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn clkremarkDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn editusrDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn editdatDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn compcodeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sernoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn clkstatusDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn icidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn serno1DataGridViewTextBoxColumn;
    }
}