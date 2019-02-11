using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Items
{
    public class Item
    {
        public string ItemID { get; set; }
        public string ItemName { get; set; }
        public double ItemPrice { get; set; }

        public Item(string itemid, string itemname, double itemprice)
        {
            ItemID = itemid;
            ItemName = itemname;
            ItemPrice = itemprice;
        }

        public override string ToString()
        {
            string stringToReturn;
            stringToReturn = ItemID + " " + ItemName + " " + ItemPrice;
            return stringToReturn;
        }
    }


    public class HardwareItem : Item
    {
        public double Weight { get; set; }

        public HardwareItem(string itemid, string itemname, double itemprice, double weight) : base(itemid, itemname, itemprice)
        {
            Weight = weight;
        }

        public override string ToString()
        {
            string toReturn = base.ToString();
            toReturn = toReturn + " " + Weight.ToString();
            return toReturn;
        }
    }

    public class SoftwareItem : Item
    {
        public string LicenceKey { get; set; }
        public double SizeInMB { get; set; }

        public SoftwareItem(string itemid, string itemname, double itemprice, string licencekey, double sizeinmb) : base(itemid, itemname, itemprice)
        {
            LicenceKey = licencekey;
            SizeInMB = sizeinmb;
        }

        public override string ToString()
        {
            string toReturn = base.ToString();
            toReturn = toReturn + " " + LicenceKey.ToString() + " " + SizeInMB.ToString();
            return toReturn;
        }
    }

    public class Computer : HardwareItem
    {
        public int NoOfCores { get; set; }
        public int AmountOfRAM { get; set; }
        public int HDDSize { get; set; }


        public Computer(string itemid, string itemname, double itemprice, double weight, int noOfCores, int amountOfRAM, int hddSize) : base(itemid, itemname, itemprice, weight)
        {
            NoOfCores = noOfCores;
            AmountOfRAM = amountOfRAM;
            HDDSize = hddSize;
        }

        public override string ToString()
        {
            string toReturn = base.ToString();
            toReturn = toReturn + " " + NoOfCores + " " + AmountOfRAM + " " + HDDSize;
            return toReturn;
        }
    }

    public class Monitor : HardwareItem
    {
        public string Resolution { get; set; }
        public string MonitorType { get; set; }

        public Monitor(string itemid, string itemname, double itemprice, double weight, string resolution, string monitorType) : base(itemid, itemname, itemprice, weight)
        {
            Resolution = resolution;
            MonitorType = monitorType;
        }

        public override string ToString()
        {
            string toReturn = base.ToString();
            toReturn = toReturn + " " + Resolution + " " + MonitorType;
            return toReturn;
        }
    }
}
