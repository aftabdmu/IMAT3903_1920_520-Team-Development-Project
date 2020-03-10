namespace BackOffice
{
    partial class frmMenu
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
            this.akPharmacy = new System.Windows.Forms.Button();
            this.saOptician = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(504, 56);
            this.label1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(262, 36);
            this.label1.TabIndex = 0;
            this.label1.Text = "Team A Business";
            // 
            // akPharmacy
            // 
            this.akPharmacy.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.akPharmacy.Location = new System.Drawing.Point(194, 211);
            this.akPharmacy.Margin = new System.Windows.Forms.Padding(6);
            this.akPharmacy.Name = "akPharmacy";
            this.akPharmacy.Size = new System.Drawing.Size(292, 48);
            this.akPharmacy.TabIndex = 1;
            this.akPharmacy.Text = "AK Pharmacy";
            this.akPharmacy.UseVisualStyleBackColor = true;
            // 
            // saOptician
            // 
            this.saOptician.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.saOptician.Location = new System.Drawing.Point(573, 211);
            this.saOptician.Margin = new System.Windows.Forms.Padding(6);
            this.saOptician.Name = "saOptician";
            this.saOptician.Size = new System.Drawing.Size(294, 45);
            this.saOptician.TabIndex = 2;
            this.saOptician.Text = "SA Optician";
            this.saOptician.UseVisualStyleBackColor = true;
            // 
            // frmMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1600, 872);
            this.Controls.Add(this.saOptician);
            this.Controls.Add(this.akPharmacy);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "frmMenu";
            this.Text = "frmMenu";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button akPharmacy;
        private System.Windows.Forms.Button saOptician;
    }
}