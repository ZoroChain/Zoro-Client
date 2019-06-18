namespace Zoro_Client.UI
{
    partial class AccountControl
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
            this.lblZoro = new System.Windows.Forms.Label();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.查看私钥VToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.复制到剪贴板CToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.删除DToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lblBct = new System.Windows.Forms.Label();
            this.btnTransferZoro = new System.Windows.Forms.Button();
            this.btnTransferBct = new System.Windows.Forms.Button();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.contextMenuStrip1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblAddress
            // 
            this.lblAddress.AutoSize = true;
            this.lblAddress.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblAddress.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblAddress.ForeColor = System.Drawing.Color.DodgerBlue;
            this.lblAddress.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblAddress.Location = new System.Drawing.Point(3, 0);
            this.lblAddress.Name = "lblAddress";
            this.lblAddress.Padding = new System.Windows.Forms.Padding(0, 9, 0, 0);
            this.lblAddress.Size = new System.Drawing.Size(341, 33);
            this.lblAddress.TabIndex = 21;
            this.lblAddress.Text = "AcQLYjGbQU2bEQ8RKFXUcf8XvromfUQodq";
            this.lblAddress.DoubleClick += new System.EventHandler(this.AccountFrm_DoubleClick);
            // 
            // lblZoro
            // 
            this.lblZoro.AutoSize = true;
            this.lblZoro.ContextMenuStrip = this.contextMenuStrip1;
            this.lblZoro.Dock = System.Windows.Forms.DockStyle.Left;
            this.lblZoro.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblZoro.ForeColor = System.Drawing.Color.DodgerBlue;
            this.lblZoro.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblZoro.Location = new System.Drawing.Point(350, 0);
            this.lblZoro.Name = "lblZoro";
            this.lblZoro.Padding = new System.Windows.Forms.Padding(0, 9, 0, 0);
            this.lblZoro.Size = new System.Drawing.Size(109, 33);
            this.lblZoro.TabIndex = 23;
            this.lblZoro.Text = "00000000.000000";
            this.lblZoro.DoubleClick += new System.EventHandler(this.AccountFrm_DoubleClick);
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
            this.查看私钥VToolStripMenuItem.Size = new System.Drawing.Size(176, 22);
            this.查看私钥VToolStripMenuItem.Text = "View &Private Key";
            this.查看私钥VToolStripMenuItem.Click += new System.EventHandler(this.查看私钥VToolStripMenuItem_Click);
            // 
            // 复制到剪贴板CToolStripMenuItem
            // 
            this.复制到剪贴板CToolStripMenuItem.Name = "复制到剪贴板CToolStripMenuItem";
            this.复制到剪贴板CToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.C)));
            this.复制到剪贴板CToolStripMenuItem.ShowShortcutKeys = false;
            this.复制到剪贴板CToolStripMenuItem.Size = new System.Drawing.Size(176, 22);
            this.复制到剪贴板CToolStripMenuItem.Text = "&Copy to Clipboard";
            this.复制到剪贴板CToolStripMenuItem.Click += new System.EventHandler(this.复制到剪贴板CToolStripMenuItem_Click);
            // 
            // 删除DToolStripMenuItem
            // 
            this.删除DToolStripMenuItem.Name = "删除DToolStripMenuItem";
            this.删除DToolStripMenuItem.Size = new System.Drawing.Size(176, 22);
            this.删除DToolStripMenuItem.Text = "&Delete...";
            this.删除DToolStripMenuItem.Click += new System.EventHandler(this.删除DToolStripMenuItem_Click);
            // 
            // lblBct
            // 
            this.lblBct.AutoSize = true;
            this.lblBct.Dock = System.Windows.Forms.DockStyle.Left;
            this.lblBct.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblBct.ForeColor = System.Drawing.Color.DodgerBlue;
            this.lblBct.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblBct.Location = new System.Drawing.Point(586, 0);
            this.lblBct.Name = "lblBct";
            this.lblBct.Padding = new System.Windows.Forms.Padding(0, 9, 0, 0);
            this.lblBct.Size = new System.Drawing.Size(109, 33);
            this.lblBct.TabIndex = 25;
            this.lblBct.Text = "00000000.000000";
            this.lblBct.DoubleClick += new System.EventHandler(this.AccountFrm_DoubleClick);
            // 
            // btnTransferZoro
            // 
            this.btnTransferZoro.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnTransferZoro.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnTransferZoro.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTransferZoro.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnTransferZoro.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnTransferZoro.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnTransferZoro.Location = new System.Drawing.Point(490, 4);
            this.btnTransferZoro.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnTransferZoro.Name = "btnTransferZoro";
            this.btnTransferZoro.Size = new System.Drawing.Size(70, 25);
            this.btnTransferZoro.TabIndex = 30;
            this.btnTransferZoro.Text = "Transfer";
            this.btnTransferZoro.UseVisualStyleBackColor = false;
            this.btnTransferZoro.Click += new System.EventHandler(this.BtnTransferZoro_Click);
            // 
            // btnTransferBct
            // 
            this.btnTransferBct.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnTransferBct.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnTransferBct.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTransferBct.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnTransferBct.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnTransferBct.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnTransferBct.Location = new System.Drawing.Point(711, 4);
            this.btnTransferBct.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnTransferBct.Name = "btnTransferBct";
            this.btnTransferBct.Size = new System.Drawing.Size(70, 25);
            this.btnTransferBct.TabIndex = 31;
            this.btnTransferBct.Text = "Transfer";
            this.btnTransferBct.UseVisualStyleBackColor = false;
            this.btnTransferBct.Click += new System.EventHandler(this.BtnTransferBct_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 5;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 140F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 96F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 125F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 162F));
            this.tableLayoutPanel1.Controls.Add(this.lblAddress, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.btnTransferBct, 4, 0);
            this.tableLayoutPanel1.Controls.Add(this.lblZoro, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.btnTransferZoro, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.lblBct, 3, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(870, 33);
            this.tableLayoutPanel1.TabIndex = 32;
            // 
            // AccountControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ContextMenuStrip = this.contextMenuStrip1;
            this.Controls.Add(this.tableLayoutPanel1);
            this.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.ForeColor = System.Drawing.Color.DodgerBlue;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "AccountControl";
            this.Size = new System.Drawing.Size(870, 33);
            this.DoubleClick += new System.EventHandler(this.AccountFrm_DoubleClick);
            this.contextMenuStrip1.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label lblAddress;
        private System.Windows.Forms.Label lblZoro;
        private System.Windows.Forms.Label lblBct;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 查看私钥VToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 复制到剪贴板CToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 删除DToolStripMenuItem;
        private System.Windows.Forms.Button btnTransferZoro;
        private System.Windows.Forms.Button btnTransferBct;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
    }
}
