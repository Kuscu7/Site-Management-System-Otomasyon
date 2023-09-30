namespace Site_Management_System
{
    partial class Security
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
            this.listBTN = new System.Windows.Forms.Button();
            this.GuestBTN = new System.Windows.Forms.Button();
            this.logOutBTN = new System.Windows.Forms.Button();
            this.listGuestBTN = new System.Windows.Forms.Button();
            this.listTXB = new System.Windows.Forms.TextBox();
            this.ListGuestTXB = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.deleteBTN = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(171, 26);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(548, 254);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // listBTN
            // 
            this.listBTN.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.listBTN.Location = new System.Drawing.Point(586, 318);
            this.listBTN.Margin = new System.Windows.Forms.Padding(2);
            this.listBTN.Name = "listBTN";
            this.listBTN.Size = new System.Drawing.Size(133, 80);
            this.listBTN.TabIndex = 3;
            this.listBTN.Text = "Search Residant";
            this.listBTN.UseVisualStyleBackColor = true;
            this.listBTN.Click += new System.EventHandler(this.listBTN_Click);
            // 
            // GuestBTN
            // 
            this.GuestBTN.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.GuestBTN.Location = new System.Drawing.Point(33, 106);
            this.GuestBTN.Margin = new System.Windows.Forms.Padding(2);
            this.GuestBTN.Name = "GuestBTN";
            this.GuestBTN.Size = new System.Drawing.Size(133, 80);
            this.GuestBTN.TabIndex = 5;
            this.GuestBTN.Text = "Add Guest";
            this.GuestBTN.UseVisualStyleBackColor = true;
            this.GuestBTN.Click += new System.EventHandler(this.GuestBTN_Click);
            // 
            // logOutBTN
            // 
            this.logOutBTN.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.logOutBTN.Location = new System.Drawing.Point(738, 33);
            this.logOutBTN.Margin = new System.Windows.Forms.Padding(2);
            this.logOutBTN.Name = "logOutBTN";
            this.logOutBTN.Size = new System.Drawing.Size(49, 31);
            this.logOutBTN.TabIndex = 6;
            this.logOutBTN.Text = "log out";
            this.logOutBTN.UseVisualStyleBackColor = true;
            this.logOutBTN.Click += new System.EventHandler(this.button2_Click);
            // 
            // listGuestBTN
            // 
            this.listGuestBTN.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.listGuestBTN.Location = new System.Drawing.Point(171, 318);
            this.listGuestBTN.Margin = new System.Windows.Forms.Padding(2);
            this.listGuestBTN.Name = "listGuestBTN";
            this.listGuestBTN.Size = new System.Drawing.Size(133, 80);
            this.listGuestBTN.TabIndex = 7;
            this.listGuestBTN.Text = "Search Guest";
            this.listGuestBTN.UseVisualStyleBackColor = true;
            this.listGuestBTN.Click += new System.EventHandler(this.listGuestBTN_Click);
            // 
            // listTXB
            // 
            this.listTXB.Location = new System.Drawing.Point(619, 293);
            this.listTXB.Name = "listTXB";
            this.listTXB.Size = new System.Drawing.Size(100, 20);
            this.listTXB.TabIndex = 8;
            // 
            // ListGuestTXB
            // 
            this.ListGuestTXB.Location = new System.Drawing.Point(204, 293);
            this.ListGuestTXB.Name = "ListGuestTXB";
            this.ListGuestTXB.Size = new System.Drawing.Size(100, 20);
            this.ListGuestTXB.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(162, 296);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 10;
            this.label1.Text = "Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(578, 300);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 11;
            this.label2.Text = "Name";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(66, 26);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 12;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(66, 58);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 20);
            this.textBox2.TabIndex = 13;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(25, 33);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 14;
            this.label3.Text = "Name";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(11, 65);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 13);
            this.label4.TabIndex = 15;
            this.label4.Text = "Surname";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // deleteBTN
            // 
            this.deleteBTN.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.deleteBTN.Location = new System.Drawing.Point(33, 200);
            this.deleteBTN.Margin = new System.Windows.Forms.Padding(2);
            this.deleteBTN.Name = "deleteBTN";
            this.deleteBTN.Size = new System.Drawing.Size(133, 80);
            this.deleteBTN.TabIndex = 16;
            this.deleteBTN.Text = "Delete Guest";
            this.deleteBTN.UseVisualStyleBackColor = true;
            this.deleteBTN.Click += new System.EventHandler(this.deleteBTN_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button1.Location = new System.Drawing.Point(383, 318);
            this.button1.Margin = new System.Windows.Forms.Padding(2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(133, 80);
            this.button1.TabIndex = 17;
            this.button1.Text = "List ALL Guests";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // Security
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(801, 409);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.deleteBTN);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ListGuestTXB);
            this.Controls.Add(this.listTXB);
            this.Controls.Add(this.listGuestBTN);
            this.Controls.Add(this.logOutBTN);
            this.Controls.Add(this.GuestBTN);
            this.Controls.Add(this.listBTN);
            this.Controls.Add(this.dataGridView1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Security";
            this.Text = "Security";
            this.Load += new System.EventHandler(this.Security_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button listBTN;
        private System.Windows.Forms.Button GuestBTN;
        private System.Windows.Forms.Button logOutBTN;
        private System.Windows.Forms.Button listGuestBTN;
        private System.Windows.Forms.TextBox listTXB;
        private System.Windows.Forms.TextBox ListGuestTXB;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button deleteBTN;
        private System.Windows.Forms.Button button1;
    }
}