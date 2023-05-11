namespace HotelMS
{
    partial class CheckAvail
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
            this.oRooms = new System.Windows.Forms.DataGridView();
            this.OrID = new System.Windows.Forms.DataGridViewButtonColumn();
            this.rType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rStatus = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.vRooms = new System.Windows.Forms.DataGridView();
            this.VrID = new System.Windows.Forms.DataGridViewButtonColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.oRooms)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vRooms)).BeginInit();
            this.SuspendLayout();
            // 
            // oRooms
            // 
            this.oRooms.AllowUserToDeleteRows = false;
            this.oRooms.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.oRooms.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.oRooms.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.OrID,
            this.rType,
            this.rPrice,
            this.rStatus});
            this.oRooms.Location = new System.Drawing.Point(180, 57);
            this.oRooms.Name = "oRooms";
            this.oRooms.ReadOnly = true;
            this.oRooms.Size = new System.Drawing.Size(446, 183);
            this.oRooms.TabIndex = 3;
            this.oRooms.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.oRooms_CellContentClick);
            // 
            // OrID
            // 
            this.OrID.HeaderText = "rID";
            this.OrID.Name = "OrID";
            this.OrID.ReadOnly = true;
            this.OrID.Resizable = System.Windows.Forms.DataGridViewTriState.True;
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
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(296, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(190, 25);
            this.label1.TabIndex = 4;
            this.label1.Text = "Occupied Rooms";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(308, 279);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(164, 25);
            this.label2.TabIndex = 5;
            this.label2.Text = "Vacant Rooms";
            // 
            // vRooms
            // 
            this.vRooms.AllowUserToDeleteRows = false;
            this.vRooms.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.vRooms.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.vRooms.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.VrID,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4});
            this.vRooms.Location = new System.Drawing.Point(180, 328);
            this.vRooms.Name = "vRooms";
            this.vRooms.ReadOnly = true;
            this.vRooms.Size = new System.Drawing.Size(444, 236);
            this.vRooms.TabIndex = 6;
            this.vRooms.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.vRooms_CellContentClick);
            // 
            // VrID
            // 
            this.VrID.HeaderText = "rID";
            this.VrID.Name = "VrID";
            this.VrID.ReadOnly = true;
            this.VrID.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.HeaderText = "Room Type";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.HeaderText = "Room Price";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.HeaderText = "Room Status";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            // 
            // CheckAvail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 604);
            this.Controls.Add(this.vRooms);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.oRooms);
            this.Name = "CheckAvail";
            this.Text = "FCB HotelMS";
            this.Load += new System.EventHandler(this.CheckAvail_Load);
            ((System.ComponentModel.ISupportInitialize)(this.oRooms)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vRooms)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView oRooms;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView vRooms;
        private System.Windows.Forms.DataGridViewButtonColumn OrID;
        private System.Windows.Forms.DataGridViewTextBoxColumn rType;
        private System.Windows.Forms.DataGridViewTextBoxColumn rPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn rStatus;
        private System.Windows.Forms.DataGridViewButtonColumn VrID;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
    }
}