namespace HotelMS
{
    partial class ManagerHome
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
            this.pfp1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnManagers = new System.Windows.Forms.Button();
            this.btnReceptionists = new System.Windows.Forms.Button();
            this.btnRooms = new System.Windows.Forms.Button();
            this.btnLogOut = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pfp1)).BeginInit();
            this.SuspendLayout();
            // 
            // pfp1
            // 
            this.pfp1.Location = new System.Drawing.Point(306, 12);
            this.pfp1.Name = "pfp1";
            this.pfp1.Size = new System.Drawing.Size(222, 202);
            this.pfp1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pfp1.TabIndex = 0;
            this.pfp1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(452, 231);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 25);
            this.label1.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(301, 231);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(108, 25);
            this.label2.TabIndex = 2;
            this.label2.Text = "Welcome";
            // 
            // btnManagers
            // 
            this.btnManagers.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnManagers.BackColor = System.Drawing.Color.Plum;
            this.btnManagers.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnManagers.Location = new System.Drawing.Point(414, 271);
            this.btnManagers.Name = "btnManagers";
            this.btnManagers.Size = new System.Drawing.Size(282, 149);
            this.btnManagers.TabIndex = 7;
            this.btnManagers.Text = "GUESTS";
            this.btnManagers.UseVisualStyleBackColor = false;
            this.btnManagers.Click += new System.EventHandler(this.btnManagers_Click);
            // 
            // btnReceptionists
            // 
            this.btnReceptionists.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnReceptionists.BackColor = System.Drawing.Color.LightSteelBlue;
            this.btnReceptionists.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReceptionists.Location = new System.Drawing.Point(137, 271);
            this.btnReceptionists.Name = "btnReceptionists";
            this.btnReceptionists.Size = new System.Drawing.Size(282, 149);
            this.btnReceptionists.TabIndex = 6;
            this.btnReceptionists.Text = "RECEPTIONISTS";
            this.btnReceptionists.UseVisualStyleBackColor = false;
            this.btnReceptionists.Click += new System.EventHandler(this.btnReceptionists_Click);
            // 
            // btnRooms
            // 
            this.btnRooms.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnRooms.BackColor = System.Drawing.Color.Plum;
            this.btnRooms.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRooms.Location = new System.Drawing.Point(137, 416);
            this.btnRooms.Name = "btnRooms";
            this.btnRooms.Size = new System.Drawing.Size(282, 149);
            this.btnRooms.TabIndex = 5;
            this.btnRooms.Text = "VIEW BOOKING DETAILS";
            this.btnRooms.UseVisualStyleBackColor = false;
            this.btnRooms.Click += new System.EventHandler(this.btnRooms_Click);
            // 
            // btnLogOut
            // 
            this.btnLogOut.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnLogOut.BackColor = System.Drawing.Color.LightSteelBlue;
            this.btnLogOut.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogOut.Location = new System.Drawing.Point(414, 416);
            this.btnLogOut.Name = "btnLogOut";
            this.btnLogOut.Size = new System.Drawing.Size(282, 149);
            this.btnLogOut.TabIndex = 4;
            this.btnLogOut.Text = "SIGN OUT";
            this.btnLogOut.UseVisualStyleBackColor = false;
            this.btnLogOut.Click += new System.EventHandler(this.btnLogOut_Click);
            // 
            // ManagerHome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 586);
            this.Controls.Add(this.btnManagers);
            this.Controls.Add(this.btnReceptionists);
            this.Controls.Add(this.btnRooms);
            this.Controls.Add(this.btnLogOut);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pfp1);
            this.Name = "ManagerHome";
            this.Text = "ManagerHome";
            this.Load += new System.EventHandler(this.ManagerHome_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pfp1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pfp1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnManagers;
        private System.Windows.Forms.Button btnReceptionists;
        private System.Windows.Forms.Button btnRooms;
        private System.Windows.Forms.Button btnLogOut;
    }
}