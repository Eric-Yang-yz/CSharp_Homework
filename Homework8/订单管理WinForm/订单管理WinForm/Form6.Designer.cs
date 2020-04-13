namespace 订单管理WinForm
{
    partial class Form6
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
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnConfirm = new System.Windows.Forms.Button();
            this.lblUpdateItemInfo = new System.Windows.Forms.Label();
            this.addOrderGroupBox = new System.Windows.Forms.GroupBox();
            this.txtCount = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtSinglePrice = new System.Windows.Forms.TextBox();
            this.txtItemName = new System.Windows.Forms.TextBox();
            this.txtItemNumber = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblAlert = new System.Windows.Forms.Label();
            this.txtOrderNumber = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.addOrderGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnCancel
            // 
            this.btnCancel.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnCancel.Font = new System.Drawing.Font("宋体", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnCancel.Location = new System.Drawing.Point(489, 371);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(100, 50);
            this.btnCancel.TabIndex = 11;
            this.btnCancel.Text = "取消";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnConfirm
            // 
            this.btnConfirm.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnConfirm.Font = new System.Drawing.Font("宋体", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnConfirm.Location = new System.Drawing.Point(211, 371);
            this.btnConfirm.Name = "btnConfirm";
            this.btnConfirm.Size = new System.Drawing.Size(100, 50);
            this.btnConfirm.TabIndex = 10;
            this.btnConfirm.Text = "确认";
            this.btnConfirm.UseVisualStyleBackColor = true;
            this.btnConfirm.Click += new System.EventHandler(this.btnConfirm_Click);
            // 
            // lblUpdateItemInfo
            // 
            this.lblUpdateItemInfo.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblUpdateItemInfo.AutoSize = true;
            this.lblUpdateItemInfo.Font = new System.Drawing.Font("宋体", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblUpdateItemInfo.Location = new System.Drawing.Point(312, 29);
            this.lblUpdateItemInfo.Name = "lblUpdateItemInfo";
            this.lblUpdateItemInfo.Size = new System.Drawing.Size(177, 40);
            this.lblUpdateItemInfo.TabIndex = 9;
            this.lblUpdateItemInfo.Text = "修改明细";
            // 
            // addOrderGroupBox
            // 
            this.addOrderGroupBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.addOrderGroupBox.Controls.Add(this.txtCount);
            this.addOrderGroupBox.Controls.Add(this.label5);
            this.addOrderGroupBox.Controls.Add(this.txtSinglePrice);
            this.addOrderGroupBox.Controls.Add(this.txtItemName);
            this.addOrderGroupBox.Controls.Add(this.txtItemNumber);
            this.addOrderGroupBox.Controls.Add(this.label4);
            this.addOrderGroupBox.Controls.Add(this.label3);
            this.addOrderGroupBox.Controls.Add(this.label2);
            this.addOrderGroupBox.Controls.Add(this.lblAlert);
            this.addOrderGroupBox.Controls.Add(this.txtOrderNumber);
            this.addOrderGroupBox.Controls.Add(this.label1);
            this.addOrderGroupBox.Location = new System.Drawing.Point(211, 93);
            this.addOrderGroupBox.Name = "addOrderGroupBox";
            this.addOrderGroupBox.Size = new System.Drawing.Size(378, 272);
            this.addOrderGroupBox.TabIndex = 8;
            this.addOrderGroupBox.TabStop = false;
            this.addOrderGroupBox.Text = "详细信息";
            // 
            // txtCount
            // 
            this.txtCount.Location = new System.Drawing.Point(108, 195);
            this.txtCount.Name = "txtCount";
            this.txtCount.Size = new System.Drawing.Size(241, 25);
            this.txtCount.TabIndex = 14;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(27, 195);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(37, 15);
            this.label5.TabIndex = 13;
            this.label5.Text = "数量";
            // 
            // txtSinglePrice
            // 
            this.txtSinglePrice.Location = new System.Drawing.Point(108, 155);
            this.txtSinglePrice.Name = "txtSinglePrice";
            this.txtSinglePrice.Size = new System.Drawing.Size(241, 25);
            this.txtSinglePrice.TabIndex = 12;
            // 
            // txtItemName
            // 
            this.txtItemName.Location = new System.Drawing.Point(108, 115);
            this.txtItemName.Name = "txtItemName";
            this.txtItemName.Size = new System.Drawing.Size(241, 25);
            this.txtItemName.TabIndex = 11;
            // 
            // txtItemNumber
            // 
            this.txtItemNumber.Location = new System.Drawing.Point(108, 75);
            this.txtItemNumber.Name = "txtItemNumber";
            this.txtItemNumber.ReadOnly = true;
            this.txtItemNumber.Size = new System.Drawing.Size(241, 25);
            this.txtItemNumber.TabIndex = 10;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(27, 155);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(37, 15);
            this.label4.TabIndex = 9;
            this.label4.Text = "单价";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(27, 115);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 15);
            this.label3.TabIndex = 8;
            this.label3.Text = "商品名称";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(27, 75);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 15);
            this.label2.TabIndex = 7;
            this.label2.Text = "商品编号";
            // 
            // lblAlert
            // 
            this.lblAlert.AutoSize = true;
            this.lblAlert.ForeColor = System.Drawing.Color.Red;
            this.lblAlert.Location = new System.Drawing.Point(105, 243);
            this.lblAlert.Name = "lblAlert";
            this.lblAlert.Size = new System.Drawing.Size(0, 15);
            this.lblAlert.TabIndex = 6;
            // 
            // txtOrderNumber
            // 
            this.txtOrderNumber.Location = new System.Drawing.Point(108, 35);
            this.txtOrderNumber.Name = "txtOrderNumber";
            this.txtOrderNumber.ReadOnly = true;
            this.txtOrderNumber.Size = new System.Drawing.Size(241, 25);
            this.txtOrderNumber.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(27, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "订单号";
            // 
            // Form6
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnConfirm);
            this.Controls.Add(this.lblUpdateItemInfo);
            this.Controls.Add(this.addOrderGroupBox);
            this.Name = "Form6";
            this.Text = "Form6";
            this.addOrderGroupBox.ResumeLayout(false);
            this.addOrderGroupBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnConfirm;
        private System.Windows.Forms.Label lblUpdateItemInfo;
        private System.Windows.Forms.GroupBox addOrderGroupBox;
        private System.Windows.Forms.TextBox txtCount;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtSinglePrice;
        private System.Windows.Forms.TextBox txtItemName;
        private System.Windows.Forms.TextBox txtItemNumber;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblAlert;
        private System.Windows.Forms.TextBox txtOrderNumber;
        private System.Windows.Forms.Label label1;
    }
}