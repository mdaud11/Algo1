namespace Task_1_REDO
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
            this.nameInput = new System.Windows.Forms.TextBox();
            this.nameLabel = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.ageInput = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.addressInput = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.amountOwedInput = new System.Windows.Forms.TextBox();
            this.enqueueBtn = new System.Windows.Forms.Button();
            this.noOfCustomersLabel = new System.Windows.Forms.Label();
            this.totalOwedLabel = new System.Windows.Forms.Label();
            this.dequeueBtn = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.removedCustomerLabel = new System.Windows.Forms.Label();
            this.mostOwedCustomerLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // nameInput
            // 
            this.nameInput.Location = new System.Drawing.Point(45, 68);
            this.nameInput.Name = "nameInput";
            this.nameInput.Size = new System.Drawing.Size(100, 20);
            this.nameInput.TabIndex = 0;
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.Location = new System.Drawing.Point(42, 52);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(35, 13);
            this.nameLabel.TabIndex = 1;
            this.nameLabel.Text = "Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(42, 109);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(26, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Age";
            // 
            // ageInput
            // 
            this.ageInput.Location = new System.Drawing.Point(45, 125);
            this.ageInput.Name = "ageInput";
            this.ageInput.Size = new System.Drawing.Size(100, 20);
            this.ageInput.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(42, 170);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Address";
            // 
            // addressInput
            // 
            this.addressInput.Location = new System.Drawing.Point(45, 186);
            this.addressInput.Name = "addressInput";
            this.addressInput.Size = new System.Drawing.Size(100, 20);
            this.addressInput.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(42, 228);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(74, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Amount Owed";
            // 
            // amountOwedInput
            // 
            this.amountOwedInput.Location = new System.Drawing.Point(45, 244);
            this.amountOwedInput.Name = "amountOwedInput";
            this.amountOwedInput.Size = new System.Drawing.Size(100, 20);
            this.amountOwedInput.TabIndex = 6;
            // 
            // enqueueBtn
            // 
            this.enqueueBtn.Location = new System.Drawing.Point(45, 301);
            this.enqueueBtn.Name = "enqueueBtn";
            this.enqueueBtn.Size = new System.Drawing.Size(100, 23);
            this.enqueueBtn.TabIndex = 8;
            this.enqueueBtn.Text = "Enqueue";
            this.enqueueBtn.UseVisualStyleBackColor = true;
            this.enqueueBtn.Click += new System.EventHandler(this.enqueueBtn_Click);
            // 
            // noOfCustomersLabel
            // 
            this.noOfCustomersLabel.AutoSize = true;
            this.noOfCustomersLabel.Location = new System.Drawing.Point(42, 375);
            this.noOfCustomersLabel.Name = "noOfCustomersLabel";
            this.noOfCustomersLabel.Size = new System.Drawing.Size(119, 13);
            this.noOfCustomersLabel.TabIndex = 9;
            this.noOfCustomersLabel.Text = "Number of customers: 0";
            // 
            // totalOwedLabel
            // 
            this.totalOwedLabel.AutoSize = true;
            this.totalOwedLabel.Location = new System.Drawing.Point(42, 409);
            this.totalOwedLabel.Name = "totalOwedLabel";
            this.totalOwedLabel.Size = new System.Drawing.Size(175, 13);
            this.totalOwedLabel.TabIndex = 10;
            this.totalOwedLabel.Text = "Total amount owed by customers: 0";
            // 
            // dequeueBtn
            // 
            this.dequeueBtn.Location = new System.Drawing.Point(242, 65);
            this.dequeueBtn.Name = "dequeueBtn";
            this.dequeueBtn.Size = new System.Drawing.Size(100, 23);
            this.dequeueBtn.TabIndex = 11;
            this.dequeueBtn.Text = "Dequeue";
            this.dequeueBtn.UseVisualStyleBackColor = true;
            this.dequeueBtn.Click += new System.EventHandler(this.dequeueBtn_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(239, 109);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(144, 13);
            this.label7.TabIndex = 12;
            this.label7.Text = "Details of removed customer:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(415, 65);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(154, 13);
            this.label8.TabIndex = 13;
            this.label8.Text = "Details of most owed customer:";
            // 
            // removedCustomerLabel
            // 
            this.removedCustomerLabel.AutoSize = true;
            this.removedCustomerLabel.Location = new System.Drawing.Point(239, 147);
            this.removedCustomerLabel.Name = "removedCustomerLabel";
            this.removedCustomerLabel.Size = new System.Drawing.Size(131, 13);
            this.removedCustomerLabel.TabIndex = 14;
            this.removedCustomerLabel.Text = "No customer removed yet.";
            // 
            // mostOwedCustomerLabel
            // 
            this.mostOwedCustomerLabel.AutoSize = true;
            this.mostOwedCustomerLabel.Location = new System.Drawing.Point(415, 95);
            this.mostOwedCustomerLabel.Name = "mostOwedCustomerLabel";
            this.mostOwedCustomerLabel.Size = new System.Drawing.Size(125, 13);
            this.mostOwedCustomerLabel.TabIndex = 15;
            this.mostOwedCustomerLabel.Text = "No customers added yet.";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 576);
            this.Controls.Add(this.mostOwedCustomerLabel);
            this.Controls.Add(this.removedCustomerLabel);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.dequeueBtn);
            this.Controls.Add(this.totalOwedLabel);
            this.Controls.Add(this.noOfCustomersLabel);
            this.Controls.Add(this.enqueueBtn);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.amountOwedInput);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.addressInput);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.ageInput);
            this.Controls.Add(this.nameLabel);
            this.Controls.Add(this.nameInput);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox nameInput;
        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox ageInput;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox addressInput;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox amountOwedInput;
        private System.Windows.Forms.Button enqueueBtn;
        private System.Windows.Forms.Label noOfCustomersLabel;
        private System.Windows.Forms.Label totalOwedLabel;
        private System.Windows.Forms.Button dequeueBtn;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label removedCustomerLabel;
        private System.Windows.Forms.Label mostOwedCustomerLabel;
    }
}

