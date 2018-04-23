using System;
using System.Data;
using System.Windows.Forms;
using DevExpress.Spreadsheet;
using System.Collections.Generic;

namespace WindowsFormsApplication1 {
    public partial class Form1 : Form {
        IWorkbook workbook;
        public Form1() {
            InitializeComponent();
            workbook = spreadsheetControl1.Document;
        }

        private void button1_Click(object sender, EventArgs e) {
            workbook.BeginUpdate();
            try {
                Worksheet worksheet = workbook.Worksheets[0];
                worksheet.DeleteCells(worksheet.Cells, DeleteMode.ShiftCellsLeft);
                ImportDataTable(workbook);
                CreateTable(workbook);
            }
            finally {
                workbook.EndUpdate();
            }
        }

        private void button2_Click(object sender, EventArgs e) {
            workbook.BeginUpdate();
            try {
                Worksheet worksheet = workbook.Worksheets[0];
                worksheet.Clear(worksheet.GetUsedRange());
                worksheet.Cells["A1"].ColumnWidthInCharacters = 35;
                worksheet.Cells["A1"].Value = "Import an array horizontally:";
                worksheet.Cells["A3"].Value = "Import a two-dimensional array:";
                ImportArrays(workbook);
            }
            finally {
                workbook.EndUpdate();
            }   
        }

        private void button3_Click(object sender, EventArgs e) {
            workbook.BeginUpdate();
            try {
                Worksheet worksheet = workbook.Worksheets[0];
                worksheet.Clear(worksheet.GetUsedRange());
                worksheet.Cells["A1"].ColumnWidthInCharacters = 35;
                worksheet.Cells["A1"].Value = "Import data from List vertically:";
                ImportList(workbook);
            }
            finally {
                workbook.EndUpdate();
            }
        }

        #region #ImportDataTable
        void ImportDataTable(IWorkbook workbook) {

            Worksheet worksheet = workbook.Worksheets[0];

            // Create a "Products" DataTable object with four columns.
            DataTable sourceTable = new DataTable("Products");
            sourceTable.Columns.Add("Product", typeof(string));
            sourceTable.Columns.Add("Price", typeof(float));
            sourceTable.Columns.Add("Quantity", typeof(Int32));
            sourceTable.Columns.Add("Discount", typeof(float));

            sourceTable.Rows.Add("Chocolade", 5, 15, 0.03);
            sourceTable.Rows.Add("Konbu", 9, 55, 0.1);
            sourceTable.Rows.Add("Geitost", 15, 70, 0.07);

            // Import data from the data table into the worksheet and insert it, starting with the B2 cell.
            worksheet.Import(sourceTable, true, 1, 1);
        }
        #endregion #ImportDataTable

        #region #CreateTable
        void CreateTable(IWorkbook workbook) {

            Worksheet worksheet = workbook.Worksheets[0];

            // Insert a table in the worksheet.
            Table table = worksheet.Tables.Add(worksheet["B2:F5"], true);

            // Format the table by applying a built-in table style.
            table.Style = workbook.TableStyles[BuiltInTableStyleId.TableStyleMedium27];

            // Access table columns.
            TableColumn productColumn = table.Columns[0];
            TableColumn priceColumn = table.Columns[1];
            TableColumn quantityColumn = table.Columns[2];
            TableColumn discountColumn = table.Columns[3];
            TableColumn amountColumn = table.Columns[4];

            // Set the name of the last column. 
            amountColumn.Name = "Amount";

            // Set the formula to calculate the amount per product 
            // and display results in the "Amount" column.
            amountColumn.Formula = "=[Price]*[Quantity]*(1-[Discount])";

            // Display the total row in the table.
            table.ShowTotals = true;

            // Set the label and function to display the sum of the "Amount" column.
            discountColumn.TotalRowLabel = "Total:";
            amountColumn.TotalRowFunction = TotalRowFunction.Sum;

            // Specify the number format for each column.
            priceColumn.DataRange.NumberFormat = "$#,##0.00";
            discountColumn.DataRange.NumberFormat = "0.0%";
            amountColumn.Range.NumberFormat = "$#,##0.00;$#,##0.00;\"\";@";

            // Specify horizontal alignment for header and total rows of the table.
            table.HeaderRowRange.Alignment.Horizontal = SpreadsheetHorizontalAlignment.Center;
            table.TotalRowRange.Alignment.Horizontal = SpreadsheetHorizontalAlignment.Center;

            // Specify horizontal alignment to display data in all columns except the first one.
            for (int i = 1; i < table.Columns.Count; i++) {
                table.Columns[i].DataRange.Alignment.Horizontal = SpreadsheetHorizontalAlignment.Center;
            }

            // Set the width of table columns.
            table.Range.ColumnWidthInCharacters = 10;
        }
        #endregion #CreateTable

        #region #ImportArrays
        void ImportArrays(IWorkbook workbook) {

            Worksheet worksheet = workbook.Worksheets[0];

            // Create an array containing string values.
            string[] array = new string[] { "AAA", "BBB", "CCC", "DDD" };

            // Import the array into the worksheet and insert it horizontally, starting with the B1 cell.
            worksheet.Import(array, 0, 1, false);

            // Create a two-dimensional array containing string values.
            String[,] names = new String[2, 4]{
            {"Ann", "Edward", "Angela", "Alex"},
            {"Rachel", "Bruce", "Barbara", "George"}
                 };

            // Import the two-dimensional array into the worksheet and insert it, starting with the B3 cell.
            worksheet.Import(names, 2, 1);
        }
        #endregion #ImportArrays

        #region #ImportList
        void ImportList(IWorkbook workbook) {

            Worksheet worksheet = workbook.Worksheets[0];

            // Create a List object containing string values.
            List<string> cities = new List<string>();
            cities.Add("New York");
            cities.Add("Rome");
            cities.Add("Beijing");
            cities.Add("Delhi");

            // Import the list into the worksheet and insert it vertically, starting with the B1 cell.
            worksheet.Import(cities, 0, 1, true);
        }
        #endregion #ImportList
    }
}
