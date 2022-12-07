namespace WindowsFormsApp1
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
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.listBox2 = new System.Windows.Forms.ListBox();
            this.driveB1 = new System.Windows.Forms.ComboBox();
            this.driveB2 = new System.Windows.Forms.ComboBox();
            this.backBtn1 = new System.Windows.Forms.Button();
            this.forwardBtn1 = new System.Windows.Forms.Button();
            this.backBtn2 = new System.Windows.Forms.Button();
            this.forwardBtn2 = new System.Windows.Forms.Button();
            this.deleteBtn = new System.Windows.Forms.Button();
            this.copyBtn = new System.Windows.Forms.Button();
            this.moveBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 16;
            this.listBox1.Location = new System.Drawing.Point(146, 43);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(280, 532);
            this.listBox1.TabIndex = 1;
            // 
            // listBox2
            // 
            this.listBox2.FormattingEnabled = true;
            this.listBox2.ItemHeight = 16;
            this.listBox2.Location = new System.Drawing.Point(559, 43);
            this.listBox2.Name = "listBox2";
            this.listBox2.Size = new System.Drawing.Size(280, 532);
            this.listBox2.TabIndex = 2;
            // 
            // driveB1
            // 
            this.driveB1.FormattingEnabled = true;
            this.driveB1.Location = new System.Drawing.Point(146, 13);
            this.driveB1.Name = "driveB1";
            this.driveB1.Size = new System.Drawing.Size(94, 24);
            this.driveB1.TabIndex = 3;
            // 
            // driveB2
            // 
            this.driveB2.FormattingEnabled = true;
            this.driveB2.Location = new System.Drawing.Point(559, 12);
            this.driveB2.Name = "driveB2";
            this.driveB2.Size = new System.Drawing.Size(94, 24);
            this.driveB2.TabIndex = 4;
            // 
            // backBtn1
            // 
            this.backBtn1.Location = new System.Drawing.Point(268, 14);
            this.backBtn1.Name = "backBtn1";
            this.backBtn1.Size = new System.Drawing.Size(75, 23);
            this.backBtn1.TabIndex = 5;
            this.backBtn1.Text = "<<";
            this.backBtn1.UseVisualStyleBackColor = true;
            // 
            // forwardBtn1
            // 
            this.forwardBtn1.Location = new System.Drawing.Point(349, 14);
            this.forwardBtn1.Name = "forwardBtn1";
            this.forwardBtn1.Size = new System.Drawing.Size(75, 23);
            this.forwardBtn1.TabIndex = 6;
            this.forwardBtn1.Text = ">>";
            this.forwardBtn1.UseVisualStyleBackColor = true;
            // 
            // backBtn2
            // 
            this.backBtn2.Location = new System.Drawing.Point(683, 14);
            this.backBtn2.Name = "backBtn2";
            this.backBtn2.Size = new System.Drawing.Size(75, 23);
            this.backBtn2.TabIndex = 7;
            this.backBtn2.Text = "<<";
            this.backBtn2.UseVisualStyleBackColor = true;
            // 
            // forwardBtn2
            // 
            this.forwardBtn2.Location = new System.Drawing.Point(764, 14);
            this.forwardBtn2.Name = "forwardBtn2";
            this.forwardBtn2.Size = new System.Drawing.Size(75, 23);
            this.forwardBtn2.TabIndex = 8;
            this.forwardBtn2.Text = ">>";
            this.forwardBtn2.UseVisualStyleBackColor = true;
            // 
            // deleteBtn
            // 
            this.deleteBtn.Location = new System.Drawing.Point(456, 191);
            this.deleteBtn.Name = "deleteBtn";
            this.deleteBtn.Size = new System.Drawing.Size(75, 50);
            this.deleteBtn.TabIndex = 9;
            this.deleteBtn.Text = "DELETE";
            this.deleteBtn.UseVisualStyleBackColor = true;
            // 
            // copyBtn
            // 
            this.copyBtn.Location = new System.Drawing.Point(456, 264);
            this.copyBtn.Name = "copyBtn";
            this.copyBtn.Size = new System.Drawing.Size(75, 50);
            this.copyBtn.TabIndex = 10;
            this.copyBtn.Text = "COPY";
            this.copyBtn.UseVisualStyleBackColor = true;
            // 
            // moveBtn
            // 
            this.moveBtn.Location = new System.Drawing.Point(456, 339);
            this.moveBtn.Name = "moveBtn";
            this.moveBtn.Size = new System.Drawing.Size(75, 50);
            this.moveBtn.TabIndex = 11;
            this.moveBtn.Text = "MOVE";
            this.moveBtn.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1006, 603);
            this.Controls.Add(this.moveBtn);
            this.Controls.Add(this.copyBtn);
            this.Controls.Add(this.deleteBtn);
            this.Controls.Add(this.forwardBtn2);
            this.Controls.Add(this.backBtn2);
            this.Controls.Add(this.forwardBtn1);
            this.Controls.Add(this.backBtn1);
            this.Controls.Add(this.driveB2);
            this.Controls.Add(this.driveB1);
            this.Controls.Add(this.listBox2);
            this.Controls.Add(this.listBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.ListBox listBox2;
        private System.Windows.Forms.ComboBox driveB1;
        private System.Windows.Forms.ComboBox driveB2;
        private System.Windows.Forms.Button backBtn1;
        private System.Windows.Forms.Button forwardBtn1;
        private System.Windows.Forms.Button backBtn2;
        private System.Windows.Forms.Button forwardBtn2;
        private System.Windows.Forms.Button deleteBtn;
        private System.Windows.Forms.Button copyBtn;
        private System.Windows.Forms.Button moveBtn;
    }
}

