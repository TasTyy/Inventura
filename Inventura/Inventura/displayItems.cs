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
    public partial class displayItems : Form
    {
        public displayItems()
        {
            InitializeComponent();
        }

        private void displayItems_Load(object sender, EventArgs e)
        {
            ItemsDatabase db = new ItemsDatabase();

            List<HardwareItem> hardwareItems = new List<HardwareItem>();
            List<Computer> computers = new List<Computer>();
            List<Monitor> monitors = new List<Monitor>();
            List<SoftwareItem> softwareItems = new List<SoftwareItem>();

            hardwareItems = db.ReadHardwareItems();
            hardwareDataGrid.DataSource = hardwareItems;

            computers = db.ReadComputers();
            computerDataGrid.DataSource = computers;

            monitors = db.ReadMonitors();
            monitorDataGrid.DataSource = monitors;

            softwareItems = db.ReadSoftwareItems();
            softwareDataGrid.DataSource = softwareItems;
        }

        private void hardwareDataGrid_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            ItemsDatabase db = new ItemsDatabase();

            var row = softwareDataGrid.CurrentCell.RowIndex;
            var column = softwareDataGrid.CurrentCell.ColumnIndex;

            double weight = Convert.ToDouble(hardwareDataGrid.Rows[row].Cells[0].Value);
            string itemID = hardwareDataGrid.Rows[row].Cells[1].Value.ToString();
            string itemName = hardwareDataGrid.Rows[row].Cells[2].Value.ToString();
            double price = Convert.ToDouble(hardwareDataGrid.Rows[row].Cells[3].Value);

            HardwareItem hardwareItem = new HardwareItem(itemID, itemName, price, weight);
            db.EditHardwareItem(hardwareItem);
        }

        private void computerDataGrid_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            ItemsDatabase db = new ItemsDatabase();

            var row = softwareDataGrid.CurrentCell.RowIndex;
            var column = softwareDataGrid.CurrentCell.ColumnIndex;

            int noOfCores = Convert.ToInt32(computerDataGrid.Rows[row].Cells[0].Value);
            int amountOfRAM = Convert.ToInt32(computerDataGrid.Rows[row].Cells[1].Value);
            int hddSize = Convert.ToInt32(computerDataGrid.Rows[row].Cells[2].Value);
            double weight = Convert.ToDouble(computerDataGrid.Rows[row].Cells[3].Value);
            string itemID = hardwareDataGrid.Rows[row].Cells[4].Value.ToString();
            string itemName = hardwareDataGrid.Rows[row].Cells[5].Value.ToString();
            double price = Convert.ToDouble(hardwareDataGrid.Rows[row].Cells[6].Value);

            Computer computer = new Computer(itemID, itemName, price, weight, noOfCores, amountOfRAM, hddSize);
            db.EditComputer(computer);
        }

        private void monitorDataGrid_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            ItemsDatabase db = new ItemsDatabase();

            var row = softwareDataGrid.CurrentCell.RowIndex;
            var column = softwareDataGrid.CurrentCell.ColumnIndex;

            string resolution = monitorDataGrid.Rows[row].Cells[0].Value.ToString();
            string monitorType = monitorDataGrid.Rows[row].Cells[1].Value.ToString();
            double weight = Convert.ToDouble(computerDataGrid.Rows[row].Cells[2].Value);
            string itemID = hardwareDataGrid.Rows[row].Cells[3].Value.ToString();
            string itemName = hardwareDataGrid.Rows[row].Cells[4].Value.ToString();
            double price = Convert.ToDouble(hardwareDataGrid.Rows[row].Cells[5].Value);

            Monitor monitor = new Monitor(itemID, itemName, price, weight, resolution, monitorType);
            db.EditMonitor(monitor);
        }

        private void softwareDataGrid_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            ItemsDatabase db = new ItemsDatabase();

            var row = softwareDataGrid.CurrentCell.RowIndex;
            var column = softwareDataGrid.CurrentCell.ColumnIndex;

            string licenceKey = softwareDataGrid.Rows[row].Cells[0].Value.ToString();
            double sizeInMB = Convert.ToDouble(softwareDataGrid.Rows[row].Cells[1].Value);
            string itemID = hardwareDataGrid.Rows[row].Cells[2].Value.ToString();
            string itemName = hardwareDataGrid.Rows[row].Cells[3].Value.ToString();
            double price = Convert.ToDouble(hardwareDataGrid.Rows[row].Cells[4].Value);

            SoftwareItem softwareItem = new SoftwareItem(itemID, itemName, price, licenceKey, sizeInMB);
            db.EditSoftwareItem(softwareItem);
        }

        private void delHardware_Click(object sender, EventArgs e)
        {
            ItemsDatabase db = new ItemsDatabase();

            var row = softwareDataGrid.CurrentCell.RowIndex;
            string itemID = hardwareDataGrid.Rows[row].Cells[1].Value.ToString();

            HardwareItem hardwareItem = new HardwareItem(itemID, "", 0.0, 0.0);
            db.DeleteHardware(hardwareItem);
            MessageBox.Show("Izdelek izbrisan!");

            List<HardwareItem> hardwareItems = new List<HardwareItem>();
            hardwareItems = db.ReadHardwareItems();
            hardwareDataGrid.DataSource = hardwareItems;
        }

        private void delComputer_Click(object sender, EventArgs e)
        {
            ItemsDatabase db = new ItemsDatabase();

            var row = softwareDataGrid.CurrentCell.RowIndex;
            string itemID = hardwareDataGrid.Rows[row].Cells[4].Value.ToString();

            Computer computer = new Computer(itemID, "", 0.0, 0.0, 0, 0, 0);
            db.DeleteComputer(computer);
            MessageBox.Show("Izdelek izbrisan!");

            List<Computer> computers = new List<Computer>();
            computers = db.ReadComputers();
            computerDataGrid.DataSource = computers;
        }

        private void delMonitor_Click(object sender, EventArgs e)
        {
            ItemsDatabase db = new ItemsDatabase();

            var row = softwareDataGrid.CurrentCell.RowIndex;
            string itemID = hardwareDataGrid.Rows[row].Cells[3].Value.ToString();

            Monitor monitor = new Monitor(itemID, "", 0.0, 0.0, "", "");
            db.DeleteMonitor(monitor);
            MessageBox.Show("Izdelek izbrisan!");

            List<Monitor> monitors = new List<Monitor>();
            monitors = db.ReadMonitors();
            monitorDataGrid.DataSource = monitors;
        }

        private void delSoftware_Click(object sender, EventArgs e)
        {
            ItemsDatabase db = new ItemsDatabase();

            var row = softwareDataGrid.CurrentCell.RowIndex;
            string itemID = hardwareDataGrid.Rows[row].Cells[2].Value.ToString();

            SoftwareItem softwareItem = new SoftwareItem(itemID, "", 0.0, "", 0.0);
            db.DeleteSoftware(softwareItem);
            MessageBox.Show("Izdelek izbrisan!");

            List<SoftwareItem> softwareItems = new List<SoftwareItem>();
            softwareItems = db.ReadSoftwareItems();
            softwareDataGrid.DataSource = softwareItems;
        }
    }
}
