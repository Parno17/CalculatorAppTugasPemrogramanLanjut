namespace CalculatorApp
{
    partial class FormHasilPerhitungan
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
            this.groupBoxHasil = new System.Windows.Forms.GroupBox();
            this.listBox = new System.Windows.Forms.ListBox();
            this.btnHitung = new System.Windows.Forms.Button();
            this.groupBoxHasil.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBoxHasil
            // 
            this.groupBoxHasil.Controls.Add(this.btnHitung);
            this.groupBoxHasil.Controls.Add(this.listBox);
            this.groupBoxHasil.Location = new System.Drawing.Point(13, 13);
            this.groupBoxHasil.Name = "groupBoxHasil";
            this.groupBoxHasil.Size = new System.Drawing.Size(508, 426);
            this.groupBoxHasil.TabIndex = 0;
            this.groupBoxHasil.TabStop = false;
            this.groupBoxHasil.Text = "[ Hasil ]";
            // 
            // listBox
            // 
            this.listBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBox.FormattingEnabled = true;
            this.listBox.ItemHeight = 18;
            this.listBox.Location = new System.Drawing.Point(6, 21);
            this.listBox.Name = "listBox";
            this.listBox.Size = new System.Drawing.Size(496, 364);
            this.listBox.TabIndex = 0;
            // 
            // btnHitung
            // 
            this.btnHitung.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHitung.Location = new System.Drawing.Point(6, 392);
            this.btnHitung.Name = "btnHitung";
            this.btnHitung.Size = new System.Drawing.Size(496, 28);
            this.btnHitung.TabIndex = 1;
            this.btnHitung.Text = "Hitung";
            this.btnHitung.UseVisualStyleBackColor = true;
            this.btnHitung.Click += new System.EventHandler(this.btnHitung_Click);
            // 
            // FormHasilPerhitungan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(532, 442);
            this.Controls.Add(this.groupBoxHasil);
            this.Name = "FormHasilPerhitungan";
            this.Text = " Hasil Perhitungan";
            this.groupBoxHasil.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxHasil;
        private System.Windows.Forms.Button btnHitung;
        private System.Windows.Forms.ListBox listBox;
    }
}