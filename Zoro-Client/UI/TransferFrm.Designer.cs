namespace Zoro_Client.UI
{
    partial class TransferFrm
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
            this.lblAsset = new System.Windows.Forms.Label();
            this.tbxFrom = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tbxTo = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tbxGasLimit = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.tbxGasPrice = new System.Windows.Forms.TextBox();
            this.btnEstimateGas = new System.Windows.Forms.Button();
            this.btnSend = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.tbxValue = new System.Windows.Forms.TextBox();
            this.btnCancel = new System.Windows.Forms.Button();
            this.tbxResult = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblAsset
            // 
            this.lblAsset.AutoSize = true;
            this.lblAsset.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblAsset.Location = new System.Drawing.Point(75, 12);
            this.lblAsset.Name = "lblAsset";
            this.lblAsset.Size = new System.Drawing.Size(344, 17);
            this.lblAsset.TabIndex = 0;
            this.lblAsset.Text = "0x0000000000000000000000000000000000000001(ZORO)";
            // 
            // tbxFrom
            // 
            this.tbxFrom.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.tbxFrom.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tbxFrom.Location = new System.Drawing.Point(78, 45);
            this.tbxFrom.Name = "tbxFrom";
            this.tbxFrom.ReadOnly = true;
            this.tbxFrom.Size = new System.Drawing.Size(341, 23);
            this.tbxFrom.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(28, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "From:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.Location = new System.Drawing.Point(27, 12);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "Asset:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label3.Location = new System.Drawing.Point(43, 91);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(26, 17);
            this.label3.TabIndex = 5;
            this.label3.Text = "To:";
            // 
            // tbxTo
            // 
            this.tbxTo.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tbxTo.Location = new System.Drawing.Point(78, 88);
            this.tbxTo.Name = "tbxTo";
            this.tbxTo.Size = new System.Drawing.Size(341, 23);
            this.tbxTo.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label4.Location = new System.Drawing.Point(9, 182);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 17);
            this.label4.TabIndex = 7;
            this.label4.Text = "GasLimit:";
            // 
            // tbxGasLimit
            // 
            this.tbxGasLimit.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.tbxGasLimit.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tbxGasLimit.Location = new System.Drawing.Point(78, 179);
            this.tbxGasLimit.Name = "tbxGasLimit";
            this.tbxGasLimit.ReadOnly = true;
            this.tbxGasLimit.Size = new System.Drawing.Size(97, 23);
            this.tbxGasLimit.TabIndex = 6;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label5.Location = new System.Drawing.Point(187, 136);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(61, 17);
            this.label5.TabIndex = 9;
            this.label5.Text = "GasPrice:";
            // 
            // tbxGasPrice
            // 
            this.tbxGasPrice.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.tbxGasPrice.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tbxGasPrice.Location = new System.Drawing.Point(254, 133);
            this.tbxGasPrice.Name = "tbxGasPrice";
            this.tbxGasPrice.Size = new System.Drawing.Size(60, 23);
            this.tbxGasPrice.TabIndex = 8;
            this.tbxGasPrice.Text = "0.0001";
            this.tbxGasPrice.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbxOnlyNumber_KeyPress);
            // 
            // btnEstimateGas
            // 
            this.btnEstimateGas.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnEstimateGas.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnEstimateGas.FlatAppearance.BorderSize = 0;
            this.btnEstimateGas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEstimateGas.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnEstimateGas.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnEstimateGas.Location = new System.Drawing.Point(329, 132);
            this.btnEstimateGas.Name = "btnEstimateGas";
            this.btnEstimateGas.Size = new System.Drawing.Size(90, 25);
            this.btnEstimateGas.TabIndex = 36;
            this.btnEstimateGas.Text = "EstimateGas";
            this.btnEstimateGas.UseVisualStyleBackColor = false;
            this.btnEstimateGas.Click += new System.EventHandler(this.BtnEstimateGas_Click);
            // 
            // btnSend
            // 
            this.btnSend.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnSend.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnSend.FlatAppearance.BorderSize = 0;
            this.btnSend.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSend.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnSend.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnSend.Location = new System.Drawing.Point(224, 178);
            this.btnSend.Name = "btnSend";
            this.btnSend.Size = new System.Drawing.Size(90, 25);
            this.btnSend.TabIndex = 35;
            this.btnSend.Text = "Send";
            this.btnSend.UseVisualStyleBackColor = false;
            this.btnSend.Click += new System.EventHandler(this.BtnSend_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label6.Location = new System.Drawing.Point(26, 136);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(43, 17);
            this.label6.TabIndex = 38;
            this.label6.Text = "Value:";
            // 
            // tbxValue
            // 
            this.tbxValue.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.tbxValue.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tbxValue.Location = new System.Drawing.Point(78, 133);
            this.tbxValue.Name = "tbxValue";
            this.tbxValue.Size = new System.Drawing.Size(97, 23);
            this.tbxValue.TabIndex = 37;
            this.tbxValue.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbxOnlyNumber_KeyPress);
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnCancel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnCancel.FlatAppearance.BorderSize = 0;
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancel.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnCancel.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnCancel.Location = new System.Drawing.Point(329, 178);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(90, 25);
            this.btnCancel.TabIndex = 34;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.BtnCancel_Click);
            // 
            // tbxResult
            // 
            this.tbxResult.AcceptsReturn = true;
            this.tbxResult.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.tbxResult.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tbxResult.Location = new System.Drawing.Point(78, 232);
            this.tbxResult.Multiline = true;
            this.tbxResult.Name = "tbxResult";
            this.tbxResult.ReadOnly = true;
            this.tbxResult.Size = new System.Drawing.Size(341, 82);
            this.tbxResult.TabIndex = 39;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label7.Location = new System.Drawing.Point(23, 234);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(46, 17);
            this.label7.TabIndex = 40;
            this.label7.Text = "Result:";
            // 
            // TransferFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(470, 326);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.tbxResult);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.tbxValue);
            this.Controls.Add(this.btnEstimateGas);
            this.Controls.Add(this.btnSend);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.tbxGasPrice);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tbxGasLimit);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tbxTo);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbxFrom);
            this.Controls.Add(this.lblAsset);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "TransferFrm";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Transaction";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblAsset;
        private System.Windows.Forms.TextBox tbxFrom;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbxTo;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbxGasLimit;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tbxGasPrice;
        private System.Windows.Forms.Button btnEstimateGas;
        private System.Windows.Forms.Button btnSend;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tbxValue;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.TextBox tbxResult;
        private System.Windows.Forms.Label label7;
    }
}