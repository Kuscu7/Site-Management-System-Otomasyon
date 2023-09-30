namespace Site_Management_System
{
    partial class Management
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.NameTXB = new System.Windows.Forms.TextBox();
            this.SurnameTXB = new System.Windows.Forms.TextBox();
            this.AptNoTXB = new System.Windows.Forms.TextBox();
            this.BlockTXB = new System.Windows.Forms.TextBox();
            this.Phone1TXB = new System.Windows.Forms.TextBox();
            this.Phone2TXB = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.InsertBTN = new System.Windows.Forms.Button();
            this.DeleteBTN = new System.Windows.Forms.Button();
            this.UpdateBTN = new System.Windows.Forms.Button();
            this.MarkAsPaidBTN = new System.Windows.Forms.Button();
            this.MarkAsUnPaidBTN = new System.Windows.Forms.Button();
            this.MarkAsUnpaidAllBTN = new System.Windows.Forms.Button();
            this.LogOutBTN = new System.Windows.Forms.Button();
            this.ExpensesPageBTN = new System.Windows.Forms.Button();
            this.SearchBTN = new System.Windows.Forms.Button();
            this.SearchTXB = new System.Windows.Forms.TextBox();
            this.ListResidantBTN = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(172, 11);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(498, 387);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            this.dataGridView1.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridView1_CellMouseClick);
            // 
            // NameTXB
            // 
            this.NameTXB.Location = new System.Drawing.Point(55, 22);
            this.NameTXB.Name = "NameTXB";
            this.NameTXB.Size = new System.Drawing.Size(100, 20);
            this.NameTXB.TabIndex = 1;
            // 
            // SurnameTXB
            // 
            this.SurnameTXB.Location = new System.Drawing.Point(55, 48);
            this.SurnameTXB.Name = "SurnameTXB";
            this.SurnameTXB.Size = new System.Drawing.Size(100, 20);
            this.SurnameTXB.TabIndex = 2;
            // 
            // AptNoTXB
            // 
            this.AptNoTXB.Location = new System.Drawing.Point(55, 74);
            this.AptNoTXB.Name = "AptNoTXB";
            this.AptNoTXB.Size = new System.Drawing.Size(100, 20);
            this.AptNoTXB.TabIndex = 3;
            // 
            // BlockTXB
            // 
            this.BlockTXB.Location = new System.Drawing.Point(55, 100);
            this.BlockTXB.Name = "BlockTXB";
            this.BlockTXB.Size = new System.Drawing.Size(100, 20);
            this.BlockTXB.TabIndex = 4;
            this.BlockTXB.TextChanged += new System.EventHandler(this.textBox4_TextChanged);
            // 
            // Phone1TXB
            // 
            this.Phone1TXB.Location = new System.Drawing.Point(55, 126);
            this.Phone1TXB.Name = "Phone1TXB";
            this.Phone1TXB.Size = new System.Drawing.Size(100, 20);
            this.Phone1TXB.TabIndex = 5;
            // 
            // Phone2TXB
            // 
            this.Phone2TXB.Location = new System.Drawing.Point(55, 152);
            this.Phone2TXB.Name = "Phone2TXB";
            this.Phone2TXB.Size = new System.Drawing.Size(100, 20);
            this.Phone2TXB.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(0, 51);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Surname";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(7, 77);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Apt No";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 103);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(34, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Block";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(5, 129);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(44, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "Phone1";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(5, 155);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(44, 13);
            this.label6.TabIndex = 12;
            this.label6.Text = "Phone2";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // InsertBTN
            // 
            this.InsertBTN.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.InsertBTN.Location = new System.Drawing.Point(16, 189);
            this.InsertBTN.Name = "InsertBTN";
            this.InsertBTN.Size = new System.Drawing.Size(147, 56);
            this.InsertBTN.TabIndex = 13;
            this.InsertBTN.Text = "Add Residant";
            this.InsertBTN.UseVisualStyleBackColor = true;
            this.InsertBTN.Click += new System.EventHandler(this.InsertBTN_Click);
            // 
            // DeleteBTN
            // 
            this.DeleteBTN.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.DeleteBTN.Location = new System.Drawing.Point(16, 264);
            this.DeleteBTN.Name = "DeleteBTN";
            this.DeleteBTN.Size = new System.Drawing.Size(147, 56);
            this.DeleteBTN.TabIndex = 14;
            this.DeleteBTN.Text = "Delete Residant";
            this.DeleteBTN.UseVisualStyleBackColor = true;
            this.DeleteBTN.Click += new System.EventHandler(this.DeleteBTN_Click);
            // 
            // UpdateBTN
            // 
            this.UpdateBTN.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.UpdateBTN.Location = new System.Drawing.Point(16, 342);
            this.UpdateBTN.Name = "UpdateBTN";
            this.UpdateBTN.Size = new System.Drawing.Size(147, 56);
            this.UpdateBTN.TabIndex = 15;
            this.UpdateBTN.Text = "Update Residant";
            this.UpdateBTN.UseVisualStyleBackColor = true;
            this.UpdateBTN.Click += new System.EventHandler(this.UpdateBTN_Click);
            // 
            // MarkAsPaidBTN
            // 
            this.MarkAsPaidBTN.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.MarkAsPaidBTN.Location = new System.Drawing.Point(682, 22);
            this.MarkAsPaidBTN.Name = "MarkAsPaidBTN";
            this.MarkAsPaidBTN.Size = new System.Drawing.Size(147, 56);
            this.MarkAsPaidBTN.TabIndex = 16;
            this.MarkAsPaidBTN.Text = "Mark as Paid";
            this.MarkAsPaidBTN.UseVisualStyleBackColor = true;
            this.MarkAsPaidBTN.Click += new System.EventHandler(this.MarkAsPaidBTN_Click);
            // 
            // MarkAsUnPaidBTN
            // 
            this.MarkAsUnPaidBTN.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.MarkAsUnPaidBTN.Location = new System.Drawing.Point(682, 100);
            this.MarkAsUnPaidBTN.Name = "MarkAsUnPaidBTN";
            this.MarkAsUnPaidBTN.Size = new System.Drawing.Size(147, 56);
            this.MarkAsUnPaidBTN.TabIndex = 17;
            this.MarkAsUnPaidBTN.Text = "Mark as Unpaid";
            this.MarkAsUnPaidBTN.UseVisualStyleBackColor = true;
            this.MarkAsUnPaidBTN.Click += new System.EventHandler(this.MarkAsUnPaidBTN_Click);
            // 
            // MarkAsUnpaidAllBTN
            // 
            this.MarkAsUnpaidAllBTN.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.MarkAsUnpaidAllBTN.Location = new System.Drawing.Point(682, 295);
            this.MarkAsUnpaidAllBTN.Name = "MarkAsUnpaidAllBTN";
            this.MarkAsUnpaidAllBTN.Size = new System.Drawing.Size(147, 56);
            this.MarkAsUnpaidAllBTN.TabIndex = 18;
            this.MarkAsUnpaidAllBTN.Text = "Mark as Unpaid-All";
            this.MarkAsUnpaidAllBTN.UseVisualStyleBackColor = true;
            this.MarkAsUnpaidAllBTN.Click += new System.EventHandler(this.MarkAsUnpaidAllBTN_Click);
            // 
            // LogOutBTN
            // 
            this.LogOutBTN.Location = new System.Drawing.Point(765, 447);
            this.LogOutBTN.Name = "LogOutBTN";
            this.LogOutBTN.Size = new System.Drawing.Size(64, 39);
            this.LogOutBTN.TabIndex = 19;
            this.LogOutBTN.Text = "Log Out";
            this.LogOutBTN.UseVisualStyleBackColor = true;
            this.LogOutBTN.Click += new System.EventHandler(this.LogOutBTN_Click);
            // 
            // ExpensesPageBTN
            // 
            this.ExpensesPageBTN.Location = new System.Drawing.Point(693, 447);
            this.ExpensesPageBTN.Name = "ExpensesPageBTN";
            this.ExpensesPageBTN.Size = new System.Drawing.Size(66, 39);
            this.ExpensesPageBTN.TabIndex = 20;
            this.ExpensesPageBTN.Text = "Expenses Page";
            this.ExpensesPageBTN.UseVisualStyleBackColor = true;
            this.ExpensesPageBTN.Click += new System.EventHandler(this.ExpensesPageBTN_Click);
            // 
            // SearchBTN
            // 
            this.SearchBTN.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.SearchBTN.Location = new System.Drawing.Point(172, 437);
            this.SearchBTN.Name = "SearchBTN";
            this.SearchBTN.Size = new System.Drawing.Size(147, 56);
            this.SearchBTN.TabIndex = 21;
            this.SearchBTN.Text = "Search By Name";
            this.SearchBTN.UseVisualStyleBackColor = true;
            this.SearchBTN.Click += new System.EventHandler(this.SearchBTN_Click);
            // 
            // SearchTXB
            // 
            this.SearchTXB.Location = new System.Drawing.Point(199, 411);
            this.SearchTXB.Name = "SearchTXB";
            this.SearchTXB.Size = new System.Drawing.Size(100, 20);
            this.SearchTXB.TabIndex = 22;
            // 
            // ListResidantBTN
            // 
            this.ListResidantBTN.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.ListResidantBTN.Location = new System.Drawing.Point(341, 437);
            this.ListResidantBTN.Name = "ListResidantBTN";
            this.ListResidantBTN.Size = new System.Drawing.Size(147, 56);
            this.ListResidantBTN.TabIndex = 23;
            this.ListResidantBTN.Text = "List Residant";
            this.ListResidantBTN.UseVisualStyleBackColor = true;
            this.ListResidantBTN.Click += new System.EventHandler(this.button1_Click);
            // 
            // Management
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(841, 501);
            this.Controls.Add(this.ListResidantBTN);
            this.Controls.Add(this.SearchTXB);
            this.Controls.Add(this.SearchBTN);
            this.Controls.Add(this.ExpensesPageBTN);
            this.Controls.Add(this.LogOutBTN);
            this.Controls.Add(this.MarkAsUnpaidAllBTN);
            this.Controls.Add(this.MarkAsUnPaidBTN);
            this.Controls.Add(this.MarkAsPaidBTN);
            this.Controls.Add(this.UpdateBTN);
            this.Controls.Add(this.DeleteBTN);
            this.Controls.Add(this.InsertBTN);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Phone2TXB);
            this.Controls.Add(this.Phone1TXB);
            this.Controls.Add(this.BlockTXB);
            this.Controls.Add(this.AptNoTXB);
            this.Controls.Add(this.SurnameTXB);
            this.Controls.Add(this.NameTXB);
            this.Controls.Add(this.dataGridView1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Management";
            this.Text = "Management";
            this.Load += new System.EventHandler(this.Management_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox NameTXB;
        private System.Windows.Forms.TextBox SurnameTXB;
        private System.Windows.Forms.TextBox AptNoTXB;
        private System.Windows.Forms.TextBox BlockTXB;
        private System.Windows.Forms.TextBox Phone1TXB;
        private System.Windows.Forms.TextBox Phone2TXB;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button InsertBTN;
        private System.Windows.Forms.Button DeleteBTN;
        private System.Windows.Forms.Button UpdateBTN;
        private System.Windows.Forms.Button MarkAsPaidBTN;
        private System.Windows.Forms.Button MarkAsUnPaidBTN;
        private System.Windows.Forms.Button MarkAsUnpaidAllBTN;
        private System.Windows.Forms.Button LogOutBTN;
        private System.Windows.Forms.Button ExpensesPageBTN;
        private System.Windows.Forms.Button SearchBTN;
        private System.Windows.Forms.TextBox SearchTXB;
        private System.Windows.Forms.Button ListResidantBTN;
    }
}