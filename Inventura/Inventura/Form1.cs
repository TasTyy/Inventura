using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Inventura
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            displayItems di = new displayItems();
            di.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            dodajItems di = new dodajItems();
            di.Show();
        }
    }
}
