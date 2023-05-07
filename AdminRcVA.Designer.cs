﻿namespace HotelMS
{
    public partial class AdminRcVA
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        public System.ComponentModel.IContainer components = null;

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
        public void InitializeComponent()
        {
            this.Receptionists = new System.Windows.Forms.DataGridView();
            this.rcID = new System.Windows.Forms.DataGridViewButtonColumn();
            this.name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DoB = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gender = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.phone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.email = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.Receptionists)).BeginInit();
            this.SuspendLayout();
            // 
            // Receptionists
            // 
            this.Receptionists.AllowUserToDeleteRows = false;
            this.Receptionists.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Receptionists.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Receptionists.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.rcID,
            this.name,
            this.DoB,
            this.gender,
            this.phone,
            this.email,
            this.ID});
            this.Receptionists.Location = new System.Drawing.Point(40, 76);
            this.Receptionists.Name = "Receptionists";
            this.Receptionists.ReadOnly = true;
            this.Receptionists.Size = new System.Drawing.Size(737, 257);
            this.Receptionists.TabIndex = 0;
            this.Receptionists.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Receptionists_CellContentClick);
            this.Receptionists.Layout += new System.Windows.Forms.LayoutEventHandler(this.Receptionists_Layout);
            // 
            // rcID
            // 
            this.rcID.HeaderText = "rcID";
            this.rcID.Name = "rcID";
            this.rcID.ReadOnly = true;
            this.rcID.Resizable = System.Windows.Forms.DataGridViewTriState.True;
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
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(263, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(298, 31);
            this.label1.TabIndex = 2;
            this.label1.Text = "Current Receptionists";
            // 
            // AdminRcVA
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 616);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Receptionists);
            this.Name = "AdminRcVA";
            this.Text = "AdminRcVA";
            this.Load += new System.EventHandler(this.AdminRcVA_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Receptionists)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView Receptionists;
        private System.Windows.Forms.DataGridViewButtonColumn rcID;
        private System.Windows.Forms.DataGridViewTextBoxColumn name;
        private System.Windows.Forms.DataGridViewTextBoxColumn DoB;
        private System.Windows.Forms.DataGridViewTextBoxColumn gender;
        private System.Windows.Forms.DataGridViewTextBoxColumn phone;
        private System.Windows.Forms.DataGridViewTextBoxColumn email;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.Label label1;
    }
}