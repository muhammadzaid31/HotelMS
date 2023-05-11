namespace HotelMS
{
    partial class AdminRA
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
            System.Windows.Forms.Button button2;
            this.addReceptionist = new System.Windows.Forms.GroupBox();
            this.cB1 = new System.Windows.Forms.ComboBox();
            this.txtrStatus = new System.Windows.Forms.TextBox();
            this.txtrPrice = new System.Windows.Forms.TextBox();
            this.txtrID = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            button2 = new System.Windows.Forms.Button();
            this.addReceptionist.SuspendLayout();
            this.SuspendLayout();
            // 
            // button2
            // 
            button2.Anchor = System.Windows.Forms.AnchorStyles.None;
            button2.BackColor = System.Drawing.Color.LightBlue;
            button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            button2.ForeColor = System.Drawing.SystemColors.ControlText;
            button2.Location = new System.Drawing.Point(230, 350);
            button2.Name = "button2";
            button2.Size = new System.Drawing.Size(305, 41);
            button2.TabIndex = 8;
            button2.Text = "Add Room";
            button2.UseVisualStyleBackColor = false;
            button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // addReceptionist
            // 
            this.addReceptionist.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.addReceptionist.Controls.Add(this.cB1);
            this.addReceptionist.Controls.Add(this.txtrStatus);
            this.addReceptionist.Controls.Add(this.txtrPrice);
            this.addReceptionist.Controls.Add(this.txtrID);
            this.addReceptionist.Controls.Add(this.label5);
            this.addReceptionist.Controls.Add(this.label4);
            this.addReceptionist.Controls.Add(this.label2);
            this.addReceptionist.Controls.Add(this.label1);
            this.addReceptionist.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addReceptionist.Location = new System.Drawing.Point(104, 34);
            this.addReceptionist.Name = "addReceptionist";
            this.addReceptionist.Size = new System.Drawing.Size(582, 310);
            this.addReceptionist.TabIndex = 6;
            this.addReceptionist.TabStop = false;
            this.addReceptionist.Text = "Details";
            // 
            // cB1
            // 
            this.cB1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cB1.FormattingEnabled = true;
            this.cB1.Items.AddRange(new object[] {
            "junior",
            "two",
            "three",
            "royal"});
            this.cB1.Location = new System.Drawing.Point(264, 113);
            this.cB1.Name = "cB1";
            this.cB1.Size = new System.Drawing.Size(285, 32);
            this.cB1.TabIndex = 13;
            // 
            // txtrStatus
            // 
            this.txtrStatus.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtrStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtrStatus.Location = new System.Drawing.Point(264, 238);
            this.txtrStatus.Name = "txtrStatus";
            this.txtrStatus.Size = new System.Drawing.Size(285, 26);
            this.txtrStatus.TabIndex = 12;
            // 
            // txtrPrice
            // 
            this.txtrPrice.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtrPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtrPrice.Location = new System.Drawing.Point(264, 171);
            this.txtrPrice.Name = "txtrPrice";
            this.txtrPrice.Size = new System.Drawing.Size(285, 26);
            this.txtrPrice.TabIndex = 9;
            this.txtrPrice.TextChanged += new System.EventHandler(this.cB1_SelectedValueChanged);
            // 
            // txtrID
            // 
            this.txtrID.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtrID.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtrID.Location = new System.Drawing.Point(264, 45);
            this.txtrID.Name = "txtrID";
            this.txtrID.Size = new System.Drawing.Size(285, 26);
            this.txtrID.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(47, 244);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(168, 20);
            this.label5.TabIndex = 4;
            this.label5.Text = "Enter Room Status:";
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label4.Location = new System.Drawing.Point(47, 177);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(160, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "Enter Room Price: ";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(47, 113);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(153, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Enter Room Type:";
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(47, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Enter rID:";
            // 
            // AdminRA
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 410);
            this.Controls.Add(this.addReceptionist);
            this.Controls.Add(button2);
            this.Name = "AdminRA";
            this.Text = "FCB HotelMS";
            this.addReceptionist.ResumeLayout(false);
            this.addReceptionist.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox addReceptionist;
        private System.Windows.Forms.TextBox txtrStatus;
        private System.Windows.Forms.TextBox txtrPrice;
        private System.Windows.Forms.TextBox txtrID;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cB1;
    }
}