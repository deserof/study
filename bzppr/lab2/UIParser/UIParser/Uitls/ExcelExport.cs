using Newtonsoft.Json;
using NPOI.SS.UserModel;
using NPOI.XSSF.UserModel;
using System.Data;

namespace UIParser.Uitls
{
    public static class ExcelExporter<T>
    {
        public static void ExportDataToExcel(List<T> exportData, string fileName, string sheetName)
        {
            DataTable table = (DataTable)JsonConvert.DeserializeObject(JsonConvert.SerializeObject(exportData), typeof(DataTable));

            using (var fs = new FileStream($"{fileName}.xlsx", FileMode.Create, FileAccess.Write))
            {
                IWorkbook workbook = new XSSFWorkbook();
                ISheet excelSheet = workbook.CreateSheet($"{sheetName}");

                List<string> columns = new List<string>();
                IRow row = excelSheet.CreateRow(0);
                int columnIndex = 0;

                foreach (DataColumn column in table!.Columns)
                {
                    columns.Add(column.ColumnName);
                    row.CreateCell(columnIndex).SetCellValue(column.ColumnName);
                    columnIndex++;
                }

                int rowIndex = 1;

                foreach (DataRow dsrow in table.Rows)
                {
                    row = excelSheet.CreateRow(rowIndex);
                    int cellIndex = 0;

                    foreach (string col in columns)
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