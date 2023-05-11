namespace HotelMS
{
    partial class AdminMVa
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
            this.Managers = new System.Windows.Forms.DataGridView();
            this.mID = new System.Windows.Forms.DataGridViewButtonColumn();
            this.name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DoB = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gender = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.phone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.email = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.Managers)).BeginInit();
            this.SuspendLayout();
            // 
            // Managers
            // 
            this.Managers.AllowUserToDeleteRows = false;
            this.Managers.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Managers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Managers.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.mID,
            this.name,
            this.DoB,
            this.gender,
            this.phone,
            this.email,
            this.ID});
            this.Managers.Location = new System.Drawing.Point(32, 65);
            this.Managers.Name = "Managers";
            this.Managers.ReadOnly = true;
            this.Managers.Size = new System.Drawing.Size(737, 320);
            this.Managers.TabIndex = 1;
            this.Managers.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Managers_CellContentClick);
            // 
            // mID
            // 
            this.mID.HeaderText = "mID";
            this.mID.Name = "mID";
            this.mID.ReadOnly = true;
            this.mID.Resizable = System.Windows.Forms.DataGridViewTriState.True;
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
            // ID
            // 
            this.ID.HeaderText = "ID";
            this.ID.Name = "ID";
            this.ID.ReadOnly = true;
            // 
            // AdminMVa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Managers);
            this.Name = "AdminMVa";
            this.Text = "FCB HotelMS";
            this.Load += new System.EventHandler(this.AdminMVa_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Managers)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView Managers;
        private System.Windows.Forms.DataGridViewButtonColumn mID;
        private System.Windows.Forms.DataGridViewTextBoxColumn name;
        private System.Windows.Forms.DataGridViewTextBoxColumn DoB;
        private System.Windows.Forms.DataGridViewTextBoxColumn gender;
        private System.Windows.Forms.DataGridViewTextBoxColumn phone;
        private System.Windows.Forms.DataGridViewTextBoxColumn email;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
    }
}