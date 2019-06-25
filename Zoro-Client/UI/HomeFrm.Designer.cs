namespace Zoro_Client.UI
{
    partial class HomeForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HomeForm));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.钱包WToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.创建钱包数据库NToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.打开钱包数据库OToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.退出XToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contractToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addAssetToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.帮助HToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.查看帮助VToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.官网WToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.关于AntSharesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.lbl_height = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel4 = new System.Windows.Forms.ToolStripStatusLabel();
            this.lbl_count_node = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripProgressBar1 = new System.Windows.Forms.ToolStripProgressBar();
            this.toolStripStatusLabel2 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel3 = new System.Windows.Forms.ToolStripStatusLabel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.创建新地址NToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.导入私钥IToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.importWIFToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.importCertificateToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator10 = new System.Windows.Forms.ToolStripSeparator();
            this.importWatchOnlyAddressToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.menuStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.White;
            this.menuStrip1.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.钱包WToolStripMenuItem,
            this.contractToolStripMenuItem,
            this.addAssetToolStripMenuItem,
            this.帮助HToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(8, 4, 0, 4);
            this.menuStrip1.Size = new System.Drawing.Size(538, 29);
            this.menuStrip1.TabIndex = 5;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // 钱包WToolStripMenuItem
            // 
            this.钱包WToolStripMenuItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.钱包WToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.创建钱包数据库NToolStripMenuItem,
            this.打开钱包数据库OToolStripMenuItem,
            this.toolStripSeparator1,
            this.退出XToolStripMenuItem});
            this.钱包WToolStripMenuItem.Name = "钱包WToolStripMenuItem";
            this.钱包WToolStripMenuItem.Size = new System.Drawing.Size(56, 21);
            this.钱包WToolStripMenuItem.Text = "&Wallet";
            // 
            // 创建钱包数据库NToolStripMenuItem
            // 
            this.创建钱包数据库NToolStripMenuItem.Name = "创建钱包数据库NToolStripMenuItem";
            this.创建钱包数据库NToolStripMenuItem.Size = new System.Drawing.Size(216, 22);
            this.创建钱包数据库NToolStripMenuItem.Text = "&New Wallet Database...";
            this.创建钱包数据库NToolStripMenuItem.Click += new System.EventHandler(this.创建钱包数据库NToolStripMenuItem_Click);
            // 
            // 打开钱包数据库OToolStripMenuItem
            // 
            this.打开钱包数据库OToolStripMenuItem.Name = "打开钱包数据库OToolStripMenuItem";
            this.打开钱包数据库OToolStripMenuItem.Size = new System.Drawing.Size(216, 22);
            this.打开钱包数据库OToolStripMenuItem.Text = "&Open Wallet Database...";
            this.打开钱包数据库OToolStripMenuItem.Click += new System.EventHandler(this.打开钱包数据库OToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(213, 6);
            // 
            // 退出XToolStripMenuItem
            // 
            this.退出XToolStripMenuItem.Name = "退出XToolStripMenuItem";
            this.退出XToolStripMenuItem.Size = new System.Drawing.Size(216, 22);
            this.退出XToolStripMenuItem.Text = "E&xit";
            this.退出XToolStripMenuItem.Click += new System.EventHandler(this.退出XToolStripMenuItem_Click);
            // 
            // contractToolStripMenuItem
            // 
            this.contractToolStripMenuItem.Name = "contractToolStripMenuItem";
            this.contractToolStripMenuItem.Size = new System.Drawing.Size(112, 21);
            this.contractToolStripMenuItem.Text = "Invoke Contract";
            // 
            // addAssetToolStripMenuItem
            // 
            this.addAssetToolStripMenuItem.Name = "addAssetToolStripMenuItem";
            this.addAssetToolStripMenuItem.Size = new System.Drawing.Size(79, 21);
            this.addAssetToolStripMenuItem.Text = "Add Asset";
            this.addAssetToolStripMenuItem.Click += new System.EventHandler(this.AddAssetToolStripMenuItem_Click);
            // 
            // 帮助HToolStripMenuItem
            // 
            this.帮助HToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.查看帮助VToolStripMenuItem,
            this.官网WToolStripMenuItem,
            this.toolStripSeparator4,
            this.关于AntSharesToolStripMenuItem});
            this.帮助HToolStripMenuItem.Name = "帮助HToolStripMenuItem";
            this.帮助HToolStripMenuItem.Size = new System.Drawing.Size(47, 21);
            this.帮助HToolStripMenuItem.Text = "&Help";
            // 
            // 查看帮助VToolStripMenuItem
            // 
            this.查看帮助VToolStripMenuItem.Name = "查看帮助VToolStripMenuItem";
            this.查看帮助VToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.查看帮助VToolStripMenuItem.Text = "&Check for Help";
            // 
            // 官网WToolStripMenuItem
            // 
            this.官网WToolStripMenuItem.Name = "官网WToolStripMenuItem";
            this.官网WToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.官网WToolStripMenuItem.Text = "Official &Web";
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(177, 6);
            // 
            // 关于AntSharesToolStripMenuItem
            // 
            this.关于AntSharesToolStripMenuItem.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.关于AntSharesToolStripMenuItem.Name = "关于AntSharesToolStripMenuItem";
            this.关于AntSharesToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.关于AntSharesToolStripMenuItem.Text = "&About Zoro";
            // 
            // statusStrip1
            // 
            this.statusStrip1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1,
            this.lbl_height,
            this.toolStripStatusLabel4,
            this.lbl_count_node,
            this.toolStripProgressBar1,
            this.toolStripStatusLabel2,
            this.toolStripStatusLabel3});
            this.statusStrip1.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.HorizontalStackWithOverflow;
            this.statusStrip1.Location = new System.Drawing.Point(0, 359);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Padding = new System.Windows.Forms.Padding(1, 0, 17, 0);
            this.statusStrip1.Size = new System.Drawing.Size(538, 22);
            this.statusStrip1.SizingGrip = false;
            this.statusStrip1.TabIndex = 6;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(49, 17);
            this.toolStripStatusLabel1.Text = "Height:";
            // 
            // lbl_height
            // 
            this.lbl_height.Name = "lbl_height";
            this.lbl_height.Size = new System.Drawing.Size(27, 17);
            this.lbl_height.Text = "0/0";
            // 
            // toolStripStatusLabel4
            // 
            this.toolStripStatusLabel4.Name = "toolStripStatusLabel4";
            this.toolStripStatusLabel4.Size = new System.Drawing.Size(73, 17);
            this.toolStripStatusLabel4.Text = "Connected:";
            // 
            // lbl_count_node
            // 
            this.lbl_count_node.Name = "lbl_count_node";
            this.lbl_count_node.Size = new System.Drawing.Size(15, 17);
            this.lbl_count_node.Text = "0";
            // 
            // toolStripProgressBar1
            // 
            this.toolStripProgressBar1.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolStripProgressBar1.BackColor = System.Drawing.Color.White;
            this.toolStripProgressBar1.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.toolStripProgressBar1.Maximum = 15;
            this.toolStripProgressBar1.Name = "toolStripProgressBar1";
            this.toolStripProgressBar1.Size = new System.Drawing.Size(90, 16);
            this.toolStripProgressBar1.Step = 1;
            // 
            // toolStripStatusLabel2
            // 
            this.toolStripStatusLabel2.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolStripStatusLabel2.Name = "toolStripStatusLabel2";
            this.toolStripStatusLabel2.Size = new System.Drawing.Size(140, 17);
            this.toolStripStatusLabel2.Text = "Waiting for next block:";
            // 
            // toolStripStatusLabel3
            // 
            this.toolStripStatusLabel3.IsLink = true;
            this.toolStripStatusLabel3.Name = "toolStripStatusLabel3";
            this.toolStripStatusLabel3.Size = new System.Drawing.Size(145, 17);
            this.toolStripStatusLabel3.Text = "Download New Version";
            this.toolStripStatusLabel3.Visible = false;
            // 
            // panel1
            // 
            this.panel1.AutoScroll = true;
            this.panel1.AutoScrollMargin = new System.Drawing.Size(0, 40);
            this.panel1.ContextMenuStrip = this.contextMenuStrip1;
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 29);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(538, 330);
            this.panel1.TabIndex = 7;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.创建新地址NToolStripMenuItem,
            this.导入私钥IToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(176, 48);
            this.contextMenuStrip1.Opening += new System.ComponentModel.CancelEventHandler(this.ContextMenuStrip1_Opening);
            // 
            // 创建新地址NToolStripMenuItem
            // 
            this.创建新地址NToolStripMenuItem.Enabled = false;
            this.创建新地址NToolStripMenuItem.Name = "创建新地址NToolStripMenuItem";
            this.创建新地址NToolStripMenuItem.Size = new System.Drawing.Size(175, 22);
            this.创建新地址NToolStripMenuItem.Text = "Create &New Add.";
            this.创建新地址NToolStripMenuItem.Click += new System.EventHandler(this.创建新地址NToolStripMenuItem_Click);
            // 
            // 导入私钥IToolStripMenuItem
            // 
            this.导入私钥IToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.importWIFToolStripMenuItem,
            this.importCertificateToolStripMenuItem,
            this.toolStripSeparator10,
            this.importWatchOnlyAddressToolStripMenuItem});
            this.导入私钥IToolStripMenuItem.Enabled = false;
            this.导入私钥IToolStripMenuItem.Name = "导入私钥IToolStripMenuItem";
            this.导入私钥IToolStripMenuItem.Size = new System.Drawing.Size(175, 22);
            this.导入私钥IToolStripMenuItem.Text = "&Import";
            // 
            // importWIFToolStripMenuItem
            // 
            this.importWIFToolStripMenuItem.Name = "importWIFToolStripMenuItem";
            this.importWIFToolStripMenuItem.Size = new System.Drawing.Size(248, 22);
            this.importWIFToolStripMenuItem.Text = "Import from &WIF...";
            this.importWIFToolStripMenuItem.Click += new System.EventHandler(this.ImportWIFToolStripMenuItem_Click);
            // 
            // importCertificateToolStripMenuItem
            // 
            this.importCertificateToolStripMenuItem.Name = "importCertificateToolStripMenuItem";
            this.importCertificateToolStripMenuItem.Size = new System.Drawing.Size(248, 22);
            this.importCertificateToolStripMenuItem.Text = "Import from &Certificate...";
            // 
            // toolStripSeparator10
            // 
            this.toolStripSeparator10.Name = "toolStripSeparator10";
            this.toolStripSeparator10.Size = new System.Drawing.Size(245, 6);
            // 
            // importWatchOnlyAddressToolStripMenuItem
            // 
            this.importWatchOnlyAddressToolStripMenuItem.Name = "importWatchOnlyAddressToolStripMenuItem";
            this.importWatchOnlyAddressToolStripMenuItem.Size = new System.Drawing.Size(248, 22);
            this.importWatchOnlyAddressToolStripMenuItem.Text = "Import Watch-Only &Address...";
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.Timer1_Tick);
            // 
            // HomeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(538, 381);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "HomeForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Zoro Gui";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.HomeForm_FormClosing);
            this.Load += new System.EventHandler(this.HomeForm_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 钱包WToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 创建钱包数据库NToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 打开钱包数据库OToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem 退出XToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem contractToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addAssetToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 帮助HToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 查看帮助VToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 官网WToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripMenuItem 关于AntSharesToolStripMenuItem;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStripStatusLabel lbl_height;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel4;
        private System.Windows.Forms.ToolStripStatusLabel lbl_count_node;
        private System.Windows.Forms.ToolStripProgressBar toolStripProgressBar1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel2;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel3;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 创建新地址NToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 导入私钥IToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem importWIFToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem importCertificateToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator10;
        private System.Windows.Forms.ToolStripMenuItem importWatchOnlyAddressToolStripMenuItem;
        private System.Windows.Forms.Timer timer1;
    }
}