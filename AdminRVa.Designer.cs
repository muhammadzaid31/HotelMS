namespace HotelMS
{
    partial class AdminRVa
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
            this.Rooms = new System.Windows.Forms.DataGridView();
            this.rID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rStatus = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.Rooms)).BeginInit();
            this.SuspendLayout();
            // 
            // Rooms
            // 
            this.Rooms.AllowUserToDeleteRows = false;
            this.Rooms.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Rooms.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Rooms.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.rID,
            this.rType,
            this.rPrice,
            this.rStatus});
            this.Rooms.Location = new System.Drawing.Point(94, 30);
            this.Rooms.Name = "Rooms";
            this.Rooms.ReadOnly = true;
            this.Rooms.Size = new System.Drawing.Size(444, 327);
            this.Rooms.TabIndex = 2;
            // 
            // rID
            // 
            this.rID.HeaderText = "rID";
            this.rID.Name = "rID";
            this.rID.ReadOnly = true;
            this.rID.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.rID.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // rType
            // 
            this.rType.HeaderText = "Room Type";
            this.rType.Name = "rType";
            this.rType.ReadOnly = true;
            // 
            // rPrice
            // 
            this.rPrice.HeaderText = "Room Price";
            this.rPrice.Name = "rPrice";
            this.rPrice.ReadOnly = true;
            // 
            // rStatus
            // 
            this.rStatus.HeaderText = "Room Status";
            this.rStatus.Name = "rStatus";
            this.rStatus.ReadOnly = true;
            // 
            // AdminRVa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(649, 390);
            this.Controls.Add(this.Rooms);
            this.Name = "AdminRVa";
            this.Text = "AdminRVa";
            this.Load += new System.EventHandler(this.AdminRVa_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Rooms)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView Rooms;
        private System.Windows.Forms.DataGridViewTextBoxColumn rID;
        private System.Windows.Forms.DataGridViewTextBoxColumn rType;
        private System.Windows.Forms.DataGridViewTextBoxColumn rPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn rStatus;
    }
}