namespace AddNums
{
    partial class frmAddition
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
            this.lblFirstNum = new System.Windows.Forms.Label();
            this.lblSecNum = new System.Windows.Forms.Label();
            this.lblSum = new System.Windows.Forms.Label();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.txtSum = new System.Windows.Forms.TextBox();
            this.txtSecNum = new System.Windows.Forms.TextBox();
            this.txtFirstNum = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lblFirstNum
            // 
            this.lblFirstNum.AutoSize = true;
            this.lblFirstNum.Location = new System.Drawing.Point(32, 20);
            this.lblFirstNum.Name = "lblFirstNum";
            this.lblFirstNum.Size = new System.Drawing.Size(66, 13);
            this.lblFirstNum.TabIndex = 0;
            this.lblFirstNum.Text = "First Number";
            // 
            // lblSecNum
            // 
            this.lblSecNum.AutoSize = true;
            this.lblSecNum.Location = new System.Drawing.Point(32, 77);
            this.lblSecNum.Name = "lblSecNum";
            this.lblSecNum.Size = new System.Drawing.Size(84, 13);
            this.lblSecNum.TabIndex = 1;
            this.lblSecNum.Text = "Second Number";
            this.lblSecNum.Click += new System.EventHandler(this.lblSecNum_Click);
            // 
            // lblSum
            // 
            this.lblSum.AutoSize = true;
            this.lblSum.Location = new System.Drawing.Point(32, 131);
            this.lblSum.Name = "lblSum";
            this.lblSum.Size = new System.Drawing.Size(28, 13);
            this.lblSum.TabIndex = 2;
            this.lblSum.Text = "Sum";
            this.lblSum.Click += new System.EventHandler(this.label3_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btnAdd.FlatAppearance.BorderSize = 2;
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdd.Location = new System.Drawing.Point(32, 187);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 40;
            this.btnAdd.Text = "&Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click_1);
            // 
            // btnCancel
            // 
            this.btnCancel.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btnCancel.FlatAppearance.BorderSize = 2;
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancel.Location = new System.Drawing.Point(175, 187);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 50;
            this.btnCancel.Text = "&Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // txtSum
            // 
            this.txtSum.Location = new System.Drawing.Point(159, 131);
            this.txtSum.Name = "txtSum";
            this.txtSum.Size = new System.Drawing.Size(100, 20);
            this.txtSum.TabIndex = 30;
            // 
            // txtSecNum
            // 
            this.txtSecNum.Location = new System.Drawing.Point(159, 77);
            this.txtSecNum.Name = "txtSecNum";
            this.txtSecNum.Size = new System.Drawing.Size(100, 20);
            this.txtSecNum.TabIndex = 24;
            // 
            // txtFirstNum
            // 
            this.txtFirstNum.Location = new System.Drawing.Point(159, 20);
            this.txtFirstNum.Name = "txtFirstNum";
            this.txtFirstNum.Size = new System.Drawing.Size(100, 20);
            this.txtFirstNum.TabIndex = 10;
            // 
            // frmAddition
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Info;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.txtFirstNum);
            this.Controls.Add(this.txtSecNum);
            this.Controls.Add(this.txtSum);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.lblSum);
            this.Controls.Add(this.lblSecNum);
            this.Controls.Add(this.lblFirstNum);
            this.Name = "frmAddition";
            this.Text = "Addition";
            this.Load += new System.EventHandler(this.frmAddition_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblFirstNum;
        private System.Windows.Forms.Label lblSecNum;
        private System.Windows.Forms.Label lblSum;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.TextBox txtSum;
        private System.Windows.Forms.TextBox txtSecNum;
        private System.Windows.Forms.TextBox txtFirstNum;
    }
}

