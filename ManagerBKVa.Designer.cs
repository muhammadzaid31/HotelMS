namespace HotelMS
{
    partial class ManagerBKVa
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
            this.bkHistory = new System.Windows.Forms.DataGridView();
            this.bkID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bkDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bkDuration = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bID = new System.Windows.Forms.DataGridViewButtonColumn();
            this.rcID = new System.Windows.Forms.DataGridViewButtonColumn();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.bkHistory)).BeginInit();
            this.SuspendLayout();
            // 
            // bkHistory
            // 
            this.bkHistory.AllowUserToDeleteRows = false;
            this.bkHistory.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.bkHistory.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.bkHistory.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.bkID,
            this.bkDate,
            this.bkDuration,
            this.rID,
            this.bID,
            this.rcID});
            this.bkHistory.Location = new System.Drawing.Point(72, 48);
            this.bkHistory.Name = "bkHistory";
            this.bkHistory.ReadOnly = true;
            this.bkHistory.Size = new System.Drawing.Size(645, 455);
            this.bkHistory.TabIndex = 4;
            this.bkHistory.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.bkHistory_CellContentClick);
            // 
            // bkID
            // 
            this.bkID.HeaderText = "Booking ID";
            this.bkID.Name = "bkID";
            this.bkID.ReadOnly = true;
            this.bkID.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.bkID.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // bkDate
            // 
            this.bkDate.HeaderText = "Booking Date";
            this.bkDate.Name = "bkDate";
            this.bkDate.ReadOnly = true;
            // 
            // bkDuration
            // 
            this.bkDuration.HeaderText = "Duration (days)";
            this.bkDuration.Name = "bkDuration";
            this.bkDuration.ReadOnly = true;
            // 
            // rID
            // 
            this.rID.HeaderText = "Room ID";
            this.rID.Name = "rID";
            this.rID.ReadOnly = true;
            // 
            // bID
            // 
            this.bID.HeaderText = "Bill ID";
            this.bID.Name = "bID";
            this.bID.ReadOnly = true;
            this.bID.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.bID.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // rcID
            // 
            this.rcID.HeaderText = "Receptionist ID";
            this.rcID.Name = "rcID";
            this.rcID.ReadOnly = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(1, -1);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(44, 23);
            this.button1.TabIndex = 5;
            this.button1.Text = "<---";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // ManagerBKVa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 530);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.bkHistory);
            this.Name = "ManagerBKVa";
            this.Text = "ManagerBKVa";
            this.Load += new System.EventHandler(this.ManagerBKVa_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bkHistory)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView bkHistory;
        private System.Windows.Forms.DataGridViewTextBoxColumn bkID;
        private System.Windows.Forms.DataGridViewTextBoxColumn bkDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn bkDuration;
        private System.Windows.Forms.DataGridViewTextBoxColumn rID;
        private System.Windows.Forms.DataGridViewButtonColumn bID;
        private System.Windows.Forms.DataGridViewButtonColumn rcID;
        private System.Windows.Forms.Button button1;
    }
}