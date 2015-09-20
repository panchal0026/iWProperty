namespace iWProperty
{
    partial class Flats
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
            this.lblBuildingName = new System.Windows.Forms.Label();
            this.pnlFlatForm = new System.Windows.Forms.Panel();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnAddFlat = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.txtPrice = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtFlatNo = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnPnlAddFlat = new System.Windows.Forms.Button();
            this.pnlFlatGrid = new System.Windows.Forms.Panel();
            this.FlatGrid = new System.Windows.Forms.DataGridView();
            this.pnlFlatForm.SuspendLayout();
            this.pnlFlatGrid.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.FlatGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // lblBuildingName
            // 
            this.lblBuildingName.AutoSize = true;
            this.lblBuildingName.Location = new System.Drawing.Point(69, 4);
            this.lblBuildingName.Name = "lblBuildingName";
            this.lblBuildingName.Size = new System.Drawing.Size(0, 13);
            this.lblBuildingName.TabIndex = 0;
            // 
            // pnlFlatForm
            // 
            this.pnlFlatForm.Controls.Add(this.btnCancel);
            this.pnlFlatForm.Controls.Add(this.btnAddFlat);
            this.pnlFlatForm.Controls.Add(this.btnUpdate);
            this.pnlFlatForm.Controls.Add(this.txtPrice);
            this.pnlFlatForm.Controls.Add(this.label2);
            this.pnlFlatForm.Controls.Add(this.txtFlatNo);
            this.pnlFlatForm.Controls.Add(this.label1);
            this.pnlFlatForm.Location = new System.Drawing.Point(162, 43);
            this.pnlFlatForm.Name = "pnlFlatForm";
            this.pnlFlatForm.Size = new System.Drawing.Size(858, 392);
            this.pnlFlatForm.TabIndex = 1;
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(196, 258);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(76, 34);
            this.btnCancel.TabIndex = 6;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnAddFlat
            // 
            this.btnAddFlat.Location = new System.Drawing.Point(312, 258);
            this.btnAddFlat.Name = "btnAddFlat";
            this.btnAddFlat.Size = new System.Drawing.Size(81, 34);
            this.btnAddFlat.TabIndex = 2;
            this.btnAddFlat.Text = "Add";
            this.btnAddFlat.UseVisualStyleBackColor = true;
            this.btnAddFlat.Click += new System.EventHandler(this.btnAddFlat_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(312, 258);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(81, 35);
            this.btnUpdate.TabIndex = 5;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Visible = false;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // txtPrice
            // 
            this.txtPrice.Location = new System.Drawing.Point(297, 95);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.Size = new System.Drawing.Size(144, 20);
            this.txtPrice.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(196, 98);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(31, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Price";
            // 
            // txtFlatNo
            // 
            this.txtFlatNo.Location = new System.Drawing.Point(297, 47);
            this.txtFlatNo.Name = "txtFlatNo";
            this.txtFlatNo.Size = new System.Drawing.Size(144, 20);
            this.txtFlatNo.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(193, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Flat No";
            // 
            // btnPnlAddFlat
            // 
            this.btnPnlAddFlat.Location = new System.Drawing.Point(1018, 4);
            this.btnPnlAddFlat.Name = "btnPnlAddFlat";
            this.btnPnlAddFlat.Size = new System.Drawing.Size(142, 33);
            this.btnPnlAddFlat.TabIndex = 2;
            this.btnPnlAddFlat.Text = "Add Flat";
            this.btnPnlAddFlat.UseVisualStyleBackColor = true;
            this.btnPnlAddFlat.Click += new System.EventHandler(this.btnPnlAddFlat_Click);
            // 
            // pnlFlatGrid
            // 
            this.pnlFlatGrid.Controls.Add(this.FlatGrid);
            this.pnlFlatGrid.Location = new System.Drawing.Point(72, 43);
            this.pnlFlatGrid.Name = "pnlFlatGrid";
            this.pnlFlatGrid.Size = new System.Drawing.Size(1000, 413);
            this.pnlFlatGrid.TabIndex = 3;
            // 
            // FlatGrid
            // 
            this.FlatGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.FlatGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.FlatGrid.Location = new System.Drawing.Point(0, 0);
            this.FlatGrid.Name = "FlatGrid";
            this.FlatGrid.Size = new System.Drawing.Size(1000, 413);
            this.FlatGrid.TabIndex = 0;
            this.FlatGrid.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.FlatGrid_CellContentClick);
            // 
            // Flats
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1172, 468);
            this.Controls.Add(this.pnlFlatGrid);
            this.Controls.Add(this.btnPnlAddFlat);
            this.Controls.Add(this.pnlFlatForm);
            this.Controls.Add(this.lblBuildingName);
            this.Name = "Flats";
            this.Text = "Flats";
            this.pnlFlatForm.ResumeLayout(false);
            this.pnlFlatForm.PerformLayout();
            this.pnlFlatGrid.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.FlatGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblBuildingName;
        private System.Windows.Forms.Panel pnlFlatForm;
        private System.Windows.Forms.Button btnPnlAddFlat;
        private System.Windows.Forms.TextBox txtFlatNo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnAddFlat;
        private System.Windows.Forms.TextBox txtPrice;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Panel pnlFlatGrid;
        private System.Windows.Forms.DataGridView FlatGrid;
    }
}