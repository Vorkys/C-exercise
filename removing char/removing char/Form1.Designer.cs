
namespace removing_char
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
            this.baseWord = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.charDel = new System.Windows.Forms.TextBox();
            this.result = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // baseWord
            // 
            this.baseWord.Location = new System.Drawing.Point(12, 12);
            this.baseWord.Name = "baseWord";
            this.baseWord.Size = new System.Drawing.Size(162, 20);
            this.baseWord.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(180, 23);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "del char at ";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // charDel
            // 
            this.charDel.Location = new System.Drawing.Point(12, 38);
            this.charDel.Name = "charDel";
            this.charDel.Size = new System.Drawing.Size(162, 20);
            this.charDel.TabIndex = 2;
            // 
            // result
            // 
            this.result.Location = new System.Drawing.Point(12, 81);
            this.result.Name = "result";
            this.result.ReadOnly = true;
            this.result.Size = new System.Drawing.Size(243, 152);
            this.result.TabIndex = 3;
            this.result.Text = "";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(263, 244);
            this.Controls.Add(this.result);
            this.Controls.Add(this.charDel);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.baseWord);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox baseWord;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox charDel;
        private System.Windows.Forms.RichTextBox result;
    }
}

