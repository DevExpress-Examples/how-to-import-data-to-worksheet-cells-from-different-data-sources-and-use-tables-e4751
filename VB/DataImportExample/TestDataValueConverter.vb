Imports System
Imports System.Collections.Generic
Imports System.Linq
Imports System.Text

Namespace DataImportExample
	#Region "#converter"
	Friend Class TestDataValueConverter
		Implements DevExpress.Spreadsheet.IDataValueConverter

		Public Function TryConvert(ByVal value As Object, ByVal columnIndex As Integer, <System.Runtime.InteropServices.Out()> ByRef result As DevExpress.Spreadsheet.CellValue) As Boolean Implements DevExpress.Spreadsheet.IDataValueConverter.TryConvert
			Dim strValue As String = TryCast(value, String)
			If strValue IsNot Nothing Then
				Dim str2int As Integer = Nothing
				Dim success As Boolean = Int32.TryParse(strValue, str2int)
				result = If(success, str2int, 0)
				Return True
			End If
			Dim valueType As Type = value.GetType()
			If valueType Is GetType(Integer) Then
				result = DirectCast(value, Integer)
			Else
				result = Nothing
			End If
			Return True
		End Function
	End Class
	#End Region ' #converter
End Namespace
