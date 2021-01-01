using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FinanceCal
{
    public enum Tax { Free, Premium, Normal };
    public enum Rate { Simple, Compound };

    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

            FinancePanel.Dock = DockStyle.Fill;
            TPanel.Hide();
        }

        private void FinanceMenu_Click(object sender, EventArgs e)
        {
            TPanel.Hide();
            FinancePanel.Show();
            FinancePanel.Dock = DockStyle.Fill;
        }

        private void NonMenu_Click(object sender, EventArgs e)
        {
            TPanel.Show();
            TPanel.Dock = DockStyle.Fill;
        }
    }
}
