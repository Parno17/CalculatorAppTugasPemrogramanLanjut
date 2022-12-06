namespace CalculatorApp
{
    partial class FormCalculator
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
            this.comboBoxOperasi = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtNilaiA = new System.Windows.Forms.TextBox();
            this.txtNilaiB = new System.Windows.Forms.TextBox();
            this.btnProses = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // comboBoxOperasi
            // 
            this.comboBoxOperasi.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxOperasi.FormattingEnabled = true;
            this.comboBoxOperasi.Location = new System.Drawing.Point(108, 18);
            this.comboBoxOperasi.Name = "comboBoxOperasi";
            this.comboBoxOperasi.Size = new System.Drawing.Size(190, 26);
            this.comboBoxOperasi.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(19, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Operasi";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(19, 61);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nilai A";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(19, 103);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 20);
            this.label3.TabIndex = 1;
            this.label3.Text = "Nilai B";
            // 
            // txtNilaiA
            // 
            this.txtNilaiA.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNilaiA.Location = new System.Drawing.Point(108, 59);
            this.txtNilaiA.Name = "txtNilaiA";
            this.txtNilaiA.Size = new System.Drawing.Size(190, 24);
            this.txtNilaiA.TabIndex = 2;
            // 
            // txtNilaiB
            // 
            this.txtNilaiB.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNilaiB.Location = new System.Drawing.Point(108, 101);
            this.txtNilaiB.Name = "txtNilaiB";
            this.txtNilaiB.Size = new System.Drawing.Size(190, 24);
            this.txtNilaiB.TabIndex = 2;
            // 
            // btnProses
            // 
            this.btnProses.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProses.Location = new System.Drawing.Point(193, 144);
            this.btnProses.Name = "btnProses";
            this.btnProses.Size = new System.Drawing.Size(105, 29);
            this.btnProses.TabIndex = 3;
            this.btnProses.Text = "Proses";
            this.btnProses.UseVisualStyleBackColor = true;
            this.btnProses.Click += new System.EventHandler(this.btnProses_Click);
            // 
            // FormCalculator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(375, 247);
            this.Controls.Add(this.btnProses);
            this.Controls.Add(this.txtNilaiB);
            this.Controls.Add(this.txtNilaiA);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBoxOperasi);
            this.Name = "FormCalculator";
            this.Text = "Calculator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBoxOperasi;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtNilaiA;
        private System.Windows.Forms.TextBox txtNilaiB;
        private System.Windows.Forms.Button btnProses;
    }
}

