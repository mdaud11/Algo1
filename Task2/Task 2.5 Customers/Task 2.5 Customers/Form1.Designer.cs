namespace Task_2._5_Customers
{
    partial class Form1
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
            this.label1 = new System.Windows.Forms.Label();
            this.nameInput = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.ageInput = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.addressInput = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.amountInput = new System.Windows.Forms.TextBox();
            this.submitBtn = new System.Windows.Forms.Button();
            this.totalCustomersLabel = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.sortedResultLabel = new System.Windows.Forms.Label();
            this.preOrderbtn = new System.Windows.Forms.Button();
            this.inOrderbtn = new System.Windows.Forms.Button();
            this.postOrderBtn = new System.Windows.Forms.Button();
            this.searchInput = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.searchBtn = new System.Windows.Forms.Button();
            this.searchResultLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(52, 66);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Name";
            // 
            // nameInput
            // 
            this.nameInput.Location = new System.Drawing.Point(55, 92);
            this.nameInput.Name = "nameInput";
            this.nameInput.Size = new System.Drawing.Size(100, 20);
            this.nameInput.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(55, 132);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(26, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Age";
            // 
            // ageInput
            // 
            this.ageInput.Location = new System.Drawing.Point(58, 148);
            this.ageInput.Name = "ageInput";
            this.ageInput.Size = new System.Drawing.Size(100, 20);
            this.ageInput.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(58, 206);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Address";
            // 
            // addressInput
            // 
            this.addressInput.Location = new System.Drawing.Point(61, 222);
            this.addressInput.Name = "addressInput";
            this.addressInput.Size = new System.Drawing.Size(100, 20);
            this.addressInput.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(58, 275);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(74, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Amount Owed";
            // 
            // amountInput
            // 
            this.amountInput.Location = new System.Drawing.Point(61, 291);
            this.amountInput.Name = "amountInput";
            this.amountInput.Size = new System.Drawing.Size(100, 20);
            this.amountInput.TabIndex = 7;
            // 
            // submitBtn
            // 
            this.submitBtn.Location = new System.Drawing.Point(61, 350);
            this.submitBtn.Name = "submitBtn";
            this.submitBtn.Size = new System.Drawing.Size(75, 23);
            this.submitBtn.TabIndex = 8;
            this.submitBtn.Text = "Submit";
            this.submitBtn.UseVisualStyleBackColor = true;
            this.submitBtn.Click += new System.EventHandler(this.submitBtn_Click);
            // 
            // totalCustomersLabel
            // 
            this.totalCustomersLabel.AutoSize = true;
            this.totalCustomersLabel.Location = new System.Drawing.Point(61, 441);
            this.totalCustomersLabel.Name = "totalCustomersLabel";
            this.totalCustomersLabel.Size = new System.Drawing.Size(119, 13);
            this.totalCustomersLabel.TabIndex = 9;
            this.totalCustomersLabel.Text = "Number of customers: 0";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(440, 66);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(59, 13);
            this.label6.TabIndex = 10;
            this.label6.Text = "Sort results";
            // 
            // sortedResultLabel
            // 
            this.sortedResultLabel.AutoSize = true;
            this.sortedResultLabel.Location = new System.Drawing.Point(443, 105);
            this.sortedResultLabel.Name = "sortedResultLabel";
            this.sortedResultLabel.Size = new System.Drawing.Size(73, 13);
            this.sortedResultLabel.TabIndex = 11;
            this.sortedResultLabel.Text = "Not sorted yet";
            // 
            // preOrderbtn
            // 
            this.preOrderbtn.Location = new System.Drawing.Point(288, 66);
            this.preOrderbtn.Name = "preOrderbtn";
            this.preOrderbtn.Size = new System.Drawing.Size(75, 23);
            this.preOrderbtn.TabIndex = 12;
            this.preOrderbtn.Text = "Pre Order";
            this.preOrderbtn.UseVisualStyleBackColor = true;
            this.preOrderbtn.Click += new System.EventHandler(this.preOrderbtn_Click);
            // 
            // inOrderbtn
            // 
            this.inOrderbtn.Location = new System.Drawing.Point(288, 118);
            this.inOrderbtn.Name = "inOrderbtn";
            this.inOrderbtn.Size = new System.Drawing.Size(75, 23);
            this.inOrderbtn.TabIndex = 13;
            this.inOrderbtn.Text = "In Order";
            this.inOrderbtn.UseVisualStyleBackColor = true;
            this.inOrderbtn.Click += new System.EventHandler(this.inOrderbtn_Click);
            // 
            // postOrderBtn
            // 
            this.postOrderBtn.Location = new System.Drawing.Point(288, 170);
            this.postOrderBtn.Name = "postOrderBtn";
            this.postOrderBtn.Size = new System.Drawing.Size(75, 23);
            this.postOrderBtn.TabIndex = 14;
            this.postOrderBtn.Text = "Post Order";
            this.postOrderBtn.UseVisualStyleBackColor = true;
            this.postOrderBtn.Click += new System.EventHandler(this.postOrderBtn_Click);
            // 
            // searchInput
            // 
            this.searchInput.Location = new System.Drawing.Point(288, 267);
            this.searchInput.Name = "searchInput";
            this.searchInput.Size = new System.Drawing.Size(100, 20);
            this.searchInput.TabIndex = 15;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(288, 234);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(35, 13);
            this.label5.TabIndex = 16;
            this.label5.Text = "Name";
            // 
            // searchBtn
            // 
            this.searchBtn.Location = new System.Drawing.Point(291, 314);
            this.searchBtn.Name = "searchBtn";
            this.searchBtn.Size = new System.Drawing.Size(75, 23);
            this.searchBtn.TabIndex = 17;
            this.searchBtn.Text = "Search";
            this.searchBtn.UseVisualStyleBackColor = true;
            this.searchBtn.Click += new System.EventHandler(this.searchBtn_Click);
            // 
            // searchResultLabel
            // 
            this.searchResultLabel.AutoSize = true;
            this.searchResultLabel.Location = new System.Drawing.Point(291, 371);
            this.searchResultLabel.Name = "searchResultLabel";
            this.searchResultLabel.Size = new System.Drawing.Size(88, 13);
            this.searchResultLabel.TabIndex = 18;
            this.searchResultLabel.Text = "Not searched yet";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 561);
            this.Controls.Add(this.searchResultLabel);
            this.Controls.Add(this.searchBtn);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.searchInput);
            this.Controls.Add(this.postOrderBtn);
            this.Controls.Add(this.inOrderbtn);
            this.Controls.Add(this.preOrderbtn);
            this.Controls.Add(this.sortedResultLabel);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.totalCustomersLabel);
            this.Controls.Add(this.submitBtn);
            this.Controls.Add(this.amountInput);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.addressInput);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.ageInput);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.nameInput);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox nameInput;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox ageInput;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox addressInput;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox amountInput;
        private System.Windows.Forms.Button submitBtn;
        private System.Windows.Forms.Label totalCustomersLabel;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label sortedResultLabel;
        private System.Windows.Forms.Button preOrderbtn;
        private System.Windows.Forms.Button inOrderbtn;
        private System.Windows.Forms.Button postOrderBtn;
        private System.Windows.Forms.TextBox searchInput;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button searchBtn;
        private System.Windows.Forms.Label searchResultLabel;
    }
}

