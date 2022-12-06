using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static CalculatorApp.FormCalculator;

namespace CalculatorApp
{
    public partial class FormHasilPerhitungan : Form
    {
        public FormHasilPerhitungan()
        {
            InitializeComponent();
        }

        private void Proses(int nilaiA, int nilaiB, string operasi, string operasiLabel, float hasil)
        {
            listBox.Items.Add(
                String.Format($"Hasil {operasiLabel} dari {nilaiA} {operasi} {nilaiB} = ") +
                String.Format(hasil % 1 == 0 ? "{0:0}" : "{0:0.00}", hasil)
            );
        }

        private void btnHitung_Click(object sender, EventArgs e)
        {
            FormCalculator formCalculator = new FormCalculator();
            formCalculator.prosesEvent += Proses;
            formCalculator.ShowDialog();
        }
    }
}
