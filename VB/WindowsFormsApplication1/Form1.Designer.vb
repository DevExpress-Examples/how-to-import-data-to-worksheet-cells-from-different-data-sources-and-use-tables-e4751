Imports Microsoft.VisualBasic
Imports System
Namespace WindowsFormsApplication1
	Partial Public Class Form1
		''' <summary>
		''' Required designer variable.
		''' </summary>
		Private components As System.ComponentModel.IContainer = Nothing

		''' <summary>
		''' Clean up any resources being used.
		''' </summary>
		''' <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		Protected Overrides Sub Dispose(ByVal disposing As Boolean)
			If disposing AndAlso (components IsNot Nothing) Then
				components.Dispose()
			End If
			MyBase.Dispose(disposing)
		End Sub

		#Region "Windows Form Designer generated code"

		''' <summary>
		''' Required method for Designer support - do not modify
		''' the contents of this method with the code editor.
		''' </summary>
		Private Sub InitializeComponent()
			Me.spreadsheetControl1 = New DevExpress.XtraSpreadsheet.SpreadsheetControl()
			Me.splitContainerControl1 = New DevExpress.XtraEditors.SplitContainerControl()
			Me.button1 = New System.Windows.Forms.Button()
			Me.button2 = New System.Windows.Forms.Button()
			Me.button3 = New System.Windows.Forms.Button()
			CType(Me.splitContainerControl1, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.splitContainerControl1.SuspendLayout()
			Me.SuspendLayout()
			' 
			' spreadsheetControl1
			' 
			Me.spreadsheetControl1.AllowDrop = True
			Me.spreadsheetControl1.Dock = System.Windows.Forms.DockStyle.Fill
			Me.spreadsheetControl1.Location = New System.Drawing.Point(0, 0)
			Me.spreadsheetControl1.Name = "spreadsheetControl1"
			Me.spreadsheetControl1.Options.Export.Csv.Culture = New System.Globalization.CultureInfo("")
			Me.spreadsheetControl1.Options.Export.Txt.Culture = New System.Globalization.CultureInfo("")
			Me.spreadsheetControl1.Options.Export.Txt.ValueSeparator = ","c
			Me.spreadsheetControl1.Options.Import.Csv.Culture = New System.Globalization.CultureInfo("")
			Me.spreadsheetControl1.Options.Import.ThrowExceptionOnInvalidDocument = False
			Me.spreadsheetControl1.Options.Import.Txt.Culture = New System.Globalization.CultureInfo("")
			Me.spreadsheetControl1.Size = New System.Drawing.Size(605, 476)
			Me.spreadsheetControl1.TabIndex = 0
			Me.spreadsheetControl1.Text = "spreadsheetControl1"
			' 
			' splitContainerControl1
			' 
			Me.splitContainerControl1.Dock = System.Windows.Forms.DockStyle.Fill
			Me.splitContainerControl1.Location = New System.Drawing.Point(0, 0)
			Me.splitContainerControl1.Name = "splitContainerControl1"
			Me.splitContainerControl1.Panel1.Controls.Add(Me.button3)
			Me.splitContainerControl1.Panel1.Controls.Add(Me.button2)
			Me.splitContainerControl1.Panel1.Controls.Add(Me.button1)
			Me.splitContainerControl1.Panel1.Text = "Panel1"
			Me.splitContainerControl1.Panel2.Controls.Add(Me.spreadsheetControl1)
			Me.splitContainerControl1.Panel2.Text = "Panel2"
			Me.splitContainerControl1.Size = New System.Drawing.Size(724, 476)
			Me.splitContainerControl1.SplitterPosition = 114
			Me.splitContainerControl1.TabIndex = 1
			Me.splitContainerControl1.Text = "splitContainerControl1"
			' 
			' button1
			' 
			Me.button1.Location = New System.Drawing.Point(3, 3)
			Me.button1.Name = "button1"
			Me.button1.Size = New System.Drawing.Size(110, 26)
			Me.button1.TabIndex = 0
			Me.button1.Text = "Import DateTable"
			Me.button1.UseVisualStyleBackColor = True
'			Me.button1.Click += New System.EventHandler(Me.button1_Click);
			' 
			' button2
			' 
			Me.button2.Location = New System.Drawing.Point(3, 35)
			Me.button2.Name = "button2"
			Me.button2.Size = New System.Drawing.Size(110, 23)
			Me.button2.TabIndex = 1
			Me.button2.Text = "Import Arrays"
			Me.button2.UseVisualStyleBackColor = True
'			Me.button2.Click += New System.EventHandler(Me.button2_Click);
			' 
			' button3
			' 
			Me.button3.Location = New System.Drawing.Point(3, 64)
			Me.button3.Name = "button3"
			Me.button3.Size = New System.Drawing.Size(110, 23)
			Me.button3.TabIndex = 2
			Me.button3.Text = "Import List"
			Me.button3.UseVisualStyleBackColor = True
'			Me.button3.Click += New System.EventHandler(Me.button3_Click);
			' 
			' Form1
			' 
			Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
			Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
			Me.ClientSize = New System.Drawing.Size(724, 476)
			Me.Controls.Add(Me.splitContainerControl1)
			Me.Name = "Form1"
			Me.Text = "Form1"
			CType(Me.splitContainerControl1, System.ComponentModel.ISupportInitialize).EndInit()
			Me.splitContainerControl1.ResumeLayout(False)
			Me.ResumeLayout(False)

		End Sub

		#End Region

		Private spreadsheetControl1 As DevExpress.XtraSpreadsheet.SpreadsheetControl
		Private splitContainerControl1 As DevExpress.XtraEditors.SplitContainerControl
		Private WithEvents button1 As System.Windows.Forms.Button
		Private WithEvents button2 As System.Windows.Forms.Button
		Private WithEvents button3 As System.Windows.Forms.Button
	End Class
End Namespace

