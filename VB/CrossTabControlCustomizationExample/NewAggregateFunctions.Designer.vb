<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Public Class NewAggregateFunctions
    Inherits DevExpress.XtraReports.UI.XtraReport

    'XtraReport overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing AndAlso components IsNot Nothing Then
            components.Dispose()
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Required by the Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Designer
    'It can be modified using the Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim SelectQuery1 As DevExpress.DataAccess.Sql.SelectQuery = New DevExpress.DataAccess.Sql.SelectQuery()
        Dim Column1 As DevExpress.DataAccess.Sql.Column = New DevExpress.DataAccess.Sql.Column()
        Dim ColumnExpression1 As DevExpress.DataAccess.Sql.ColumnExpression = New DevExpress.DataAccess.Sql.ColumnExpression()
        Dim Table1 As DevExpress.DataAccess.Sql.Table = New DevExpress.DataAccess.Sql.Table()
        Dim Column2 As DevExpress.DataAccess.Sql.Column = New DevExpress.DataAccess.Sql.Column()
        Dim ColumnExpression2 As DevExpress.DataAccess.Sql.ColumnExpression = New DevExpress.DataAccess.Sql.ColumnExpression()
        Dim Table2 As DevExpress.DataAccess.Sql.Table = New DevExpress.DataAccess.Sql.Table()
        Dim Column3 As DevExpress.DataAccess.Sql.Column = New DevExpress.DataAccess.Sql.Column()
        Dim ColumnExpression3 As DevExpress.DataAccess.Sql.ColumnExpression = New DevExpress.DataAccess.Sql.ColumnExpression()
        Dim Table3 As DevExpress.DataAccess.Sql.Table = New DevExpress.DataAccess.Sql.Table()
        Dim Join1 As DevExpress.DataAccess.Sql.Join = New DevExpress.DataAccess.Sql.Join()
        Dim RelationColumnInfo1 As DevExpress.DataAccess.Sql.RelationColumnInfo = New DevExpress.DataAccess.Sql.RelationColumnInfo()
        Dim Join2 As DevExpress.DataAccess.Sql.Join = New DevExpress.DataAccess.Sql.Join()
        Dim RelationColumnInfo2 As DevExpress.DataAccess.Sql.RelationColumnInfo = New DevExpress.DataAccess.Sql.RelationColumnInfo()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(NewAggregateFunctions))
        Dim DynamicListLookUpSettings1 As DevExpress.XtraReports.Parameters.DynamicListLookUpSettings = New DevExpress.XtraReports.Parameters.DynamicListLookUpSettings()
        Dim CrossTabColumnDefinition1 As DevExpress.XtraReports.UI.CrossTab.CrossTabColumnDefinition = New DevExpress.XtraReports.UI.CrossTab.CrossTabColumnDefinition(81.81815!)
        Dim CrossTabColumnDefinition2 As DevExpress.XtraReports.UI.CrossTab.CrossTabColumnDefinition = New DevExpress.XtraReports.UI.CrossTab.CrossTabColumnDefinition(55.66819!)
        Dim CrossTabColumnDefinition3 As DevExpress.XtraReports.UI.CrossTab.CrossTabColumnDefinition = New DevExpress.XtraReports.UI.CrossTab.CrossTabColumnDefinition(55.66819!)
        Dim CrossTabColumnDefinition4 As DevExpress.XtraReports.UI.CrossTab.CrossTabColumnDefinition = New DevExpress.XtraReports.UI.CrossTab.CrossTabColumnDefinition(55.66819!)
        Dim CrossTabColumnDefinition5 As DevExpress.XtraReports.UI.CrossTab.CrossTabColumnDefinition = New DevExpress.XtraReports.UI.CrossTab.CrossTabColumnDefinition(55.66819!)
        Dim CrossTabColumnDefinition6 As DevExpress.XtraReports.UI.CrossTab.CrossTabColumnDefinition = New DevExpress.XtraReports.UI.CrossTab.CrossTabColumnDefinition(55.66819!)
        Dim CrossTabColumnField1 As DevExpress.XtraReports.UI.CrossTab.CrossTabColumnField = New DevExpress.XtraReports.UI.CrossTab.CrossTabColumnField()
        Dim CrossTabDataField1 As DevExpress.XtraReports.UI.CrossTab.CrossTabDataField = New DevExpress.XtraReports.UI.CrossTab.CrossTabDataField()
        Dim CrossTabDataField2 As DevExpress.XtraReports.UI.CrossTab.CrossTabDataField = New DevExpress.XtraReports.UI.CrossTab.CrossTabDataField()
        Dim CrossTabDataField3 As DevExpress.XtraReports.UI.CrossTab.CrossTabDataField = New DevExpress.XtraReports.UI.CrossTab.CrossTabDataField()
        Dim CrossTabDataField4 As DevExpress.XtraReports.UI.CrossTab.CrossTabDataField = New DevExpress.XtraReports.UI.CrossTab.CrossTabDataField()
        Dim CrossTabDataField5 As DevExpress.XtraReports.UI.CrossTab.CrossTabDataField = New DevExpress.XtraReports.UI.CrossTab.CrossTabDataField()
        Dim CrossTabRowDefinition1 As DevExpress.XtraReports.UI.CrossTab.CrossTabRowDefinition = New DevExpress.XtraReports.UI.CrossTab.CrossTabRowDefinition(25.0!)
        Dim CrossTabRowDefinition2 As DevExpress.XtraReports.UI.CrossTab.CrossTabRowDefinition = New DevExpress.XtraReports.UI.CrossTab.CrossTabRowDefinition(25.0!)
        Dim CrossTabRowField1 As DevExpress.XtraReports.UI.CrossTab.CrossTabRowField = New DevExpress.XtraReports.UI.CrossTab.CrossTabRowField()
        Me.sqlDataSource1 = New DevExpress.DataAccess.Sql.SqlDataSource(Me.components)
        Me.ReportHeader = New DevExpress.XtraReports.UI.ReportHeaderBand()
        Me.label1 = New DevExpress.XtraReports.UI.XRLabel()
        Me.Detail = New DevExpress.XtraReports.UI.DetailBand()
        Me.xrSubreport1 = New DevExpress.XtraReports.UI.XRSubreport()
        Me.parameter1 = New DevExpress.XtraReports.Parameters.Parameter()
        Me.crossTab1 = New DevExpress.XtraReports.UI.XRCrossTab()
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
        Me.crossTabHeaderCell4 = New DevExpress.XtraReports.UI.CrossTab.XRCrossTabCell()
        Me.crossTabDataCell1 = New DevExpress.XtraReports.UI.CrossTab.XRCrossTabCell()
        Me.crossTabTotalCell1 = New DevExpress.XtraReports.UI.CrossTab.XRCrossTabCell()
        Me.crossTabTotalCell2 = New DevExpress.XtraReports.UI.CrossTab.XRCrossTabCell()
        Me.crossTabTotalCell3 = New DevExpress.XtraReports.UI.CrossTab.XRCrossTabCell()
        Me.crossTabHeaderCell5 = New DevExpress.XtraReports.UI.CrossTab.XRCrossTabCell()
        Me.crossTabHeaderCell6 = New DevExpress.XtraReports.UI.CrossTab.XRCrossTabCell()
        Me.crossTabDataCell2 = New DevExpress.XtraReports.UI.CrossTab.XRCrossTabCell()
        Me.crossTabTotalCell4 = New DevExpress.XtraReports.UI.CrossTab.XRCrossTabCell()
        Me.crossTabTotalCell5 = New DevExpress.XtraReports.UI.CrossTab.XRCrossTabCell()
        Me.crossTabTotalCell6 = New DevExpress.XtraReports.UI.CrossTab.XRCrossTabCell()
        Me.crossTabHeaderCell7 = New DevExpress.XtraReports.UI.CrossTab.XRCrossTabCell()
        Me.crossTabHeaderCell8 = New DevExpress.XtraReports.UI.CrossTab.XRCrossTabCell()
        Me.crossTabDataCell3 = New DevExpress.XtraReports.UI.CrossTab.XRCrossTabCell()
        Me.crossTabTotalCell7 = New DevExpress.XtraReports.UI.CrossTab.XRCrossTabCell()
        Me.crossTabTotalCell8 = New DevExpress.XtraReports.UI.CrossTab.XRCrossTabCell()
        Me.crossTabTotalCell9 = New DevExpress.XtraReports.UI.CrossTab.XRCrossTabCell()
        Me.crossTabHeaderCell9 = New DevExpress.XtraReports.UI.CrossTab.XRCrossTabCell()
        Me.crossTabHeaderCell10 = New DevExpress.XtraReports.UI.CrossTab.XRCrossTabCell()
        Me.crossTabDataCell4 = New DevExpress.XtraReports.UI.CrossTab.XRCrossTabCell()
        Me.crossTabTotalCell10 = New DevExpress.XtraReports.UI.CrossTab.XRCrossTabCell()
        Me.crossTabTotalCell11 = New DevExpress.XtraReports.UI.CrossTab.XRCrossTabCell()
        Me.crossTabTotalCell12 = New DevExpress.XtraReports.UI.CrossTab.XRCrossTabCell()
        Me.TopMargin = New DevExpress.XtraReports.UI.TopMarginBand()
        Me.BottomMargin = New DevExpress.XtraReports.UI.BottomMarginBand()
        Me.TitleStyle = New DevExpress.XtraReports.UI.XRControlStyle()
        Me.crossTabGeneralStyle = New DevExpress.XtraReports.UI.XRControlStyle()
        Me.crossTabHeaderStyle = New DevExpress.XtraReports.UI.XRControlStyle()
        Me.crossTabDataStyle = New DevExpress.XtraReports.UI.XRControlStyle()
        Me.crossTabTotalStyle = New DevExpress.XtraReports.UI.XRControlStyle()
        Me.QtyCount = New DevExpress.XtraReports.UI.CalculatedField()
        Me.QtyCountDistinct = New DevExpress.XtraReports.UI.CalculatedField()
        Me.QtyMedian = New DevExpress.XtraReports.UI.CalculatedField()
        Me.QtyMode = New DevExpress.XtraReports.UI.CalculatedField()
        CType(Me.crossTab1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me, System.ComponentModel.ISupportInitialize).BeginInit()
        '
        'sqlDataSource1
        '
        Me.sqlDataSource1.ConnectionName = "nwind"
        Me.sqlDataSource1.Name = "sqlDataSource1"
        ColumnExpression1.ColumnName = "ProductName"
        Table1.MetaSerializable = "<Meta X=""340"" Y=""30"" Width=""125"" Height=""283"" />"
        Table1.Name = "Products"
        ColumnExpression1.Table = Table1
        Column1.Expression = ColumnExpression1
        ColumnExpression2.ColumnName = "Quantity"
        Table2.MetaSerializable = "<Meta X=""30"" Y=""30"" Width=""125"" Height=""163"" />"
        Table2.Name = "OrderDetails"
        ColumnExpression2.Table = Table2
        Column2.Expression = ColumnExpression2
        ColumnExpression3.ColumnName = "OrderDate"
        Table3.MetaSerializable = "<Meta X=""185"" Y=""30"" Width=""125"" Height=""343"" />"
        Table3.Name = "Orders"
        ColumnExpression3.Table = Table3
        Column3.Expression = ColumnExpression3
        SelectQuery1.Columns.Add(Column1)
        SelectQuery1.Columns.Add(Column2)
        SelectQuery1.Columns.Add(Column3)
        SelectQuery1.Name = "OrderDetails_1"
        RelationColumnInfo1.NestedKeyColumn = "OrderID"
        RelationColumnInfo1.ParentKeyColumn = "OrderID"
        Join1.KeyColumns.Add(RelationColumnInfo1)
        Join1.Nested = Table3
        Join1.Parent = Table2
        RelationColumnInfo2.NestedKeyColumn = "ProductID"
        RelationColumnInfo2.ParentKeyColumn = "ProductID"
        Join2.KeyColumns.Add(RelationColumnInfo2)
        Join2.Nested = Table1
        Join2.Parent = Table2
        SelectQuery1.Relations.Add(Join1)
        SelectQuery1.Relations.Add(Join2)
        SelectQuery1.Tables.Add(Table2)
        SelectQuery1.Tables.Add(Table3)
        SelectQuery1.Tables.Add(Table1)
        Me.sqlDataSource1.Queries.AddRange(New DevExpress.DataAccess.Sql.SqlQuery() {SelectQuery1})
        Me.sqlDataSource1.ResultSchemaSerializable = resources.GetString("sqlDataSource1.ResultSchemaSerializable")
        '
        'ReportHeader
        '
        Me.ReportHeader.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.label1})
        Me.ReportHeader.HeightF = 38.34636!
        Me.ReportHeader.Name = "ReportHeader"
        '
        'label1
        '
        Me.label1.AllowMarkupText = True
        Me.label1.ExpressionBindings.AddRange(New DevExpress.XtraReports.UI.ExpressionBinding() {New DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "?parameter1")})
        Me.label1.LocationFloat = New DevExpress.Utils.PointFloat(0!, 0!)
        Me.label1.Name = "label1"
        Me.label1.SizeF = New System.Drawing.SizeF(793.0!, 30.01302!)
        Me.label1.StyleName = "TitleStyle"
        Me.label1.TextFormatString = "Quantity Per Order - Product: <color=orange>{0}</color>"
        '
        'Detail
        '
        Me.Detail.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.xrSubreport1, Me.crossTab1})
        Me.Detail.HeightF = 227.3906!
        Me.Detail.Name = "Detail"
        '
        'xrSubreport1
        '
        Me.xrSubreport1.LocationFloat = New DevExpress.Utils.PointFloat(0!, 194.3906!)
        Me.xrSubreport1.Name = "xrSubreport1"
        Me.xrSubreport1.ParameterBindings.Add(New DevExpress.XtraReports.UI.ParameterBinding("parameter1", Me.parameter1))
        Me.xrSubreport1.ReportSource = New OrderDateData()
        Me.xrSubreport1.SizeF = New System.Drawing.SizeF(100.0!, 23.0!)
        '
        'parameter1
        '
        Me.parameter1.Description = "Parameter1"
        Me.parameter1.Name = "parameter1"
        Me.parameter1.ValueInfo = "Alice Mutton"
        DynamicListLookUpSettings1.DataMember = "OrderDetails_1"
        DynamicListLookUpSettings1.DataSource = Me.sqlDataSource1
        DynamicListLookUpSettings1.DisplayMember = "ProductName"
        DynamicListLookUpSettings1.SortOrder = DevExpress.Data.ColumnSortOrder.Ascending
        DynamicListLookUpSettings1.ValueMember = "ProductName"
        Me.parameter1.ValueSourceSettings = DynamicListLookUpSettings1
        '
        'crossTab1
        '
        Me.crossTab1.Cells.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.xrCrossTabCell1, Me.xrCrossTabCell2, Me.xrCrossTabCell3, Me.xrCrossTabCell4, Me.xrCrossTabCell5, Me.xrCrossTabCell6, Me.xrCrossTabCell7, Me.xrCrossTabCell8, Me.xrCrossTabCell9, Me.crossTabHeaderCell1, Me.crossTabHeaderCell2, Me.crossTabHeaderCell3, Me.crossTabHeaderCell4, Me.crossTabDataCell1, Me.crossTabTotalCell1, Me.crossTabTotalCell2, Me.crossTabTotalCell3, Me.crossTabHeaderCell5, Me.crossTabHeaderCell6, Me.crossTabDataCell2, Me.crossTabTotalCell4, Me.crossTabTotalCell5, Me.crossTabTotalCell6, Me.crossTabHeaderCell7, Me.crossTabHeaderCell8, Me.crossTabDataCell3, Me.crossTabTotalCell7, Me.crossTabTotalCell8, Me.crossTabTotalCell9, Me.crossTabHeaderCell9, Me.crossTabHeaderCell10, Me.crossTabDataCell4, Me.crossTabTotalCell10, Me.crossTabTotalCell11, Me.crossTabTotalCell12})
        CrossTabColumnDefinition1.AutoWidthMode = DevExpress.XtraReports.UI.AutoSizeMode.ShrinkAndGrow
        CrossTabColumnDefinition2.Visible = False
        CrossTabColumnDefinition3.Visible = False
        CrossTabColumnDefinition4.Visible = False
        CrossTabColumnDefinition5.Visible = False
        CrossTabColumnDefinition6.Visible = False
        Me.crossTab1.ColumnDefinitions.AddRange(New DevExpress.XtraReports.UI.CrossTab.CrossTabColumnDefinition() {CrossTabColumnDefinition1, New DevExpress.XtraReports.UI.CrossTab.CrossTabColumnDefinition(98.48486!), New DevExpress.XtraReports.UI.CrossTab.CrossTabColumnDefinition(81.81815!), New DevExpress.XtraReports.UI.CrossTab.CrossTabColumnDefinition(110.9849!), New DevExpress.XtraReports.UI.CrossTab.CrossTabColumnDefinition(116.1932!), New DevExpress.XtraReports.UI.CrossTab.CrossTabColumnDefinition(120.3598!), CrossTabColumnDefinition2, CrossTabColumnDefinition3, CrossTabColumnDefinition4, CrossTabColumnDefinition5, CrossTabColumnDefinition6})
        CrossTabColumnField1.FieldName = "ProductName"
        Me.crossTab1.ColumnFields.AddRange(New DevExpress.XtraReports.UI.CrossTab.CrossTabColumnField() {CrossTabColumnField1})
        Me.crossTab1.DataAreaStyleName = "crossTabDataStyle"
        CrossTabDataField1.FieldName = "Quantity"
        CrossTabDataField2.FieldName = "QtyCount"
        CrossTabDataField2.SummaryType = DevExpress.XtraReports.UI.CrossTab.SummaryType.Count
        CrossTabDataField3.FieldName = "QtyCountDistinct"
        CrossTabDataField3.SummaryType = DevExpress.XtraReports.UI.CrossTab.SummaryType.CountDistinct
        CrossTabDataField4.FieldName = "QtyMedian"
        CrossTabDataField4.SummaryType = DevExpress.XtraReports.UI.CrossTab.SummaryType.Median
        CrossTabDataField5.FieldName = "QtyMode"
        CrossTabDataField5.SummaryType = DevExpress.XtraReports.UI.CrossTab.SummaryType.Mode
        Me.crossTab1.DataFields.AddRange(New DevExpress.XtraReports.UI.CrossTab.CrossTabDataField() {CrossTabDataField1, CrossTabDataField2, CrossTabDataField3, CrossTabDataField4, CrossTabDataField5})
        Me.crossTab1.DataMember = "OrderDetails_1"
        Me.crossTab1.DataSource = Me.sqlDataSource1
        Me.crossTab1.FilterString = "[ProductName] = ?controlParameter1"
        Me.crossTab1.GeneralStyleName = "crossTabGeneralStyle"
        Me.crossTab1.HeaderAreaStyleName = "crossTabHeaderStyle"
        Me.crossTab1.LocationFloat = New DevExpress.Utils.PointFloat(0!, 0!)
        Me.crossTab1.Name = "crossTab1"
        Me.crossTab1.Parameters.AddRange(New DevExpress.XtraReports.UI.XRControlParameter() {New DevExpress.XtraReports.UI.XRControlParameter("controlParameter1", Me.parameter1)})
        CrossTabRowDefinition1.Visible = False
        CrossTabRowDefinition2.AutoHeightMode = DevExpress.XtraReports.UI.AutoSizeMode.GrowOnly
        Me.crossTab1.RowDefinitions.AddRange(New DevExpress.XtraReports.UI.CrossTab.CrossTabRowDefinition() {CrossTabRowDefinition1, New DevExpress.XtraReports.UI.CrossTab.CrossTabRowDefinition(50.0!), CrossTabRowDefinition2, New DevExpress.XtraReports.UI.CrossTab.CrossTabRowDefinition(25.0!)})
        CrossTabRowField1.FieldName = "OrderDate"
        CrossTabRowField1.GroupInterval = DevExpress.XtraReports.UI.CrossTab.GroupInterval.DateQuarterYear
        Me.crossTab1.RowFields.AddRange(New DevExpress.XtraReports.UI.CrossTab.CrossTabRowField() {CrossTabRowField1})
        Me.crossTab1.SizeF = New System.Drawing.SizeF(888.0!, 125.0!)
        Me.crossTab1.TotalAreaStyleName = "crossTabTotalStyle"
        '
        'xrCrossTabCell1
        '
        Me.xrCrossTabCell1.BackColor = System.Drawing.Color.FromArgb(CType(CType(242, Byte), Integer), CType(CType(242, Byte), Integer), CType(CType(242, Byte), Integer))
        Me.xrCrossTabCell1.ColumnIndex = 0
        Me.xrCrossTabCell1.Name = "xrCrossTabCell1"
        Me.xrCrossTabCell1.RowIndex = 0
        Me.xrCrossTabCell1.RowSpan = 2
        Me.xrCrossTabCell1.Text = "Order Date Range"
        '
        'xrCrossTabCell2
        '
        Me.xrCrossTabCell2.AllowMarkupText = True
        Me.xrCrossTabCell2.ColumnIndex = 1
        Me.xrCrossTabCell2.Name = "xrCrossTabCell2"
        Me.xrCrossTabCell2.RowIndex = 2
        '
        'xrCrossTabCell3
        '
        Me.xrCrossTabCell3.ColumnIndex = 1
        Me.xrCrossTabCell3.ColumnSpan = 5
        Me.xrCrossTabCell3.Name = "xrCrossTabCell3"
        Me.xrCrossTabCell3.RowIndex = 0
        '
        'xrCrossTabCell4
        '
        Me.xrCrossTabCell4.ColumnIndex = 6
        Me.xrCrossTabCell4.ColumnSpan = 5
        Me.xrCrossTabCell4.Name = "xrCrossTabCell4"
        Me.xrCrossTabCell4.RowIndex = 0
        Me.xrCrossTabCell4.Text = "Grand Total"
        '
        'xrCrossTabCell5
        '
        Me.xrCrossTabCell5.ColumnIndex = 6
        Me.xrCrossTabCell5.Name = "xrCrossTabCell5"
        Me.xrCrossTabCell5.RowIndex = 2
        '
        'xrCrossTabCell6
        '
        Me.xrCrossTabCell6.ColumnIndex = 0
        Me.xrCrossTabCell6.ExpressionBindings.AddRange(New DevExpress.XtraReports.UI.ExpressionBinding() {New DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "BackColor", "IIF([Arguments.GroupRowIndex]%2==0,'LightGray',?)" & Global.Microsoft.VisualBasic.ChrW(10))})
        Me.xrCrossTabCell6.Name = "xrCrossTabCell6"
        Me.xrCrossTabCell6.RowIndex = 2
        '
        'xrCrossTabCell7
        '
        Me.xrCrossTabCell7.BackColor = System.Drawing.Color.Black
        Me.xrCrossTabCell7.BorderColor = System.Drawing.Color.White
        Me.xrCrossTabCell7.ColumnIndex = 0
        Me.xrCrossTabCell7.ForeColor = System.Drawing.Color.White
        Me.xrCrossTabCell7.Name = "xrCrossTabCell7"
        Me.xrCrossTabCell7.RowIndex = 3
        Me.xrCrossTabCell7.Text = "Grand Total"
        '
        'xrCrossTabCell8
        '
        Me.xrCrossTabCell8.ColumnIndex = 1
        Me.xrCrossTabCell8.Name = "xrCrossTabCell8"
        Me.xrCrossTabCell8.RowIndex = 3
        '
        'xrCrossTabCell9
        '
        Me.xrCrossTabCell9.ColumnIndex = 6
        Me.xrCrossTabCell9.Name = "xrCrossTabCell9"
        Me.xrCrossTabCell9.RowIndex = 3
        '
        'crossTabHeaderCell1
        '
        Me.crossTabHeaderCell1.AllowMarkupText = True
        Me.crossTabHeaderCell1.ColumnIndex = 1
        Me.crossTabHeaderCell1.Name = "crossTabHeaderCell1"
        Me.crossTabHeaderCell1.RowIndex = 1
        Me.crossTabHeaderCell1.Text = "<color=red>Sum</color><br><size=-3>The sum of all the values.</size>"
        Me.crossTabHeaderCell1.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        '
        'crossTabHeaderCell2
        '
        Me.crossTabHeaderCell2.AllowMarkupText = True
        Me.crossTabHeaderCell2.ColumnIndex = 2
        Me.crossTabHeaderCell2.Name = "crossTabHeaderCell2"
        Me.crossTabHeaderCell2.RowIndex = 1
        Me.crossTabHeaderCell2.Text = "<href=https://docs.devexpress.com/XtraReports/DevExpress.XtraReports.UI.CrossTab." &
    "SummaryType>Count</href><br><size=-3>The number of values.</size>"
        Me.crossTabHeaderCell2.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        '
        'crossTabHeaderCell3
        '
        Me.crossTabHeaderCell3.ColumnIndex = 6
        Me.crossTabHeaderCell3.Name = "crossTabHeaderCell3"
        Me.crossTabHeaderCell3.RowIndex = 1
        Me.crossTabHeaderCell3.Text = "Quantity"
        '
        'crossTabHeaderCell4
        '
        Me.crossTabHeaderCell4.ColumnIndex = 7
        Me.crossTabHeaderCell4.Name = "crossTabHeaderCell4"
        Me.crossTabHeaderCell4.RowIndex = 1
        Me.crossTabHeaderCell4.Text = "Quantity"
        '
        'crossTabDataCell1
        '
        Me.crossTabDataCell1.ColumnIndex = 2
        Me.crossTabDataCell1.Name = "crossTabDataCell1"
        Me.crossTabDataCell1.RowIndex = 2
        '
        'crossTabTotalCell1
        '
        Me.crossTabTotalCell1.ColumnIndex = 7
        Me.crossTabTotalCell1.Name = "crossTabTotalCell1"
        Me.crossTabTotalCell1.RowIndex = 2
        '
        'crossTabTotalCell2
        '
        Me.crossTabTotalCell2.ColumnIndex = 2
        Me.crossTabTotalCell2.Name = "crossTabTotalCell2"
        Me.crossTabTotalCell2.RowIndex = 3
        '
        'crossTabTotalCell3
        '
        Me.crossTabTotalCell3.ColumnIndex = 7
        Me.crossTabTotalCell3.Name = "crossTabTotalCell3"
        Me.crossTabTotalCell3.RowIndex = 3
        '
        'crossTabHeaderCell5
        '
        Me.crossTabHeaderCell5.AllowMarkupText = True
        Me.crossTabHeaderCell5.ColumnIndex = 3
        Me.crossTabHeaderCell5.Name = "crossTabHeaderCell5"
        Me.crossTabHeaderCell5.RowIndex = 1
        Me.crossTabHeaderCell5.Text = "<href=https://docs.devexpress.com/XtraReports/DevExpress.XtraReports.UI.CrossTab." &
    "SummaryType>CountDistinct</href><br><size=-3>The number of unique values.</size>" &
    ""
        Me.crossTabHeaderCell5.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        '
        'crossTabHeaderCell6
        '
        Me.crossTabHeaderCell6.ColumnIndex = 8
        Me.crossTabHeaderCell6.Name = "crossTabHeaderCell6"
        Me.crossTabHeaderCell6.RowIndex = 1
        Me.crossTabHeaderCell6.Text = "Quantity"
        '
        'crossTabDataCell2
        '
        Me.crossTabDataCell2.AllowMarkupText = True
        Me.crossTabDataCell2.ColumnIndex = 3
        Me.crossTabDataCell2.ExpressionBindings.AddRange(New DevExpress.XtraReports.UI.ExpressionBinding() {New DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "IIF([QtyCount]>[QtyCountDistinct],[QtyCountDistinct] + '<image=downarrowbmp>', [Q" &
                    "tyCountDistinct])")})
        Me.crossTabDataCell2.Name = "crossTabDataCell2"
        Me.crossTabDataCell2.RowIndex = 2
        '
        'crossTabTotalCell4
        '
        Me.crossTabTotalCell4.ColumnIndex = 8
        Me.crossTabTotalCell4.Name = "crossTabTotalCell4"
        Me.crossTabTotalCell4.RowIndex = 2
        '
        'crossTabTotalCell5
        '
        Me.crossTabTotalCell5.ColumnIndex = 3
        Me.crossTabTotalCell5.Name = "crossTabTotalCell5"
        Me.crossTabTotalCell5.RowIndex = 3
        '
        'crossTabTotalCell6
        '
        Me.crossTabTotalCell6.ColumnIndex = 8
        Me.crossTabTotalCell6.Name = "crossTabTotalCell6"
        Me.crossTabTotalCell6.RowIndex = 3
        '
        'crossTabHeaderCell7
        '
        Me.crossTabHeaderCell7.AllowMarkupText = True
        Me.crossTabHeaderCell7.ColumnIndex = 4
        Me.crossTabHeaderCell7.Name = "crossTabHeaderCell7"
        Me.crossTabHeaderCell7.RowIndex = 1
        Me.crossTabHeaderCell7.Text = "<href=https://docs.devexpress.com/XtraReports/DevExpress.XtraReports.UI.CrossTab." &
    "SummaryType>Median</href><br><size=-3>The middle value in an ordered list of val" &
    "ues.</size>"
        Me.crossTabHeaderCell7.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        '
        'crossTabHeaderCell8
        '
        Me.crossTabHeaderCell8.ColumnIndex = 9
        Me.crossTabHeaderCell8.Name = "crossTabHeaderCell8"
        Me.crossTabHeaderCell8.RowIndex = 1
        Me.crossTabHeaderCell8.Text = "Quantity"
        '
        'crossTabDataCell3
        '
        Me.crossTabDataCell3.ColumnIndex = 4
        Me.crossTabDataCell3.Name = "crossTabDataCell3"
        Me.crossTabDataCell3.RowIndex = 2
        '
        'crossTabTotalCell7
        '
        Me.crossTabTotalCell7.ColumnIndex = 9
        Me.crossTabTotalCell7.Name = "crossTabTotalCell7"
        Me.crossTabTotalCell7.RowIndex = 2
        '
        'crossTabTotalCell8
        '
        Me.crossTabTotalCell8.ColumnIndex = 4
        Me.crossTabTotalCell8.Name = "crossTabTotalCell8"
        Me.crossTabTotalCell8.RowIndex = 3
        '
        'crossTabTotalCell9
        '
        Me.crossTabTotalCell9.ColumnIndex = 9
        Me.crossTabTotalCell9.Name = "crossTabTotalCell9"
        Me.crossTabTotalCell9.RowIndex = 3
        '
        'crossTabHeaderCell9
        '
        Me.crossTabHeaderCell9.AllowMarkupText = True
        Me.crossTabHeaderCell9.ColumnIndex = 5
        Me.crossTabHeaderCell9.Name = "crossTabHeaderCell9"
        Me.crossTabHeaderCell9.RowIndex = 1
        Me.crossTabHeaderCell9.Text = "<href=https://docs.devexpress.com/XtraReports/DevExpress.XtraReports.UI.CrossTab." &
    "SummaryType>Mode</href><br><size=-3>The value that appears most frequently.</siz" &
    "e>"
        Me.crossTabHeaderCell9.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        '
        'crossTabHeaderCell10
        '
        Me.crossTabHeaderCell10.ColumnIndex = 10
        Me.crossTabHeaderCell10.Name = "crossTabHeaderCell10"
        Me.crossTabHeaderCell10.RowIndex = 1
        Me.crossTabHeaderCell10.Text = "Quantity"
        '
        'crossTabDataCell4
        '
        Me.crossTabDataCell4.ColumnIndex = 5
        Me.crossTabDataCell4.Name = "crossTabDataCell4"
        Me.crossTabDataCell4.RowIndex = 2
        '
        'crossTabTotalCell10
        '
        Me.crossTabTotalCell10.ColumnIndex = 10
        Me.crossTabTotalCell10.Name = "crossTabTotalCell10"
        Me.crossTabTotalCell10.RowIndex = 2
        '
        'crossTabTotalCell11
        '
        Me.crossTabTotalCell11.ColumnIndex = 5
        Me.crossTabTotalCell11.Name = "crossTabTotalCell11"
        Me.crossTabTotalCell11.RowIndex = 3
        '
        'crossTabTotalCell12
        '
        Me.crossTabTotalCell12.ColumnIndex = 10
        Me.crossTabTotalCell12.Name = "crossTabTotalCell12"
        Me.crossTabTotalCell12.RowIndex = 3
        '
        'TopMargin
        '
        Me.TopMargin.HeightF = 48.0!
        Me.TopMargin.Name = "TopMargin"
        '
        'BottomMargin
        '
        Me.BottomMargin.HeightF = 34.0!
        Me.BottomMargin.Name = "BottomMargin"
        '
        'TitleStyle
        '
        Me.TitleStyle.Font = New System.Drawing.Font("Arial", 18.0!)
        Me.TitleStyle.Name = "TitleStyle"
        Me.TitleStyle.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        '
        'crossTabGeneralStyle
        '
        Me.crossTabGeneralStyle.BorderColor = System.Drawing.Color.FromArgb(CType(CType(230, Byte), Integer), CType(CType(232, Byte), Integer), CType(CType(234, Byte), Integer))
        Me.crossTabGeneralStyle.Borders = CType((((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Top) _
            Or DevExpress.XtraPrinting.BorderSide.Right) _
            Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide)
        Me.crossTabGeneralStyle.BorderWidth = 1.0!
        Me.crossTabGeneralStyle.Font = New System.Drawing.Font("Arial", 9.75!)
        Me.crossTabGeneralStyle.Name = "crossTabGeneralStyle"
        Me.crossTabGeneralStyle.Padding = New DevExpress.XtraPrinting.PaddingInfo(6, 6, 0, 0, 100.0!)
        '
        'crossTabHeaderStyle
        '
        Me.crossTabHeaderStyle.BackColor = System.Drawing.Color.FromArgb(CType(CType(250, Byte), Integer), CType(CType(251, Byte), Integer), CType(CType(252, Byte), Integer))
        Me.crossTabHeaderStyle.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold)
        Me.crossTabHeaderStyle.Name = "crossTabHeaderStyle"
        Me.crossTabHeaderStyle.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        '
        'crossTabDataStyle
        '
        Me.crossTabDataStyle.Name = "crossTabDataStyle"
        Me.crossTabDataStyle.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
        '
        'crossTabTotalStyle
        '
        Me.crossTabTotalStyle.BackColor = System.Drawing.Color.FromArgb(CType(CType(250, Byte), Integer), CType(CType(251, Byte), Integer), CType(CType(252, Byte), Integer))
        Me.crossTabTotalStyle.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold)
        Me.crossTabTotalStyle.Name = "crossTabTotalStyle"
        Me.crossTabTotalStyle.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
        '
        'QtyCount
        '
        Me.QtyCount.DataMember = "OrderDetails_1"
        Me.QtyCount.DataSource = Me.sqlDataSource1
        Me.QtyCount.Expression = "[Quantity]"
        Me.QtyCount.FieldType = DevExpress.XtraReports.UI.FieldType.Int32
        Me.QtyCount.Name = "QtyCount"
        '
        'QtyCountDistinct
        '
        Me.QtyCountDistinct.DataMember = "OrderDetails_1"
        Me.QtyCountDistinct.DataSource = Me.sqlDataSource1
        Me.QtyCountDistinct.Expression = "[Quantity]"
        Me.QtyCountDistinct.FieldType = DevExpress.XtraReports.UI.FieldType.Int32
        Me.QtyCountDistinct.Name = "QtyCountDistinct"
        '
        'QtyMedian
        '
        Me.QtyMedian.DataMember = "OrderDetails_1"
        Me.QtyMedian.DataSource = Me.sqlDataSource1
        Me.QtyMedian.Expression = "[Quantity]"
        Me.QtyMedian.FieldType = DevExpress.XtraReports.UI.FieldType.Int32
        Me.QtyMedian.Name = "QtyMedian"
        '
        'QtyMode
        '
        Me.QtyMode.DataMember = "OrderDetails_1"
        Me.QtyMode.DataSource = Me.sqlDataSource1
        Me.QtyMode.Expression = "[Quantity]"
        Me.QtyMode.FieldType = DevExpress.XtraReports.UI.FieldType.Int32
        Me.QtyMode.Name = "QtyMode"
        '
        'NewAggregateFunctions
        '
        Me.Bands.AddRange(New DevExpress.XtraReports.UI.Band() {Me.ReportHeader, Me.Detail, Me.TopMargin, Me.BottomMargin})
        Me.CalculatedFields.AddRange(New DevExpress.XtraReports.UI.CalculatedField() {Me.QtyCount, Me.QtyCountDistinct, Me.QtyMedian, Me.QtyMode})
        Me.ComponentStorage.AddRange(New System.ComponentModel.IComponent() {Me.sqlDataSource1})
        Me.DrawGrid = False
        Me.Font = New System.Drawing.Font("Arial", 9.75!)
        Me.HorizontalContentSplitting = DevExpress.XtraPrinting.HorizontalContentSplitting.Smart
        Me.ImageResources.AddRange(New DevExpress.XtraPrinting.Drawing.ImageItem() {New DevExpress.XtraPrinting.Drawing.ImageItem("uparrow", New DevExpress.XtraPrinting.Drawing.ImageSource("svg", resources.GetString("$this.ImageResources"))), New DevExpress.XtraPrinting.Drawing.ImageItem("downarrow", New DevExpress.XtraPrinting.Drawing.ImageSource("svg", resources.GetString("$this.ImageResources1"))), New DevExpress.XtraPrinting.Drawing.ImageItem("downarrowbmp", New DevExpress.XtraPrinting.Drawing.ImageSource("img", resources.GetString("$this.ImageResources2"))), New DevExpress.XtraPrinting.Drawing.ImageItem("uparrowbmp", New DevExpress.XtraPrinting.Drawing.ImageSource("img", resources.GetString("$this.ImageResources3")))})
        Me.Landscape = True
        Me.Margins = New System.Drawing.Printing.Margins(100, 102, 48, 34)
        Me.PageHeight = 850
        Me.PageWidth = 1100
        Me.ParameterPanelLayoutItems.AddRange(New DevExpress.XtraReports.Parameters.ParameterPanelLayoutItem() {New DevExpress.XtraReports.Parameters.ParameterLayoutItem(Me.parameter1, DevExpress.XtraReports.Parameters.Orientation.Horizontal)})
        Me.Parameters.AddRange(New DevExpress.XtraReports.Parameters.Parameter() {Me.parameter1})
        Me.RequestParameters = False
        Me.StyleSheet.AddRange(New DevExpress.XtraReports.UI.XRControlStyle() {Me.TitleStyle, Me.crossTabGeneralStyle, Me.crossTabHeaderStyle, Me.crossTabDataStyle, Me.crossTabTotalStyle})
        Me.Version = "22.1"
        Me.VerticalContentSplitting = DevExpress.XtraPrinting.VerticalContentSplitting.Smart
        CType(Me.crossTab1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me, System.ComponentModel.ISupportInitialize).EndInit()

    End Sub

    Friend WithEvents ReportHeader As DevExpress.XtraReports.UI.ReportHeaderBand
    Friend WithEvents label1 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents Detail As DevExpress.XtraReports.UI.DetailBand
    Friend WithEvents xrSubreport1 As DevExpress.XtraReports.UI.XRSubreport
    Friend WithEvents parameter1 As DevExpress.XtraReports.Parameters.Parameter
    Friend WithEvents sqlDataSource1 As DevExpress.DataAccess.Sql.SqlDataSource
    Friend WithEvents crossTab1 As DevExpress.XtraReports.UI.XRCrossTab
    Friend WithEvents xrCrossTabCell1 As DevExpress.XtraReports.UI.CrossTab.XRCrossTabCell
    Friend WithEvents xrCrossTabCell2 As DevExpress.XtraReports.UI.CrossTab.XRCrossTabCell
    Friend WithEvents xrCrossTabCell3 As DevExpress.XtraReports.UI.CrossTab.XRCrossTabCell
    Friend WithEvents xrCrossTabCell4 As DevExpress.XtraReports.UI.CrossTab.XRCrossTabCell
    Friend WithEvents xrCrossTabCell5 As DevExpress.XtraReports.UI.CrossTab.XRCrossTabCell
    Friend WithEvents xrCrossTabCell6 As DevExpress.XtraReports.UI.CrossTab.XRCrossTabCell
    Friend WithEvents xrCrossTabCell7 As DevExpress.XtraReports.UI.CrossTab.XRCrossTabCell
    Friend WithEvents xrCrossTabCell8 As DevExpress.XtraReports.UI.CrossTab.XRCrossTabCell
    Friend WithEvents xrCrossTabCell9 As DevExpress.XtraReports.UI.CrossTab.XRCrossTabCell
    Friend WithEvents crossTabHeaderCell1 As DevExpress.XtraReports.UI.CrossTab.XRCrossTabCell
    Friend WithEvents crossTabHeaderCell2 As DevExpress.XtraReports.UI.CrossTab.XRCrossTabCell
    Friend WithEvents crossTabHeaderCell3 As DevExpress.XtraReports.UI.CrossTab.XRCrossTabCell
    Friend WithEvents crossTabHeaderCell4 As DevExpress.XtraReports.UI.CrossTab.XRCrossTabCell
    Friend WithEvents crossTabDataCell1 As DevExpress.XtraReports.UI.CrossTab.XRCrossTabCell
    Friend WithEvents crossTabTotalCell1 As DevExpress.XtraReports.UI.CrossTab.XRCrossTabCell
    Friend WithEvents crossTabTotalCell2 As DevExpress.XtraReports.UI.CrossTab.XRCrossTabCell
    Friend WithEvents crossTabTotalCell3 As DevExpress.XtraReports.UI.CrossTab.XRCrossTabCell
    Friend WithEvents crossTabHeaderCell5 As DevExpress.XtraReports.UI.CrossTab.XRCrossTabCell
    Friend WithEvents crossTabHeaderCell6 As DevExpress.XtraReports.UI.CrossTab.XRCrossTabCell
    Friend WithEvents crossTabDataCell2 As DevExpress.XtraReports.UI.CrossTab.XRCrossTabCell
    Friend WithEvents crossTabTotalCell4 As DevExpress.XtraReports.UI.CrossTab.XRCrossTabCell
    Friend WithEvents crossTabTotalCell5 As DevExpress.XtraReports.UI.CrossTab.XRCrossTabCell
    Friend WithEvents crossTabTotalCell6 As DevExpress.XtraReports.UI.CrossTab.XRCrossTabCell
    Friend WithEvents crossTabHeaderCell7 As DevExpress.XtraReports.UI.CrossTab.XRCrossTabCell
    Friend WithEvents crossTabHeaderCell8 As DevExpress.XtraReports.UI.CrossTab.XRCrossTabCell
    Friend WithEvents crossTabDataCell3 As DevExpress.XtraReports.UI.CrossTab.XRCrossTabCell
    Friend WithEvents crossTabTotalCell7 As DevExpress.XtraReports.UI.CrossTab.XRCrossTabCell
    Friend WithEvents crossTabTotalCell8 As DevExpress.XtraReports.UI.CrossTab.XRCrossTabCell
    Friend WithEvents crossTabTotalCell9 As DevExpress.XtraReports.UI.CrossTab.XRCrossTabCell
    Friend WithEvents crossTabHeaderCell9 As DevExpress.XtraReports.UI.CrossTab.XRCrossTabCell
    Friend WithEvents crossTabHeaderCell10 As DevExpress.XtraReports.UI.CrossTab.XRCrossTabCell
    Friend WithEvents crossTabDataCell4 As DevExpress.XtraReports.UI.CrossTab.XRCrossTabCell
    Friend WithEvents crossTabTotalCell10 As DevExpress.XtraReports.UI.CrossTab.XRCrossTabCell
    Friend WithEvents crossTabTotalCell11 As DevExpress.XtraReports.UI.CrossTab.XRCrossTabCell
    Friend WithEvents crossTabTotalCell12 As DevExpress.XtraReports.UI.CrossTab.XRCrossTabCell
    Friend WithEvents TopMargin As DevExpress.XtraReports.UI.TopMarginBand
    Friend WithEvents BottomMargin As DevExpress.XtraReports.UI.BottomMarginBand
    Friend WithEvents TitleStyle As DevExpress.XtraReports.UI.XRControlStyle
    Friend WithEvents crossTabGeneralStyle As DevExpress.XtraReports.UI.XRControlStyle
    Friend WithEvents crossTabHeaderStyle As DevExpress.XtraReports.UI.XRControlStyle
    Friend WithEvents crossTabDataStyle As DevExpress.XtraReports.UI.XRControlStyle
    Friend WithEvents crossTabTotalStyle As DevExpress.XtraReports.UI.XRControlStyle
    Friend WithEvents QtyCount As DevExpress.XtraReports.UI.CalculatedField
    Friend WithEvents QtyCountDistinct As DevExpress.XtraReports.UI.CalculatedField
    Friend WithEvents QtyMedian As DevExpress.XtraReports.UI.CalculatedField
    Friend WithEvents QtyMode As DevExpress.XtraReports.UI.CalculatedField
End Class
