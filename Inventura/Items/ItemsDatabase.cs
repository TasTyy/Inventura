using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SQLite;

namespace Items
{
    public class ItemsDatabase
    {
        public string itemID;
        private SQLiteConnection con;

        public ItemsDatabase()
        {
            con = new SQLiteConnection(@"data source=Baza.db");
            con.Open();
        }

        public void SaveItemHardware(HardwareItem itemToSave)
        {
            using (SQLiteCommand com = new SQLiteCommand(con))
            {
                com.CommandText = "INSERT INTO Hardware (itemID, itemName, price, weight) VALUES ('" + itemToSave.ItemID + "', '" + itemToSave.ItemName + "', '" + itemToSave.ItemPrice + "', '" + itemToSave.Weight + "' );";

                com.ExecuteNonQuery();
                com.Dispose();
            }
        }

        public void SaveItemSoftware(SoftwareItem itemToSave)
        {
            using (SQLiteCommand com = new SQLiteCommand(con))
            {
                com.CommandText = "INSERT INTO Software (itemID, itemName, price, licenceKey, sizeInMB) VALUES ('" + itemToSave.ItemID + "', '" + itemToSave.ItemName + "', '" + itemToSave.ItemPrice + "', '" + itemToSave.LicenceKey + "', '" + itemToSave.SizeInMB + "');";

                com.ExecuteNonQuery();
                com.Dispose();
            }
        }

        public void SaveItemComputer(Computer itemToSave)
        {
            using (SQLiteCommand com = new SQLiteCommand(con))
            {
                com.CommandText = "INSERT INTO Computer (itemID, itemName, price, weight, noOfCores, amountOfRAM, hddSize) VALUES ('" + itemToSave.ItemID + "', '" + itemToSave.ItemName + "', '" + itemToSave.ItemPrice + "', '" + itemToSave.Weight + "', '" + itemToSave.NoOfCores + "', '" + itemToSave.AmountOfRAM + "', '" + itemToSave.HDDSize + "');";

                com.ExecuteNonQuery();
                com.Dispose();
            }
        }

        public void SaveItemMonitor(Monitor itemToSave)
        {
            using (SQLiteCommand com = new SQLiteCommand(con))
            {
                com.CommandText = "INSERT INTO Monitor (itemID, itemName, price, weight, resolution, monitorType) VALUES ('" + itemToSave.ItemID + "', '" + itemToSave.ItemName + "', '" + itemToSave.ItemPrice + "', '" + itemToSave.Weight + "', '" + itemToSave.Resolution + "', '" + itemToSave.MonitorType + "');";

                com.ExecuteNonQuery();
                com.Dispose();
            }
        }

        public void DeleteHardware(HardwareItem itemToDelete)
        {
            using (SQLiteCommand com = new SQLiteCommand(con))
            {
                com.CommandText = "DELETE FROM Hardware WHERE itemID = '" + itemToDelete.ItemID + "';";
                com.ExecuteNonQuery();
            }
        }

        public void DeleteSoftware(SoftwareItem itemToDelete)
        {
            using (SQLiteCommand com = new SQLiteCommand(con))
            {
                com.CommandText = "DELETE FROM Software WHERE itemID = '" + itemToDelete.ItemID + "';";
                com.ExecuteNonQuery();
            }
        }

        public void DeleteComputer(Computer itemToDelete)
        {
            using (SQLiteCommand com = new SQLiteCommand(con))
            {
                com.CommandText = "DELETE FROM Computer WHERE itemID = '" + itemToDelete.ItemID + "';";
                com.ExecuteNonQuery();
            }
        }

        public void DeleteMonitor(Monitor itemToDelete)
        {
            using (SQLiteCommand com = new SQLiteCommand(con))
            {
                com.CommandText = "DELETE FROM Monitor WHERE itemID = '" + itemToDelete.ItemID + "';";
                com.ExecuteNonQuery();
            }
        }

        public List<SoftwareItem> ReadSoftwareItems()
        {

            List<SoftwareItem> seznam = new List<SoftwareItem>();
            using (SQLiteCommand com = new SQLiteCommand(con))
            {
                com.CommandText = "SELECT * FROM Software";
                SQLiteDataReader reader = null;
                reader = com.ExecuteReader();
                while (reader.Read())
                {
                    SoftwareItem item = new SoftwareItem(Convert.ToString(reader["itemID"]), Convert.ToString(reader["itemName"]), Convert.ToDouble(reader["price"]), Convert.ToString(reader["licenceKey"]), Convert.ToDouble(reader["sizeInMB"]));
                    seznam.Add(item);
                }
            }

            return seznam;

        }

        public List<HardwareItem> ReadHardwareItems()
        {
            List<HardwareItem> seznam = new List<HardwareItem>();
            using (SQLiteCommand com = new SQLiteCommand(con))
            {
                com.CommandText = "SELECT * FROM Hardware";
                SQLiteDataReader reader = null;
                reader = com.ExecuteReader();
                while (reader.Read())
                {
                    HardwareItem item = new HardwareItem(Convert.ToString(reader["itemID"]), Convert.ToString(reader["itemName"]), Convert.ToDouble(reader["price"]), Convert.ToDouble(reader["weight"]));
                    seznam.Add(item);
                }
            }

            return seznam;
        }

        public List<Computer> ReadComputers()
        {

            List<Computer> seznam = new List<Computer>();
            using (SQLiteCommand com = new SQLiteCommand(con))
            {
                com.CommandText = "SELECT * FROM Computer";
                SQLiteDataReader reader = null;
                reader = com.ExecuteReader();
                while (reader.Read())
                {
                    Computer item = new Computer(Convert.ToString(reader["itemID"]), Convert.ToString(reader["itemName"]), Convert.ToDouble(reader["price"]), Convert.ToDouble(reader["weight"]), Convert.ToInt32(reader["noOfCores"]), Convert.ToInt32(reader["amountOfRAM"]), Convert.ToInt32(reader["hddSize"]));
                    seznam.Add(item);
                }
            }

            return seznam;

        }

        public List<Monitor> ReadMonitors()
        {

            List<Monitor> seznam = new List<Monitor>();
            using (SQLiteCommand com = new SQLiteCommand(con))
            {
                com.CommandText = "SELECT * FROM Monitor";
                SQLiteDataReader reader = null;
                reader = com.ExecuteReader();
                while (reader.Read())
                {
                    Monitor item = new Monitor(Convert.ToString(reader["itemID"]), Convert.ToString(reader["itemName"]), Convert.ToDouble(reader["price"]), Convert.ToDouble(reader["weight"]), Convert.ToString(reader["resolution"]), Convert.ToString(reader["monitorType"]));
                    seznam.Add(item);
                }
            }

            return seznam;

        }

        public void EditHardwareItem(HardwareItem itemToEdit)
        {
            using (SQLiteCommand com = new SQLiteCommand(con))
            {
                com.CommandText = "UPDATE Hardware SET itemName = '" + itemToEdit.ItemName + "', price = '" + itemToEdit.ItemPrice + "', weight = '" + itemToEdit.Weight + "' WHERE itemID = '" + itemToEdit.ItemID + "';";
                com.ExecuteNonQuery();
            }
        }

        public void EditSoftwareItem(SoftwareItem itemToEdit)
        {
            using (SQLiteCommand com = new SQLiteCommand(con))
            {
                com.CommandText = "UPDATE Software SET itemName = '" + itemToEdit.ItemName + "', price = '" + itemToEdit.ItemPrice + "', licenceKey = '" + itemToEdit.LicenceKey + "', sizeInMB = '" + itemToEdit.SizeInMB + "' WHERE itemID = '" + itemToEdit.ItemID + "';";
                com.ExecuteNonQuery();
            }
        }

        public void EditComputer(Computer itemToEdit)
        {
            using (SQLiteCommand com = new SQLiteCommand(con))
            {
                com.CommandText = "UPDATE Computer SET itemName = '" + itemToEdit.ItemName + "', price = '" + itemToEdit.ItemPrice + "', weight = '" + itemToEdit.Weight + "', noOfCores = '" + itemToEdit.NoOfCores + "', amountOfRAM = '" + itemToEdit.AmountOfRAM + "', hddSize = '" + itemToEdit.HDDSize + "' WHERE itemID = '" + itemToEdit.ItemID + "';";
                com.ExecuteNonQuery();
            }
        }

        public void EditMonitor(Monitor itemToEdit)
        {
            using (SQLiteCommand com = new SQLiteCommand(con))
            {
                com.CommandText = "UPDATE Monitor SET itemName = '" + itemToEdit.ItemName + "', price = '" + itemToEdit.ItemPrice + "', weight = '" + itemToEdit.Weight + "', resolution = '" + itemToEdit.Resolution + "', monitorType = '" + itemToEdit.MonitorType + "' WHERE itemID = '" + itemToEdit.ItemID + "';";
                com.ExecuteNonQuery();
            }
        }
    }
}
