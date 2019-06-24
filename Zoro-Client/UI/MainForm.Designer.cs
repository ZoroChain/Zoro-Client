namespace Zoro_Client.UI
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.columnHeader7 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader8 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader9 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader10 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.contractToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.publishContractToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.invokeContractToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.panel4 = new System.Windows.Forms.Panel();
            this.lblAddress = new System.Windows.Forms.Label();
            this.backToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // columnHeader7
            // 
            this.columnHeader7.DisplayIndex = 0;
            this.columnHeader7.Text = "Time";
            this.columnHeader7.Width = 132;
            // 
            // columnHeader8
            // 
            this.columnHeader8.DisplayIndex = 1;
            this.columnHeader8.Text = "Transaction ID";
            this.columnHeader8.Width = 482;
            // 
            // columnHeader9
            // 
            this.columnHeader9.DisplayIndex = 2;
            this.columnHeader9.Text = "confirm";
            this.columnHeader9.Width = 78;
            // 
            // columnHeader10
            // 
            this.columnHeader10.DisplayIndex = 3;
            this.columnHeader10.Text = "Transaction Type";
            this.columnHeader10.Width = 163;
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.White;
            this.menuStrip1.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.backToolStripMenuItem,
            this.contractToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(8, 4, 0, 4);
            this.menuStrip1.Size = new System.Drawing.Size(630, 29);
            this.menuStrip1.TabIndex = 4;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // contractToolStripMenuItem
            // 
            this.contractToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.publishContractToolStripMenuItem,
            this.invokeContractToolStripMenuItem});
            this.contractToolStripMenuItem.Name = "contractToolStripMenuItem";
            this.contractToolStripMenuItem.Size = new System.Drawing.Size(69, 21);
            this.contractToolStripMenuItem.Text = "Contract";
            // 
            // publishContractToolStripMenuItem
            // 
            this.publishContractToolStripMenuItem.Name = "publishContractToolStripMenuItem";
            this.publishContractToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.publishContractToolStripMenuItem.Text = "Publish Contract";
            this.publishContractToolStripMenuItem.Click += new System.EventHandler(this.PublishContractToolStripMenuItem_Click);
            // 
            // invokeContractToolStripMenuItem
            // 
            this.invokeContractToolStripMenuItem.Name = "invokeContractToolStripMenuItem";
            this.invokeContractToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.invokeContractToolStripMenuItem.Text = "Invoke Contract";
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.Timer1_Tick);
            // 
            // panel4
            // 
            this.panel4.AutoScroll = true;
            this.panel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel4.Location = new System.Drawing.Point(0, 52);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(630, 328);
            this.panel4.TabIndex = 6;
            // 
            // lblAddress
            // 
            this.lblAddress.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblAddress.Location = new System.Drawing.Point(0, 29);
            this.lblAddress.Name = "lblAddress";
            this.lblAddress.Size = new System.Drawing.Size(630, 23);
            this.lblAddress.TabIndex = 5;
            this.lblAddress.Text = "Address";
            this.lblAddress.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblAddress.Click += new System.EventHandler(this.LblAddress_Click);
            // 
            // backToolStripMenuItem
            // 
            this.backToolStripMenuItem.Name = "backToolStripMenuItem";
            this.backToolStripMenuItem.Size = new System.Drawing.Size(48, 21);
            this.backToolStripMenuItem.Text = "Back";
            this.backToolStripMenuItem.Click += new System.EventHandler(this.BackToolStripMenuItem_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(630, 381);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.lblAddress);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Zoro-Client";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ColumnHeader columnHeader7;
        private System.Windows.Forms.ColumnHeader columnHeader8;
        private System.Windows.Forms.ColumnHeader columnHeader9;
        private System.Windows.Forms.ColumnHeader columnHeader10;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem contractToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem publishContractToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem invokeContractToolStripMenuItem;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label lblAddress;
        private System.Windows.Forms.ToolStripMenuItem backToolStripMenuItem;
    }
}

