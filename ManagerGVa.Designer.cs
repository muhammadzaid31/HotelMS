namespace HotelMS
{
    partial class ManagerGVa
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
            this.Guests = new System.Windows.Forms.DataGridView();
            this.gID = new System.Windows.Forms.DataGridViewButtonColumn();
            this.name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DoB = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gender = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.phone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.email = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.Guests)).BeginInit();
            this.SuspendLayout();
            // 
            // Guests
            // 
            this.Guests.AllowUserToDeleteRows = false;
            this.Guests.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Guests.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Guests.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.gID,
            this.name,
            this.DoB,
            this.gender,
            this.phone,
            this.email});
            this.Guests.Location = new System.Drawing.Point(19, 33);
            this.Guests.Name = "Guests";
            this.Guests.ReadOnly = true;
            this.Guests.Size = new System.Drawing.Size(644, 339);
            this.Guests.TabIndex = 2;
            this.Guests.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Guests_CellContentClick);
            // 
            // gID
            // 
            this.gID.HeaderText = "gID";
            this.gID.Name = "gID";
            this.gID.ReadOnly = true;
            this.gID.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // name
            // 
            this.name.HeaderText = "Name";
            this.name.Name = "name";
            this.name.ReadOnly = true;
            // 
            // DoB
            // 
            this.DoB.HeaderText = "Date of birth";
            this.DoB.Name = "DoB";
            this.DoB.ReadOnly = true;
            // 
            // gender
            // 
            this.gender.HeaderText = "Gender";
            this.gender.Name = "gender";
            this.gender.ReadOnly = true;
            // 
            // phone
            // 
            this.phone.HeaderText = "Phone";
            this.phone.Name = "phone";
            this.phone.ReadOnly = true;
            // 
            // email
            // 
            this.email.HeaderText = "Email";
            this.email.Name = "email";
            this.email.ReadOnly = true;
            // 
            // ManagerGVa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(695, 408);
            this.Controls.Add(this.Guests);
            this.Name = "ManagerGVa";
            this.Text = "ManagerGVa";
            this.Load += new System.EventHandler(this.ManagerGVa_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Guests)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView Guests;
        private System.Windows.Forms.DataGridViewButtonColumn gID;
        private System.Windows.Forms.DataGridViewTextBoxColumn name;
        private System.Windows.Forms.DataGridViewTextBoxColumn DoB;
        private System.Windows.Forms.DataGridViewTextBoxColumn gender;
        private System.Windows.Forms.DataGridViewTextBoxColumn phone;
        private System.Windows.Forms.DataGridViewTextBoxColumn email;
    }
}