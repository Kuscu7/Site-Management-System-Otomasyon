namespace Site_Management_System
{
    partial class adminPage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(adminPage));
            this.InsertBTN = new System.Windows.Forms.Button();
            this.DeleteBTN = new System.Windows.Forms.Button();
            this.UpdateBTN = new System.Windows.Forms.Button();
            this.ApartmanDGV = new System.Windows.Forms.DataGridView();
            this.NameTXB = new System.Windows.Forms.TextBox();
            this.CapacityTXB = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.logoutBTN = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.ApartmanDGV)).BeginInit();
            this.SuspendLayout();
            // 
            // InsertBTN
            // 
            this.InsertBTN.Location = new System.Drawing.Point(77, 236);
            this.InsertBTN.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.InsertBTN.Name = "InsertBTN";
            this.InsertBTN.Size = new System.Drawing.Size(120, 47);
            this.InsertBTN.TabIndex = 0;
            this.InsertBTN.Text = "Insert";
            this.InsertBTN.UseVisualStyleBackColor = true;
            this.InsertBTN.Click += new System.EventHandler(this.InsertBTN_Click);
            // 
            // DeleteBTN
            // 
            this.DeleteBTN.Location = new System.Drawing.Point(12, 298);
            this.DeleteBTN.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.DeleteBTN.Name = "DeleteBTN";
            this.DeleteBTN.Size = new System.Drawing.Size(120, 47);
            this.DeleteBTN.TabIndex = 1;
            this.DeleteBTN.Text = "Delete";
            this.DeleteBTN.UseVisualStyleBackColor = true;
            this.DeleteBTN.Click += new System.EventHandler(this.DeleteBTN_Click);
            // 
            // UpdateBTN
            // 
            this.UpdateBTN.Location = new System.Drawing.Point(139, 298);
            this.UpdateBTN.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.UpdateBTN.Name = "UpdateBTN";
            this.UpdateBTN.Size = new System.Drawing.Size(124, 47);
            this.UpdateBTN.TabIndex = 2;
            this.UpdateBTN.Text = "Update";
            this.UpdateBTN.UseVisualStyleBackColor = true;
            this.UpdateBTN.Click += new System.EventHandler(this.UpdateBTN_Click);
            // 
            // ApartmanDGV
            // 
            this.ApartmanDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ApartmanDGV.Location = new System.Drawing.Point(297, 62);
            this.ApartmanDGV.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ApartmanDGV.Name = "ApartmanDGV";
            this.ApartmanDGV.RowHeadersWidth = 51;
            this.ApartmanDGV.RowTemplate.Height = 24;
            this.ApartmanDGV.Size = new System.Drawing.Size(473, 287);
            this.ApartmanDGV.TabIndex = 3;
            this.ApartmanDGV.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.ApartmanDGV_CellContentClick);
            this.ApartmanDGV.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.ApartmanDGV_CellMouseClick);
            // 
            // NameTXB
            // 
            this.NameTXB.Location = new System.Drawing.Point(163, 103);
            this.NameTXB.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.NameTXB.Name = "NameTXB";
            this.NameTXB.Size = new System.Drawing.Size(100, 22);
            this.NameTXB.TabIndex = 4;
            // 
            // CapacityTXB
            // 
            this.CapacityTXB.Location = new System.Drawing.Point(163, 155);
            this.CapacityTXB.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.CapacityTXB.Name = "CapacityTXB";
            this.CapacityTXB.Size = new System.Drawing.Size(100, 22);
            this.CapacityTXB.TabIndex = 5;
            this.CapacityTXB.TextChanged += new System.EventHandler(this.CapacityTXB_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 106);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(105, 16);
            this.label1.TabIndex = 6;
            this.label1.Text = "Apartman Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 158);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(121, 16);
            this.label2.TabIndex = 7;
            this.label2.Text = "Apartman Capacity";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // logoutBTN
            // 
            this.logoutBTN.Location = new System.Drawing.Point(12, 15);
            this.logoutBTN.Margin = new System.Windows.Forms.Padding(4);
            this.logoutBTN.Name = "logoutBTN";
            this.logoutBTN.Size = new System.Drawing.Size(100, 28);
            this.logoutBTN.TabIndex = 8;
            this.logoutBTN.Text = "Log Out";
            this.logoutBTN.UseVisualStyleBackColor = true;
            this.logoutBTN.Click += new System.EventHandler(this.logoutBTN_Click);
            // 
            // adminPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.logoutBTN);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.CapacityTXB);
            this.Controls.Add(this.NameTXB);
            this.Controls.Add(this.ApartmanDGV);
            this.Controls.Add(this.UpdateBTN);
            this.Controls.Add(this.DeleteBTN);
            this.Controls.Add(this.InsertBTN);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "adminPage";
            this.Text = resources.GetString("$this.Text");
            this.Load += new System.EventHandler(this.adminPage_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ApartmanDGV)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button InsertBTN;
        private System.Windows.Forms.Button DeleteBTN;
        private System.Windows.Forms.Button UpdateBTN;
        private System.Windows.Forms.DataGridView ApartmanDGV;
        private System.Windows.Forms.TextBox NameTXB;
        private System.Windows.Forms.TextBox CapacityTXB;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button logoutBTN;
    }
}