using OfficeOpenXml;
using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;

namespace WinForm.Common
{
    public static class ExcelHelper
    {
        /// <summary>
        /// 将worksheet转成datatable
        /// </summary>
        /// <param name="worksheet">待处理的worksheet</param>
        /// <returns>返回处理后的datatable</returns>
        public static DataTable WorksheetToTable(ExcelWorksheet worksheet)
        {
            //获取worksheet的行数
            int rows = worksheet.Dimension.End.Row;
            //获取worksheet的列数
            int cols = worksheet.Dimension.End.Column;

            DataTable dt = new DataTable(worksheet.Name);
            DataRow dr = null;
            int columnNum = 0;
            for (int i = 1; i <= rows; i++)
            {
                if (i > 1)
                {
                    dr = dt.Rows.Add();
                }
                if (i == 2)
                {
                    cols = columnNum;
                }
                for (int j = 1; j <= cols; j++)
                {
                    //默认将第一行设置为datatable的标题
                    if (i == 1)
                    {
                        var columnValue = worksheet.Cells[i, j].Value?.ToString();
                        if (!string.IsNullOrWhiteSpace(columnValue))
                        {
                            dt.Columns.Add(columnValue);
                            columnNum++;
                        }
                    }
                    else
                    {
                        var sl = worksheet.Cells[i, j].Style;
                        if (j == 9)
                        {
                            dr[j - 1] = worksheet.Cells[i, j].GetValue<DateTime>();
                        }
                        else
                        {
                            dr[j - 1] = worksheet.Cells[i, j].Value?.ToString();
                        }
                    }
                }
            }
            return dt;
        }


        public static void ExportExcel()
        {
            FileInfo newFile = new FileInfo(@"d:\test.xlsx");
            if (newFile.Exists)
            {
                newFile.Delete();
                newFile = new FileInfo(@"d:\test.xlsx");
            }
            using (ExcelPackage package = new ExcelPackage(newFile))
            {
                ExcelWorksheet worksheet = package.Workbook.Worksheets.Add("test");
                worksheet.Cells[1, 1].Value = "名称";
                worksheet.Cells[1, 2].Value = "价格";
                worksheet.Cells[1, 3].Value = "销量";

                worksheet.Cells[2, 1].Value = "大米";
                worksheet.Cells[2, 2].Value = 56;
                worksheet.Cells[2, 3].Value = 100;

                worksheet.Cells[3, 1].Value = "玉米";
                worksheet.Cells[3, 2].Value = 45;
                worksheet.Cells[3, 3].Value = 150;

                worksheet.Cells[4, 1].Value = "小米";
                worksheet.Cells[4, 2].Value = 38;
                worksheet.Cells[4, 3].Value = 130;

                worksheet.Cells[5, 1].Value = "糯米";
                worksheet.Cells[5, 2].Value = 22;
                worksheet.Cells[5, 3].Value = 200;

                package.Save();
            }
        }


        public static void ExportToExcel(List<string> columnList, DataTable source)
        {
            if (columnList != null && columnList.Any() && source != null && source.Rows.Count > 0)
            {
                ExcelPackage ep = new ExcelPackage();
                ExcelWorkbook workbook = ep.Workbook;
                ExcelWorksheet sheet = workbook.Worksheets.Add("信息表");
                for (int i = 0; i < columnList.Count; i++)
                {
                    sheet.Cells[1, i].Value = columnList[i];
                }
                for (int i = 0, h = 2; i < source.Rows.Count; i++)
                {
                    for (var j = 0; j < columnList.Count; j++)
                    {
                        sheet.Cells[h, j].Value = source.Rows[i][j];
                    }
                }
                FileInfo file = new FileInfo($"{Environment.CurrentDirectory}\\test.excel");
                ep.File = file;
                ep.Save();
            }
          
        }

    }
}
