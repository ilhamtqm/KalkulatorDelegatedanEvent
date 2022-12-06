namespace KalkulatorDelegatedanEvent21113969
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
            this.HasilBox = new System.Windows.Forms.GroupBox();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.Btn_Hitung = new System.Windows.Forms.Button();
            this.HasilBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // HasilBox
            // 
            this.HasilBox.Controls.Add(this.listBox1);
            this.HasilBox.Location = new System.Drawing.Point(12, 30);
            this.HasilBox.Name = "HasilBox";
            this.HasilBox.Size = new System.Drawing.Size(582, 382);
            this.HasilBox.TabIndex = 0;
            this.HasilBox.TabStop = false;
            this.HasilBox.Text = "[ Hasil ]";
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 16;
            this.listBox1.Location = new System.Drawing.Point(6, 33);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(570, 340);
            this.listBox1.TabIndex = 0;
            // 
            // Btn_Hitung
            // 
            this.Btn_Hitung.Location = new System.Drawing.Point(261, 418);
            this.Btn_Hitung.Name = "Btn_Hitung";
            this.Btn_Hitung.Size = new System.Drawing.Size(75, 23);
            this.Btn_Hitung.TabIndex = 1;
            this.Btn_Hitung.Text = "Hitung";
            this.Btn_Hitung.UseVisualStyleBackColor = true;
            this.Btn_Hitung.Click += new System.EventHandler(this.Btn_Hitung_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(606, 450);
            this.Controls.Add(this.Btn_Hitung);
            this.Controls.Add(this.HasilBox);
            this.Name = "Form1";
            this.Text = "Form1";
            this.HasilBox.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox HasilBox;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button Btn_Hitung;
    }
}

