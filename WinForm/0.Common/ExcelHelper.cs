using OfficeOpenXml;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
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
                    //剩下的写入datatable
                    else
                    {

                        dr[j - 1] = worksheet.Cells[i, j].Value?.ToString();
                    }
                }
            }
            return dt;
        }

    }
}
