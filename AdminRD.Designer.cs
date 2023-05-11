namespace HotelMS
{
    partial class AdminRD
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
            this.del = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtRid = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // del
            // 
            this.del.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.del.BackColor = System.Drawing.Color.LightSteelBlue;
            this.del.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.del.Location = new System.Drawing.Point(192, 161);
            this.del.Name = "del";
            this.del.Size = new System.Drawing.Size(155, 33);
            this.del.TabIndex = 8;
            this.del.Text = "Delete Receptionist";
            this.del.UseVisualStyleBackColor = false;
            this.del.Click += new System.EventHandler(this.del_Click);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(105, 100);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 24);
            this.label1.TabIndex = 7;
            this.label1.Text = "Enter rID:";
            // 
            // txtRid
            // 
            this.txtRid.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtRid.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRid.Location = new System.Drawing.Point(234, 100);
            this.txtRid.Name = "txtRid";
            this.txtRid.Size = new System.Drawing.Size(242, 26);
            this.txtRid.TabIndex = 6;
            // 
            // AdminRD
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(581, 295);
            this.Controls.Add(this.del);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtRid);
            this.Name = "AdminRD";
            this.Text = "FCB HotelMS";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button del;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtRid;
    }
}