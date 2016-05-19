namespace FangMomFucker
{
    partial class Form1
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
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.ip = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.delay = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.type = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.crt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pass = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.speed = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.privateIP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.导入IPToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.导出ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.空格分隔剪切板ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.换行分隔剪切板ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.空格分隔TXTToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.换行分隔TXTToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ToIPSEGToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ToINIToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.移除ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.去重ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.removeAllToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.buttonRandTest = new System.Windows.Forms.Button();
            this.buttonBandTest = new System.Windows.Forms.Button();
            this.buttonStopTest = new System.Windows.Forms.Button();
            this.buttonStandardTest = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.numericUpDownTimeOut = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownTimes = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownThrs = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.buttonClearPool = new System.Windows.Forms.Button();
            this.buttonAddIP = new System.Windows.Forms.Button();
            this.buttonAddIPS = new System.Windows.Forms.Button();
            this.labelCount = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.labelRemainder = new System.Windows.Forms.Label();
            this.comboBoxIPPools = new System.Windows.Forms.ComboBox();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownTimeOut)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownTimes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownThrs)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.EnableWithoutHeaderText;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ip,
            this.delay,
            this.type,
            this.crt,
            this.pass,
            this.speed,
            this.privateIP});
            this.dataGridView1.ContextMenuStrip = this.contextMenuStrip1;
            this.dataGridView1.Location = new System.Drawing.Point(11, 12);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 80;
            this.dataGridView1.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(656, 530);
            this.dataGridView1.TabIndex = 0;
            // 
            // ip
            // 
            this.ip.FillWeight = 25F;
            this.ip.HeaderText = "地址";
            this.ip.Name = "ip";
            this.ip.ReadOnly = true;
            // 
            // delay
            // 
            this.delay.FillWeight = 16F;
            this.delay.HeaderText = "延迟";
            this.delay.MinimumWidth = 10;
            this.delay.Name = "delay";
            this.delay.ReadOnly = true;
            // 
            // type
            // 
            this.type.FillWeight = 8F;
            this.type.HeaderText = "类型";
            this.type.Name = "type";
            this.type.ReadOnly = true;
            // 
            // crt
            // 
            this.crt.FillWeight = 27F;
            this.crt.HeaderText = "证书";
            this.crt.Name = "crt";
            this.crt.ReadOnly = true;
            // 
            // pass
            // 
            this.pass.FillWeight = 9F;
            this.pass.HeaderText = "通过";
            this.pass.Name = "pass";
            this.pass.ReadOnly = true;
            // 
            // speed
            // 
            this.speed.FillWeight = 15F;
            this.speed.HeaderText = "带宽";
            this.speed.Name = "speed";
            this.speed.ReadOnly = true;
            // 
            // privateIP
            // 
            this.privateIP.HeaderText = "privateIP";
            this.privateIP.Name = "privateIP";
            this.privateIP.ReadOnly = true;
            this.privateIP.Visible = false;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.导入IPToolStripMenuItem,
            this.移除ToolStripMenuItem,
            this.去重ToolStripMenuItem,
            this.removeAllToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(161, 108);
            // 
            // 导入IPToolStripMenuItem
            // 
            this.导入IPToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.导出ToolStripMenuItem,
            this.空格分隔剪切板ToolStripMenuItem,
            this.换行分隔剪切板ToolStripMenuItem,
            this.空格分隔TXTToolStripMenuItem,
            this.换行分隔TXTToolStripMenuItem,
            this.ToIPSEGToolStripMenuItem,
            this.ToINIToolStripMenuItem});
            this.导入IPToolStripMenuItem.Name = "导入IPToolStripMenuItem";
            this.导入IPToolStripMenuItem.Size = new System.Drawing.Size(160, 26);
            this.导入IPToolStripMenuItem.Text = "导出选中到";
            // 
            // 导出ToolStripMenuItem
            // 
            this.导出ToolStripMenuItem.Name = "导出ToolStripMenuItem";
            this.导出ToolStripMenuItem.Size = new System.Drawing.Size(251, 26);
            this.导出ToolStripMenuItem.Text = "\" | \" 分隔→剪切板";
            this.导出ToolStripMenuItem.Click += new System.EventHandler(this.导出ToolStripMenuItem_Click);
            // 
            // 空格分隔剪切板ToolStripMenuItem
            // 
            this.空格分隔剪切板ToolStripMenuItem.Name = "空格分隔剪切板ToolStripMenuItem";
            this.空格分隔剪切板ToolStripMenuItem.Size = new System.Drawing.Size(251, 26);
            this.空格分隔剪切板ToolStripMenuItem.Text = "空格分隔→剪切板";
            this.空格分隔剪切板ToolStripMenuItem.Click += new System.EventHandler(this.空格分隔剪切板ToolStripMenuItem_Click);
            // 
            // 换行分隔剪切板ToolStripMenuItem
            // 
            this.换行分隔剪切板ToolStripMenuItem.Name = "换行分隔剪切板ToolStripMenuItem";
            this.换行分隔剪切板ToolStripMenuItem.Size = new System.Drawing.Size(251, 26);
            this.换行分隔剪切板ToolStripMenuItem.Text = "换行分隔→剪切板";
            this.换行分隔剪切板ToolStripMenuItem.Click += new System.EventHandler(this.换行分隔剪切板ToolStripMenuItem_Click);
            // 
            // 空格分隔TXTToolStripMenuItem
            // 
            this.空格分隔TXTToolStripMenuItem.Name = "空格分隔TXTToolStripMenuItem";
            this.空格分隔TXTToolStripMenuItem.Size = new System.Drawing.Size(251, 26);
            this.空格分隔TXTToolStripMenuItem.Text = "空格分隔→TXT文件";
            this.空格分隔TXTToolStripMenuItem.Click += new System.EventHandler(this.空格分隔TXTToolStripMenuItem_Click);
            // 
            // 换行分隔TXTToolStripMenuItem
            // 
            this.换行分隔TXTToolStripMenuItem.Name = "换行分隔TXTToolStripMenuItem";
            this.换行分隔TXTToolStripMenuItem.Size = new System.Drawing.Size(251, 26);
            this.换行分隔TXTToolStripMenuItem.Text = "换行分隔→TXT文件";
            this.换行分隔TXTToolStripMenuItem.Click += new System.EventHandler(this.换行分隔TXTToolStripMenuItem_Click);
            // 
            // ToIPSEGToolStripMenuItem
            // 
            this.ToIPSEGToolStripMenuItem.Name = "ToIPSEGToolStripMenuItem";
            this.ToIPSEGToolStripMenuItem.Size = new System.Drawing.Size(251, 26);
            this.ToIPSEGToolStripMenuItem.Text = "换行分隔IP段→TXT文件";
            this.ToIPSEGToolStripMenuItem.Click += new System.EventHandler(this.ToIPSEGToolStripMenuItem_Click);
            // 
            // ToINIToolStripMenuItem
            // 
            this.ToINIToolStripMenuItem.Name = "ToINIToolStripMenuItem";
            this.ToINIToolStripMenuItem.ShortcutKeyDisplayString = "";
            this.ToINIToolStripMenuItem.Size = new System.Drawing.Size(251, 26);
            this.ToINIToolStripMenuItem.Text = "proxy.user.ini 配置文件";
            this.ToINIToolStripMenuItem.Click += new System.EventHandler(this.ToINIToolStripMenuItem_Click);
            // 
            // 移除ToolStripMenuItem
            // 
            this.移除ToolStripMenuItem.Name = "移除ToolStripMenuItem";
            this.移除ToolStripMenuItem.Size = new System.Drawing.Size(160, 26);
            this.移除ToolStripMenuItem.Text = "移除选中";
            this.移除ToolStripMenuItem.Click += new System.EventHandler(this.移除选中ToolStripMenuItem_Click_1);
            // 
            // 去重ToolStripMenuItem
            // 
            this.去重ToolStripMenuItem.Name = "去重ToolStripMenuItem";
            this.去重ToolStripMenuItem.Size = new System.Drawing.Size(160, 26);
            this.去重ToolStripMenuItem.Text = "移除重复";
            this.去重ToolStripMenuItem.Click += new System.EventHandler(this.去重ToolStripMenuItem_Click);
            // 
            // removeAllToolStripMenuItem
            // 
            this.removeAllToolStripMenuItem.Name = "removeAllToolStripMenuItem";
            this.removeAllToolStripMenuItem.Size = new System.Drawing.Size(160, 26);
            this.removeAllToolStripMenuItem.Text = "全部移除";
            this.removeAllToolStripMenuItem.Click += new System.EventHandler(this.removeAllToolStripMenuItem_Click);
            // 
            // buttonRandTest
            // 
            this.buttonRandTest.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.buttonRandTest.Font = new System.Drawing.Font("微软雅黑", 9.969231F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.buttonRandTest.Location = new System.Drawing.Point(4, 370);
            this.buttonRandTest.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.buttonRandTest.Name = "buttonRandTest";
            this.buttonRandTest.Size = new System.Drawing.Size(100, 44);
            this.buttonRandTest.TabIndex = 8;
            this.buttonRandTest.Text = "测试IP池";
            this.buttonRandTest.Click += new System.EventHandler(this.buttonRandTest_Click);
            this.buttonRandTest.MouseEnter += new System.EventHandler(this.buttonRandTest_MouseEnter);
            // 
            // buttonBandTest
            // 
            this.buttonBandTest.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.buttonBandTest.Font = new System.Drawing.Font("微软雅黑", 9.969231F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.buttonBandTest.Location = new System.Drawing.Point(4, 466);
            this.buttonBandTest.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.buttonBandTest.Name = "buttonBandTest";
            this.buttonBandTest.Size = new System.Drawing.Size(100, 44);
            this.buttonBandTest.TabIndex = 1;
            this.buttonBandTest.Text = "带宽测试";
            this.buttonBandTest.UseVisualStyleBackColor = true;
            this.buttonBandTest.Click += new System.EventHandler(this.buttonBandTest_Click);
            this.buttonBandTest.MouseEnter += new System.EventHandler(this.buttonBandTest_MouseEnter);
            // 
            // buttonStopTest
            // 
            this.buttonStopTest.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonStopTest.Font = new System.Drawing.Font("微软雅黑", 9.969231F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.buttonStopTest.Location = new System.Drawing.Point(674, 498);
            this.buttonStopTest.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.buttonStopTest.Name = "buttonStopTest";
            this.buttonStopTest.Size = new System.Drawing.Size(100, 44);
            this.buttonStopTest.TabIndex = 1;
            this.buttonStopTest.Text = "停止测试";
            this.buttonStopTest.UseVisualStyleBackColor = true;
            this.buttonStopTest.Click += new System.EventHandler(this.buttonStopTest_Click);
            // 
            // buttonStandardTest
            // 
            this.buttonStandardTest.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.buttonStandardTest.Font = new System.Drawing.Font("微软雅黑", 9.969231F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.buttonStandardTest.Location = new System.Drawing.Point(4, 418);
            this.buttonStandardTest.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.buttonStandardTest.Name = "buttonStandardTest";
            this.buttonStandardTest.Size = new System.Drawing.Size(100, 44);
            this.buttonStandardTest.TabIndex = 1;
            this.buttonStandardTest.Text = "测试列表";
            this.buttonStandardTest.UseVisualStyleBackColor = true;
            this.buttonStandardTest.Click += new System.EventHandler(this.buttonStandardTest_Click);
            this.buttonStandardTest.MouseEnter += new System.EventHandler(this.buttonStandardTest_MouseEnter);
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.numericUpDownTimeOut);
            this.groupBox1.Controls.Add(this.numericUpDownTimes);
            this.groupBox1.Controls.Add(this.numericUpDownThrs);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.textBox1);
            this.groupBox1.Controls.Add(this.buttonClearPool);
            this.groupBox1.Controls.Add(this.buttonStandardTest);
            this.groupBox1.Controls.Add(this.buttonAddIP);
            this.groupBox1.Controls.Add(this.buttonAddIPS);
            this.groupBox1.Controls.Add(this.labelCount);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.labelRemainder);
            this.groupBox1.Controls.Add(this.buttonRandTest);
            this.groupBox1.Controls.Add(this.buttonBandTest);
            this.groupBox1.Controls.Add(this.comboBoxIPPools);
            this.groupBox1.Location = new System.Drawing.Point(670, -15);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(1);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(0);
            this.groupBox1.Size = new System.Drawing.Size(108, 510);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("微软雅黑", 8.861538F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label4.Location = new System.Drawing.Point(3, 107);
            this.label4.Margin = new System.Windows.Forms.Padding(2);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(42, 21);
            this.label4.TabIndex = 7;
            this.label4.Text = "次数";
            // 
            // numericUpDownTimeOut
            // 
            this.numericUpDownTimeOut.Increment = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numericUpDownTimeOut.Location = new System.Drawing.Point(49, 137);
            this.numericUpDownTimeOut.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numericUpDownTimeOut.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDownTimeOut.Name = "numericUpDownTimeOut";
            this.numericUpDownTimeOut.Size = new System.Drawing.Size(55, 26);
            this.numericUpDownTimeOut.TabIndex = 9;
            this.numericUpDownTimeOut.Value = new decimal(new int[] {
            200,
            0,
            0,
            0});
            this.numericUpDownTimeOut.ValueChanged += new System.EventHandler(this.numericUpDownTimeOut_ValueChanged);
            // 
            // numericUpDownTimes
            // 
            this.numericUpDownTimes.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.numericUpDownTimes.Location = new System.Drawing.Point(49, 108);
            this.numericUpDownTimes.Margin = new System.Windows.Forms.Padding(2);
            this.numericUpDownTimes.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDownTimes.Name = "numericUpDownTimes";
            this.numericUpDownTimes.Size = new System.Drawing.Size(55, 26);
            this.numericUpDownTimes.TabIndex = 6;
            this.numericUpDownTimes.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDownTimes.ValueChanged += new System.EventHandler(this.numericUpDownTimes_ValueChanged);
            // 
            // numericUpDownThrs
            // 
            this.numericUpDownThrs.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.numericUpDownThrs.Increment = new decimal(new int[] {
            50,
            0,
            0,
            0});
            this.numericUpDownThrs.Location = new System.Drawing.Point(49, 78);
            this.numericUpDownThrs.Margin = new System.Windows.Forms.Padding(2);
            this.numericUpDownThrs.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numericUpDownThrs.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDownThrs.Name = "numericUpDownThrs";
            this.numericUpDownThrs.Size = new System.Drawing.Size(55, 26);
            this.numericUpDownThrs.TabIndex = 6;
            this.numericUpDownThrs.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.numericUpDownThrs.ValueChanged += new System.EventHandler(this.numericUpDownThrs_ValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("微软雅黑", 8.861538F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(3, 136);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 21);
            this.label1.TabIndex = 3;
            this.label1.Text = "超时";
            // 
            // textBox1
            // 
            this.textBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.textBox1.Location = new System.Drawing.Point(4, 312);
            this.textBox1.Margin = new System.Windows.Forms.Padding(2);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 26);
            this.textBox1.TabIndex = 4;
            // 
            // buttonClearPool
            // 
            this.buttonClearPool.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.buttonClearPool.Font = new System.Drawing.Font("微软雅黑", 9.969231F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.buttonClearPool.Location = new System.Drawing.Point(4, 168);
            this.buttonClearPool.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.buttonClearPool.Name = "buttonClearPool";
            this.buttonClearPool.Size = new System.Drawing.Size(100, 44);
            this.buttonClearPool.TabIndex = 1;
            this.buttonClearPool.Text = "清空IP池";
            this.buttonClearPool.UseVisualStyleBackColor = true;
            this.buttonClearPool.Click += new System.EventHandler(this.buttonClearPool_Click);
            this.buttonClearPool.MouseEnter += new System.EventHandler(this.button1_MouseEnter);
            // 
            // buttonAddIP
            // 
            this.buttonAddIP.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.buttonAddIP.Font = new System.Drawing.Font("微软雅黑", 9.969231F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.buttonAddIP.Location = new System.Drawing.Point(4, 264);
            this.buttonAddIP.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.buttonAddIP.Name = "buttonAddIP";
            this.buttonAddIP.Size = new System.Drawing.Size(100, 44);
            this.buttonAddIP.TabIndex = 1;
            this.buttonAddIP.Text = "输入IP";
            this.buttonAddIP.UseVisualStyleBackColor = true;
            this.buttonAddIP.Click += new System.EventHandler(this.buttonAddIP_Click);
            this.buttonAddIP.MouseEnter += new System.EventHandler(this.buttonAddIP_MouseEnter);
            // 
            // buttonAddIPS
            // 
            this.buttonAddIPS.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.buttonAddIPS.Font = new System.Drawing.Font("微软雅黑", 9.969231F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.buttonAddIPS.Location = new System.Drawing.Point(4, 216);
            this.buttonAddIPS.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.buttonAddIPS.Name = "buttonAddIPS";
            this.buttonAddIPS.Size = new System.Drawing.Size(100, 44);
            this.buttonAddIPS.TabIndex = 1;
            this.buttonAddIPS.Text = "导入IP";
            this.buttonAddIPS.UseVisualStyleBackColor = true;
            this.buttonAddIPS.Click += new System.EventHandler(this.buttonAddIPS_Click);
            this.buttonAddIPS.MouseEnter += new System.EventHandler(this.buttonAddIPS_MouseEnter);
            // 
            // labelCount
            // 
            this.labelCount.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.labelCount.AutoSize = true;
            this.labelCount.Font = new System.Drawing.Font("微软雅黑", 8.861538F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labelCount.Location = new System.Drawing.Point(3, 53);
            this.labelCount.Margin = new System.Windows.Forms.Padding(2);
            this.labelCount.Name = "labelCount";
            this.labelCount.Size = new System.Drawing.Size(105, 21);
            this.labelCount.TabIndex = 5;
            this.labelCount.Text = "有效9999999";
            this.labelCount.MouseEnter += new System.EventHandler(this.labelCount_MouseEnter);
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("微软雅黑", 8.861538F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label3.Location = new System.Drawing.Point(3, 77);
            this.label3.Margin = new System.Windows.Forms.Padding(2);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 21);
            this.label3.TabIndex = 7;
            this.label3.Text = "线程";
            // 
            // labelRemainder
            // 
            this.labelRemainder.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.labelRemainder.AutoSize = true;
            this.labelRemainder.Font = new System.Drawing.Font("微软雅黑", 8.861538F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labelRemainder.Location = new System.Drawing.Point(3, 28);
            this.labelRemainder.Margin = new System.Windows.Forms.Padding(2);
            this.labelRemainder.Name = "labelRemainder";
            this.labelRemainder.Size = new System.Drawing.Size(105, 21);
            this.labelRemainder.TabIndex = 5;
            this.labelRemainder.Text = "剩余9999999";
            this.labelRemainder.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.labelRemainder.MouseEnter += new System.EventHandler(this.labelRemainder_MouseEnter);
            // 
            // comboBoxIPPools
            // 
            this.comboBoxIPPools.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.comboBoxIPPools.FormattingEnabled = true;
            this.comboBoxIPPools.Location = new System.Drawing.Point(4, 342);
            this.comboBoxIPPools.Margin = new System.Windows.Forms.Padding(2);
            this.comboBoxIPPools.Name = "comboBoxIPPools";
            this.comboBoxIPPools.Size = new System.Drawing.Size(100, 24);
            this.comboBoxIPPools.TabIndex = 3;
            this.comboBoxIPPools.DropDown += new System.EventHandler(this.comboBoxIpPools_DropDown);
            this.comboBoxIPPools.SelectionChangeCommitted += new System.EventHandler(this.comboBoxIPPools_SelectionChangeCommitted);
            this.comboBoxIPPools.MouseEnter += new System.EventHandler(this.comboBoxIpPools_MouseEnter);
            // 
            // toolTip1
            // 
            this.toolTip1.AutoPopDelay = 10000;
            this.toolTip1.InitialDelay = 500;
            this.toolTip1.IsBalloon = true;
            this.toolTip1.ReshowDelay = 500;
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Form1
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(782, 553);
            this.Controls.Add(this.buttonStopTest);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dataGridView1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximumSize = new System.Drawing.Size(1920, 1080);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MotherFuckerFang 测试GVS、GWS谷歌IP";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.DragDrop += new System.Windows.Forms.DragEventHandler(this.AddIPS_DragDrop);
            this.DragEnter += new System.Windows.Forms.DragEventHandler(this.AddIPS_DragEnter);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownTimeOut)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownTimes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownThrs)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button buttonRandTest;
        private System.Windows.Forms.Button buttonBandTest;
        private System.Windows.Forms.Button buttonStopTest;
        private System.Windows.Forms.Button buttonStandardTest;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label labelRemainder;
        private System.Windows.Forms.Label labelCount;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.ComboBox comboBoxIPPools;
        private System.Windows.Forms.Button buttonAddIPS;
        private System.Windows.Forms.Button buttonAddIP;
        private System.Windows.Forms.NumericUpDown numericUpDownThrs;
        private System.Windows.Forms.NumericUpDown numericUpDownTimes;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.ToolStripMenuItem 导入IPToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 空格分隔剪切板ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 换行分隔剪切板ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 空格分隔TXTToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 换行分隔TXTToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ToIPSEGToolStripMenuItem;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button buttonClearPool;
        private System.Windows.Forms.ToolStripMenuItem 导出ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ToINIToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 移除ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 去重ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem removeAllToolStripMenuItem;
        private System.Windows.Forms.NumericUpDown numericUpDownTimeOut;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn ip;
        private System.Windows.Forms.DataGridViewTextBoxColumn delay;
        private System.Windows.Forms.DataGridViewTextBoxColumn type;
        private System.Windows.Forms.DataGridViewTextBoxColumn crt;
        private System.Windows.Forms.DataGridViewTextBoxColumn pass;
        private System.Windows.Forms.DataGridViewTextBoxColumn speed;
        private System.Windows.Forms.DataGridViewTextBoxColumn privateIP;
    }
}

