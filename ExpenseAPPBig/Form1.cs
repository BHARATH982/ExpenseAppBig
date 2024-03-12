using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ExpenseAPPBig
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void filterPanel_Click(object sender, EventArgs e)
        {
            //categoryPanel.Location = new Point(categoryPanel.Location.X , categoryPanel.Location.Y + 265);
            //budgetPanel.Location = new Point(budgetPanel.Location.X , budgetPanel.Location.Y + 265);
            //filterItemPanel.Location = new Point(3, 122);
            filterItemPanel.Visible = true;

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            //categoryPanel.Location = new Point(categoryPanel.Location.X, categoryPanel.Location.Y + 50);
            //budgetPanel.Location = new Point(budgetPanel.Location.X, budgetPanel.Location.Y + 50);
           
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
