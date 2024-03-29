﻿namespace Zoro_Client.UI
{
    partial class AssetControl
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
            this.lblBalance = new System.Windows.Forms.Label();
            this.lblAsset = new System.Windows.Forms.Label();
            this.btnTransfer = new System.Windows.Forms.Button();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblBalance
            // 
            this.lblBalance.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblBalance.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblBalance.ForeColor = System.Drawing.Color.DodgerBlue;
            this.lblBalance.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblBalance.Location = new System.Drawing.Point(408, 0);
            this.lblBalance.Name = "lblBalance";
            this.lblBalance.Padding = new System.Windows.Forms.Padding(0, 9, 0, 0);
            this.lblBalance.Size = new System.Drawing.Size(155, 33);
            this.lblBalance.TabIndex = 28;
            this.lblBalance.Text = "00000000.000000";
            // 
            // lblAsset
            // 
            this.lblAsset.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblAsset.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblAsset.ForeColor = System.Drawing.Color.DodgerBlue;
            this.lblAsset.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblAsset.Location = new System.Drawing.Point(26, 0);
            this.lblAsset.Name = "lblAsset";
            this.lblAsset.Padding = new System.Windows.Forms.Padding(0, 9, 0, 0);
            this.lblAsset.Size = new System.Drawing.Size(352, 33);
            this.lblAsset.TabIndex = 27;
            this.lblAsset.Text = "abc:0x00000000000000000000000";
            // 
            // btnTransfer
            // 
            this.btnTransfer.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnTransfer.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnTransfer.Enabled = false;
            this.btnTransfer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTransfer.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnTransfer.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnTransfer.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnTransfer.Location = new System.Drawing.Point(569, 4);
            this.btnTransfer.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnTransfer.Name = "btnTransfer";
            this.btnTransfer.Size = new System.Drawing.Size(82, 25);
            this.btnTransfer.TabIndex = 29;
            this.btnTransfer.Text = "Transfer";
            this.btnTransfer.UseVisualStyleBackColor = false;
            this.btnTransfer.Click += new System.EventHandler(this.BtnTransfer_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 161F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Controls.Add(this.btnTransfer, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.lblBalance, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.lblAsset, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(666, 33);
            this.tableLayoutPanel1.TabIndex = 30;
            // 
            // AssetControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Controls.Add(this.tableLayoutPanel1);
            this.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "AssetControl";
            this.Size = new System.Drawing.Size(666, 35);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblBalance;
        private System.Windows.Forms.Label lblAsset;
        private System.Windows.Forms.Button btnTransfer;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
    }
}
