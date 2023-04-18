using CsvHelper.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace data_miner
{
    public class CsvRecord
    {
        public string driverHead { get; set; }
        public string driverLeftUpper { get; set; }
        public string driverRightUpper { get; set; }
        public string driverLeftLeg { get; set; }
        public string driverRightLeg { get; set; }
        public string driverChest { get; set; }

        public string passengerHead { get; set; }
        public string passengerLeftUpper { get; set; }
        public string passengerRightUpper { get; set; }
        public string passengerLeftLeg { get; set; }
        public string passengerRightLeg { get; set; }
        public string passengerChest { get; set; }
    }

    public class CsvMap : ClassMap<CsvRecord>
    {
        public CsvMap() 
        {
            Map(m => m.passengerHead).Name("YOLCU_KAFA");
            Map(m => m.passengerLeftUpper).Name("YOLCU_SOL_BALDIR");
            Map(m => m.passengerRightUpper).Name("YOLCU_SAG_BALDIR");
            Map(m => m.passengerLeftLeg).Name("YOLCU_SOL_BACAK");
            Map(m => m.passengerRightLeg).Name("YOLCU_SAG_BACAK");
            Map(m => m.passengerChest).Name("YOLCU_GOVDE");
            Map(m => m.driverHead).Name("SURUCU_KAFA");
            Map(m => m.driverLeftUpper).Name("SURUCU_SOL_BALDIR");
            Map(m => m.driverRightUpper).Name("SURUCU_SAG_BALDIR");
            Map(m => m.driverLeftLeg).Name("SURUCU_SOL_BACAK");
            Map(m => m.driverRightLeg).Name("SURUCU_SAG_BACAK");
            Map(m => m.driverChest).Name("SURUCU_GOVDE");
        } 

    }
}
