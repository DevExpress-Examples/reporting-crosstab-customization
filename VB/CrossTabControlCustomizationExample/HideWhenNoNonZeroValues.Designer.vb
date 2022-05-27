Partial Public Class HideWhenNoNonZeroValues
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
		Dim crossTabColumnDefinition1 As New DevExpress.XtraReports.UI.CrossTab.CrossTabColumnDefinition(60F)
		Dim crossTabColumnDefinition2 As New DevExpress.XtraReports.UI.CrossTab.CrossTabColumnDefinition(60F)
		Dim crossTabColumnDefinition3 As New DevExpress.XtraReports.UI.CrossTab.CrossTabColumnDefinition(60F)
		Dim crossTabColumnDefinition4 As New DevExpress.XtraReports.UI.CrossTab.CrossTabColumnDefinition(60F)
		Dim crossTabColumnField1 As New DevExpress.XtraReports.UI.CrossTab.CrossTabColumnField()
		Dim crossTabDataField1 As New DevExpress.XtraReports.UI.CrossTab.CrossTabDataField()
		Dim crossTabDataField2 As New DevExpress.XtraReports.UI.CrossTab.CrossTabDataField()
		Dim crossTabRowField1 As New DevExpress.XtraReports.UI.CrossTab.CrossTabRowField()
		Dim customJsonSource1 As New DevExpress.DataAccess.Json.CustomJsonSource()
		Dim resources As New System.ComponentModel.ComponentResourceManager(GetType(HideWhenNoNonZeroValues))
		Dim jsonSchemaNode1 As New DevExpress.DataAccess.Json.JsonSchemaNode("root", True, DevExpress.DataAccess.Json.JsonNodeType.Array)
		Dim jsonSchemaNode2 As New DevExpress.DataAccess.Json.JsonSchemaNode("elementType", True, DevExpress.DataAccess.Json.JsonNodeType.Property, GetType(String))
		Dim jsonSchemaNode3 As New DevExpress.DataAccess.Json.JsonSchemaNode("elementID", True, DevExpress.DataAccess.Json.JsonNodeType.Property, GetType(String))
		Dim jsonSchemaNode4 As New DevExpress.DataAccess.Json.JsonSchemaNode("season", True, DevExpress.DataAccess.Json.JsonNodeType.Property, GetType(String))
		Dim jsonSchemaNode5 As New DevExpress.DataAccess.Json.JsonSchemaNode("value1", True, DevExpress.DataAccess.Json.JsonNodeType.Property, GetType(Double?))
		Dim jsonSchemaNode6 As New DevExpress.DataAccess.Json.JsonSchemaNode("value2", True, DevExpress.DataAccess.Json.JsonNodeType.Property, GetType(Double?))
		Me.TopMargin = New DevExpress.XtraReports.UI.TopMarginBand()
		Me.Detail = New DevExpress.XtraReports.UI.DetailBand()
		Me.BottomMargin = New DevExpress.XtraReports.UI.BottomMarginBand()
		Me.GroupHeader1 = New DevExpress.XtraReports.UI.GroupHeaderBand()
		Me.crossTab1 = New DevExpress.XtraReports.UI.XRCrossTab()
		Me.label1 = New DevExpress.XtraReports.UI.XRLabel()
		Me.crossTabHeaderCell1 = New DevExpress.XtraReports.UI.CrossTab.XRCrossTabCell()
		Me.crossTabDataCell1 = New DevExpress.XtraReports.UI.CrossTab.XRCrossTabCell()
		Me.crossTabHeaderCell2 = New DevExpress.XtraReports.UI.CrossTab.XRCrossTabCell()
		Me.crossTabHeaderCell3 = New DevExpress.XtraReports.UI.CrossTab.XRCrossTabCell()
		Me.crossTabHeaderCell4 = New DevExpress.XtraReports.UI.CrossTab.XRCrossTabCell()
		Me.crossTabTotalCell1 = New DevExpress.XtraReports.UI.CrossTab.XRCrossTabCell()
		Me.crossTabHeaderCell5 = New DevExpress.XtraReports.UI.CrossTab.XRCrossTabCell()
		Me.crossTabTotalCell2 = New DevExpress.XtraReports.UI.CrossTab.XRCrossTabCell()
		Me.crossTabTotalCell3 = New DevExpress.XtraReports.UI.CrossTab.XRCrossTabCell()
		Me.crossTabHeaderCell6 = New DevExpress.XtraReports.UI.CrossTab.XRCrossTabCell()
		Me.crossTabHeaderCell7 = New DevExpress.XtraReports.UI.CrossTab.XRCrossTabCell()
		Me.crossTabHeaderCell8 = New DevExpress.XtraReports.UI.CrossTab.XRCrossTabCell()
		Me.crossTabHeaderCell9 = New DevExpress.XtraReports.UI.CrossTab.XRCrossTabCell()
		Me.crossTabDataCell2 = New DevExpress.XtraReports.UI.CrossTab.XRCrossTabCell()
		Me.crossTabTotalCell5 = New DevExpress.XtraReports.UI.CrossTab.XRCrossTabCell()
		Me.crossTabTotalCell4 = New DevExpress.XtraReports.UI.CrossTab.XRCrossTabCell()
		Me.crossTabTotalCell6 = New DevExpress.XtraReports.UI.CrossTab.XRCrossTabCell()
		Me.jsonDataSource1 = New DevExpress.DataAccess.Json.JsonDataSource(Me.components)
		Me.crossTabGeneralStyle1 = New DevExpress.XtraReports.UI.XRControlStyle()
		Me.crossTabHeaderStyle1 = New DevExpress.XtraReports.UI.XRControlStyle()
		Me.crossTabDataStyle1 = New DevExpress.XtraReports.UI.XRControlStyle()
		Me.crossTabTotalStyle1 = New DevExpress.XtraReports.UI.XRControlStyle()
		DirectCast(Me.crossTab1, System.ComponentModel.ISupportInitialize).BeginInit()
		DirectCast(Me, System.ComponentModel.ISupportInitialize).BeginInit()
		' 
		' TopMargin
		' 
		Me.TopMargin.Name = "TopMargin"
		' 
		' Detail
		' 
		Me.Detail.HeightF = 0F
		Me.Detail.Name = "Detail"
		' 
		' BottomMargin
		' 
		Me.BottomMargin.Name = "BottomMargin"
		' 
		' GroupHeader1
		' 
		Me.GroupHeader1.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() { Me.crossTab1, Me.label1})
		Me.GroupHeader1.GroupFields.AddRange(New DevExpress.XtraReports.UI.GroupField() { New DevExpress.XtraReports.UI.GroupField("elementType", DevExpress.XtraReports.UI.XRColumnSortOrder.Ascending)})
		Me.GroupHeader1.HeightF = 145.5F
		Me.GroupHeader1.Name = "GroupHeader1"
		' 
		' crossTab1
		' 
		Me.crossTab1.Cells.AddRange(New DevExpress.XtraReports.UI.XRControl() { Me.crossTabHeaderCell1, Me.crossTabDataCell1, Me.crossTabHeaderCell2, Me.crossTabHeaderCell3, Me.crossTabHeaderCell4, Me.crossTabTotalCell1, Me.crossTabHeaderCell5, Me.crossTabTotalCell2, Me.crossTabTotalCell3, Me.crossTabHeaderCell6, Me.crossTabHeaderCell7, Me.crossTabHeaderCell8, Me.crossTabHeaderCell9, Me.crossTabDataCell2, Me.crossTabTotalCell5, Me.crossTabTotalCell4, Me.crossTabTotalCell6})
		crossTabColumnDefinition1.AutoWidthMode = DevExpress.XtraReports.UI.AutoSizeMode.ShrinkAndGrow
		crossTabColumnDefinition2.AutoWidthMode = DevExpress.XtraReports.UI.AutoSizeMode.ShrinkAndGrow
		crossTabColumnDefinition3.AutoWidthMode = DevExpress.XtraReports.UI.AutoSizeMode.ShrinkAndGrow
		crossTabColumnDefinition4.AutoWidthMode = DevExpress.XtraReports.UI.AutoSizeMode.ShrinkAndGrow
		Me.crossTab1.ColumnDefinitions.AddRange(New DevExpress.XtraReports.UI.CrossTab.CrossTabColumnDefinition() {
			New DevExpress.XtraReports.UI.CrossTab.CrossTabColumnDefinition(85F),
			crossTabColumnDefinition1,
			crossTabColumnDefinition2,
			crossTabColumnDefinition3,
			crossTabColumnDefinition4
		})
		crossTabColumnField1.FieldName = "season"
		Me.crossTab1.ColumnFields.AddRange(New DevExpress.XtraReports.UI.CrossTab.CrossTabColumnField() { crossTabColumnField1})
		Me.crossTab1.DataAreaStyleName = "crossTabDataStyle1"
		crossTabDataField1.FieldName = "value1"
		crossTabDataField2.FieldName = "value2"
		Me.crossTab1.DataFields.AddRange(New DevExpress.XtraReports.UI.CrossTab.CrossTabDataField() { crossTabDataField1, crossTabDataField2})
		Me.crossTab1.DataSource = Me.jsonDataSource1
		Me.crossTab1.FilterString = "[elementType] = ?controlParameter1"
		Me.crossTab1.GeneralStyleName = "crossTabGeneralStyle1"
		Me.crossTab1.HeaderAreaStyleName = "crossTabHeaderStyle1"
		Me.crossTab1.LocationFloat = New DevExpress.Utils.PointFloat(0F, 32.99998F)
		Me.crossTab1.Name = "crossTab1"
		Me.crossTab1.Parameters.AddRange(New DevExpress.XtraReports.UI.XRControlParameter() { New DevExpress.XtraReports.UI.XRControlParameter("controlParameter1", Nothing, "elementType")})
		Me.crossTab1.RowDefinitions.AddRange(New DevExpress.XtraReports.UI.CrossTab.CrossTabRowDefinition() {
			New DevExpress.XtraReports.UI.CrossTab.CrossTabRowDefinition(25F),
			New DevExpress.XtraReports.UI.CrossTab.CrossTabRowDefinition(25F),
			New DevExpress.XtraReports.UI.CrossTab.CrossTabRowDefinition(25F),
			New DevExpress.XtraReports.UI.CrossTab.CrossTabRowDefinition(25F)
		})
		crossTabRowField1.FieldName = "elementID"
		Me.crossTab1.RowFields.AddRange(New DevExpress.XtraReports.UI.CrossTab.CrossTabRowField() { crossTabRowField1})
		Me.crossTab1.SizeF = New System.Drawing.SizeF(325F, 100F)
		Me.crossTab1.TotalAreaStyleName = "crossTabTotalStyle1"
		' 
		' label1
		' 
		Me.label1.ExpressionBindings.AddRange(New DevExpress.XtraReports.UI.ExpressionBinding() { New DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[elementType]")})
		Me.label1.Font = New System.Drawing.Font("Arial", 9.75F, (CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle)))
		Me.label1.LocationFloat = New DevExpress.Utils.PointFloat(0F, 10F)
		Me.label1.Multiline = True
		Me.label1.Name = "label1"
		Me.label1.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F)
		Me.label1.SizeF = New System.Drawing.SizeF(100F, 23F)
		Me.label1.StylePriority.UseFont = False
		Me.label1.Text = "label1"
		' 
		' crossTabHeaderCell1
		' 
		Me.crossTabHeaderCell1.ColumnIndex = 0
		Me.crossTabHeaderCell1.Name = "crossTabHeaderCell1"
		Me.crossTabHeaderCell1.RowIndex = 0
		Me.crossTabHeaderCell1.RowSpan = 2
		Me.crossTabHeaderCell1.Text = "element ID"
		' 
		' crossTabDataCell1
		' 
		Me.crossTabDataCell1.ColumnIndex = 1
		Me.crossTabDataCell1.Name = "crossTabDataCell1"
		Me.crossTabDataCell1.RowIndex = 2
		' 
		' crossTabHeaderCell2
		' 
		Me.crossTabHeaderCell2.ColumnIndex = 1
		Me.crossTabHeaderCell2.ColumnSpan = 2
		Me.crossTabHeaderCell2.Name = "crossTabHeaderCell2"
		Me.crossTabHeaderCell2.RowIndex = 0
		' 
		' crossTabHeaderCell3
		' 
		Me.crossTabHeaderCell3.ColumnIndex = 0
		Me.crossTabHeaderCell3.Name = "crossTabHeaderCell3"
		Me.crossTabHeaderCell3.RowIndex = 2
		' 
		' crossTabHeaderCell4
		' 
		Me.crossTabHeaderCell4.ColumnIndex = 0
		Me.crossTabHeaderCell4.Name = "crossTabHeaderCell4"
		Me.crossTabHeaderCell4.RowIndex = 3
		Me.crossTabHeaderCell4.Text = "Grand Total"
		' 
		' crossTabTotalCell1
		' 
		Me.crossTabTotalCell1.ColumnIndex = 1
		Me.crossTabTotalCell1.Name = "crossTabTotalCell1"
		Me.crossTabTotalCell1.RowIndex = 3
		' 
		' crossTabHeaderCell5
		' 
		Me.crossTabHeaderCell5.ColumnIndex = 3
		Me.crossTabHeaderCell5.ColumnSpan = 2
		Me.crossTabHeaderCell5.Name = "crossTabHeaderCell5"
		Me.crossTabHeaderCell5.RowIndex = 0
		Me.crossTabHeaderCell5.Text = "Grand Total"
		' 
		' crossTabTotalCell2
		' 
		Me.crossTabTotalCell2.ColumnIndex = 3
		Me.crossTabTotalCell2.Name = "crossTabTotalCell2"
		Me.crossTabTotalCell2.RowIndex = 2
		' 
		' crossTabTotalCell3
		' 
		Me.crossTabTotalCell3.ColumnIndex = 3
		Me.crossTabTotalCell3.Name = "crossTabTotalCell3"
		Me.crossTabTotalCell3.RowIndex = 3
		' 
		' crossTabHeaderCell6
		' 
		Me.crossTabHeaderCell6.ColumnIndex = 1
		Me.crossTabHeaderCell6.Name = "crossTabHeaderCell6"
		Me.crossTabHeaderCell6.RowIndex = 1
		Me.crossTabHeaderCell6.Text = "v1 (sum)"
		' 
		' crossTabHeaderCell7
		' 
		Me.crossTabHeaderCell7.ColumnIndex = 3
		Me.crossTabHeaderCell7.Name = "crossTabHeaderCell7"
		Me.crossTabHeaderCell7.RowIndex = 1
		Me.crossTabHeaderCell7.Text = "v1 (sum)"
		' 
		' crossTabHeaderCell8
		' 
		Me.crossTabHeaderCell8.BackColor = System.Drawing.Color.FromArgb((CInt((CByte(255)))), (CInt((CByte(255)))), (CInt((CByte(192)))))
		Me.crossTabHeaderCell8.ColumnIndex = 2
		Me.crossTabHeaderCell8.Name = "crossTabHeaderCell8"
		Me.crossTabHeaderCell8.RowIndex = 1
		Me.crossTabHeaderCell8.Text = "v2 (sum)"
		' 
		' crossTabHeaderCell9
		' 
		Me.crossTabHeaderCell9.BackColor = System.Drawing.Color.FromArgb((CInt((CByte(255)))), (CInt((CByte(255)))), (CInt((CByte(192)))))
		Me.crossTabHeaderCell9.ColumnIndex = 4
		Me.crossTabHeaderCell9.Name = "crossTabHeaderCell9"
		Me.crossTabHeaderCell9.RowIndex = 1
		Me.crossTabHeaderCell9.Text = "v2 (sum)"
		' 
		' crossTabDataCell2
		' 
		Me.crossTabDataCell2.BackColor = System.Drawing.Color.FromArgb((CInt((CByte(255)))), (CInt((CByte(255)))), (CInt((CByte(192)))))
		Me.crossTabDataCell2.ColumnIndex = 2
		Me.crossTabDataCell2.Name = "crossTabDataCell2"
		Me.crossTabDataCell2.RowIndex = 2
		' 
		' crossTabTotalCell5
		' 
		Me.crossTabTotalCell5.BackColor = System.Drawing.Color.FromArgb((CInt((CByte(255)))), (CInt((CByte(255)))), (CInt((CByte(192)))))
		Me.crossTabTotalCell5.ColumnIndex = 4
		Me.crossTabTotalCell5.Name = "crossTabTotalCell5"
		Me.crossTabTotalCell5.RowIndex = 2
		' 
		' crossTabTotalCell4
		' 
		Me.crossTabTotalCell4.BackColor = System.Drawing.Color.FromArgb((CInt((CByte(255)))), (CInt((CByte(255)))), (CInt((CByte(192)))))
		Me.crossTabTotalCell4.ColumnIndex = 2
		Me.crossTabTotalCell4.ExpressionBindings.AddRange(New DevExpress.XtraReports.UI.ExpressionBinding() { New DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "ColumnVisible", "[value2] > 0" & ControlChars.Lf)})
		Me.crossTabTotalCell4.Name = "crossTabTotalCell4"
		Me.crossTabTotalCell4.RowIndex = 3
		' 
		' crossTabTotalCell6
		' 
		Me.crossTabTotalCell6.BackColor = System.Drawing.Color.FromArgb((CInt((CByte(255)))), (CInt((CByte(255)))), (CInt((CByte(192)))))
		Me.crossTabTotalCell6.ColumnIndex = 4
		Me.crossTabTotalCell6.ExpressionBindings.AddRange(New DevExpress.XtraReports.UI.ExpressionBinding() { New DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "ColumnVisible", "[value2] > 0" & ControlChars.Lf)})
		Me.crossTabTotalCell6.Name = "crossTabTotalCell6"
		Me.crossTabTotalCell6.RowIndex = 3
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
		jsonSchemaNode1.Nodes.Add(jsonSchemaNode6)
		Me.jsonDataSource1.Schema = jsonSchemaNode1
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
		' HideWhenNoNonZeroValues
		' 
		Me.Bands.AddRange(New DevExpress.XtraReports.UI.Band() { Me.TopMargin, Me.Detail, Me.BottomMargin, Me.GroupHeader1})
		Me.ComponentStorage.AddRange(New System.ComponentModel.IComponent() { Me.jsonDataSource1})
		Me.DataSource = Me.jsonDataSource1
		Me.Font = New System.Drawing.Font("Arial", 9.75F)
		Me.Margins = New System.Drawing.Printing.Margins(109, 100, 100, 100)
		Me.StyleSheet.AddRange(New DevExpress.XtraReports.UI.XRControlStyle() { Me.crossTabGeneralStyle1, Me.crossTabHeaderStyle1, Me.crossTabDataStyle1, Me.crossTabTotalStyle1})
		Me.Version = "22.1"
		DirectCast(Me.crossTab1, System.ComponentModel.ISupportInitialize).EndInit()
		DirectCast(Me, System.ComponentModel.ISupportInitialize).EndInit()

	End Sub

	#End Region

	Private TopMargin As DevExpress.XtraReports.UI.TopMarginBand
	Private Detail As DevExpress.XtraReports.UI.DetailBand
	Private BottomMargin As DevExpress.XtraReports.UI.BottomMarginBand
	Private GroupHeader1 As DevExpress.XtraReports.UI.GroupHeaderBand
	Private crossTab1 As DevExpress.XtraReports.UI.XRCrossTab
	Private crossTabHeaderCell1 As DevExpress.XtraReports.UI.CrossTab.XRCrossTabCell
	Private crossTabDataCell1 As DevExpress.XtraReports.UI.CrossTab.XRCrossTabCell
	Private crossTabHeaderCell2 As DevExpress.XtraReports.UI.CrossTab.XRCrossTabCell
	Private crossTabHeaderCell3 As DevExpress.XtraReports.UI.CrossTab.XRCrossTabCell
	Private crossTabHeaderCell4 As DevExpress.XtraReports.UI.CrossTab.XRCrossTabCell
	Private crossTabTotalCell1 As DevExpress.XtraReports.UI.CrossTab.XRCrossTabCell
	Private crossTabHeaderCell5 As DevExpress.XtraReports.UI.CrossTab.XRCrossTabCell
	Private crossTabTotalCell2 As DevExpress.XtraReports.UI.CrossTab.XRCrossTabCell
	Private crossTabTotalCell3 As DevExpress.XtraReports.UI.CrossTab.XRCrossTabCell
	Private crossTabHeaderCell6 As DevExpress.XtraReports.UI.CrossTab.XRCrossTabCell
	Private crossTabHeaderCell7 As DevExpress.XtraReports.UI.CrossTab.XRCrossTabCell
	Private crossTabHeaderCell8 As DevExpress.XtraReports.UI.CrossTab.XRCrossTabCell
	Private crossTabHeaderCell9 As DevExpress.XtraReports.UI.CrossTab.XRCrossTabCell
	Private crossTabDataCell2 As DevExpress.XtraReports.UI.CrossTab.XRCrossTabCell
	Private crossTabTotalCell5 As DevExpress.XtraReports.UI.CrossTab.XRCrossTabCell
	Private crossTabTotalCell4 As DevExpress.XtraReports.UI.CrossTab.XRCrossTabCell
	Private crossTabTotalCell6 As DevExpress.XtraReports.UI.CrossTab.XRCrossTabCell
	Private jsonDataSource1 As DevExpress.DataAccess.Json.JsonDataSource
	Private label1 As DevExpress.XtraReports.UI.XRLabel
	Private crossTabGeneralStyle1 As DevExpress.XtraReports.UI.XRControlStyle
	Private crossTabHeaderStyle1 As DevExpress.XtraReports.UI.XRControlStyle
	Private crossTabDataStyle1 As DevExpress.XtraReports.UI.XRControlStyle
	Private crossTabTotalStyle1 As DevExpress.XtraReports.UI.XRControlStyle
End Class

