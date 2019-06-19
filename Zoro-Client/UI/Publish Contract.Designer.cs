namespace Zoro_Client.UI
{
    partial class PublishContractFrm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PublishContractFrm));
            this.label25 = new System.Windows.Forms.Label();
            this.btnLoadContract = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.tbxParameterType = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.tbxReturnType = new System.Windows.Forms.TextBox();
            this.btnPublish = new System.Windows.Forms.Button();
            this.lblBcpFee = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.cbxNeedStorge = new System.Windows.Forms.CheckBox();
            this.cbxNeedCharge = new System.Windows.Forms.CheckBox();
            this.label7 = new System.Windows.Forms.Label();
            this.tbxContractName = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.tbxVersion = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.tbxAuthor = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tbxEmail = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tbxDescri = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tbxContractHash = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tbxContractPath = new System.Windows.Forms.TextBox();
            this.cbxNeedNep4 = new System.Windows.Forms.CheckBox();
            this.tbxResult = new System.Windows.Forms.TextBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.SuspendLayout();
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.Location = new System.Drawing.Point(24, 259);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(46, 17);
            this.label25.TabIndex = 55;
            this.label25.Text = "Result:";
            this.label25.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // btnLoadContract
            // 
            this.btnLoadContract.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnLoadContract.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnLoadContract.FlatAppearance.BorderSize = 0;
            this.btnLoadContract.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLoadContract.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnLoadContract.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnLoadContract.Location = new System.Drawing.Point(488, 16);
            this.btnLoadContract.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnLoadContract.Name = "btnLoadContract";
            this.btnLoadContract.Size = new System.Drawing.Size(90, 25);
            this.btnLoadContract.TabIndex = 53;
            this.btnLoadContract.Text = "Browse";
            this.btnLoadContract.UseVisualStyleBackColor = false;
            this.btnLoadContract.Click += new System.EventHandler(this.BtnLoadContract_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(24, 190);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(103, 17);
            this.label10.TabIndex = 52;
            this.label10.Text = "Parameter Type:";
            // 
            // tbxParameterType
            // 
            this.tbxParameterType.Location = new System.Drawing.Point(136, 187);
            this.tbxParameterType.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tbxParameterType.Name = "tbxParameterType";
            this.tbxParameterType.Size = new System.Drawing.Size(136, 23);
            this.tbxParameterType.TabIndex = 51;
            this.tbxParameterType.Text = "0710";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(297, 190);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(81, 17);
            this.label11.TabIndex = 50;
            this.label11.Text = "Return Type:";
            // 
            // tbxReturnType
            // 
            this.tbxReturnType.Location = new System.Drawing.Point(384, 187);
            this.tbxReturnType.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tbxReturnType.Name = "tbxReturnType";
            this.tbxReturnType.Size = new System.Drawing.Size(194, 23);
            this.tbxReturnType.TabIndex = 49;
            this.tbxReturnType.Text = "05";
            // 
            // btnPublish
            // 
            this.btnPublish.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnPublish.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnPublish.FlatAppearance.BorderSize = 0;
            this.btnPublish.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPublish.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnPublish.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnPublish.Location = new System.Drawing.Point(488, 220);
            this.btnPublish.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnPublish.Name = "btnPublish";
            this.btnPublish.Size = new System.Drawing.Size(90, 25);
            this.btnPublish.TabIndex = 48;
            this.btnPublish.Text = "Publish";
            this.btnPublish.UseVisualStyleBackColor = false;
            // 
            // lblBcpFee
            // 
            this.lblBcpFee.AutoSize = true;
            this.lblBcpFee.ForeColor = System.Drawing.Color.Red;
            this.lblBcpFee.Location = new System.Drawing.Point(419, 226);
            this.lblBcpFee.Name = "lblBcpFee";
            this.lblBcpFee.Size = new System.Drawing.Size(39, 17);
            this.lblBcpFee.TabIndex = 47;
            this.lblBcpFee.Text = "90.00";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(343, 226);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(70, 17);
            this.label8.TabIndex = 46;
            this.label8.Text = "ZORO Fee:";
            // 
            // cbxNeedStorge
            // 
            this.cbxNeedStorge.AutoSize = true;
            this.cbxNeedStorge.Location = new System.Drawing.Point(134, 225);
            this.cbxNeedStorge.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cbxNeedStorge.Name = "cbxNeedStorge";
            this.cbxNeedStorge.Size = new System.Drawing.Size(102, 21);
            this.cbxNeedStorge.TabIndex = 45;
            this.cbxNeedStorge.Text = "Need Storge";
            this.cbxNeedStorge.UseVisualStyleBackColor = true;
            // 
            // cbxNeedCharge
            // 
            this.cbxNeedCharge.AutoSize = true;
            this.cbxNeedCharge.Location = new System.Drawing.Point(242, 225);
            this.cbxNeedCharge.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cbxNeedCharge.Name = "cbxNeedCharge";
            this.cbxNeedCharge.Size = new System.Drawing.Size(95, 21);
            this.cbxNeedCharge.TabIndex = 44;
            this.cbxNeedCharge.Text = "Can Charge";
            this.cbxNeedCharge.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(28, 88);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(99, 17);
            this.label7.TabIndex = 43;
            this.label7.Text = "Contract Name:";
            // 
            // tbxContractName
            // 
            this.tbxContractName.Location = new System.Drawing.Point(136, 86);
            this.tbxContractName.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tbxContractName.Name = "tbxContractName";
            this.tbxContractName.Size = new System.Drawing.Size(160, 23);
            this.tbxContractName.TabIndex = 42;
            this.tbxContractName.Text = "TestContract";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(323, 89);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(55, 17);
            this.label6.TabIndex = 41;
            this.label6.Text = "Versoin:";
            // 
            // tbxVersion
            // 
            this.tbxVersion.Location = new System.Drawing.Point(384, 85);
            this.tbxVersion.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tbxVersion.Name = "tbxVersion";
            this.tbxVersion.Size = new System.Drawing.Size(194, 23);
            this.tbxVersion.TabIndex = 40;
            this.tbxVersion.Text = "1.0";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(77, 120);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(50, 17);
            this.label5.TabIndex = 39;
            this.label5.Text = "Author:";
            // 
            // tbxAuthor
            // 
            this.tbxAuthor.Location = new System.Drawing.Point(136, 117);
            this.tbxAuthor.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tbxAuthor.Name = "tbxAuthor";
            this.tbxAuthor.Size = new System.Drawing.Size(162, 23);
            this.tbxAuthor.TabIndex = 38;
            this.tbxAuthor.Text = "Satoshi";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(336, 120);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(42, 17);
            this.label4.TabIndex = 37;
            this.label4.Text = "Email:";
            // 
            // tbxEmail
            // 
            this.tbxEmail.Location = new System.Drawing.Point(384, 117);
            this.tbxEmail.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tbxEmail.Name = "tbxEmail";
            this.tbxEmail.Size = new System.Drawing.Size(194, 23);
            this.tbxEmail.TabIndex = 36;
            this.tbxEmail.Text = "author@zoro.com";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(50, 155);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 17);
            this.label3.TabIndex = 35;
            this.label3.Text = "Description:";
            // 
            // tbxDescri
            // 
            this.tbxDescri.Location = new System.Drawing.Point(136, 152);
            this.tbxDescri.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tbxDescri.Name = "tbxDescri";
            this.tbxDescri.Size = new System.Drawing.Size(442, 23);
            this.tbxDescri.TabIndex = 34;
            this.tbxDescri.Text = "None";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(34, 55);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 17);
            this.label2.TabIndex = 33;
            this.label2.Text = "Contract Hash:";
            // 
            // tbxContractHash
            // 
            this.tbxContractHash.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.tbxContractHash.Location = new System.Drawing.Point(136, 52);
            this.tbxContractHash.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tbxContractHash.Name = "tbxContractHash";
            this.tbxContractHash.ReadOnly = true;
            this.tbxContractHash.Size = new System.Drawing.Size(442, 23);
            this.tbxContractHash.TabIndex = 32;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(44, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 17);
            this.label1.TabIndex = 31;
            this.label1.Text = "Contract File:";
            // 
            // tbxContractPath
            // 
            this.tbxContractPath.Location = new System.Drawing.Point(136, 17);
            this.tbxContractPath.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tbxContractPath.Name = "tbxContractPath";
            this.tbxContractPath.Size = new System.Drawing.Size(346, 23);
            this.tbxContractPath.TabIndex = 30;
            // 
            // cbxNeedNep4
            // 
            this.cbxNeedNep4.AutoSize = true;
            this.cbxNeedNep4.Location = new System.Drawing.Point(27, 225);
            this.cbxNeedNep4.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cbxNeedNep4.Name = "cbxNeedNep4";
            this.cbxNeedNep4.Size = new System.Drawing.Size(101, 21);
            this.cbxNeedNep4.TabIndex = 29;
            this.cbxNeedNep4.Text = "Dynamic Call";
            this.cbxNeedNep4.UseVisualStyleBackColor = true;
            // 
            // tbxResult
            // 
            this.tbxResult.AcceptsReturn = true;
            this.tbxResult.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.tbxResult.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tbxResult.Location = new System.Drawing.Point(24, 281);
            this.tbxResult.Multiline = true;
            this.tbxResult.Name = "tbxResult";
            this.tbxResult.ReadOnly = true;
            this.tbxResult.Size = new System.Drawing.Size(554, 53);
            this.tbxResult.TabIndex = 56;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "contract.avm";
            this.openFileDialog1.Filter = "ContractFile(*.avm)|*.avm";
            // 
            // PublishContractFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(609, 360);
            this.Controls.Add(this.tbxResult);
            this.Controls.Add(this.label25);
            this.Controls.Add(this.btnLoadContract);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.tbxParameterType);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.tbxReturnType);
            this.Controls.Add(this.btnPublish);
            this.Controls.Add(this.lblBcpFee);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.cbxNeedStorge);
            this.Controls.Add(this.cbxNeedCharge);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.tbxContractName);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.tbxVersion);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.tbxAuthor);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tbxEmail);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tbxDescri);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbxContractHash);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbxContractPath);
            this.Controls.Add(this.cbxNeedNep4);
            this.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "PublishContractFrm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Publish Contract";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.Button btnLoadContract;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox tbxParameterType;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox tbxReturnType;
        private System.Windows.Forms.Button btnPublish;
        private System.Windows.Forms.Label lblBcpFee;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.CheckBox cbxNeedStorge;
        private System.Windows.Forms.CheckBox cbxNeedCharge;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox tbxContractName;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tbxVersion;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tbxAuthor;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbxEmail;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbxDescri;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbxContractHash;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbxContractPath;
        private System.Windows.Forms.CheckBox cbxNeedNep4;
        private System.Windows.Forms.TextBox tbxResult;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
    }
}