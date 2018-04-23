Imports Microsoft.VisualBasic
Imports System
Imports System.Data
Imports System.Windows.Forms
Imports DevExpress.Spreadsheet
Imports System.Collections.Generic

Namespace WindowsFormsApplication1
	Partial Public Class Form1
		Inherits Form
		Public Sub New()
			InitializeComponent()
		End Sub

		Private Sub button1_Click(ByVal sender As Object, ByVal e As EventArgs) Handles button1.Click
			spreadsheetControl1.Document.BeginUpdate()
			Try
				Dim worksheet As Worksheet = spreadsheetControl1.Document.Worksheets(0)
				worksheet.DeleteCells(worksheet.Cells, DeleteMode.ShiftCellsLeft)
				ImportDataTable()
				CreateTable()
			Finally
				spreadsheetControl1.Document.EndUpdate()
			End Try
		End Sub

		Private Sub button2_Click(ByVal sender As Object, ByVal e As EventArgs) Handles button2.Click
			spreadsheetControl1.Document.BeginUpdate()
			Try
				Dim worksheet As Worksheet = spreadsheetControl1.Document.Worksheets(0)
				worksheet.Clear(worksheet.GetUsedRange())
				worksheet.Cells("A1").ColumnWidthInCharacters = 35
				worksheet.Cells("A1").Value = "Import an array horizontally:"
				worksheet.Cells("A3").Value = "Import a two-dimensional array:"
				ImportArrays()
			Finally
				spreadsheetControl1.Document.EndUpdate()
			End Try
		End Sub

		Private Sub button3_Click(ByVal sender As Object, ByVal e As EventArgs) Handles button3.Click
			spreadsheetControl1.Document.BeginUpdate()
			Try
				Dim worksheet As Worksheet = spreadsheetControl1.Document.Worksheets(0)
				worksheet.Clear(worksheet.GetUsedRange())
				worksheet.Cells("A1").ColumnWidthInCharacters = 35
				worksheet.Cells("A1").Value = "Import data from List vertically:"
				ImportList()
			Finally
				spreadsheetControl1.Document.EndUpdate()
			End Try
		End Sub

		#Region "#ImportDataTable"
		Private Sub ImportDataTable()

			Dim worksheet As Worksheet = spreadsheetControl1.Document.Worksheets(0)

			' Create a "Products" DataTable object with four columns.
			Dim sourceTable As New DataTable("Products")
			sourceTable.Columns.Add("Product", GetType(String))
			sourceTable.Columns.Add("Price", GetType(Single))
			sourceTable.Columns.Add("Quantity", GetType(Int32))
			sourceTable.Columns.Add("Discount", GetType(Single))

			sourceTable.Rows.Add("Chocolade", 5, 15, 0.03)
			sourceTable.Rows.Add("Konbu", 9, 55, 0.1)
			sourceTable.Rows.Add("Geitost", 15, 70, 0.07)

			' Import data from the data table into the worksheet and insert it, starting with the B2 cell.
			worksheet.Import(sourceTable, True, 1, 1)
		End Sub
		#End Region ' #ImportDataTable

		#Region "#CreateTable"
		Private Sub CreateTable()

			Dim worksheet As Worksheet = spreadsheetControl1.Document.Worksheets(0)

			' Insert a table in the worksheet.
			Dim table As Table = worksheet.Tables.Add(worksheet("B2:F5"), True)

			' Format the table by applying a built-in table style.
			table.Style = spreadsheetControl1.Document.TableStyles(BuiltInTableStyleId.TableStyleMedium27)

			' Access table columns.
			Dim productColumn As TableColumn = table.Columns(0)
			Dim priceColumn As TableColumn = table.Columns(1)
			Dim quantityColumn As TableColumn = table.Columns(2)
			Dim discountColumn As TableColumn = table.Columns(3)
			Dim amountColumn As TableColumn = table.Columns(4)

			' Set the name of the last column. 
			amountColumn.Name = "Amount"

			' Set the formula to calculate the amount per product 
			' and display results in the "Amount" column.
			amountColumn.Formula = "=[Price]*[Quantity]*(1-[Discount])"

			' Display the total row in the table.
			table.ShowTotals = True

			' Set the label and function to display the sum of the "Amount" column.
			discountColumn.TotalRowLabel = "Total:"
			amountColumn.TotalRowFunction = TotalRowFunction.Sum

			' Specify the number format for each column.
			priceColumn.DataRange.NumberFormat = "$#,##0.00"
			discountColumn.DataRange.NumberFormat = "0.0%"
			amountColumn.Range.NumberFormat = "$#,##0.00;$#,##0.00;"""";@"

			' Specify horizontal alignment for header and total rows of the table.
			table.HeaderRowRange.Alignment.Horizontal = SpreadsheetHorizontalAlignment.Center
			table.TotalRowRange.Alignment.Horizontal = SpreadsheetHorizontalAlignment.Center

			' Specify horizontal alignment to display data in all columns except the first one.
			For i As Integer = 1 To table.Columns.Count - 1
				table.Columns(i).DataRange.Alignment.Horizontal = SpreadsheetHorizontalAlignment.Center
			Next i

			' Set the width of table columns.
			table.Range.ColumnWidthInCharacters = 10
		End Sub
		#End Region ' #CreateTable

		#Region "#ImportArrays"
		Private Sub ImportArrays()

			Dim worksheet As Worksheet = spreadsheetControl1.Document.Worksheets(0)

			' Create an array containing string values.
			Dim array() As String = { "AAA", "BBB", "CCC", "DDD" }

			' Import the array into the worksheet and insert it horizontally, starting with the B1 cell.
			worksheet.Import(array, 0, 1, False)

			' Create a two-dimensional array containing string values.
			Dim names(,) As String = { {"Ann", "Edward", "Angela", "Alex"}, {"Rachel", "Bruce", "Barbara", "George"} }

			' Import the two-dimensional array into the worksheet and insert it, starting with the B3 cell.
			worksheet.Import(names, 2, 1)
		End Sub
		#End Region ' #ImportArrays

		#Region "#ImportList"
		Private Sub ImportList()

			Dim worksheet As Worksheet = spreadsheetControl1.Document.Worksheets(0)

			' Create a List object containing string values.
			Dim cities As New List(Of String)()
			cities.Add("New York")
			cities.Add("Rome")
			cities.Add("Beijing")
			cities.Add("Delhi")

			' Import the list into the worksheet and insert it vertically, starting with the B1 cell.
			worksheet.Import(cities, 0, 1, True)
		End Sub
		#End Region ' #ImportList
	End Class
End Namespace
