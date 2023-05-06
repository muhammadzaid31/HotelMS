namespace HotelMS
{
    partial class AdminHome
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
            this.btnLogOut = new System.Windows.Forms.Button();
            this.btnRooms = new System.Windows.Forms.Button();
            this.btnReceptionists = new System.Windows.Forms.Button();
            this.btnManagers = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnLogOut
            // 
            this.btnLogOut.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnLogOut.BackColor = System.Drawing.Color.LightSteelBlue;
            this.btnLogOut.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogOut.Location = new System.Drawing.Point(422, 221);
            this.btnLogOut.Name = "btnLogOut";
            this.btnLogOut.Size = new System.Drawing.Size(282, 149);
            this.btnLogOut.TabIndex = 0;
            this.btnLogOut.Text = "SIGN OUT";
            this.btnLogOut.UseVisualStyleBackColor = false;
            this.btnLogOut.Click += new System.EventHandler(this.btnLogOut_Click);
            // 
            // btnRooms
            // 
            this.btnRooms.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnRooms.BackColor = System.Drawing.Color.Plum;
            this.btnRooms.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRooms.Location = new System.Drawing.Point(145, 221);
            this.btnRooms.Name = "btnRooms";
            this.btnRooms.Size = new System.Drawing.Size(282, 149);
            this.btnRooms.TabIndex = 1;
            this.btnRooms.Text = "ROOMS";
            this.btnRooms.UseVisualStyleBackColor = false;
            this.btnRooms.Click += new System.EventHandler(this.btnRooms_Click);
            // 
            // btnReceptionists
            // 
            this.btnReceptionists.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnReceptionists.BackColor = System.Drawing.Color.LightSteelBlue;
            this.btnReceptionists.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReceptionists.Location = new System.Drawing.Point(145, 76);
            this.btnReceptionists.Name = "btnReceptionists";
            this.btnReceptionists.Size = new System.Drawing.Size(282, 149);
            this.btnReceptionists.TabIndex = 2;
            this.btnReceptionists.Text = "RECEPTIONISTS";
            this.btnReceptionists.UseVisualStyleBackColor = false;
            this.btnReceptionists.Click += new System.EventHandler(this.btnReceptionists_Click);
            // 
            // btnManagers
            // 
            this.btnManagers.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnManagers.BackColor = System.Drawing.Color.Plum;
            this.btnManagers.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnManagers.Location = new System.Drawing.Point(422, 76);
            this.btnManagers.Name = "btnManagers";
            this.btnManagers.Size = new System.Drawing.Size(282, 149);
            this.btnManagers.TabIndex = 3;
            this.btnManagers.Text = "MANAGERS";
            this.btnManagers.UseVisualStyleBackColor = false;
            this.btnManagers.Click += new System.EventHandler(this.btnManagers_Click);
            // 
            // AdminHome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(824, 478);
            this.Controls.Add(this.btnManagers);
            this.Controls.Add(this.btnReceptionists);
            this.Controls.Add(this.btnRooms);
            this.Controls.Add(this.btnLogOut);
            this.Name = "AdminHome";
            this.Text = "AdminHome";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnLogOut;
        private System.Windows.Forms.Button btnRooms;
        private System.Windows.Forms.Button btnReceptionists;
        private System.Windows.Forms.Button btnManagers;
    }
}