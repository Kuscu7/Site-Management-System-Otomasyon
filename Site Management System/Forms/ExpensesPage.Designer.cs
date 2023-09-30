namespace Site_Management_System.Forms
{
    partial class Management_Expenses
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
            this.AddExpenseBTN = new System.Windows.Forms.Button();
            this.NameTXB = new System.Windows.Forms.TextBox();
            this.PriceTXB = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.DeleteExpenseBTN = new System.Windows.Forms.Button();
            this.UpdateExpenseBTN = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.LogOutBTN = new System.Windows.Forms.Button();
            this.ResidantPageBTN = new System.Windows.Forms.Button();
            this.Total = new System.Windows.Forms.Button();
            this.ListExpense = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // AddExpenseBTN
            // 
            this.AddExpenseBTN.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.AddExpenseBTN.Location = new System.Drawing.Point(27, 129);
            this.AddExpenseBTN.Name = "AddExpenseBTN";
            this.AddExpenseBTN.Size = new System.Drawing.Size(138, 62);
            this.AddExpenseBTN.TabIndex = 0;
            this.AddExpenseBTN.Text = "Add Expense";
            this.AddExpenseBTN.UseVisualStyleBackColor = true;
            this.AddExpenseBTN.Click += new System.EventHandler(this.AddExpenseBTN_Click);
            // 
            // NameTXB
            // 
            this.NameTXB.Location = new System.Drawing.Point(65, 38);
            this.NameTXB.Name = "NameTXB";
            this.NameTXB.Size = new System.Drawing.Size(100, 20);
            this.NameTXB.TabIndex = 4;
            // 
            // PriceTXB
            // 
            this.PriceTXB.Location = new System.Drawing.Point(65, 76);
            this.PriceTXB.Name = "PriceTXB";
            this.PriceTXB.Size = new System.Drawing.Size(100, 20);
            this.PriceTXB.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(24, 79);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(31, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Price";
            // 
            // DeleteExpenseBTN
            // 
            this.DeleteExpenseBTN.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.DeleteExpenseBTN.Location = new System.Drawing.Point(27, 197);
            this.DeleteExpenseBTN.Name = "DeleteExpenseBTN";
            this.DeleteExpenseBTN.Size = new System.Drawing.Size(138, 62);
            this.DeleteExpenseBTN.TabIndex = 8;
            this.DeleteExpenseBTN.Text = "Delete Expense";
            this.DeleteExpenseBTN.UseVisualStyleBackColor = true;
            this.DeleteExpenseBTN.Click += new System.EventHandler(this.DeleteExpenseBTN_Click);
            // 
            // UpdateExpenseBTN
            // 
            this.UpdateExpenseBTN.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.UpdateExpenseBTN.Location = new System.Drawing.Point(27, 265);
            this.UpdateExpenseBTN.Name = "UpdateExpenseBTN";
            this.UpdateExpenseBTN.Size = new System.Drawing.Size(138, 62);
            this.UpdateExpenseBTN.TabIndex = 9;
            this.UpdateExpenseBTN.Text = "Update Expense";
            this.UpdateExpenseBTN.UseVisualStyleBackColor = true;
            this.UpdateExpenseBTN.Click += new System.EventHandler(this.UpdateExpenseBTN_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(185, 38);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(317, 433);
            this.dataGridView1.TabIndex = 11;
            this.dataGridView1.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridView1_CellMouseClick);
            // 
            // LogOutBTN
            // 
            this.LogOutBTN.Location = new System.Drawing.Point(380, -1);
            this.LogOutBTN.Name = "LogOutBTN";
            this.LogOutBTN.Size = new System.Drawing.Size(58, 33);
            this.LogOutBTN.TabIndex = 20;
            this.LogOutBTN.Text = "Log Out";
            this.LogOutBTN.UseVisualStyleBackColor = true;
            this.LogOutBTN.Click += new System.EventHandler(this.LogOutBTN_Click);
            // 
            // ResidantPageBTN
            // 
            this.ResidantPageBTN.Location = new System.Drawing.Point(286, -1);
            this.ResidantPageBTN.Name = "ResidantPageBTN";
            this.ResidantPageBTN.Size = new System.Drawing.Size(88, 33);
            this.ResidantPageBTN.TabIndex = 21;
            this.ResidantPageBTN.Text = "Residant Page";
            this.ResidantPageBTN.UseVisualStyleBackColor = true;
            this.ResidantPageBTN.Click += new System.EventHandler(this.ResidantPageBTN_Click);
            // 
            // Total
            // 
            this.Total.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Total.Location = new System.Drawing.Point(27, 333);
            this.Total.Name = "Total";
            this.Total.Size = new System.Drawing.Size(138, 62);
            this.Total.TabIndex = 22;
            this.Total.Text = "Show Total Expense";
            this.Total.UseVisualStyleBackColor = true;
            this.Total.Click += new System.EventHandler(this.Total_Click);
            // 
            // ListExpense
            // 
            this.ListExpense.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.ListExpense.Location = new System.Drawing.Point(27, 401);
            this.ListExpense.Name = "ListExpense";
            this.ListExpense.Size = new System.Drawing.Size(138, 62);
            this.ListExpense.TabIndex = 23;
            this.ListExpense.Text = "List Expenses";
            this.ListExpense.UseVisualStyleBackColor = true;
            this.ListExpense.Click += new System.EventHandler(this.ListExpense_Click);
            // 
            // Management_Expenses
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(514, 483);
            this.Controls.Add(this.ListExpense);
            this.Controls.Add(this.Total);
            this.Controls.Add(this.ResidantPageBTN);
            this.Controls.Add(this.LogOutBTN);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.UpdateExpenseBTN);
            this.Controls.Add(this.DeleteExpenseBTN);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.PriceTXB);
            this.Controls.Add(this.NameTXB);
            this.Controls.Add(this.AddExpenseBTN);
            this.Name = "Management_Expenses";
            this.Text = "Management_Expenses";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button AddExpenseBTN;
        private System.Windows.Forms.TextBox NameTXB;
        private System.Windows.Forms.TextBox PriceTXB;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button DeleteExpenseBTN;
        private System.Windows.Forms.Button UpdateExpenseBTN;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button LogOutBTN;
        private System.Windows.Forms.Button ResidantPageBTN;
        private System.Windows.Forms.Button Total;
        private System.Windows.Forms.Button ListExpense;
    }
}