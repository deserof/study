using NPOI.SS.UserModel;
using NPOI.XSSF.UserModel;
using OpenQA.Selenium;
using System.Text;
using UIParser.Uitls;

namespace UIParser
{
    public class Program
    {
        private static int count = 0;

        static void Main(string[] args)
        {
            var phones = new List<Phone>();
            var prices = new List<Phones>();

            XSSFWorkbook hssfwb;
            using (FileStream file = new FileStream(@"Parsed Phones all.xlsx", FileMode.Open, FileAccess.Read))
            {
                hssfwb = new XSSFWorkbook(file);
            }

            ISheet sheet = hssfwb.GetSheet("phones");

            for (int row = 1; row <= 1439; row++)
            {
                Phone phone = new();

                if (sheet.GetRow(row) != null)
                {
                    phone.Name = sheet.GetRow(row).Cells[0].StringCellValue;
                    try
                    {
                        phone.Price = sheet.GetRow(row).Cells[1].NumericCellValue.ToString();
                    }
                    catch
                    {
                    }

                    phone.OS = sheet.GetRow(row).Cells[2].StringCellValue;
                    phone.ScreenTechnology = sheet.GetRow(row).Cells[3].StringCellValue;
                    try
                    {
                        phone.ScreenRefreshRate = sheet.GetRow(row).Cells[4].NumericCellValue.ToString();
                    }
                    catch
                    {
                    }

                    try
                    {
                        phone.NumberOfMatrixPoints = sheet.GetRow(row).Cells[5].NumericCellValue.ToString();
                    }
                    catch
                    {
                    }

                    phone.CameraSpecifications = sheet.GetRow(row).Cells[6].StringCellValue;
                    phone.MaximumVideoResolution = sheet.GetRow(row).Cells[7].StringCellValue;
                    try
                    {
                        phone.NumberOfSIMcards = sheet.GetRow(row).Cells[8].NumericCellValue.ToString();
                    }
                    catch
                    {
                    }

                    phone.ScreenResolution = sheet.GetRow(row).Cells[9].StringCellValue;
                    try
                    {
                        phone.RAM = sheet.GetRow(row).Cells[10].NumericCellValue.ToString();
                    }
                    catch
                    {
                    }

                    try
                    {
                        phone.Memory = sheet.GetRow(row).Cells[11].NumericCellValue.ToString();
                    }   
                    catch
                    {
                    }

                    phone.Processor = sheet.GetRow(row).Cells[12].StringCellValue;
                    try
                    {
                        phone.ProcessorClockSpeed = sheet.GetRow(row).Cells[13].NumericCellValue.ToString();
                    }
                    catch
                    {
                    }

                    try
                    {
                        phone.ProcessTechnology = sheet.GetRow(row).Cells[14].NumericCellValue.ToString();
                    }
                    catch
                    {
                    }

                    phone.Material = sheet.GetRow(row).Cells[15].StringCellValue;
                    phone.SimFormat = sheet.GetRow(row).Cells[16].StringCellValue;
                    phone.SensorScreen = sheet.GetRow(row).Cells[17].StringCellValue;
                    phone.ScratchProtection = sheet.GetRow(row).Cells[18].StringCellValue;
                    phone.GPS = sheet.GetRow(row).Cells[19].StringCellValue;
                    phone.LTE = sheet.GetRow(row).Cells[20].StringCellValue;
                    phone.G5 = sheet.GetRow(row).Cells[21].StringCellValue; 
                    try
                    {
                        phone.BatteryCapacity = sheet.GetRow(row).Cells[22].NumericCellValue.ToString();
                    }
                    catch
                    {
                    }

                    phones.Add(phone);
                    Console.WriteLine(count++);
                }
            }



            XSSFWorkbook hssfwb2;
            using (FileStream file = new FileStream(@"Parsed Phones price.xlsx", FileMode.Open, FileAccess.Read))
            {
                hssfwb2 = new XSSFWorkbook(file);
            }

            ISheet sheet2 = hssfwb2.GetSheet("phones");

            for (int row = 1; row <= 955; row++)
            {
                var phonepr = new Phones
                {
                    Name = sheet2.GetRow(row).Cells[0].StringCellValue,
                    Price = sheet2.GetRow(row).Cells[1].NumericCellValue.ToString()

                };

                prices.Add(phonepr);
                Console.WriteLine(count++);
            }

            for (int i = 0; i < prices.Count; i++)
            {
                for (int j = 0; j < phones.Count; j++)
                {
                    if (phones[j].Name == prices[i].Name)
                    {
                        phones[j].Price = prices[i].Price;
                    }
                }
            }

            ExcelExporter.ExportDataToExcel(phones, "fin", "phones");
        }

        class Phone
        {
            public string Name { get; set; }
            public string Price { get; set; }
            public string ScreenTechnology { get; set; }

            public string ScreenRefreshRate { get; set; }

            public string NumberOfMatrixPoints { get; set; }

            public string CameraSpecifications { get; set; }

            public string MaximumVideoResolution { get; set; }

            public string NumberOfSIMcards { get; set; }

            public string ScreenResolution { get; set; }

            public string RAM { get; set; }

            public string Memory { get; set; }
            public string OS { get; set; }
            public string ScratchProtection { get; set; }

            public string Processor { get; set; }

            public string ProcessorClockSpeed { get; set; }

            public string ProcessTechnology { get; set; }
            public string Material { get; set; }
            public string SimFormat { get; set; }
            public string SensorScreen { get; set; }
            public string GPS { get; set; }

            public string LTE { get; set; }
            public string G5 { get; set; }
            public string BatteryCapacity { get; set; }

        }
        class Phones
        {
            public string Name { get; set; }
            public string Price { get; set; }
        }
    }
}