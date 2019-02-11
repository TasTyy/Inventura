using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Items;

namespace Inventura
{
    public partial class dodajItems : Form
    {
        public dodajItems()
        {
            InitializeComponent();
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            string itemID = textBox1.Text;
            string itemName = textBox2.Text;
            double price;
            Double.TryParse(textBox3.Text, out price);

            if (comboBox1.SelectedIndex == 0)
            {
                double weight;
                Double.TryParse(textBox4.Text, out weight);

                HardwareItem hardwareItem = new HardwareItem(itemID, itemName, price, weight);

                ItemsDatabase db = new ItemsDatabase();
                db.SaveItemHardware(hardwareItem);

                MessageBox.Show("Izdelek dodan!");

                textBox1.Text = "";
                textBox2.Text = "";
                textBox3.Text = "";
                textBox4.Text = "";
            }
            else if (comboBox1.SelectedIndex == 1)
            {
                double weight;
                int noOfCores;
                int amountOfRAM;
                int hddSize;
                Double.TryParse(textBox10.Text, out weight);
                Int32.TryParse(textBox9.Text, out noOfCores);
                Int32.TryParse(textBox12.Text, out amountOfRAM);
                Int32.TryParse(textBox11.Text, out hddSize);

                Computer computer = new Computer(itemID, itemName, price, weight, noOfCores, amountOfRAM, hddSize);

                ItemsDatabase db = new ItemsDatabase();
                db.SaveItemComputer(computer);

                MessageBox.Show("Izdelek dodan!");

                textBox1.Text = "";
                textBox2.Text = "";
                textBox3.Text = "";
                textBox10.Text = "";
                textBox9.Text = "";
                textBox11.Text = "";
                textBox12.Text = "";
            }
            else if (comboBox1.SelectedIndex == 2)
            {
                double weight;
                string resolution = textBox13.Text;
                string monitorType = textBox7.Text;
                Double.TryParse(textBox8.Text, out weight);                

                Monitor monitor = new Monitor(itemID, itemName, price, weight, resolution, monitorType);

                ItemsDatabase db = new ItemsDatabase();
                db.SaveItemMonitor(monitor);

                MessageBox.Show("Izdelek dodan!");

                textBox1.Text = "";
                textBox2.Text = "";
                textBox3.Text = "";
                textBox8.Text = "";
                textBox13.Text = "";
                textBox7.Text = "";
            }
            else if (comboBox1.SelectedIndex == 3)
            {
                string licenceKey = textBox5.Text;
                double sizeInMB;
                Double.TryParse(textBox6.Text, out sizeInMB);

                SoftwareItem softwareItem = new SoftwareItem(itemID, itemName, price, licenceKey, sizeInMB);

                ItemsDatabase db = new ItemsDatabase();
                db.SaveItemSoftware(softwareItem);

                MessageBox.Show("Izdelek dodan!");

                textBox1.Text = "";
                textBox2.Text = "";
                textBox3.Text = "";
                textBox5.Text = "";
                textBox6.Text = "";
            }
        }

        private void dodajItems_Load(object sender, EventArgs e)
        {
            groupBox1.Enabled = true;
            groupBox2.Enabled = false;
            groupBox3.Enabled = false;
            groupBox4.Enabled = false;
            groupBox5.Enabled = false;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex == 0)
            {
                groupBox2.Enabled = true;
                groupBox3.Enabled = false;
                groupBox4.Enabled = false;
                groupBox5.Enabled = false;
            }
            else if (comboBox1.SelectedIndex == 1)
            {
                groupBox2.Enabled = false;
                groupBox3.Enabled = true;
                groupBox4.Enabled = false;
                groupBox5.Enabled = false;
            }
            else if (comboBox1.SelectedIndex == 2)
            {
                groupBox2.Enabled = false;
                groupBox3.Enabled = false;
                groupBox4.Enabled = true;
                groupBox5.Enabled = false;
            }
            else if (comboBox1.SelectedIndex == 3)
            {
                groupBox2.Enabled = false;
                groupBox3.Enabled = false;
                groupBox4.Enabled = false;
                groupBox5.Enabled = true;
            }
        }
    }
}
