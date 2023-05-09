namespace HotelMS
{
    partial class ReceptionistHome
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
            this.btnGuestProfile = new System.Windows.Forms.Button();
            this.btnAvailability = new System.Windows.Forms.Button();
            this.btnRooms = new System.Windows.Forms.Button();
            this.btnLogOut = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pfp1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pfp1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnGuestProfile
            // 
            this.btnGuestProfile.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnGuestProfile.BackColor = System.Drawing.Color.Plum;
            this.btnGuestProfile.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuestProfile.Location = new System.Drawing.Point(398, 291);
            this.btnGuestProfile.Name = "btnGuestProfile";
            this.btnGuestProfile.Size = new System.Drawing.Size(282, 149);
            this.btnGuestProfile.TabIndex = 14;
            this.btnGuestProfile.Text = "CREATE GUEST PROFILE";
            this.btnGuestProfile.UseVisualStyleBackColor = false;
            this.btnGuestProfile.Click += new System.EventHandler(this.btnGuestProfile_Click);
            // 
            // btnAvailability
            // 
            this.btnAvailability.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnAvailability.BackColor = System.Drawing.Color.LightSteelBlue;
            this.btnAvailability.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAvailability.Location = new System.Drawing.Point(121, 291);
            this.btnAvailability.Name = "btnAvailability";
            this.btnAvailability.Size = new System.Drawing.Size(282, 149);
            this.btnAvailability.TabIndex = 13;
            this.btnAvailability.Text = "CHECK AVAILABILITY";
            this.btnAvailability.UseVisualStyleBackColor = false;
            this.btnAvailability.Click += new System.EventHandler(this.btnAvailability_Click);
            // 
            // btnRooms
            // 
            this.btnRooms.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnRooms.BackColor = System.Drawing.Color.Plum;
            this.btnRooms.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRooms.Location = new System.Drawing.Point(121, 436);
            this.btnRooms.Name = "btnRooms";
            this.btnRooms.Size = new System.Drawing.Size(282, 149);
            this.btnRooms.TabIndex = 12;
            this.btnRooms.Text = "VIEW BOOKING DETAILS";
            this.btnRooms.UseVisualStyleBackColor = false;
            this.btnRooms.Click += new System.EventHandler(this.btnRooms_Click);
            // 
            // btnLogOut
            // 
            this.btnLogOut.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnLogOut.BackColor = System.Drawing.Color.LightSteelBlue;
            this.btnLogOut.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogOut.Location = new System.Drawing.Point(398, 436);
            this.btnLogOut.Name = "btnLogOut";
            this.btnLogOut.Size = new System.Drawing.Size(282, 149);
            this.btnLogOut.TabIndex = 11;
            this.btnLogOut.Text = "SIGN OUT";
            this.btnLogOut.UseVisualStyleBackColor = false;
            this.btnLogOut.Click += new System.EventHandler(this.btnLogOut_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(285, 251);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(108, 25);
            this.label2.TabIndex = 10;
            this.label2.Text = "Welcome";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(415, 251);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 25);
            this.label1.TabIndex = 9;
            // 
            // pfp1
            // 
            this.pfp1.Location = new System.Drawing.Point(270, 3);
            this.pfp1.Name = "pfp1";
            this.pfp1.Size = new System.Drawing.Size(259, 236);
            this.pfp1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pfp1.TabIndex = 8;
            this.pfp1.TabStop = false;
            // 
            // ReceptionistHome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 616);
            this.Controls.Add(this.btnGuestProfile);
            this.Controls.Add(this.btnAvailability);
            this.Controls.Add(this.btnRooms);
            this.Controls.Add(this.btnLogOut);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pfp1);
            this.Name = "ReceptionistHome";
            this.Text = "ReceptionistHome";
            this.Load += new System.EventHandler(this.ReceptionistHome_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pfp1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnGuestProfile;
        private System.Windows.Forms.Button btnAvailability;
        private System.Windows.Forms.Button btnRooms;
        private System.Windows.Forms.Button btnLogOut;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pfp1;
    }
}