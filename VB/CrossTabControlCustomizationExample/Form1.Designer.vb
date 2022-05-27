Namespace CrossTabControlCustomizationExample
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
			Dim itemTemplateBase1 As New DevExpress.XtraEditors.TableLayout.ItemTemplateBase()
			Dim tableColumnDefinition1 As New DevExpress.XtraEditors.TableLayout.TableColumnDefinition()
			Dim templatedItemElement1 As New DevExpress.XtraEditors.TableLayout.TemplatedItemElement()
			Dim templatedItemElement2 As New DevExpress.XtraEditors.TableLayout.TemplatedItemElement()
			Dim tableRowDefinition1 As New DevExpress.XtraEditors.TableLayout.TableRowDefinition()
			Dim tableRowDefinition2 As New DevExpress.XtraEditors.TableLayout.TableRowDefinition()
			Me.htmlTemplate1 = New DevExpress.Utils.Html.HtmlTemplate()
			Me.btnDesign = New DevExpress.XtraEditors.SimpleButton()
			Me.listBoxControl1 = New DevExpress.XtraEditors.ListBoxControl()
			Me.reportDescriptionDataBindingSource = New System.Windows.Forms.BindingSource(Me.components)
			DirectCast(Me.listBoxControl1, System.ComponentModel.ISupportInitialize).BeginInit()
			DirectCast(Me.reportDescriptionDataBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.SuspendLayout()
			' 
			' htmlTemplate1
			' 
			Me.htmlTemplate1.Name = "htmlTemplate1"
			' 
			' btnDesign
			' 
			Me.btnDesign.Location = New System.Drawing.Point(1035, 708)
			Me.btnDesign.Name = "btnDesign"
			Me.btnDesign.Size = New System.Drawing.Size(151, 30)
			Me.btnDesign.TabIndex = 1
			Me.btnDesign.Text = "Design"
'INSTANT VB NOTE: The following InitializeComponent event wireup was converted to a 'Handles' clause:
'ORIGINAL LINE: this.btnDesign.Click += new System.EventHandler(this.btnDesign_Click);
			' 
			' listBoxControl1
			' 
			Me.listBoxControl1.DataSource = GetType(CrossTabControlCustomizationExample.DataItem)
			Me.listBoxControl1.DisplayMember = "DisplayName"
			Me.listBoxControl1.HtmlTemplates.AddRange(New DevExpress.Utils.Html.HtmlTemplate() { Me.htmlTemplate1})
			Me.listBoxControl1.ItemAutoHeight = True
			Me.listBoxControl1.ItemHeight = 120
			Me.listBoxControl1.Location = New System.Drawing.Point(12, 12)
			Me.listBoxControl1.Name = "listBoxControl1"
			Me.listBoxControl1.Size = New System.Drawing.Size(1174, 654)
			Me.listBoxControl1.TabIndex = 0
			tableColumnDefinition1.Length.Value = 8R
			tableColumnDefinition1.PaddingLeft = 10
			itemTemplateBase1.Columns.Add(tableColumnDefinition1)
			templatedItemElement1.Appearance.Normal.Font = New System.Drawing.Font("Tahoma", 11F, System.Drawing.FontStyle.Bold)
			templatedItemElement1.Appearance.Normal.Options.UseFont = True
			templatedItemElement1.FieldName = "DisplayName"
			templatedItemElement1.ImageOptions.ImageAlignment = DevExpress.XtraEditors.TileItemContentAlignment.MiddleCenter
			templatedItemElement1.ImageOptions.ImageScaleMode = DevExpress.XtraEditors.TileItemImageScaleMode.ZoomInside
			templatedItemElement1.ImageVisible = False
			templatedItemElement1.Text = "DisplayName"
			templatedItemElement1.TextAlignment = DevExpress.XtraEditors.TileItemContentAlignment.TopLeft
			templatedItemElement2.FieldName = "Description"
			templatedItemElement2.ImageOptions.ImageAlignment = DevExpress.XtraEditors.TileItemContentAlignment.MiddleCenter
			templatedItemElement2.ImageOptions.ImageScaleMode = DevExpress.XtraEditors.TileItemImageScaleMode.ZoomInside
			templatedItemElement2.MaxLineCount = 150
			templatedItemElement2.RowIndex = 1
			templatedItemElement2.Text = "Description"
			templatedItemElement2.TextAlignment = DevExpress.XtraEditors.TileItemContentAlignment.TopLeft
			itemTemplateBase1.Elements.Add(templatedItemElement1)
			itemTemplateBase1.Elements.Add(templatedItemElement2)
			itemTemplateBase1.Name = "template1"
			tableRowDefinition1.AutoHeight = True
			tableRowDefinition1.Length.Value = 46R
			tableRowDefinition1.PaddingBottom = 10
			tableRowDefinition1.PaddingTop = 10
			tableRowDefinition2.AutoHeight = True
			tableRowDefinition2.Length.Value = 68R
			tableRowDefinition2.PaddingBottom = 10
			tableRowDefinition2.PaddingTop = 10
			itemTemplateBase1.Rows.Add(tableRowDefinition1)
			itemTemplateBase1.Rows.Add(tableRowDefinition2)
			Me.listBoxControl1.Templates.Add(itemTemplateBase1)
			Me.listBoxControl1.ValueMember = "ReportName"
			' 
			' reportDescriptionDataBindingSource
			' 
			Me.reportDescriptionDataBindingSource.DataSource = GetType(CrossTabControlCustomizationExample.ReportDescriptionData)
			' 
			' Form1
			' 
			Me.AutoScaleDimensions = New System.Drawing.SizeF(7F, 16F)
			Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
			Me.ClientSize = New System.Drawing.Size(1198, 760)
			Me.Controls.Add(Me.btnDesign)
			Me.Controls.Add(Me.listBoxControl1)
			Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
			Me.Margin = New System.Windows.Forms.Padding(4)
			Me.Name = "Form1"
			Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide
			Me.Text = "CrossTab Control Customization"
'INSTANT VB NOTE: The following InitializeComponent event wireup was converted to a 'Handles' clause:
'ORIGINAL LINE: this.Load += new System.EventHandler(this.Form1_Load);
			DirectCast(Me.listBoxControl1, System.ComponentModel.ISupportInitialize).EndInit()
			DirectCast(Me.reportDescriptionDataBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
			Me.ResumeLayout(False)

		End Sub

		#End Region

		Private listBoxControl1 As DevExpress.XtraEditors.ListBoxControl
		Private reportDescriptionDataBindingSource As System.Windows.Forms.BindingSource
		Private htmlTemplate1 As DevExpress.Utils.Html.HtmlTemplate
		Private WithEvents btnDesign As DevExpress.XtraEditors.SimpleButton
	End Class
End Namespace

