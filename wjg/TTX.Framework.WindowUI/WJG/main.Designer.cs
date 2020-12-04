namespace WJG
{
    partial class main
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(main));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.hpzd01BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.skcclocksystemDataSet = new WJG.skcclocksystemDataSet();
            this.txButton1 = new TX.Framework.WindowUI.Controls.TXButton();
            this.txGroupBox1 = new TX.Framework.WindowUI.Controls.TXGroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txTextBox3 = new TX.Framework.WindowUI.Controls.TXTextBox();
            this.txTextBox2 = new TX.Framework.WindowUI.Controls.TXTextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txTextBox1 = new TX.Framework.WindowUI.Controls.TXTextBox();
            this.txButton2 = new TX.Framework.WindowUI.Controls.TXButton();
            this.xPanderPanelList1 = new TX.Framework.WindowUI.Controls.XPanderPanelList();
            this.xPanderPanel1 = new TX.Framework.WindowUI.Controls.XPanderPanel();
            this.txButton8 = new TX.Framework.WindowUI.Controls.TXButton();
            this.txButton7 = new TX.Framework.WindowUI.Controls.TXButton();
            this.txButton3 = new TX.Framework.WindowUI.Controls.TXButton();
            this.xPanderPanel3 = new TX.Framework.WindowUI.Controls.XPanderPanel();
            this.txButton9 = new TX.Framework.WindowUI.Controls.TXButton();
            this.txButton5 = new TX.Framework.WindowUI.Controls.TXButton();
            this.txButton4 = new TX.Framework.WindowUI.Controls.TXButton();
            this.xPanderPanel4 = new TX.Framework.WindowUI.Controls.XPanderPanel();
            this.txButton6 = new TX.Framework.WindowUI.Controls.TXButton();
            this.hp_zd01TableAdapter = new WJG.skcclocksystemDataSetTableAdapters.hp_zd01TableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hpzd01BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.skcclocksystemDataSet)).BeginInit();
            this.txGroupBox1.SuspendLayout();
            this.xPanderPanelList1.SuspendLayout();
            this.xPanderPanel1.SuspendLayout();
            this.xPanderPanel3.SuspendLayout();
            this.xPanderPanel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(158, 145);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 23;
            this.dataGridView1.Size = new System.Drawing.Size(922, 409);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            this.dataGridView1.RowDividerHeightChanged += new System.Windows.Forms.DataGridViewRowEventHandler(this.dataGridView1_RowDividerHeightChanged);
            this.dataGridView1.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.Mosclick);
            this.dataGridView1.Paint += new System.Windows.Forms.PaintEventHandler(this.dataGridView1_Paint);
            // 
            // hpzd01BindingSource
            // 
            this.hpzd01BindingSource.DataMember = "hp_zd01";
            this.hpzd01BindingSource.DataSource = this.skcclocksystemDataSet;
            // 
            // skcclocksystemDataSet
            // 
            this.skcclocksystemDataSet.DataSetName = "skcclocksystemDataSet";
            this.skcclocksystemDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // txButton1
            // 
            this.txButton1.Image = null;
            this.txButton1.Location = new System.Drawing.Point(880, 50);
            this.txButton1.Name = "txButton1";
            this.txButton1.Size = new System.Drawing.Size(100, 28);
            this.txButton1.TabIndex = 10;
            this.txButton1.Text = "执行查询";
            this.txButton1.UseVisualStyleBackColor = true;
            this.txButton1.Click += new System.EventHandler(this.txButton1_Click);
            // 
            // txGroupBox1
            // 
            this.txGroupBox1.AutoSize = true;
            this.txGroupBox1.BackColor = System.Drawing.Color.Transparent;
            this.txGroupBox1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(182)))), ((int)(((byte)(168)))), ((int)(((byte)(192)))));
            this.txGroupBox1.CaptionColor = System.Drawing.Color.Black;
            this.txGroupBox1.CaptionFont = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Bold);
            this.txGroupBox1.Controls.Add(this.label1);
            this.txGroupBox1.Controls.Add(this.txTextBox3);
            this.txGroupBox1.Controls.Add(this.txTextBox2);
            this.txGroupBox1.Controls.Add(this.label6);
            this.txGroupBox1.Controls.Add(this.label5);
            this.txGroupBox1.Controls.Add(this.txTextBox1);
            this.txGroupBox1.Location = new System.Drawing.Point(169, 34);
            this.txGroupBox1.Name = "txGroupBox1";
            this.txGroupBox1.Size = new System.Drawing.Size(697, 105);
            this.txGroupBox1.TabIndex = 18;
            this.txGroupBox1.TabStop = false;
            this.txGroupBox1.Text = "查询";
            this.txGroupBox1.TextMargin = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(134, 73);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 12);
            this.label1.TabIndex = 23;
            this.label1.Text = "工号";
            // 
            // txTextBox3
            // 
            this.txTextBox3.BackColor = System.Drawing.Color.Transparent;
            this.txTextBox3.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(182)))), ((int)(((byte)(168)))), ((int)(((byte)(192)))));
            this.txTextBox3.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txTextBox3.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txTextBox3.HeightLightBolorColor = System.Drawing.Color.FromArgb(((int)(((byte)(140)))), ((int)(((byte)(67)))), ((int)(((byte)(165)))), ((int)(((byte)(220)))));
            this.txTextBox3.Image = null;
            this.txTextBox3.ImageSize = new System.Drawing.Size(0, 0);
            this.txTextBox3.Location = new System.Drawing.Point(181, 63);
            this.txTextBox3.Name = "txTextBox3";
            this.txTextBox3.Padding = new System.Windows.Forms.Padding(2);
            this.txTextBox3.PasswordChar = '\0';
            this.txTextBox3.Required = false;
            this.txTextBox3.Size = new System.Drawing.Size(180, 22);
            this.txTextBox3.TabIndex = 22;
            // 
            // txTextBox2
            // 
            this.txTextBox2.BackColor = System.Drawing.Color.Transparent;
            this.txTextBox2.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(182)))), ((int)(((byte)(168)))), ((int)(((byte)(192)))));
            this.txTextBox2.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txTextBox2.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txTextBox2.HeightLightBolorColor = System.Drawing.Color.FromArgb(((int)(((byte)(140)))), ((int)(((byte)(67)))), ((int)(((byte)(165)))), ((int)(((byte)(220)))));
            this.txTextBox2.Image = null;
            this.txTextBox2.ImageSize = new System.Drawing.Size(0, 0);
            this.txTextBox2.Location = new System.Drawing.Point(461, 18);
            this.txTextBox2.Name = "txTextBox2";
            this.txTextBox2.Padding = new System.Windows.Forms.Padding(2);
            this.txTextBox2.PasswordChar = '\0';
            this.txTextBox2.Required = false;
            this.txTextBox2.Size = new System.Drawing.Size(180, 22);
            this.txTextBox2.TabIndex = 21;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(416, 22);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(29, 12);
            this.label6.TabIndex = 20;
            this.label6.Text = "卡号";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(134, 28);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(29, 12);
            this.label5.TabIndex = 19;
            this.label5.Text = "姓名";
            // 
            // txTextBox1
            // 
            this.txTextBox1.BackColor = System.Drawing.Color.Transparent;
            this.txTextBox1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(182)))), ((int)(((byte)(168)))), ((int)(((byte)(192)))));
            this.txTextBox1.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txTextBox1.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txTextBox1.HeightLightBolorColor = System.Drawing.Color.FromArgb(((int)(((byte)(140)))), ((int)(((byte)(67)))), ((int)(((byte)(165)))), ((int)(((byte)(220)))));
            this.txTextBox1.Image = null;
            this.txTextBox1.ImageSize = new System.Drawing.Size(0, 0);
            this.txTextBox1.Location = new System.Drawing.Point(181, 18);
            this.txTextBox1.Name = "txTextBox1";
            this.txTextBox1.Padding = new System.Windows.Forms.Padding(2);
            this.txTextBox1.PasswordChar = '\0';
            this.txTextBox1.Required = false;
            this.txTextBox1.Size = new System.Drawing.Size(180, 22);
            this.txTextBox1.TabIndex = 18;
            // 
            // txButton2
            // 
            this.txButton2.Image = null;
            this.txButton2.Location = new System.Drawing.Point(880, 99);
            this.txButton2.Name = "txButton2";
            this.txButton2.Size = new System.Drawing.Size(100, 28);
            this.txButton2.TabIndex = 19;
            this.txButton2.Text = "刷新";
            this.txButton2.UseVisualStyleBackColor = true;
            this.txButton2.Click += new System.EventHandler(this.txButton2_Click);
            // 
            // xPanderPanelList1
            // 
            this.xPanderPanelList1.CaptionStyle = TX.Framework.WindowUI.Controls.CaptionStyle.Normal;
            this.xPanderPanelList1.Controls.Add(this.xPanderPanel1);
            this.xPanderPanelList1.Controls.Add(this.xPanderPanel3);
            this.xPanderPanelList1.Controls.Add(this.xPanderPanel4);
            this.xPanderPanelList1.GradientBackground = System.Drawing.Color.Empty;
            this.xPanderPanelList1.Location = new System.Drawing.Point(6, 34);
            this.xPanderPanelList1.Name = "xPanderPanelList1";
            this.xPanderPanelList1.PanelColors = null;
            this.xPanderPanelList1.PanelStyle = TX.Framework.WindowUI.Controls.PanelStyle.Office2007;
            this.xPanderPanelList1.ShowCloseIcon = true;
            this.xPanderPanelList1.ShowExpandIcon = true;
            this.xPanderPanelList1.Size = new System.Drawing.Size(146, 520);
            this.xPanderPanelList1.TabIndex = 20;
            this.xPanderPanelList1.Text = "xPanderPanelList1";
            // 
            // xPanderPanel1
            // 
            this.xPanderPanel1.CaptionFont = new System.Drawing.Font("Microsoft YaHei UI", 8F, System.Drawing.FontStyle.Bold);
            this.xPanderPanel1.Controls.Add(this.txButton8);
            this.xPanderPanel1.Controls.Add(this.txButton7);
            this.xPanderPanel1.Controls.Add(this.txButton3);
            this.xPanderPanel1.CustomColors.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(247)))), ((int)(((byte)(252)))));
            this.xPanderPanel1.CustomColors.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(182)))), ((int)(((byte)(168)))), ((int)(((byte)(192)))));
            this.xPanderPanel1.CustomColors.CaptionCheckedGradientBegin = System.Drawing.Color.FromArgb(((int)(((byte)(140)))), ((int)(((byte)(67)))), ((int)(((byte)(165)))), ((int)(((byte)(220)))));
            this.xPanderPanel1.CustomColors.CaptionCheckedGradientEnd = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(165)))), ((int)(((byte)(220)))));
            this.xPanderPanel1.CustomColors.CaptionCheckedGradientMiddle = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(165)))), ((int)(((byte)(220)))));
            this.xPanderPanel1.CustomColors.CaptionCloseIcon = System.Drawing.Color.Red;
            this.xPanderPanel1.CustomColors.CaptionExpandIcon = System.Drawing.SystemColors.ControlText;
            this.xPanderPanel1.CustomColors.CaptionGradientBegin = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(246)))), ((int)(((byte)(247)))), ((int)(((byte)(250)))));
            this.xPanderPanel1.CustomColors.CaptionGradientEnd = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(246)))), ((int)(((byte)(247)))), ((int)(((byte)(250)))));
            this.xPanderPanel1.CustomColors.CaptionGradientMiddle = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(214)))), ((int)(((byte)(223)))));
            this.xPanderPanel1.CustomColors.CaptionPressedGradientBegin = System.Drawing.Color.FromArgb(((int)(((byte)(140)))), ((int)(((byte)(67)))), ((int)(((byte)(165)))), ((int)(((byte)(220)))));
            this.xPanderPanel1.CustomColors.CaptionPressedGradientEnd = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(165)))), ((int)(((byte)(220)))));
            this.xPanderPanel1.CustomColors.CaptionPressedGradientMiddle = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(165)))), ((int)(((byte)(220)))));
            this.xPanderPanel1.CustomColors.CaptionSelectedGradientBegin = System.Drawing.Color.FromArgb(((int)(((byte)(140)))), ((int)(((byte)(67)))), ((int)(((byte)(165)))), ((int)(((byte)(220)))));
            this.xPanderPanel1.CustomColors.CaptionSelectedGradientEnd = System.Drawing.Color.FromArgb(((int)(((byte)(140)))), ((int)(((byte)(67)))), ((int)(((byte)(165)))), ((int)(((byte)(220)))));
            this.xPanderPanel1.CustomColors.CaptionSelectedGradientMiddle = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(165)))), ((int)(((byte)(220)))));
            this.xPanderPanel1.CustomColors.CaptionSelectedText = System.Drawing.SystemColors.ControlText;
            this.xPanderPanel1.CustomColors.CaptionText = System.Drawing.SystemColors.ControlText;
            this.xPanderPanel1.CustomColors.FlatCaptionGradientBegin = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(204)))), ((int)(((byte)(214)))), ((int)(((byte)(223)))));
            this.xPanderPanel1.CustomColors.FlatCaptionGradientEnd = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(214)))), ((int)(((byte)(223)))));
            this.xPanderPanel1.CustomColors.InnerBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(218)))), ((int)(((byte)(222)))));
            this.xPanderPanel1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.xPanderPanel1.Image = null;
            this.xPanderPanel1.Name = "xPanderPanel1";
            this.xPanderPanel1.PanelStyle = TX.Framework.WindowUI.Controls.PanelStyle.Office2007;
            this.xPanderPanel1.Size = new System.Drawing.Size(146, 25);
            this.xPanderPanel1.TabIndex = 0;
            this.xPanderPanel1.Text = "人员管理";
            this.xPanderPanel1.ToolTipTextCloseIcon = null;
            this.xPanderPanel1.ToolTipTextExpandIconPanelCollapsed = null;
            this.xPanderPanel1.ToolTipTextExpandIconPanelExpanded = null;
            // 
            // txButton8
            // 
            this.txButton8.Image = null;
            this.txButton8.Location = new System.Drawing.Point(16, 217);
            this.txButton8.Name = "txButton8";
            this.txButton8.Size = new System.Drawing.Size(100, 28);
            this.txButton8.TabIndex = 2;
            this.txButton8.Text = "删除人员信息";
            this.txButton8.UseVisualStyleBackColor = true;
            this.txButton8.Click += new System.EventHandler(this.txButton8_Click);
            // 
            // txButton7
            // 
            this.txButton7.Image = null;
            this.txButton7.Location = new System.Drawing.Point(16, 134);
            this.txButton7.Name = "txButton7";
            this.txButton7.Size = new System.Drawing.Size(100, 28);
            this.txButton7.TabIndex = 1;
            this.txButton7.Text = "修改人员信息";
            this.txButton7.UseVisualStyleBackColor = true;
            this.txButton7.Click += new System.EventHandler(this.txButton7_Click);
            // 
            // txButton3
            // 
            this.txButton3.Image = null;
            this.txButton3.Location = new System.Drawing.Point(16, 57);
            this.txButton3.Name = "txButton3";
            this.txButton3.Size = new System.Drawing.Size(100, 28);
            this.txButton3.TabIndex = 0;
            this.txButton3.Text = "添加人员信息";
            this.txButton3.UseVisualStyleBackColor = true;
            this.txButton3.Click += new System.EventHandler(this.txButton3_Click);
            // 
            // xPanderPanel3
            // 
            this.xPanderPanel3.CaptionFont = new System.Drawing.Font("Microsoft YaHei UI", 8F, System.Drawing.FontStyle.Bold);
            this.xPanderPanel3.Controls.Add(this.txButton9);
            this.xPanderPanel3.Controls.Add(this.txButton5);
            this.xPanderPanel3.Controls.Add(this.txButton4);
            this.xPanderPanel3.CustomColors.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(247)))), ((int)(((byte)(252)))));
            this.xPanderPanel3.CustomColors.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(182)))), ((int)(((byte)(168)))), ((int)(((byte)(192)))));
            this.xPanderPanel3.CustomColors.CaptionCheckedGradientBegin = System.Drawing.Color.FromArgb(((int)(((byte)(140)))), ((int)(((byte)(67)))), ((int)(((byte)(165)))), ((int)(((byte)(220)))));
            this.xPanderPanel3.CustomColors.CaptionCheckedGradientEnd = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(165)))), ((int)(((byte)(220)))));
            this.xPanderPanel3.CustomColors.CaptionCheckedGradientMiddle = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(165)))), ((int)(((byte)(220)))));
            this.xPanderPanel3.CustomColors.CaptionCloseIcon = System.Drawing.Color.Red;
            this.xPanderPanel3.CustomColors.CaptionExpandIcon = System.Drawing.SystemColors.ControlText;
            this.xPanderPanel3.CustomColors.CaptionGradientBegin = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(246)))), ((int)(((byte)(247)))), ((int)(((byte)(250)))));
            this.xPanderPanel3.CustomColors.CaptionGradientEnd = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(246)))), ((int)(((byte)(247)))), ((int)(((byte)(250)))));
            this.xPanderPanel3.CustomColors.CaptionGradientMiddle = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(214)))), ((int)(((byte)(223)))));
            this.xPanderPanel3.CustomColors.CaptionPressedGradientBegin = System.Drawing.Color.FromArgb(((int)(((byte)(140)))), ((int)(((byte)(67)))), ((int)(((byte)(165)))), ((int)(((byte)(220)))));
            this.xPanderPanel3.CustomColors.CaptionPressedGradientEnd = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(165)))), ((int)(((byte)(220)))));
            this.xPanderPanel3.CustomColors.CaptionPressedGradientMiddle = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(165)))), ((int)(((byte)(220)))));
            this.xPanderPanel3.CustomColors.CaptionSelectedGradientBegin = System.Drawing.Color.FromArgb(((int)(((byte)(140)))), ((int)(((byte)(67)))), ((int)(((byte)(165)))), ((int)(((byte)(220)))));
            this.xPanderPanel3.CustomColors.CaptionSelectedGradientEnd = System.Drawing.Color.FromArgb(((int)(((byte)(140)))), ((int)(((byte)(67)))), ((int)(((byte)(165)))), ((int)(((byte)(220)))));
            this.xPanderPanel3.CustomColors.CaptionSelectedGradientMiddle = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(165)))), ((int)(((byte)(220)))));
            this.xPanderPanel3.CustomColors.CaptionSelectedText = System.Drawing.SystemColors.ControlText;
            this.xPanderPanel3.CustomColors.CaptionText = System.Drawing.SystemColors.ControlText;
            this.xPanderPanel3.CustomColors.FlatCaptionGradientBegin = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(204)))), ((int)(((byte)(214)))), ((int)(((byte)(223)))));
            this.xPanderPanel3.CustomColors.FlatCaptionGradientEnd = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(214)))), ((int)(((byte)(223)))));
            this.xPanderPanel3.CustomColors.InnerBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(218)))), ((int)(((byte)(222)))));
            this.xPanderPanel3.Expand = true;
            this.xPanderPanel3.ForeColor = System.Drawing.SystemColors.ControlText;
            this.xPanderPanel3.Image = null;
            this.xPanderPanel3.Name = "xPanderPanel3";
            this.xPanderPanel3.PanelStyle = TX.Framework.WindowUI.Controls.PanelStyle.Office2007;
            this.xPanderPanel3.Size = new System.Drawing.Size(146, 470);
            this.xPanderPanel3.TabIndex = 2;
            this.xPanderPanel3.Text = "考勤管理";
            this.xPanderPanel3.ToolTipTextCloseIcon = null;
            this.xPanderPanel3.ToolTipTextExpandIconPanelCollapsed = null;
            this.xPanderPanel3.ToolTipTextExpandIconPanelExpanded = null;
            // 
            // txButton9
            // 
            this.txButton9.Image = null;
            this.txButton9.Location = new System.Drawing.Point(15, 253);
            this.txButton9.Name = "txButton9";
            this.txButton9.Size = new System.Drawing.Size(100, 28);
            this.txButton9.TabIndex = 2;
            this.txButton9.Text = "考勤导出";
            this.txButton9.UseVisualStyleBackColor = true;
            // 
            // txButton5
            // 
            this.txButton5.Image = null;
            this.txButton5.Location = new System.Drawing.Point(16, 143);
            this.txButton5.Name = "txButton5";
            this.txButton5.Size = new System.Drawing.Size(100, 28);
            this.txButton5.TabIndex = 1;
            this.txButton5.Text = "考勤记录";
            this.txButton5.UseVisualStyleBackColor = true;
            this.txButton5.Click += new System.EventHandler(this.txButton5_Click);
            // 
            // txButton4
            // 
            this.txButton4.Image = null;
            this.txButton4.Location = new System.Drawing.Point(15, 61);
            this.txButton4.Name = "txButton4";
            this.txButton4.Size = new System.Drawing.Size(100, 28);
            this.txButton4.TabIndex = 0;
            this.txButton4.Text = "考勤人员";
            this.txButton4.UseVisualStyleBackColor = true;
            this.txButton4.Click += new System.EventHandler(this.txButton4_Click);
            // 
            // xPanderPanel4
            // 
            this.xPanderPanel4.CaptionFont = new System.Drawing.Font("Microsoft YaHei UI", 8F, System.Drawing.FontStyle.Bold);
            this.xPanderPanel4.Controls.Add(this.txButton6);
            this.xPanderPanel4.CustomColors.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(247)))), ((int)(((byte)(252)))));
            this.xPanderPanel4.CustomColors.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(182)))), ((int)(((byte)(168)))), ((int)(((byte)(192)))));
            this.xPanderPanel4.CustomColors.CaptionCheckedGradientBegin = System.Drawing.Color.FromArgb(((int)(((byte)(140)))), ((int)(((byte)(67)))), ((int)(((byte)(165)))), ((int)(((byte)(220)))));
            this.xPanderPanel4.CustomColors.CaptionCheckedGradientEnd = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(165)))), ((int)(((byte)(220)))));
            this.xPanderPanel4.CustomColors.CaptionCheckedGradientMiddle = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(165)))), ((int)(((byte)(220)))));
            this.xPanderPanel4.CustomColors.CaptionCloseIcon = System.Drawing.Color.Red;
            this.xPanderPanel4.CustomColors.CaptionExpandIcon = System.Drawing.SystemColors.ControlText;
            this.xPanderPanel4.CustomColors.CaptionGradientBegin = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(246)))), ((int)(((byte)(247)))), ((int)(((byte)(250)))));
            this.xPanderPanel4.CustomColors.CaptionGradientEnd = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(246)))), ((int)(((byte)(247)))), ((int)(((byte)(250)))));
            this.xPanderPanel4.CustomColors.CaptionGradientMiddle = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(214)))), ((int)(((byte)(223)))));
            this.xPanderPanel4.CustomColors.CaptionPressedGradientBegin = System.Drawing.Color.FromArgb(((int)(((byte)(140)))), ((int)(((byte)(67)))), ((int)(((byte)(165)))), ((int)(((byte)(220)))));
            this.xPanderPanel4.CustomColors.CaptionPressedGradientEnd = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(165)))), ((int)(((byte)(220)))));
            this.xPanderPanel4.CustomColors.CaptionPressedGradientMiddle = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(165)))), ((int)(((byte)(220)))));
            this.xPanderPanel4.CustomColors.CaptionSelectedGradientBegin = System.Drawing.Color.FromArgb(((int)(((byte)(140)))), ((int)(((byte)(67)))), ((int)(((byte)(165)))), ((int)(((byte)(220)))));
            this.xPanderPanel4.CustomColors.CaptionSelectedGradientEnd = System.Drawing.Color.FromArgb(((int)(((byte)(140)))), ((int)(((byte)(67)))), ((int)(((byte)(165)))), ((int)(((byte)(220)))));
            this.xPanderPanel4.CustomColors.CaptionSelectedGradientMiddle = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(165)))), ((int)(((byte)(220)))));
            this.xPanderPanel4.CustomColors.CaptionSelectedText = System.Drawing.SystemColors.ControlText;
            this.xPanderPanel4.CustomColors.CaptionText = System.Drawing.SystemColors.ControlText;
            this.xPanderPanel4.CustomColors.FlatCaptionGradientBegin = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(204)))), ((int)(((byte)(214)))), ((int)(((byte)(223)))));
            this.xPanderPanel4.CustomColors.FlatCaptionGradientEnd = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(214)))), ((int)(((byte)(223)))));
            this.xPanderPanel4.CustomColors.InnerBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(218)))), ((int)(((byte)(222)))));
            this.xPanderPanel4.ForeColor = System.Drawing.SystemColors.ControlText;
            this.xPanderPanel4.Image = null;
            this.xPanderPanel4.Name = "xPanderPanel4";
            this.xPanderPanel4.PanelStyle = TX.Framework.WindowUI.Controls.PanelStyle.Office2007;
            this.xPanderPanel4.Size = new System.Drawing.Size(146, 25);
            this.xPanderPanel4.TabIndex = 3;
            this.xPanderPanel4.Text = "账户管理";
            this.xPanderPanel4.ToolTipTextCloseIcon = null;
            this.xPanderPanel4.ToolTipTextExpandIconPanelCollapsed = null;
            this.xPanderPanel4.ToolTipTextExpandIconPanelExpanded = null;
            // 
            // txButton6
            // 
            this.txButton6.Image = null;
            this.txButton6.Location = new System.Drawing.Point(15, 87);
            this.txButton6.Name = "txButton6";
            this.txButton6.Size = new System.Drawing.Size(100, 28);
            this.txButton6.TabIndex = 0;
            this.txButton6.Text = "修改密码";
            this.txButton6.UseVisualStyleBackColor = true;
            this.txButton6.Click += new System.EventHandler(this.txButton6_Click);
            // 
            // hp_zd01TableAdapter
            // 
            this.hp_zd01TableAdapter.ClearBeforeFill = true;
            // 
            // main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1142, 613);
            this.Controls.Add(this.xPanderPanelList1);
            this.Controls.Add(this.txButton2);
            this.Controls.Add(this.txGroupBox1);
            this.Controls.Add(this.txButton1);
            this.Controls.Add(this.dataGridView1);
            this.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Location = new System.Drawing.Point(0, 0);
            this.Name = "main";
            this.Text = "首页";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hpzd01BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.skcclocksystemDataSet)).EndInit();
            this.txGroupBox1.ResumeLayout(false);
            this.txGroupBox1.PerformLayout();
            this.xPanderPanelList1.ResumeLayout(false);
            this.xPanderPanel1.ResumeLayout(false);
            this.xPanderPanel3.ResumeLayout(false);
            this.xPanderPanel4.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private TX.Framework.WindowUI.Controls.TXButton txButton1;
        private TX.Framework.WindowUI.Controls.TXGroupBox txGroupBox1;
        private System.Windows.Forms.Label label1;
        private TX.Framework.WindowUI.Controls.TXTextBox txTextBox3;
        private TX.Framework.WindowUI.Controls.TXTextBox txTextBox2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private TX.Framework.WindowUI.Controls.TXTextBox txTextBox1;
        private TX.Framework.WindowUI.Controls.TXButton txButton2;
        private TX.Framework.WindowUI.Controls.XPanderPanelList xPanderPanelList1;
        private TX.Framework.WindowUI.Controls.XPanderPanel xPanderPanel1;
        private TX.Framework.WindowUI.Controls.XPanderPanel xPanderPanel3;
        private TX.Framework.WindowUI.Controls.XPanderPanel xPanderPanel4;
        private skcclocksystemDataSet skcclocksystemDataSet;
        private System.Windows.Forms.BindingSource hpzd01BindingSource;
        private skcclocksystemDataSetTableAdapters.hp_zd01TableAdapter hp_zd01TableAdapter;
        private TX.Framework.WindowUI.Controls.TXButton txButton3;
        private TX.Framework.WindowUI.Controls.TXButton txButton4;
        private TX.Framework.WindowUI.Controls.TXButton txButton6;
        private TX.Framework.WindowUI.Controls.TXButton txButton8;
        private TX.Framework.WindowUI.Controls.TXButton txButton7;
        private TX.Framework.WindowUI.Controls.TXButton txButton9;
        private TX.Framework.WindowUI.Controls.TXButton txButton5;
    }
}

