namespace HotelMS
{
    partial class CheckIn
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
            this.btnExistingGuest = new System.Windows.Forms.Button();
            this.btnCreateGuest = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnExistingGuest
            // 
            this.btnExistingGuest.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnExistingGuest.BackColor = System.Drawing.Color.Plum;
            this.btnExistingGuest.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExistingGuest.Location = new System.Drawing.Point(178, 217);
            this.btnExistingGuest.Name = "btnExistingGuest";
            this.btnExistingGuest.Size = new System.Drawing.Size(282, 149);
            this.btnExistingGuest.TabIndex = 5;
            this.btnExistingGuest.Text = "EXISTING GUEST";
            this.btnExistingGuest.UseVisualStyleBackColor = false;
            this.btnExistingGuest.Click += new System.EventHandler(this.btnExistingGuest_Click);
            // 
            // btnCreateGuest
            // 
            this.btnCreateGuest.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnCreateGuest.BackColor = System.Drawing.Color.LightSteelBlue;
            this.btnCreateGuest.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCreateGuest.Location = new System.Drawing.Point(178, 48);
            this.btnCreateGuest.Name = "btnCreateGuest";
            this.btnCreateGuest.Size = new System.Drawing.Size(282, 149);
            this.btnCreateGuest.TabIndex = 4;
            this.btnCreateGuest.Text = "NEW GUEST";
            this.btnCreateGuest.UseVisualStyleBackColor = false;
            this.btnCreateGuest.Click += new System.EventHandler(this.btnCreateGuest_Click);
            // 
            // CheckIn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(636, 444);
            this.Controls.Add(this.btnExistingGuest);
            this.Controls.Add(this.btnCreateGuest);
            this.Name = "CheckIn";
            this.Text = "CheckIn";
            this.Load += new System.EventHandler(this.CheckIn_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnExistingGuest;
        private System.Windows.Forms.Button btnCreateGuest;
    }
}