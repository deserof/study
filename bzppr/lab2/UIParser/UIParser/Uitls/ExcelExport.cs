using Newtonsoft.Json;
using NPOI.SS.UserModel;
using NPOI.XSSF.UserModel;
using System.Data;

namespace UIParser.Uitls
{
    public static class ExcelExporter
    {
        public static void ExportDataToExcel(dynamic exportData, string fileName, string sheetName)
        {
            var table = (DataTable)JsonConvert.DeserializeObject(JsonConvert.SerializeObject(exportData), typeof(DataTable));

            using (var fs = new FileStream($"..\\..\\..\\..\\{fileName}.xlsx", FileMode.Create, FileAccess.Write))
            {
                IWorkbook workbook = new XSSFWorkbook();
                var excelSheet = workbook.CreateSheet($"{sheetName}");

                var columns = new List<string>();
                var row = excelSheet.CreateRow(0);
                var columnIndex = 0;

                foreach (DataColumn column in table!.Columns)
                {
                    columns.Add(column.ColumnName);
                    row.CreateCell(columnIndex).SetCellValue(column.ColumnName);
                    columnIndex++;
                }

                var rowIndex = 1;

                foreach (DataRow dsrow in table.Rows)
                {
                    row = excelSheet.CreateRow(rowIndex);
                    var cellIndex = 0;

                    foreach (var col in columns)
                    {
                        row.CreateCell(cellIndex).SetCellValue(dsrow[col].ToString());
                        cellIndex++;
                    }

                    rowIndex++;
                }

                workbook.Write(fs);
            }
        }
    }
}