Partial Public Class HideGroupDetails
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

	#Region "Designer generated code"

	''' <summary>
	''' Required method for Designer support - do not modify
	''' the contents of this method with the code editor.
	''' </summary>
	Private Sub InitializeComponent()
			Me.components = New System.ComponentModel.Container()
			Dim crossTabColumnField1 As New DevExpress.XtraReports.UI.CrossTab.CrossTabColumnField()
			Dim crossTabDataField1 As New DevExpress.XtraReports.UI.CrossTab.CrossTabDataField()
			Dim crossTabRowField1 As New DevExpress.XtraReports.UI.CrossTab.CrossTabRowField()
			Dim crossTabRowField2 As New DevExpress.XtraReports.UI.CrossTab.CrossTabRowField()
			Dim customJsonSource1 As New DevExpress.DataAccess.Json.CustomJsonSource()
			Dim resources As New System.ComponentModel.ComponentResourceManager(GetType(HideGroupDetails))
			Dim jsonSchemaNode1 As New DevExpress.DataAccess.Json.JsonSchemaNode("root", True, DevExpress.DataAccess.Json.JsonNodeType.Array)
			Dim jsonSchemaNode2 As New DevExpress.DataAccess.Json.JsonSchemaNode("name", True, DevExpress.DataAccess.Json.JsonNodeType.Property, GetType(String))
			Dim jsonSchemaNode3 As New DevExpress.DataAccess.Json.JsonSchemaNode("store", True, DevExpress.DataAccess.Json.JsonNodeType.Property, GetType(String))
			Dim jsonSchemaNode4 As New DevExpress.DataAccess.Json.JsonSchemaNode("value", True, DevExpress.DataAccess.Json.JsonNodeType.Property, GetType(Long?))
			Dim jsonSchemaNode5 As New DevExpress.DataAccess.Json.JsonSchemaNode("group", True, DevExpress.DataAccess.Json.JsonNodeType.Property, GetType(String))
			Me.TopMargin = New DevExpress.XtraReports.UI.TopMarginBand()
			Me.BottomMargin = New DevExpress.XtraReports.UI.BottomMarginBand()
			Me.Detail = New DevExpress.XtraReports.UI.DetailBand()
			Me.xrCrossTab2 = New DevExpress.XtraReports.UI.XRCrossTab()
			Me.xrCrossTabCell1 = New DevExpress.XtraReports.UI.CrossTab.XRCrossTabCell()
			Me.xrCrossTabCell2 = New DevExpress.XtraReports.UI.CrossTab.XRCrossTabCell()
			Me.xrCrossTabCell3 = New DevExpress.XtraReports.UI.CrossTab.XRCrossTabCell()
			Me.xrCrossTabCell4 = New DevExpress.XtraReports.UI.CrossTab.XRCrossTabCell()
			Me.xrCrossTabCell5 = New DevExpress.XtraReports.UI.CrossTab.XRCrossTabCell()
			Me.xrCrossTabCell6 = New DevExpress.XtraReports.UI.CrossTab.XRCrossTabCell()
			Me.xrCrossTabCell7 = New DevExpress.XtraReports.UI.CrossTab.XRCrossTabCell()
			Me.xrCrossTabCell8 = New DevExpress.XtraReports.UI.CrossTab.XRCrossTabCell()
			Me.xrCrossTabCell9 = New DevExpress.XtraReports.UI.CrossTab.XRCrossTabCell()
			Me.crossTabHeaderCell1 = New DevExpress.XtraReports.UI.CrossTab.XRCrossTabCell()
			Me.crossTabHeaderCell2 = New DevExpress.XtraReports.UI.CrossTab.XRCrossTabCell()
			Me.crossTabHeaderCell3 = New DevExpress.XtraReports.UI.CrossTab.XRCrossTabCell()
			Me.crossTabTotalCell1 = New DevExpress.XtraReports.UI.CrossTab.XRCrossTabCell()
			Me.crossTabTotalCell3 = New DevExpress.XtraReports.UI.CrossTab.XRCrossTabCell()
			Me.jsonDataSource1 = New DevExpress.DataAccess.Json.JsonDataSource(Me.components)
			Me.ReportHeader = New DevExpress.XtraReports.UI.ReportHeaderBand()
			Me.xrLabel1 = New DevExpress.XtraReports.UI.XRLabel()
			Me.crossTabGeneralStyle1 = New DevExpress.XtraReports.UI.XRControlStyle()
			Me.crossTabHeaderStyle1 = New DevExpress.XtraReports.UI.XRControlStyle()
			Me.crossTabDataStyle1 = New DevExpress.XtraReports.UI.XRControlStyle()
			Me.crossTabTotalStyle1 = New DevExpress.XtraReports.UI.XRControlStyle()
			DirectCast(Me.xrCrossTab2, System.ComponentModel.ISupportInitialize).BeginInit()
			DirectCast(Me, System.ComponentModel.ISupportInitialize).BeginInit()
			' 
			' TopMargin
			' 
			Me.TopMargin.Name = "TopMargin"
			' 
			' BottomMargin
			' 
			Me.BottomMargin.Name = "BottomMargin"
			' 
			' Detail
			' 
			Me.Detail.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() { Me.xrCrossTab2})
			Me.Detail.HeightF = 125F
			Me.Detail.Name = "Detail"
			' 
			' xrCrossTab2
			' 
			Me.xrCrossTab2.Cells.AddRange(New DevExpress.XtraReports.UI.XRControl() { Me.xrCrossTabCell1, Me.xrCrossTabCell2, Me.xrCrossTabCell3, Me.xrCrossTabCell4, Me.xrCrossTabCell5, Me.xrCrossTabCell6, Me.xrCrossTabCell7, Me.xrCrossTabCell8, Me.xrCrossTabCell9, Me.crossTabHeaderCell1, Me.crossTabHeaderCell2, Me.crossTabHeaderCell3, Me.crossTabTotalCell1, Me.crossTabTotalCell3})
			Me.xrCrossTab2.ColumnDefinitions.AddRange(New DevExpress.XtraReports.UI.CrossTab.CrossTabColumnDefinition() {
				New DevExpress.XtraReports.UI.CrossTab.CrossTabColumnDefinition(100F),
				New DevExpress.XtraReports.UI.CrossTab.CrossTabColumnDefinition(72.22224F),
				New DevExpress.XtraReports.UI.CrossTab.CrossTabColumnDefinition(72.22224F),
				New DevExpress.XtraReports.UI.CrossTab.CrossTabColumnDefinition(106.3889F)
			})
			crossTabColumnField1.FieldName = "store"
			Me.xrCrossTab2.ColumnFields.AddRange(New DevExpress.XtraReports.UI.CrossTab.CrossTabColumnField() { crossTabColumnField1})
			Me.xrCrossTab2.DataAreaStyleName = "crossTabDataStyle1"
			crossTabDataField1.FieldName = "value"
			Me.xrCrossTab2.DataFields.AddRange(New DevExpress.XtraReports.UI.CrossTab.CrossTabDataField() { crossTabDataField1})
			Me.xrCrossTab2.DataSource = Me.jsonDataSource1
			Me.xrCrossTab2.GeneralStyleName = "crossTabGeneralStyle1"
			Me.xrCrossTab2.HeaderAreaStyleName = "crossTabHeaderStyle1"
			Me.xrCrossTab2.LocationFloat = New DevExpress.Utils.PointFloat(0F, 0F)
			Me.xrCrossTab2.Name = "xrCrossTab2"
			Me.xrCrossTab2.RowDefinitions.AddRange(New DevExpress.XtraReports.UI.CrossTab.CrossTabRowDefinition() {
				New DevExpress.XtraReports.UI.CrossTab.CrossTabRowDefinition(25F),
				New DevExpress.XtraReports.UI.CrossTab.CrossTabRowDefinition(25F),
				New DevExpress.XtraReports.UI.CrossTab.CrossTabRowDefinition(25F),
				New DevExpress.XtraReports.UI.CrossTab.CrossTabRowDefinition(25F)
			})
			crossTabRowField1.FieldName = "group"
			crossTabRowField2.FieldName = "name"
			Me.xrCrossTab2.RowFields.AddRange(New DevExpress.XtraReports.UI.CrossTab.CrossTabRowField() { crossTabRowField1, crossTabRowField2})
			Me.xrCrossTab2.SizeF = New System.Drawing.SizeF(350.8334F, 100F)
			Me.xrCrossTab2.TotalAreaStyleName = "crossTabTotalStyle1"
			' 
			' xrCrossTabCell1
			' 
			Me.xrCrossTabCell1.ColumnIndex = 1
			Me.xrCrossTabCell1.Name = "xrCrossTabCell1"
			Me.xrCrossTabCell1.RowIndex = 0
			Me.xrCrossTabCell1.Text = "name"
			' 
			' xrCrossTabCell2
			' 
			Me.xrCrossTabCell2.ColumnIndex = 2
			Me.xrCrossTabCell2.Name = "xrCrossTabCell2"
			Me.xrCrossTabCell2.RowIndex = 0
			' 
			' xrCrossTabCell3
			' 
			Me.xrCrossTabCell3.ColumnIndex = 1
			Me.xrCrossTabCell3.ExpressionBindings.AddRange(New DevExpress.XtraReports.UI.ExpressionBinding() { New DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "RowVisible", "[group] != 'Gr1'" & ControlChars.Lf)})
			Me.xrCrossTabCell3.Name = "xrCrossTabCell3"
			Me.xrCrossTabCell3.RowIndex = 1
			' 
			' xrCrossTabCell4
			' 
			Me.xrCrossTabCell4.ColumnIndex = 0
			Me.xrCrossTabCell4.ColumnSpan = 2
			Me.xrCrossTabCell4.Name = "xrCrossTabCell4"
			Me.xrCrossTabCell4.RowIndex = 3
			Me.xrCrossTabCell4.Text = "Grand Total"
			' 
			' xrCrossTabCell5
			' 
			Me.xrCrossTabCell5.ColumnIndex = 2
			Me.xrCrossTabCell5.Name = "xrCrossTabCell5"
			Me.xrCrossTabCell5.RowIndex = 1
			' 
			' xrCrossTabCell6
			' 
			Me.xrCrossTabCell6.ColumnIndex = 2
			Me.xrCrossTabCell6.Name = "xrCrossTabCell6"
			Me.xrCrossTabCell6.RowIndex = 3
			' 
			' xrCrossTabCell7
			' 
			Me.xrCrossTabCell7.ColumnIndex = 3
			Me.xrCrossTabCell7.Name = "xrCrossTabCell7"
			Me.xrCrossTabCell7.RowIndex = 0
			Me.xrCrossTabCell7.Text = "Grand Total"
			' 
			' xrCrossTabCell8
			' 
			Me.xrCrossTabCell8.ColumnIndex = 3
			Me.xrCrossTabCell8.Name = "xrCrossTabCell8"
			Me.xrCrossTabCell8.RowIndex = 1
			' 
			' xrCrossTabCell9
			' 
			Me.xrCrossTabCell9.ColumnIndex = 3
			Me.xrCrossTabCell9.Name = "xrCrossTabCell9"
			Me.xrCrossTabCell9.RowIndex = 3
			' 
			' crossTabHeaderCell1
			' 
			Me.crossTabHeaderCell1.ColumnIndex = 0
			Me.crossTabHeaderCell1.Name = "crossTabHeaderCell1"
			Me.crossTabHeaderCell1.RowIndex = 0
			Me.crossTabHeaderCell1.Text = "group"
			' 
			' crossTabHeaderCell2
			' 
			Me.crossTabHeaderCell2.ColumnIndex = 0
			Me.crossTabHeaderCell2.Font = New System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold)
			Me.crossTabHeaderCell2.Name = "crossTabHeaderCell2"
			Me.crossTabHeaderCell2.RowIndex = 1
			' 
			' crossTabHeaderCell3
			' 
			Me.crossTabHeaderCell3.ColumnIndex = 0
			Me.crossTabHeaderCell3.ColumnSpan = 2
			Me.crossTabHeaderCell3.Name = "crossTabHeaderCell3"
			Me.crossTabHeaderCell3.RowIndex = 2
			Me.crossTabHeaderCell3.TextFormatString = "Total {0}"
			' 
			' crossTabTotalCell1
			' 
			Me.crossTabTotalCell1.ColumnIndex = 2
			Me.crossTabTotalCell1.Name = "crossTabTotalCell1"
			Me.crossTabTotalCell1.RowIndex = 2
			' 
			' crossTabTotalCell3
			' 
			Me.crossTabTotalCell3.ColumnIndex = 3
			Me.crossTabTotalCell3.Name = "crossTabTotalCell3"
			Me.crossTabTotalCell3.RowIndex = 2
			' 
			' jsonDataSource1
			' 
			customJsonSource1.Json = resources.GetString("customJsonSource1.Json")
			Me.jsonDataSource1.JsonSource = customJsonSource1
			Me.jsonDataSource1.Name = "jsonDataSource1"
			jsonSchemaNode1.Nodes.Add(jsonSchemaNode2)
			jsonSchemaNode1.Nodes.Add(jsonSchemaNode3)
			jsonSchemaNode1.Nodes.Add(jsonSchemaNode4)
			jsonSchemaNode1.Nodes.Add(jsonSchemaNode5)
			Me.jsonDataSource1.Schema = jsonSchemaNode1
			' 
			' ReportHeader
			' 
			Me.ReportHeader.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() { Me.xrLabel1})
			Me.ReportHeader.HeightF = 50F
			Me.ReportHeader.Name = "ReportHeader"
			' 
			' xrLabel1
			' 
			Me.xrLabel1.Font = New System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (CByte(0)))
			Me.xrLabel1.LocationFloat = New DevExpress.Utils.PointFloat(0F, 0F)
			Me.xrLabel1.Multiline = True
			Me.xrLabel1.Name = "xrLabel1"
			Me.xrLabel1.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F)
			Me.xrLabel1.SizeF = New System.Drawing.SizeF(650F, 25F)
			Me.xrLabel1.StylePriority.UseFont = False
			Me.xrLabel1.Text = "Hide detailed records and show the total for the specified group"
			' 
			' crossTabGeneralStyle1
			' 
			Me.crossTabGeneralStyle1.BackColor = System.Drawing.Color.White
			Me.crossTabGeneralStyle1.BorderColor = System.Drawing.Color.FromArgb((CInt((CByte(160)))), (CInt((CByte(160)))), (CInt((CByte(160)))))
			Me.crossTabGeneralStyle1.Borders = (CType((((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Top) Or DevExpress.XtraPrinting.BorderSide.Right) Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide))
			Me.crossTabGeneralStyle1.Font = New System.Drawing.Font("Arial", 9.75F)
			Me.crossTabGeneralStyle1.ForeColor = System.Drawing.Color.Black
			Me.crossTabGeneralStyle1.Name = "crossTabGeneralStyle1"
			Me.crossTabGeneralStyle1.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F)
			' 
			' crossTabHeaderStyle1
			' 
			Me.crossTabHeaderStyle1.BackColor = System.Drawing.Color.FromArgb((CInt((CByte(240)))), (CInt((CByte(240)))), (CInt((CByte(240)))))
			Me.crossTabHeaderStyle1.Name = "crossTabHeaderStyle1"
			Me.crossTabHeaderStyle1.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
			' 
			' crossTabDataStyle1
			' 
			Me.crossTabDataStyle1.Name = "crossTabDataStyle1"
			Me.crossTabDataStyle1.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
			' 
			' crossTabTotalStyle1
			' 
			Me.crossTabTotalStyle1.Name = "crossTabTotalStyle1"
			Me.crossTabTotalStyle1.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
			' 
			' HideGroupDetails
			' 
			Me.Bands.AddRange(New DevExpress.XtraReports.UI.Band() { Me.TopMargin, Me.BottomMargin, Me.Detail, Me.ReportHeader})
			Me.ComponentStorage.AddRange(New System.ComponentModel.IComponent() { Me.jsonDataSource1})
			Me.Font = New System.Drawing.Font("Arial", 9.75F)
			Me.StyleSheet.AddRange(New DevExpress.XtraReports.UI.XRControlStyle() { Me.crossTabGeneralStyle1, Me.crossTabHeaderStyle1, Me.crossTabDataStyle1, Me.crossTabTotalStyle1})
			Me.Version = "22.1"
			DirectCast(Me.xrCrossTab2, System.ComponentModel.ISupportInitialize).EndInit()
			DirectCast(Me, System.ComponentModel.ISupportInitialize).EndInit()

	End Sub

	#End Region

	Private TopMargin As DevExpress.XtraReports.UI.TopMarginBand
	Private BottomMargin As DevExpress.XtraReports.UI.BottomMarginBand
	Private Detail As DevExpress.XtraReports.UI.DetailBand
	Private xrCrossTab2 As DevExpress.XtraReports.UI.XRCrossTab
	Private xrCrossTabCell1 As DevExpress.XtraReports.UI.CrossTab.XRCrossTabCell
	Private xrCrossTabCell2 As DevExpress.XtraReports.UI.CrossTab.XRCrossTabCell
	Private xrCrossTabCell3 As DevExpress.XtraReports.UI.CrossTab.XRCrossTabCell
	Private xrCrossTabCell4 As DevExpress.XtraReports.UI.CrossTab.XRCrossTabCell
	Private xrCrossTabCell5 As DevExpress.XtraReports.UI.CrossTab.XRCrossTabCell
	Private xrCrossTabCell6 As DevExpress.XtraReports.UI.CrossTab.XRCrossTabCell
	Private xrCrossTabCell7 As DevExpress.XtraReports.UI.CrossTab.XRCrossTabCell
	Private xrCrossTabCell8 As DevExpress.XtraReports.UI.CrossTab.XRCrossTabCell
	Private xrCrossTabCell9 As DevExpress.XtraReports.UI.CrossTab.XRCrossTabCell
	Private crossTabHeaderCell1 As DevExpress.XtraReports.UI.CrossTab.XRCrossTabCell
	Private crossTabHeaderCell2 As DevExpress.XtraReports.UI.CrossTab.XRCrossTabCell
	Private crossTabHeaderCell3 As DevExpress.XtraReports.UI.CrossTab.XRCrossTabCell
	Private crossTabTotalCell1 As DevExpress.XtraReports.UI.CrossTab.XRCrossTabCell
	Private crossTabTotalCell3 As DevExpress.XtraReports.UI.CrossTab.XRCrossTabCell
	Private jsonDataSource1 As DevExpress.DataAccess.Json.JsonDataSource
	Private ReportHeader As DevExpress.XtraReports.UI.ReportHeaderBand
	Private xrLabel1 As DevExpress.XtraReports.UI.XRLabel
	Private crossTabGeneralStyle1 As DevExpress.XtraReports.UI.XRControlStyle
	Private crossTabHeaderStyle1 As DevExpress.XtraReports.UI.XRControlStyle
	Private crossTabDataStyle1 As DevExpress.XtraReports.UI.XRControlStyle
	Private crossTabTotalStyle1 As DevExpress.XtraReports.UI.XRControlStyle
End Class
