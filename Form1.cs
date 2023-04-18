using HtmlAgilityPack;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using System.IO;
using CsvHelper;
using System.Globalization;
using CsvHelper.Configuration;

namespace data_miner
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        private void Form1_Load(object sender, EventArgs e)
        {
            button2.Enabled = false;
        }
        public List<CsvRecord> csvrecordlist = new List<CsvRecord>();

        private void button1_Click(object sender, EventArgs e)
        {
            var ct = 0;

            for (int i = 0; i < 114; i++)
            {
                var path = String.Format(Environment.CurrentDirectory  + "\\images\\{0}.png", i);               
                Bitmap btmap = new Bitmap(path);
                var driver_head = btmap.GetPixel(204, 20);
                var driver_chest = btmap.GetPixel(204, 74);
                var driver_leftupper = btmap.GetPixel(216, 105);
                var driver_rightupper = btmap.GetPixel(192, 107);
                var driver_leftleg = btmap.GetPixel(225, 126);
                var driver_rightleg = btmap.GetPixel(178, 126);
                var passenger_head = btmap.GetPixel(95, 23);
                var passenger_chest = btmap.GetPixel(94, 74);
                var passenger_leftupper = btmap.GetPixel(104, 107);
                var passenger_rightupper = btmap.GetPixel(83, 107);
                var passenger_leftleg = btmap.GetPixel(116, 126);
                var passenger_rightleg = btmap.GetPixel(73, 125);


                DriverPassengerTogether a = new DriverPassengerTogether();
                PassengerColorTogether b = new PassengerColorTogether();

                var csvRecord = new CsvRecord()
                {
                    driverHead = a.ifelseDriverHead(driver_head).ToString(),
                    driverChest = a.ifelseDriverChest(driver_chest).ToString(),
                    driverLeftLeg = a.ifelseDriverLeftLeg(driver_leftleg).ToString(),
                    driverRightLeg = a.ifelseDriverRightLeg(driver_rightleg).ToString(),
                    driverLeftUpper = a.ifelseDriverLeftUpper(driver_leftupper).ToString(),
                    driverRightUpper = a.ifelseDriverRightUpper(driver_rightupper).ToString(),
                    passengerChest = b.ifelsePassengerChest(passenger_chest).ToString(),
                    passengerHead = b.ifelsePassengerHead(passenger_head).ToString(),
                    passengerLeftLeg = b.ifelsePassengerLeftLeg(passenger_leftleg).ToString(),
                    passengerRightLeg = b.ifelsePassengerRightLeg(passenger_rightleg).ToString(),
                    passengerLeftUpper = b.ifelsePassengerLeftUpper(passenger_leftupper).ToString(),
                    passengerRightUpper = b.ifelsePassengerRightUpper(passenger_rightupper).ToString(),
                };
                csvrecordlist.Add(csvRecord);
                ct++;
            }

            for (int i = 114; i < 566; i++)
            {
                var pathdriver = String.Format(Environment.CurrentDirectory + "\\images\\{0}_driver.png", i);
                var pathpassenger = String.Format(Environment.CurrentDirectory + "\\images\\{0}_passenger.png", i);
                Bitmap btmap = new Bitmap(pathdriver);
                Bitmap btmap2 = new Bitmap(pathpassenger);
                var driver_head = btmap.GetPixel(52, 23);
                var driver_chest = btmap.GetPixel(52, 75);
                var driver_leftupper = btmap.GetPixel(68, 111);
                var driver_rightupper = btmap.GetPixel(42, 111);
                var driver_leftleg = btmap.GetPixel(80, 134);
                var driver_rightleg = btmap.GetPixel(28, 134);
                var passenger_head = btmap2.GetPixel(52, 21);
                var passenger_chest = btmap2.GetPixel(53, 75);
                var passenger_leftupper = btmap2.GetPixel(67, 111);
                var passenger_rightupper = btmap2.GetPixel(42, 111);
                var passenger_leftleg = btmap2.GetPixel(78, 133);
                var passenger_rightleg = btmap2.GetPixel(28, 133);
                
                DriverPassengerSingle dcs = new DriverPassengerSingle();
                PassengerColorSingle pcs = new PassengerColorSingle();
                var csvRecord = new CsvRecord()
                {
                    driverHead = dcs.ifelseDriverHead(driver_head).ToString(),
                    driverChest = dcs.ifelseDriverChest(driver_chest).ToString(),
                    driverLeftLeg = dcs.ifelseDriverLeftLeg(driver_leftleg).ToString(),
                    driverRightLeg = dcs.ifelseDriverRightLeg(driver_rightleg).ToString(),
                    driverLeftUpper = dcs.ifelseDriverLeftUpper(driver_leftupper).ToString(),
                    driverRightUpper = dcs.ifelseDriverRightUpper(driver_rightupper).ToString(),
                    passengerChest = pcs.ifelsePassengerChest(passenger_chest).ToString(),
                    passengerHead = pcs.ifelsePassengerHead(passenger_head).ToString(),
                    passengerLeftLeg = pcs.ifelsePassengerLeftLeg(passenger_leftleg).ToString(),
                    passengerRightLeg = pcs.ifelsePassengerRightLeg(passenger_rightleg).ToString(),
                    passengerLeftUpper = pcs.ifelsePassengerLeftUpper(passenger_leftupper).ToString(),
                    passengerRightUpper = pcs.ifelsePassengerRightUpper(passenger_rightupper).ToString(),
                };
                csvrecordlist.Add(csvRecord);
            }
            MessageBox.Show("DATA DONE!");
            button2.Enabled = true;
        }

        
 
     

        private void button2_Click(object sender, EventArgs e)
        {
            var csvConfig = new CsvConfiguration(CultureInfo.CurrentCulture)
            {
                HasHeaderRecord = true,
                Delimiter = ";",
                Encoding = Encoding.UTF8
            };

            using (var writer = new StreamWriter(Environment.CurrentDirectory + "\\data.csv"))
            using (var csv = new CsvWriter(writer, csvConfig))
            {
                csv.Context.RegisterClassMap<CsvMap>();

                csv.WriteRecords(csvrecordlist);
            }
            MessageBox.Show("EXCEL IS DONE!");
        }

    }
}

