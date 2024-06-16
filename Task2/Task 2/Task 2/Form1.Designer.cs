namespace Task_2
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
            this.numberInput = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.addnumber = new System.Windows.Forms.Button();
            this.numOfItems = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.sortingResultLabel = new System.Windows.Forms.Label();
            this.preOrderBtn = new System.Windows.Forms.Button();
            this.inOrderBtn = new System.Windows.Forms.Button();
            this.postOrderBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // numberInput
            // 
            this.numberInput.Location = new System.Drawing.Point(69, 104);
            this.numberInput.Name = "numberInput";
            this.numberInput.Size = new System.Drawing.Size(100, 20);
            this.numberInput.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(69, 85);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(18, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "ID";
            // 
            // addnumber
            // 
            this.addnumber.Location = new System.Drawing.Point(69, 131);
            this.addnumber.Name = "addnumber";
            this.addnumber.Size = new System.Drawing.Size(100, 23);
            this.addnumber.TabIndex = 2;
            this.addnumber.Text = "Add";
            this.addnumber.UseVisualStyleBackColor = true;
            this.addnumber.Click += new System.EventHandler(this.addnumber_Click);
            // 
            // numOfItems
            // 
            this.numOfItems.AutoSize = true;
            this.numOfItems.Location = new System.Drawing.Point(69, 188);
            this.numOfItems.Name = "numOfItems";
            this.numOfItems.Size = new System.Drawing.Size(96, 13);
            this.numOfItems.TabIndex = 3;
            this.numOfItems.Text = "Number of Items: 0";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(400, 76);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Sorting result:";
            // 
            // sortingResultLabel
            // 
            this.sortingResultLabel.AutoSize = true;
            this.sortingResultLabel.Location = new System.Drawing.Point(400, 111);
            this.sortingResultLabel.Name = "sortingResultLabel";
            this.sortingResultLabel.Size = new System.Drawing.Size(73, 13);
            this.sortingResultLabel.TabIndex = 5;
            this.sortingResultLabel.Text = "Not sorted yet";
            // 
            // preOrderBtn
            // 
            this.preOrderBtn.Location = new System.Drawing.Point(265, 65);
            this.preOrderBtn.Name = "preOrderBtn";
            this.preOrderBtn.Size = new System.Drawing.Size(75, 23);
            this.preOrderBtn.TabIndex = 6;
            this.preOrderBtn.Text = "Pre Order";
            this.preOrderBtn.UseVisualStyleBackColor = true;
            this.preOrderBtn.Click += new System.EventHandler(this.preOrderBtn_Click);
            // 
            // inOrderBtn
            // 
            this.inOrderBtn.Location = new System.Drawing.Point(265, 111);
            this.inOrderBtn.Name = "inOrderBtn";
            this.inOrderBtn.Size = new System.Drawing.Size(75, 23);
            this.inOrderBtn.TabIndex = 7;
            this.inOrderBtn.Text = "In Order";
            this.inOrderBtn.UseVisualStyleBackColor = true;
            this.inOrderBtn.Click += new System.EventHandler(this.inOrderBtn_Click);
            // 
            // postOrderBtn
            // 
            this.postOrderBtn.Location = new System.Drawing.Point(265, 161);
            this.postOrderBtn.Name = "postOrderBtn";
            this.postOrderBtn.Size = new System.Drawing.Size(75, 23);
            this.postOrderBtn.TabIndex = 8;
            this.postOrderBtn.Text = "Post Order";
            this.postOrderBtn.UseVisualStyleBackColor = true;
            this.postOrderBtn.Click += new System.EventHandler(this.postOrderBtn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.postOrderBtn);
            this.Controls.Add(this.inOrderBtn);
            this.Controls.Add(this.preOrderBtn);
            this.Controls.Add(this.sortingResultLabel);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.numOfItems);
            this.Controls.Add(this.addnumber);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.numberInput);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox numberInput;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button addnumber;
        private System.Windows.Forms.Label numOfItems;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label sortingResultLabel;
        private System.Windows.Forms.Button preOrderBtn;
        private System.Windows.Forms.Button inOrderBtn;
        private System.Windows.Forms.Button postOrderBtn;
    }
}

