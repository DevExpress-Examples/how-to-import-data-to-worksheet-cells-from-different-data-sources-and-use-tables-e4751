Imports System
Imports System.Collections.Generic
Imports System.Linq
Imports System.Text

Namespace DataImportExample
	#Region "#testobject"
	Friend Class TestObject
		Public Sub New(ByVal intValue As Integer, ByVal value As String, ByVal boolValue As Boolean)
			Me.intValue_Renamed = intValue
			Me.Value = value
			Me.BoolValue = boolValue

		End Sub
		Public intValue_Renamed As Integer
		Private ReadOnly Property privateValue() As Integer
			Get
				Return 123
			End Get
		End Property
		Public ReadOnly Property IntValue() As Integer
			Get
				Return intValue_Renamed + privateValue - 123
			End Get
		End Property
		Public Property Value() As String
		Public Property BoolValue() As Boolean
		Default Public ReadOnly Property Item(ByVal index As Integer) As Integer
			Get
				Return index
			End Get
		End Property
	End Class
#End Region	' #testobject
End Namespace
