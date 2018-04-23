Namespace DataImportExample
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
			Me.components = New System.ComponentModel.Container()
			Me.spreadsheetControl1 = New DevExpress.XtraSpreadsheet.SpreadsheetControl()
			Me.splitContainerControl1 = New DevExpress.XtraEditors.SplitContainerControl()
			Me.btnArrayList = New System.Windows.Forms.Button()
			Me.button7 = New System.Windows.Forms.Button()
			Me.button6 = New System.Windows.Forms.Button()
			Me.button5 = New System.Windows.Forms.Button()
			Me.button4 = New System.Windows.Forms.Button()
			Me.button3 = New System.Windows.Forms.Button()
			Me.button2 = New System.Windows.Forms.Button()
			Me.button1 = New System.Windows.Forms.Button()
			Me.splitterControl1 = New DevExpress.XtraEditors.SplitterControl()
			Me.splitContainerControl2 = New DevExpress.XtraEditors.SplitContainerControl()
			Me.spreadsheetNameBoxControl1 = New DevExpress.XtraSpreadsheet.SpreadsheetNameBoxControl()
			Me.spreadsheetFormulaBarControl1 = New DevExpress.XtraSpreadsheet.SpreadsheetFormulaBarControl()
			Me.spreadsheetDockManager1 = New DevExpress.XtraSpreadsheet.SpreadsheetDockManager(Me.components)
			DirectCast(Me.splitContainerControl1, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.splitContainerControl1.SuspendLayout()
			DirectCast(Me.splitContainerControl2, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.splitContainerControl2.SuspendLayout()
			DirectCast(Me.spreadsheetNameBoxControl1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
			DirectCast(Me.spreadsheetDockManager1, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.SuspendLayout()
			' 
			' spreadsheetControl1
			' 
			Me.spreadsheetControl1.Dock = System.Windows.Forms.DockStyle.Fill
			Me.spreadsheetControl1.Location = New System.Drawing.Point(0, 25)
			Me.spreadsheetControl1.Name = "spreadsheetControl1"
			Me.spreadsheetControl1.Options.Export.Csv.Culture = New System.Globalization.CultureInfo("")
			Me.spreadsheetControl1.Options.Export.Txt.Culture = New System.Globalization.CultureInfo("")
			Me.spreadsheetControl1.Options.Export.Txt.ValueSeparator = ","c
			Me.spreadsheetControl1.Options.Import.Csv.Culture = New System.Globalization.CultureInfo("")
			Me.spreadsheetControl1.Options.Import.Txt.Culture = New System.Globalization.CultureInfo("")
			Me.spreadsheetControl1.Size = New System.Drawing.Size(575, 451)
			Me.spreadsheetControl1.TabIndex = 0
			Me.spreadsheetControl1.Text = "spreadsheetControl1"
			' 
			' splitContainerControl1
			' 
			Me.splitContainerControl1.Dock = System.Windows.Forms.DockStyle.Fill
			Me.splitContainerControl1.Location = New System.Drawing.Point(0, 0)
			Me.splitContainerControl1.Name = "splitContainerControl1"
			Me.splitContainerControl1.Panel1.Controls.Add(Me.btnArrayList)
			Me.splitContainerControl1.Panel1.Controls.Add(Me.button7)
			Me.splitContainerControl1.Panel1.Controls.Add(Me.button6)
			Me.splitContainerControl1.Panel1.Controls.Add(Me.button5)
			Me.splitContainerControl1.Panel1.Controls.Add(Me.button4)
			Me.splitContainerControl1.Panel1.Controls.Add(Me.button3)
			Me.splitContainerControl1.Panel1.Controls.Add(Me.button2)
			Me.splitContainerControl1.Panel1.Controls.Add(Me.button1)
			Me.splitContainerControl1.Panel1.Text = "Panel1"
			Me.splitContainerControl1.Panel2.Controls.Add(Me.spreadsheetControl1)
			Me.splitContainerControl1.Panel2.Controls.Add(Me.splitterControl1)
			Me.splitContainerControl1.Panel2.Controls.Add(Me.splitContainerControl2)
			Me.splitContainerControl1.Panel2.Text = "Panel2"
			Me.splitContainerControl1.Size = New System.Drawing.Size(724, 476)
			Me.splitContainerControl1.SplitterPosition = 144
			Me.splitContainerControl1.TabIndex = 1
			Me.splitContainerControl1.Text = "splitContainerControl1"
			' 
			' btnArrayList
			' 
			Me.btnArrayList.Location = New System.Drawing.Point(3, 122)
			Me.btnArrayList.Name = "btnArrayList"
			Me.btnArrayList.Size = New System.Drawing.Size(134, 23)
			Me.btnArrayList.TabIndex = 7
			Me.btnArrayList.Text = "Import ArrayList"
			Me.btnArrayList.UseVisualStyleBackColor = True
'INSTANT VB NOTE: The following InitializeComponent event wireup was converted to a 'Handles' clause:
'ORIGINAL LINE: this.btnArrayList.Click += new System.EventHandler(this.btnArrayList_Click);
			' 
			' button7
			' 
			Me.button7.Location = New System.Drawing.Point(3, 209)
			Me.button7.Name = "button7"
			Me.button7.Size = New System.Drawing.Size(134, 23)
			Me.button7.TabIndex = 6
			Me.button7.Text = "Import Using Converter"
			Me.button7.UseVisualStyleBackColor = True
'INSTANT VB NOTE: The following InitializeComponent event wireup was converted to a 'Handles' clause:
'ORIGINAL LINE: this.button7.Click += new System.EventHandler(this.button7_Click);
			' 
			' button6
			' 
			Me.button6.Location = New System.Drawing.Point(3, 180)
			Me.button6.Name = "button6"
			Me.button6.Size = New System.Drawing.Size(134, 23)
			Me.button6.TabIndex = 5
			Me.button6.Text = "Import Specified Fields"
			Me.button6.UseVisualStyleBackColor = True
'INSTANT VB NOTE: The following InitializeComponent event wireup was converted to a 'Handles' clause:
'ORIGINAL LINE: this.button6.Click += new System.EventHandler(this.button6_Click);
			' 
			' button5
			' 
			Me.button5.Location = New System.Drawing.Point(3, 151)
			Me.button5.Name = "button5"
			Me.button5.Size = New System.Drawing.Size(134, 23)
			Me.button5.TabIndex = 4
			Me.button5.Text = "Import Using Options"
			Me.button5.UseVisualStyleBackColor = True
'INSTANT VB NOTE: The following InitializeComponent event wireup was converted to a 'Handles' clause:
'ORIGINAL LINE: this.button5.Click += new System.EventHandler(this.button5_Click);
			' 
			' button4
			' 
			Me.button4.Location = New System.Drawing.Point(3, 93)
			Me.button4.Name = "button4"
			Me.button4.Size = New System.Drawing.Size(134, 23)
			Me.button4.TabIndex = 3
			Me.button4.Text = "Import Object"
			Me.button4.UseVisualStyleBackColor = True
'INSTANT VB NOTE: The following InitializeComponent event wireup was converted to a 'Handles' clause:
'ORIGINAL LINE: this.button4.Click += new System.EventHandler(this.button4_Click);
			' 
			' button3
			' 
			Me.button3.Location = New System.Drawing.Point(3, 64)
			Me.button3.Name = "button3"
			Me.button3.Size = New System.Drawing.Size(134, 23)
			Me.button3.TabIndex = 2
			Me.button3.Text = "Import List"
			Me.button3.UseVisualStyleBackColor = True
'INSTANT VB NOTE: The following InitializeComponent event wireup was converted to a 'Handles' clause:
'ORIGINAL LINE: this.button3.Click += new System.EventHandler(this.button3_Click);
			' 
			' button2
			' 
			Me.button2.Location = New System.Drawing.Point(3, 35)
			Me.button2.Name = "button2"
			Me.button2.Size = New System.Drawing.Size(134, 23)
			Me.button2.TabIndex = 1
			Me.button2.Text = "Import Arrays"
			Me.button2.UseVisualStyleBackColor = True
'INSTANT VB NOTE: The following InitializeComponent event wireup was converted to a 'Handles' clause:
'ORIGINAL LINE: this.button2.Click += new System.EventHandler(this.button2_Click);
			' 
			' button1
			' 
			Me.button1.Location = New System.Drawing.Point(3, 3)
			Me.button1.Name = "button1"
			Me.button1.Size = New System.Drawing.Size(134, 26)
			Me.button1.TabIndex = 0
			Me.button1.Text = "Import DataTable"
			Me.button1.UseVisualStyleBackColor = True
'INSTANT VB NOTE: The following InitializeComponent event wireup was converted to a 'Handles' clause:
'ORIGINAL LINE: this.button1.Click += new System.EventHandler(this.button1_Click);
			' 
			' splitterControl1
			' 
			Me.splitterControl1.Dock = System.Windows.Forms.DockStyle.Top
			Me.splitterControl1.Location = New System.Drawing.Point(0, 20)
			Me.splitterControl1.MinSize = 20
			Me.splitterControl1.Name = "splitterControl1"
			Me.splitterControl1.Size = New System.Drawing.Size(575, 5)
			Me.splitterControl1.TabIndex = 1
			Me.splitterControl1.TabStop = False
			' 
			' splitContainerControl2
			' 
			Me.splitContainerControl2.Dock = System.Windows.Forms.DockStyle.Top
			Me.splitContainerControl2.Location = New System.Drawing.Point(0, 0)
			Me.splitContainerControl2.MinimumSize = New System.Drawing.Size(0, 20)
			Me.splitContainerControl2.Name = "splitContainerControl2"
			Me.splitContainerControl2.Panel1.Controls.Add(Me.spreadsheetNameBoxControl1)
			Me.splitContainerControl2.Panel2.Controls.Add(Me.spreadsheetFormulaBarControl1)
			Me.splitContainerControl2.Size = New System.Drawing.Size(575, 20)
			Me.splitContainerControl2.SplitterPosition = 145
			Me.splitContainerControl2.TabIndex = 2
			' 
			' spreadsheetNameBoxControl1
			' 
			Me.spreadsheetNameBoxControl1.Dock = System.Windows.Forms.DockStyle.Fill
			Me.spreadsheetNameBoxControl1.EditValue = "A1"
			Me.spreadsheetNameBoxControl1.Location = New System.Drawing.Point(0, 0)
			Me.spreadsheetNameBoxControl1.MinimumSize = New System.Drawing.Size(0, 20)
			Me.spreadsheetNameBoxControl1.Name = "spreadsheetNameBoxControl1"
			Me.spreadsheetNameBoxControl1.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() { New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
			Me.spreadsheetNameBoxControl1.Size = New System.Drawing.Size(145, 20)
			Me.spreadsheetNameBoxControl1.SpreadsheetControl = Me.spreadsheetControl1
			Me.spreadsheetNameBoxControl1.TabIndex = 0
			' 
			' spreadsheetFormulaBarControl1
			' 
			Me.spreadsheetFormulaBarControl1.Dock = System.Windows.Forms.DockStyle.Fill
			Me.spreadsheetFormulaBarControl1.Location = New System.Drawing.Point(0, 0)
			Me.spreadsheetFormulaBarControl1.MinimumSize = New System.Drawing.Size(0, 20)
			Me.spreadsheetFormulaBarControl1.Name = "spreadsheetFormulaBarControl1"
			Me.spreadsheetFormulaBarControl1.Size = New System.Drawing.Size(425, 20)
			Me.spreadsheetFormulaBarControl1.SpreadsheetControl = Me.spreadsheetControl1
			Me.spreadsheetFormulaBarControl1.TabIndex = 0
			' 
			' spreadsheetDockManager1
			' 
			Me.spreadsheetDockManager1.Form = Me
			Me.spreadsheetDockManager1.SpreadsheetControl = Me.spreadsheetControl1
			Me.spreadsheetDockManager1.TopZIndexControls.AddRange(New String() { "DevExpress.XtraBars.BarDockControl", "DevExpress.XtraBars.StandaloneBarDockControl", "System.Windows.Forms.StatusBar", "System.Windows.Forms.MenuStrip", "System.Windows.Forms.StatusStrip", "DevExpress.XtraBars.Ribbon.RibbonStatusBar", "DevExpress.XtraBars.Ribbon.RibbonControl", "DevExpress.XtraBars.Navigation.OfficeNavigationBar", "DevExpress.XtraBars.Navigation.TileNavPane"})
			' 
			' Form1
			' 
			Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
			Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
			Me.ClientSize = New System.Drawing.Size(724, 476)
			Me.Controls.Add(Me.splitContainerControl1)
			Me.Name = "Form1"
			Me.Text = "Form1"
			DirectCast(Me.splitContainerControl1, System.ComponentModel.ISupportInitialize).EndInit()
			Me.splitContainerControl1.ResumeLayout(False)
			DirectCast(Me.splitContainerControl2, System.ComponentModel.ISupportInitialize).EndInit()
			Me.splitContainerControl2.ResumeLayout(False)
			DirectCast(Me.spreadsheetNameBoxControl1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
			DirectCast(Me.spreadsheetDockManager1, System.ComponentModel.ISupportInitialize).EndInit()
			Me.ResumeLayout(False)

		End Sub

		#End Region

		Private spreadsheetControl1 As DevExpress.XtraSpreadsheet.SpreadsheetControl
		Private splitContainerControl1 As DevExpress.XtraEditors.SplitContainerControl
		Private WithEvents button1 As System.Windows.Forms.Button
		Private WithEvents button2 As System.Windows.Forms.Button
		Private WithEvents button3 As System.Windows.Forms.Button
		Private WithEvents button4 As System.Windows.Forms.Button
		Private WithEvents button5 As System.Windows.Forms.Button
		Private splitterControl1 As DevExpress.XtraEditors.SplitterControl
		Private splitContainerControl2 As DevExpress.XtraEditors.SplitContainerControl
		Private spreadsheetNameBoxControl1 As DevExpress.XtraSpreadsheet.SpreadsheetNameBoxControl
		Private spreadsheetFormulaBarControl1 As DevExpress.XtraSpreadsheet.SpreadsheetFormulaBarControl
		Private spreadsheetDockManager1 As DevExpress.XtraSpreadsheet.SpreadsheetDockManager
		Private WithEvents button6 As System.Windows.Forms.Button
		Private WithEvents button7 As System.Windows.Forms.Button
		Private WithEvents btnArrayList As System.Windows.Forms.Button
	End Class
End Namespace

