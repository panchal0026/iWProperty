namespace iWProperty
{
    partial class Sell_Flat
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtClientName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtContactNo = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtDownpayment = new System.Windows.Forms.TextBox();
            this.btnSell = new System.Windows.Forms.Button();
            this.lblLocationName = new System.Windows.Forms.Label();
            this.lblBuildingName = new System.Windows.Forms.Label();
            this.lblFlatNo = new System.Windows.Forms.Label();
            this.lblPrice = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(67, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Client Name";
            // 
            // txtClientName
            // 
            this.txtClientName.Location = new System.Drawing.Point(167, 31);
            this.txtClientName.Name = "txtClientName";
            this.txtClientName.Size = new System.Drawing.Size(151, 20);
            this.txtClientName.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(70, 85);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Contact No";
            // 
            // txtContactNo
            // 
            this.txtContactNo.Location = new System.Drawing.Point(167, 82);
            this.txtContactNo.Name = "txtContactNo";
            this.txtContactNo.Size = new System.Drawing.Size(151, 20);
            this.txtContactNo.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(70, 139);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Down Payment";
            // 
            // txtDownpayment
            // 
            this.txtDownpayment.Location = new System.Drawing.Point(167, 136);
            this.txtDownpayment.Name = "txtDownpayment";
            this.txtDownpayment.Size = new System.Drawing.Size(151, 20);
            this.txtDownpayment.TabIndex = 5;
            // 
            // btnSell
            // 
            this.btnSell.Location = new System.Drawing.Point(167, 312);
            this.btnSell.Name = "btnSell";
            this.btnSell.Size = new System.Drawing.Size(117, 48);
            this.btnSell.TabIndex = 6;
            this.btnSell.Text = "Sell";
            this.btnSell.UseVisualStyleBackColor = true;
            this.btnSell.Click += new System.EventHandler(this.btnSell_Click);
            // 
            // lblLocationName
            // 
            this.lblLocationName.AutoSize = true;
            this.lblLocationName.Location = new System.Drawing.Point(648, 33);
            this.lblLocationName.Name = "lblLocationName";
            this.lblLocationName.Size = new System.Drawing.Size(0, 13);
            this.lblLocationName.TabIndex = 7;
            // 
            // lblBuildingName
            // 
            this.lblBuildingName.AutoSize = true;
            this.lblBuildingName.Location = new System.Drawing.Point(640, 85);
            this.lblBuildingName.Name = "lblBuildingName";
            this.lblBuildingName.Size = new System.Drawing.Size(0, 13);
            this.lblBuildingName.TabIndex = 8;
            // 
            // lblFlatNo
            // 
            this.lblFlatNo.AutoSize = true;
            this.lblFlatNo.Location = new System.Drawing.Point(643, 152);
            this.lblFlatNo.Name = "lblFlatNo";
            this.lblFlatNo.Size = new System.Drawing.Size(0, 13);
            this.lblFlatNo.TabIndex = 9;
            // 
            // lblPrice
            // 
            this.lblPrice.AutoSize = true;
            this.lblPrice.Location = new System.Drawing.Point(675, 312);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(0, 13);
            this.lblPrice.TabIndex = 10;
            // 
            // Sell_Flat
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1109, 452);
            this.Controls.Add(this.lblPrice);
            this.Controls.Add(this.lblFlatNo);
            this.Controls.Add(this.lblBuildingName);
            this.Controls.Add(this.lblLocationName);
            this.Controls.Add(this.btnSell);
            this.Controls.Add(this.txtDownpayment);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtContactNo);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtClientName);
            this.Controls.Add(this.label1);
            this.Name = "Sell_Flat";
            this.Text = "Sell_Flat";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtClientName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtContactNo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtDownpayment;
        private System.Windows.Forms.Button btnSell;
        private System.Windows.Forms.Label lblLocationName;
        private System.Windows.Forms.Label lblBuildingName;
        private System.Windows.Forms.Label lblFlatNo;
        private System.Windows.Forms.Label lblPrice;
    }
}