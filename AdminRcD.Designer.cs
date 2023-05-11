namespace HotelMS
{
    partial class AdminRcD
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
            this.txtRcid = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.del = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtRcid
            // 
            this.txtRcid.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtRcid.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRcid.Location = new System.Drawing.Point(202, 83);
            this.txtRcid.Name = "txtRcid";
            this.txtRcid.Size = new System.Drawing.Size(242, 26);
            this.txtRcid.TabIndex = 0;
            this.txtRcid.TextChanged += new System.EventHandler(this.txtRcid_TextChanged);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(73, 83);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(109, 24);
            this.label1.TabIndex = 1;
            this.label1.Text = "Enter rcID:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // del
            // 
            this.del.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.del.BackColor = System.Drawing.Color.LightSteelBlue;
            this.del.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.del.Location = new System.Drawing.Point(160, 144);
            this.del.Name = "del";
            this.del.Size = new System.Drawing.Size(155, 33);
            this.del.TabIndex = 2;
            this.del.Text = "Delete Receptionist";
            this.del.UseVisualStyleBackColor = false;
            this.del.Click += new System.EventHandler(this.del_Click);
            // 
            // AdminRcD
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(499, 214);
            this.Controls.Add(this.del);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtRcid);
            this.Name = "AdminRcD";
            this.Text = "FCB HotelMS";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtRcid;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button del;
    }
}