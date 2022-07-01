partial class OrderDateData
{
    /// <summary>
    /// Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary> 
    /// Clean up any resources being used.
    /// </summary>
    /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
    protected override void Dispose(bool disposing)
    {
        if (disposing && (components != null))
        {
            components.Dispose();
        }
        base.Dispose(disposing);
    }

    #region Designer generated code

    /// <summary>
    /// Required method for Designer support - do not modify
    /// the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {
        this.components = new System.ComponentModel.Container();
        DevExpress.DataAccess.Sql.SelectQuery selectQuery1 = new DevExpress.DataAccess.Sql.SelectQuery();
        DevExpress.DataAccess.Sql.Column column1 = new DevExpress.DataAccess.Sql.Column();
        DevExpress.DataAccess.Sql.ColumnExpression columnExpression1 = new DevExpress.DataAccess.Sql.ColumnExpression();
        DevExpress.DataAccess.Sql.Table table1 = new DevExpress.DataAccess.Sql.Table();
        DevExpress.DataAccess.Sql.Column column2 = new DevExpress.DataAccess.Sql.Column();
        DevExpress.DataAccess.Sql.ColumnExpression columnExpression2 = new DevExpress.DataAccess.Sql.ColumnExpression();
        DevExpress.DataAccess.Sql.Table table4 = new DevExpress.DataAccess.Sql.Table();
        DevExpress.DataAccess.Sql.Column column3 = new DevExpress.DataAccess.Sql.Column();
        DevExpress.DataAccess.Sql.ColumnExpression columnExpression3 = new DevExpress.DataAccess.Sql.ColumnExpression();
        DevExpress.DataAccess.Sql.Table table5 = new DevExpress.DataAccess.Sql.Table();
        DevExpress.DataAccess.Sql.Join join1 = new DevExpress.DataAccess.Sql.Join();
        DevExpress.DataAccess.Sql.RelationColumnInfo relationColumnInfo1 = new DevExpress.DataAccess.Sql.RelationColumnInfo();
        DevExpress.DataAccess.Sql.Join join2 = new DevExpress.DataAccess.Sql.Join();
        DevExpress.DataAccess.Sql.RelationColumnInfo relationColumnInfo2 = new DevExpress.DataAccess.Sql.RelationColumnInfo();
        System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(OrderDateData));
        this.TopMargin = new DevExpress.XtraReports.UI.TopMarginBand();
        this.BottomMargin = new DevExpress.XtraReports.UI.BottomMarginBand();
        this.GroupHeader1 = new DevExpress.XtraReports.UI.GroupHeaderBand();
        this.GroupHeader2 = new DevExpress.XtraReports.UI.GroupHeaderBand();
        this.Detail = new DevExpress.XtraReports.UI.DetailBand();
        this.table2 = new DevExpress.XtraReports.UI.XRTable();
        this.tableRow2 = new DevExpress.XtraReports.UI.XRTableRow();
        this.tableCell3 = new DevExpress.XtraReports.UI.XRTableCell();
        this.tableCell4 = new DevExpress.XtraReports.UI.XRTableCell();
        this.table3 = new DevExpress.XtraReports.UI.XRTable();
        this.tableRow3 = new DevExpress.XtraReports.UI.XRTableRow();
        this.tableCell5 = new DevExpress.XtraReports.UI.XRTableCell();
        this.tableCell6 = new DevExpress.XtraReports.UI.XRTableCell();
        this.sqlDataSource1 = new DevExpress.DataAccess.Sql.SqlDataSource(this.components);
        this.Title = new DevExpress.XtraReports.UI.XRControlStyle();
        this.GroupCaption1 = new DevExpress.XtraReports.UI.XRControlStyle();
        this.GroupData1 = new DevExpress.XtraReports.UI.XRControlStyle();
        this.DetailCaption1 = new DevExpress.XtraReports.UI.XRControlStyle();
        this.DetailData1 = new DevExpress.XtraReports.UI.XRControlStyle();
        this.GroupFooterBackground3 = new DevExpress.XtraReports.UI.XRControlStyle();
        this.DetailData3_Odd = new DevExpress.XtraReports.UI.XRControlStyle();
        this.PageInfo = new DevExpress.XtraReports.UI.XRControlStyle();
        this.parameter1 = new DevExpress.XtraReports.Parameters.Parameter();
        ((System.ComponentModel.ISupportInitialize)(this.table2)).BeginInit();
        ((System.ComponentModel.ISupportInitialize)(this.table3)).BeginInit();
        ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
        // 
        // TopMargin
        // 
        this.TopMargin.Name = "TopMargin";
        // 
        // BottomMargin
        // 
        this.BottomMargin.Name = "BottomMargin";
        // 
        // GroupHeader1
        // 
        this.GroupHeader1.GroupFields.AddRange(new DevExpress.XtraReports.UI.GroupField[] {
        new DevExpress.XtraReports.UI.GroupField("ProductName", DevExpress.XtraReports.UI.XRColumnSortOrder.Ascending)});
        this.GroupHeader1.GroupUnion = DevExpress.XtraReports.UI.GroupUnion.WithFirstDetail;
        this.GroupHeader1.HeightF = 0F;
        this.GroupHeader1.Name = "GroupHeader1";
        // 
        // GroupHeader2
        // 
        this.GroupHeader2.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
        this.table2});
        this.GroupHeader2.GroupUnion = DevExpress.XtraReports.UI.GroupUnion.WithFirstDetail;
        this.GroupHeader2.HeightF = 25F;
        this.GroupHeader2.Level = 1;
        this.GroupHeader2.Name = "GroupHeader2";
        // 
        // Detail
        // 
        this.Detail.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
        this.table3});
        this.Detail.HeightF = 20F;
        this.Detail.MultiColumn.ColumnCount = 3;
        this.Detail.MultiColumn.ColumnSpacing = 10F;
        this.Detail.MultiColumn.Mode = DevExpress.XtraReports.UI.MultiColumnMode.UseColumnCount;
        this.Detail.Name = "Detail";
        // 
        // table2
        // 
        this.table2.LocationFloat = new DevExpress.Utils.PointFloat(0F, 0F);
        this.table2.Name = "table2";
        this.table2.Rows.AddRange(new DevExpress.XtraReports.UI.XRTableRow[] {
        this.tableRow2});
        this.table2.SizeF = new System.Drawing.SizeF(259.9999F, 25F);
        // 
        // tableRow2
        // 
        this.tableRow2.Cells.AddRange(new DevExpress.XtraReports.UI.XRTableCell[] {
        this.tableCell3,
        this.tableCell4});
        this.tableRow2.Name = "tableRow2";
        this.tableRow2.Weight = 1D;
        // 
        // tableCell3
        // 
        this.tableCell3.Borders = DevExpress.XtraPrinting.BorderSide.None;
        this.tableCell3.Name = "tableCell3";
        this.tableCell3.StyleName = "DetailCaption1";
        this.tableCell3.StylePriority.UseBorders = false;
        this.tableCell3.Text = "Order Date";
        this.tableCell3.Weight = 0.14600667334624726D;
        // 
        // tableCell4
        // 
        this.tableCell4.Name = "tableCell4";
        this.tableCell4.StyleName = "DetailCaption1";
        this.tableCell4.StylePriority.UseTextAlignment = false;
        this.tableCell4.Text = "Quantity";
        this.tableCell4.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight;
        this.tableCell4.Weight = 0.14288213374669262D;
        // 
        // table3
        // 
        this.table3.LocationFloat = new DevExpress.Utils.PointFloat(0F, 0F);
        this.table3.Name = "table3";
        this.table3.OddStyleName = "DetailData3_Odd";
        this.table3.Rows.AddRange(new DevExpress.XtraReports.UI.XRTableRow[] {
        this.tableRow3});
        this.table3.SizeF = new System.Drawing.SizeF(260F, 20F);
        // 
        // tableRow3
        // 
        this.tableRow3.Cells.AddRange(new DevExpress.XtraReports.UI.XRTableCell[] {
        this.tableCell5,
        this.tableCell6});
        this.tableRow3.Name = "tableRow3";
        this.tableRow3.Weight = 11.5D;
        // 
        // tableCell5
        // 
        this.tableCell5.Borders = DevExpress.XtraPrinting.BorderSide.None;
        this.tableCell5.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
        new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[OrderDate]")});
        this.tableCell5.Name = "tableCell5";
        this.tableCell5.StyleName = "DetailData1";
        this.tableCell5.StylePriority.UseBorders = false;
        this.tableCell5.TextFormatString = "{0:dd/MM/yyyy}";
        this.tableCell5.Weight = 0.14600665622287329D;
        // 
        // tableCell6
        // 
        this.tableCell6.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
        new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[Quantity]")});
        this.tableCell6.Name = "tableCell6";
        this.tableCell6.StyleName = "DetailData1";
        this.tableCell6.StylePriority.UseTextAlignment = false;
        this.tableCell6.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight;
        this.tableCell6.Weight = 0.14288219875759545D;
        // 
        // sqlDataSource1
        // 
        this.sqlDataSource1.ConnectionName = "nwind";
        this.sqlDataSource1.Name = "sqlDataSource1";
        columnExpression1.ColumnName = "ProductName";
        table1.MetaSerializable = "<Meta X=\"340\" Y=\"30\" Width=\"125\" Height=\"283\" />";
        table1.Name = "Products";
        columnExpression1.Table = table1;
        column1.Expression = columnExpression1;
        columnExpression2.ColumnName = "OrderDate";
        table4.MetaSerializable = "<Meta X=\"185\" Y=\"30\" Width=\"125\" Height=\"343\" />";
        table4.Name = "Orders";
        columnExpression2.Table = table4;
        column2.Expression = columnExpression2;
        columnExpression3.ColumnName = "Quantity";
        table5.MetaSerializable = "<Meta X=\"30\" Y=\"30\" Width=\"125\" Height=\"163\" />";
        table5.Name = "OrderDetails";
        columnExpression3.Table = table5;
        column3.Expression = columnExpression3;
        selectQuery1.Columns.Add(column1);
        selectQuery1.Columns.Add(column2);
        selectQuery1.Columns.Add(column3);
        selectQuery1.Name = "OrderDetails_1";
        relationColumnInfo1.NestedKeyColumn = "OrderID";
        relationColumnInfo1.ParentKeyColumn = "OrderID";
        join1.KeyColumns.Add(relationColumnInfo1);
        join1.Nested = table4;
        join1.Parent = table5;
        relationColumnInfo2.NestedKeyColumn = "ProductID";
        relationColumnInfo2.ParentKeyColumn = "ProductID";
        join2.KeyColumns.Add(relationColumnInfo2);
        join2.Nested = table1;
        join2.Parent = table5;
        selectQuery1.Relations.Add(join1);
        selectQuery1.Relations.Add(join2);
        selectQuery1.Tables.Add(table5);
        selectQuery1.Tables.Add(table4);
        selectQuery1.Tables.Add(table1);
        this.sqlDataSource1.Queries.AddRange(new DevExpress.DataAccess.Sql.SqlQuery[] {
        selectQuery1});
        this.sqlDataSource1.ResultSchemaSerializable = resources.GetString("sqlDataSource1.ResultSchemaSerializable");
        // 
        // Title
        // 
        this.Title.BackColor = System.Drawing.Color.Transparent;
        this.Title.BorderColor = System.Drawing.Color.Black;
        this.Title.Borders = DevExpress.XtraPrinting.BorderSide.None;
        this.Title.BorderWidth = 1F;
        this.Title.Font = new System.Drawing.Font("Arial", 14.25F);
        this.Title.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(75)))), ((int)(((byte)(75)))));
        this.Title.Name = "Title";
        this.Title.Padding = new DevExpress.XtraPrinting.PaddingInfo(6, 6, 0, 0, 100F);
        // 
        // GroupCaption1
        // 
        this.GroupCaption1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(162)))), ((int)(((byte)(162)))), ((int)(((byte)(162)))));
        this.GroupCaption1.BorderColor = System.Drawing.Color.White;
        this.GroupCaption1.Borders = DevExpress.XtraPrinting.BorderSide.Bottom;
        this.GroupCaption1.BorderWidth = 2F;
        this.GroupCaption1.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold);
        this.GroupCaption1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(228)))), ((int)(((byte)(228)))));
        this.GroupCaption1.Name = "GroupCaption1";
        this.GroupCaption1.Padding = new DevExpress.XtraPrinting.PaddingInfo(6, 2, 0, 0, 100F);
        this.GroupCaption1.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
        // 
        // GroupData1
        // 
        this.GroupData1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(162)))), ((int)(((byte)(162)))), ((int)(((byte)(162)))));
        this.GroupData1.BorderColor = System.Drawing.Color.White;
        this.GroupData1.Borders = DevExpress.XtraPrinting.BorderSide.Bottom;
        this.GroupData1.BorderWidth = 2F;
        this.GroupData1.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold);
        this.GroupData1.ForeColor = System.Drawing.Color.White;
        this.GroupData1.Name = "GroupData1";
        this.GroupData1.Padding = new DevExpress.XtraPrinting.PaddingInfo(6, 2, 0, 0, 100F);
        this.GroupData1.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
        // 
        // DetailCaption1
        // 
        this.DetailCaption1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(75)))), ((int)(((byte)(75)))));
        this.DetailCaption1.BorderColor = System.Drawing.Color.White;
        this.DetailCaption1.Borders = DevExpress.XtraPrinting.BorderSide.Left;
        this.DetailCaption1.BorderWidth = 2F;
        this.DetailCaption1.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold);
        this.DetailCaption1.ForeColor = System.Drawing.Color.White;
        this.DetailCaption1.Name = "DetailCaption1";
        this.DetailCaption1.Padding = new DevExpress.XtraPrinting.PaddingInfo(6, 6, 0, 0, 100F);
        this.DetailCaption1.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
        // 
        // DetailData1
        // 
        this.DetailData1.BorderColor = System.Drawing.Color.Transparent;
        this.DetailData1.Borders = DevExpress.XtraPrinting.BorderSide.Left;
        this.DetailData1.BorderWidth = 2F;
        this.DetailData1.Font = new System.Drawing.Font("Arial", 8.25F);
        this.DetailData1.ForeColor = System.Drawing.Color.Black;
        this.DetailData1.Name = "DetailData1";
        this.DetailData1.Padding = new DevExpress.XtraPrinting.PaddingInfo(6, 6, 0, 0, 100F);
        this.DetailData1.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
        // 
        // GroupFooterBackground3
        // 
        this.GroupFooterBackground3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(137)))), ((int)(((byte)(137)))), ((int)(((byte)(137)))));
        this.GroupFooterBackground3.BorderColor = System.Drawing.Color.White;
        this.GroupFooterBackground3.Borders = DevExpress.XtraPrinting.BorderSide.Bottom;
        this.GroupFooterBackground3.BorderWidth = 2F;
        this.GroupFooterBackground3.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold);
        this.GroupFooterBackground3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(228)))), ((int)(((byte)(228)))));
        this.GroupFooterBackground3.Name = "GroupFooterBackground3";
        this.GroupFooterBackground3.Padding = new DevExpress.XtraPrinting.PaddingInfo(6, 2, 0, 0, 100F);
        this.GroupFooterBackground3.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
        // 
        // DetailData3_Odd
        // 
        this.DetailData3_Odd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(231)))), ((int)(((byte)(231)))));
        this.DetailData3_Odd.BorderColor = System.Drawing.Color.Transparent;
        this.DetailData3_Odd.Borders = DevExpress.XtraPrinting.BorderSide.None;
        this.DetailData3_Odd.BorderWidth = 1F;
        this.DetailData3_Odd.Font = new System.Drawing.Font("Arial", 8.25F);
        this.DetailData3_Odd.ForeColor = System.Drawing.Color.Black;
        this.DetailData3_Odd.Name = "DetailData3_Odd";
        this.DetailData3_Odd.Padding = new DevExpress.XtraPrinting.PaddingInfo(6, 6, 0, 0, 100F);
        this.DetailData3_Odd.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
        // 
        // PageInfo
        // 
        this.PageInfo.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold);
        this.PageInfo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(75)))), ((int)(((byte)(75)))));
        this.PageInfo.Name = "PageInfo";
        this.PageInfo.Padding = new DevExpress.XtraPrinting.PaddingInfo(6, 6, 0, 0, 100F);
        // 
        // parameter1
        // 
        this.parameter1.Description = "Parameter1";
        this.parameter1.Name = "parameter1";
        // 
        // OrderDateData
        // 
        this.Bands.AddRange(new DevExpress.XtraReports.UI.Band[] {
        this.TopMargin,
        this.BottomMargin,
        this.GroupHeader1,
        this.GroupHeader2,
        this.Detail});
        this.ComponentStorage.AddRange(new System.ComponentModel.IComponent[] {
        this.sqlDataSource1});
        this.DataMember = "OrderDetails_1";
        this.DataSource = this.sqlDataSource1;
        this.DrawGrid = false;
        this.FilterString = "[ProductName] = ?parameter1";
        this.Font = new System.Drawing.Font("Arial", 9.75F);
        this.Landscape = true;
        this.PageHeight = 850;
        this.PageWidth = 1100;
        this.Parameters.AddRange(new DevExpress.XtraReports.Parameters.Parameter[] {
        this.parameter1});
        this.RequestParameters = false;
        this.StyleSheet.AddRange(new DevExpress.XtraReports.UI.XRControlStyle[] {
        this.Title,
        this.GroupCaption1,
        this.GroupData1,
        this.DetailCaption1,
        this.DetailData1,
        this.GroupFooterBackground3,
        this.DetailData3_Odd,
        this.PageInfo});
        this.Version = "22.1";
        ((System.ComponentModel.ISupportInitialize)(this.table2)).EndInit();
        ((System.ComponentModel.ISupportInitialize)(this.table3)).EndInit();
        ((System.ComponentModel.ISupportInitialize)(this)).EndInit();

    }

    #endregion

    private DevExpress.XtraReports.UI.TopMarginBand TopMargin;
    private DevExpress.XtraReports.UI.BottomMarginBand BottomMargin;
    private DevExpress.XtraReports.UI.GroupHeaderBand GroupHeader1;
    private DevExpress.XtraReports.UI.GroupHeaderBand GroupHeader2;
    private DevExpress.XtraReports.UI.XRTable table2;
    private DevExpress.XtraReports.UI.XRTableRow tableRow2;
    private DevExpress.XtraReports.UI.XRTableCell tableCell3;
    private DevExpress.XtraReports.UI.XRTableCell tableCell4;
    private DevExpress.XtraReports.UI.DetailBand Detail;
    private DevExpress.XtraReports.UI.XRTable table3;
    private DevExpress.XtraReports.UI.XRTableRow tableRow3;
    private DevExpress.XtraReports.UI.XRTableCell tableCell5;
    private DevExpress.XtraReports.UI.XRTableCell tableCell6;
    private DevExpress.DataAccess.Sql.SqlDataSource sqlDataSource1;
    private DevExpress.XtraReports.UI.XRControlStyle Title;
    private DevExpress.XtraReports.UI.XRControlStyle GroupCaption1;
    private DevExpress.XtraReports.UI.XRControlStyle GroupData1;
    private DevExpress.XtraReports.UI.XRControlStyle DetailCaption1;
    private DevExpress.XtraReports.UI.XRControlStyle DetailData1;
    private DevExpress.XtraReports.UI.XRControlStyle GroupFooterBackground3;
    private DevExpress.XtraReports.UI.XRControlStyle DetailData3_Odd;
    private DevExpress.XtraReports.UI.XRControlStyle PageInfo;
    private DevExpress.XtraReports.Parameters.Parameter parameter1;
}
