namespace iWProperty
{
    partial class Home
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
            this.btnManageLocation = new System.Windows.Forms.Button();
            this.btnAvailableFlats = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnManageLocation
            // 
            this.btnManageLocation.Location = new System.Drawing.Point(61, 158);
            this.btnManageLocation.Name = "btnManageLocation";
            this.btnManageLocation.Size = new System.Drawing.Size(162, 68);
            this.btnManageLocation.TabIndex = 0;
            this.btnManageLocation.Text = "Manage Location";
            this.btnManageLocation.UseVisualStyleBackColor = true;
            this.btnManageLocation.Click += new System.EventHandler(this.btnManageLocation_Click);
            // 
            // btnAvailableFlats
            // 
            this.btnAvailableFlats.Location = new System.Drawing.Point(359, 158);
            this.btnAvailableFlats.Name = "btnAvailableFlats";
            this.btnAvailableFlats.Size = new System.Drawing.Size(162, 68);
            this.btnAvailableFlats.TabIndex = 1;
            this.btnAvailableFlats.Text = "Available Flats";
            this.btnAvailableFlats.UseVisualStyleBackColor = true;
            this.btnAvailableFlats.Click += new System.EventHandler(this.btnAvailableFlats_Click);
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(664, 415);
            this.Controls.Add(this.btnAvailableFlats);
            this.Controls.Add(this.btnManageLocation);
            this.Name = "Home";
            this.Text = "Home";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnManageLocation;
        private System.Windows.Forms.Button btnAvailableFlats;
    }
}