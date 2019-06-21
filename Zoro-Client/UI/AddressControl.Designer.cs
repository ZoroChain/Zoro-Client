namespace Zoro_Client.UI
{
    partial class AddressControl
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

        #region 组件设计器生成的代码

        /// <summary> 
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.lblAddress = new System.Windows.Forms.Label();
            this.btnOpen = new System.Windows.Forms.Button();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.查看私钥VToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.复制到剪贴板CToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.删除DToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblAddress
            // 
            this.lblAddress.AutoSize = true;
            this.lblAddress.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblAddress.ForeColor = System.Drawing.Color.DodgerBlue;
            this.lblAddress.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblAddress.Location = new System.Drawing.Point(13, -1);
            this.lblAddress.Name = "lblAddress";
            this.lblAddress.Padding = new System.Windows.Forms.Padding(0, 9, 0, 0);
            this.lblAddress.Size = new System.Drawing.Size(264, 26);
            this.lblAddress.TabIndex = 22;
            this.lblAddress.Text = "AcQLYjGbQU2bEQ8RKFXUcf8XvromfUQodq";
            this.lblAddress.DoubleClick += new System.EventHandler(this.AddressControl_DoubleClick);
            // 
            // btnOpen
            // 
            this.btnOpen.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnOpen.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOpen.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnOpen.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnOpen.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnOpen.Location = new System.Drawing.Point(426, 4);
            this.btnOpen.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnOpen.Name = "btnOpen";
            this.btnOpen.Size = new System.Drawing.Size(82, 25);
            this.btnOpen.TabIndex = 30;
            this.btnOpen.Text = "Open";
            this.btnOpen.UseVisualStyleBackColor = false;
            this.btnOpen.Click += new System.EventHandler(this.BtnOpen_Click);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.contextMenuStrip1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.查看私钥VToolStripMenuItem,
            this.复制到剪贴板CToolStripMenuItem,
            this.删除DToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(177, 70);
            // 
            // 查看私钥VToolStripMenuItem
            // 
            this.查看私钥VToolStripMenuItem.Name = "查看私钥VToolStripMenuItem";
            this.查看私钥VToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.查看私钥VToolStripMenuItem.Text = "View &Private Key";
            this.查看私钥VToolStripMenuItem.Click += new System.EventHandler(this.查看私钥VToolStripMenuItem_Click);
            // 
            // 复制到剪贴板CToolStripMenuItem
            // 
            this.复制到剪贴板CToolStripMenuItem.Name = "复制到剪贴板CToolStripMenuItem";
            this.复制到剪贴板CToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.C)));
            this.复制到剪贴板CToolStripMenuItem.ShowShortcutKeys = false;
            this.复制到剪贴板CToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.复制到剪贴板CToolStripMenuItem.Text = "&Copy to Clipboard";
            this.复制到剪贴板CToolStripMenuItem.Click += new System.EventHandler(this.复制到剪贴板CToolStripMenuItem_Click);
            // 
            // 删除DToolStripMenuItem
            // 
            this.删除DToolStripMenuItem.Name = "删除DToolStripMenuItem";
            this.删除DToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.删除DToolStripMenuItem.Text = "&Delete...";
            this.删除DToolStripMenuItem.Click += new System.EventHandler(this.删除DToolStripMenuItem_Click);
            // 
            // AddressControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ContextMenuStrip = this.contextMenuStrip1;
            this.Controls.Add(this.btnOpen);
            this.Controls.Add(this.lblAddress);
            this.Name = "AddressControl";
            this.Size = new System.Drawing.Size(530, 33);
            this.DoubleClick += new System.EventHandler(this.AddressControl_DoubleClick);
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblAddress;
        private System.Windows.Forms.Button btnOpen;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 查看私钥VToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 复制到剪贴板CToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 删除DToolStripMenuItem;
    }
}
