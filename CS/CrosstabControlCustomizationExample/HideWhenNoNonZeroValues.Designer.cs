partial class HideWhenNoNonZeroValues
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
        DevExpress.XtraReports.UI.CrossTab.CrossTabColumnDefinition crossTabColumnDefinition1 = new DevExpress.XtraReports.UI.CrossTab.CrossTabColumnDefinition(60F);
        DevExpress.XtraReports.UI.CrossTab.CrossTabColumnDefinition crossTabColumnDefinition2 = new DevExpress.XtraReports.UI.CrossTab.CrossTabColumnDefinition(60F);
        DevExpress.XtraReports.UI.CrossTab.CrossTabColumnDefinition crossTabColumnDefinition3 = new DevExpress.XtraReports.UI.CrossTab.CrossTabColumnDefinition(60F);
        DevExpress.XtraReports.UI.CrossTab.CrossTabColumnDefinition crossTabColumnDefinition4 = new DevExpress.XtraReports.UI.CrossTab.CrossTabColumnDefinition(60F);
        DevExpress.XtraReports.UI.CrossTab.CrossTabColumnField crossTabColumnField1 = new DevExpress.XtraReports.UI.CrossTab.CrossTabColumnField();
        DevExpress.XtraReports.UI.CrossTab.CrossTabDataField crossTabDataField1 = new DevExpress.XtraReports.UI.CrossTab.CrossTabDataField();
        DevExpress.XtraReports.UI.CrossTab.CrossTabDataField crossTabDataField2 = new DevExpress.XtraReports.UI.CrossTab.CrossTabDataField();
        DevExpress.XtraReports.UI.CrossTab.CrossTabRowField crossTabRowField1 = new DevExpress.XtraReports.UI.CrossTab.CrossTabRowField();
        DevExpress.DataAccess.Json.CustomJsonSource customJsonSource1 = new DevExpress.DataAccess.Json.CustomJsonSource();
        System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HideWhenNoNonZeroValues));
        DevExpress.DataAccess.Json.JsonSchemaNode jsonSchemaNode1 = new DevExpress.DataAccess.Json.JsonSchemaNode("root", true, DevExpress.DataAccess.Json.JsonNodeType.Array);
        DevExpress.DataAccess.Json.JsonSchemaNode jsonSchemaNode2 = new DevExpress.DataAccess.Json.JsonSchemaNode("elementType", true, DevExpress.DataAccess.Json.JsonNodeType.Property, typeof(string));
        DevExpress.DataAccess.Json.JsonSchemaNode jsonSchemaNode3 = new DevExpress.DataAccess.Json.JsonSchemaNode("elementID", true, DevExpress.DataAccess.Json.JsonNodeType.Property, typeof(string));
        DevExpress.DataAccess.Json.JsonSchemaNode jsonSchemaNode4 = new DevExpress.DataAccess.Json.JsonSchemaNode("season", true, DevExpress.DataAccess.Json.JsonNodeType.Property, typeof(string));
        DevExpress.DataAccess.Json.JsonSchemaNode jsonSchemaNode5 = new DevExpress.DataAccess.Json.JsonSchemaNode("value1", true, DevExpress.DataAccess.Json.JsonNodeType.Property, typeof(System.Nullable<double>));
        DevExpress.DataAccess.Json.JsonSchemaNode jsonSchemaNode6 = new DevExpress.DataAccess.Json.JsonSchemaNode("value2", true, DevExpress.DataAccess.Json.JsonNodeType.Property, typeof(System.Nullable<double>));
        this.TopMargin = new DevExpress.XtraReports.UI.TopMarginBand();
        this.Detail = new DevExpress.XtraReports.UI.DetailBand();
        this.BottomMargin = new DevExpress.XtraReports.UI.BottomMarginBand();
        this.GroupHeader1 = new DevExpress.XtraReports.UI.GroupHeaderBand();
        this.crossTab1 = new DevExpress.XtraReports.UI.XRCrossTab();
        this.label1 = new DevExpress.XtraReports.UI.XRLabel();
        this.crossTabHeaderCell1 = new DevExpress.XtraReports.UI.CrossTab.XRCrossTabCell();
        this.crossTabDataCell1 = new DevExpress.XtraReports.UI.CrossTab.XRCrossTabCell();
        this.crossTabHeaderCell2 = new DevExpress.XtraReports.UI.CrossTab.XRCrossTabCell();
        this.crossTabHeaderCell3 = new DevExpress.XtraReports.UI.CrossTab.XRCrossTabCell();
        this.crossTabHeaderCell4 = new DevExpress.XtraReports.UI.CrossTab.XRCrossTabCell();
        this.crossTabTotalCell1 = new DevExpress.XtraReports.UI.CrossTab.XRCrossTabCell();
        this.crossTabHeaderCell5 = new DevExpress.XtraReports.UI.CrossTab.XRCrossTabCell();
        this.crossTabTotalCell2 = new DevExpress.XtraReports.UI.CrossTab.XRCrossTabCell();
        this.crossTabTotalCell3 = new DevExpress.XtraReports.UI.CrossTab.XRCrossTabCell();
        this.crossTabHeaderCell6 = new DevExpress.XtraReports.UI.CrossTab.XRCrossTabCell();
        this.crossTabHeaderCell7 = new DevExpress.XtraReports.UI.CrossTab.XRCrossTabCell();
        this.crossTabHeaderCell8 = new DevExpress.XtraReports.UI.CrossTab.XRCrossTabCell();
        this.crossTabHeaderCell9 = new DevExpress.XtraReports.UI.CrossTab.XRCrossTabCell();
        this.crossTabDataCell2 = new DevExpress.XtraReports.UI.CrossTab.XRCrossTabCell();
        this.crossTabTotalCell5 = new DevExpress.XtraReports.UI.CrossTab.XRCrossTabCell();
        this.crossTabTotalCell4 = new DevExpress.XtraReports.UI.CrossTab.XRCrossTabCell();
        this.crossTabTotalCell6 = new DevExpress.XtraReports.UI.CrossTab.XRCrossTabCell();
        this.jsonDataSource1 = new DevExpress.DataAccess.Json.JsonDataSource(this.components);
        this.crossTabGeneralStyle1 = new DevExpress.XtraReports.UI.XRControlStyle();
        this.crossTabHeaderStyle1 = new DevExpress.XtraReports.UI.XRControlStyle();
        this.crossTabDataStyle1 = new DevExpress.XtraReports.UI.XRControlStyle();
        this.crossTabTotalStyle1 = new DevExpress.XtraReports.UI.XRControlStyle();
        ((System.ComponentModel.ISupportInitialize)(this.crossTab1)).BeginInit();
        ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
        // 
        // TopMargin
        // 
        this.TopMargin.Name = "TopMargin";
        // 
        // Detail
        // 
        this.Detail.HeightF = 0F;
        this.Detail.Name = "Detail";
        // 
        // BottomMargin
        // 
        this.BottomMargin.Name = "BottomMargin";
        // 
        // GroupHeader1
        // 
        this.GroupHeader1.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
        this.crossTab1,
        this.label1});
        this.GroupHeader1.GroupFields.AddRange(new DevExpress.XtraReports.UI.GroupField[] {
        new DevExpress.XtraReports.UI.GroupField("elementType", DevExpress.XtraReports.UI.XRColumnSortOrder.Ascending)});
        this.GroupHeader1.HeightF = 145.5F;
        this.GroupHeader1.Name = "GroupHeader1";
        // 
        // crossTab1
        // 
        this.crossTab1.Cells.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
        this.crossTabHeaderCell1,
        this.crossTabDataCell1,
        this.crossTabHeaderCell2,
        this.crossTabHeaderCell3,
        this.crossTabHeaderCell4,
        this.crossTabTotalCell1,
        this.crossTabHeaderCell5,
        this.crossTabTotalCell2,
        this.crossTabTotalCell3,
        this.crossTabHeaderCell6,
        this.crossTabHeaderCell7,
        this.crossTabHeaderCell8,
        this.crossTabHeaderCell9,
        this.crossTabDataCell2,
        this.crossTabTotalCell5,
        this.crossTabTotalCell4,
        this.crossTabTotalCell6});
        crossTabColumnDefinition1.AutoWidthMode = DevExpress.XtraReports.UI.AutoSizeMode.ShrinkAndGrow;
        crossTabColumnDefinition2.AutoWidthMode = DevExpress.XtraReports.UI.AutoSizeMode.ShrinkAndGrow;
        crossTabColumnDefinition3.AutoWidthMode = DevExpress.XtraReports.UI.AutoSizeMode.ShrinkAndGrow;
        crossTabColumnDefinition4.AutoWidthMode = DevExpress.XtraReports.UI.AutoSizeMode.ShrinkAndGrow;
        this.crossTab1.ColumnDefinitions.AddRange(new DevExpress.XtraReports.UI.CrossTab.CrossTabColumnDefinition[] {
        new DevExpress.XtraReports.UI.CrossTab.CrossTabColumnDefinition(85F),
        crossTabColumnDefinition1,
        crossTabColumnDefinition2,
        crossTabColumnDefinition3,
        crossTabColumnDefinition4});
        crossTabColumnField1.FieldName = "season";
        this.crossTab1.ColumnFields.AddRange(new DevExpress.XtraReports.UI.CrossTab.CrossTabColumnField[] {
        crossTabColumnField1});
        this.crossTab1.DataAreaStyleName = "crossTabDataStyle1";
        crossTabDataField1.FieldName = "value1";
        crossTabDataField2.FieldName = "value2";
        this.crossTab1.DataFields.AddRange(new DevExpress.XtraReports.UI.CrossTab.CrossTabDataField[] {
        crossTabDataField1,
        crossTabDataField2});
        this.crossTab1.DataSource = this.jsonDataSource1;
        this.crossTab1.FilterString = "[elementType] = ?controlParameter1";
        this.crossTab1.GeneralStyleName = "crossTabGeneralStyle1";
        this.crossTab1.HeaderAreaStyleName = "crossTabHeaderStyle1";
        this.crossTab1.LocationFloat = new DevExpress.Utils.PointFloat(0F, 32.99998F);
        this.crossTab1.Name = "crossTab1";
        this.crossTab1.Parameters.AddRange(new DevExpress.XtraReports.UI.XRControlParameter[] {
        new DevExpress.XtraReports.UI.XRControlParameter("controlParameter1", null, "elementType")});
        this.crossTab1.RowDefinitions.AddRange(new DevExpress.XtraReports.UI.CrossTab.CrossTabRowDefinition[] {
        new DevExpress.XtraReports.UI.CrossTab.CrossTabRowDefinition(25F),
        new DevExpress.XtraReports.UI.CrossTab.CrossTabRowDefinition(25F),
        new DevExpress.XtraReports.UI.CrossTab.CrossTabRowDefinition(25F),
        new DevExpress.XtraReports.UI.CrossTab.CrossTabRowDefinition(25F)});
        crossTabRowField1.FieldName = "elementID";
        this.crossTab1.RowFields.AddRange(new DevExpress.XtraReports.UI.CrossTab.CrossTabRowField[] {
        crossTabRowField1});
        this.crossTab1.SizeF = new System.Drawing.SizeF(325F, 100F);
        this.crossTab1.TotalAreaStyleName = "crossTabTotalStyle1";
        // 
        // label1
        // 
        this.label1.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
        new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[elementType]")});
        this.label1.Font = new System.Drawing.Font("Arial", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))));
        this.label1.LocationFloat = new DevExpress.Utils.PointFloat(0F, 10F);
        this.label1.Multiline = true;
        this.label1.Name = "label1";
        this.label1.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
        this.label1.SizeF = new System.Drawing.SizeF(100F, 23F);
        this.label1.StylePriority.UseFont = false;
        this.label1.Text = "label1";
        // 
        // crossTabHeaderCell1
        // 
        this.crossTabHeaderCell1.ColumnIndex = 0;
        this.crossTabHeaderCell1.Name = "crossTabHeaderCell1";
        this.crossTabHeaderCell1.RowIndex = 0;
        this.crossTabHeaderCell1.RowSpan = 2;
        this.crossTabHeaderCell1.Text = "element ID";
        // 
        // crossTabDataCell1
        // 
        this.crossTabDataCell1.ColumnIndex = 1;
        this.crossTabDataCell1.Name = "crossTabDataCell1";
        this.crossTabDataCell1.RowIndex = 2;
        // 
        // crossTabHeaderCell2
        // 
        this.crossTabHeaderCell2.ColumnIndex = 1;
        this.crossTabHeaderCell2.ColumnSpan = 2;
        this.crossTabHeaderCell2.Name = "crossTabHeaderCell2";
        this.crossTabHeaderCell2.RowIndex = 0;
        // 
        // crossTabHeaderCell3
        // 
        this.crossTabHeaderCell3.ColumnIndex = 0;
        this.crossTabHeaderCell3.Name = "crossTabHeaderCell3";
        this.crossTabHeaderCell3.RowIndex = 2;
        // 
        // crossTabHeaderCell4
        // 
        this.crossTabHeaderCell4.ColumnIndex = 0;
        this.crossTabHeaderCell4.Name = "crossTabHeaderCell4";
        this.crossTabHeaderCell4.RowIndex = 3;
        this.crossTabHeaderCell4.Text = "Grand Total";
        // 
        // crossTabTotalCell1
        // 
        this.crossTabTotalCell1.ColumnIndex = 1;
        this.crossTabTotalCell1.Name = "crossTabTotalCell1";
        this.crossTabTotalCell1.RowIndex = 3;
        // 
        // crossTabHeaderCell5
        // 
        this.crossTabHeaderCell5.ColumnIndex = 3;
        this.crossTabHeaderCell5.ColumnSpan = 2;
        this.crossTabHeaderCell5.Name = "crossTabHeaderCell5";
        this.crossTabHeaderCell5.RowIndex = 0;
        this.crossTabHeaderCell5.Text = "Grand Total";
        // 
        // crossTabTotalCell2
        // 
        this.crossTabTotalCell2.ColumnIndex = 3;
        this.crossTabTotalCell2.Name = "crossTabTotalCell2";
        this.crossTabTotalCell2.RowIndex = 2;
        // 
        // crossTabTotalCell3
        // 
        this.crossTabTotalCell3.ColumnIndex = 3;
        this.crossTabTotalCell3.Name = "crossTabTotalCell3";
        this.crossTabTotalCell3.RowIndex = 3;
        // 
        // crossTabHeaderCell6
        // 
        this.crossTabHeaderCell6.ColumnIndex = 1;
        this.crossTabHeaderCell6.Name = "crossTabHeaderCell6";
        this.crossTabHeaderCell6.RowIndex = 1;
        this.crossTabHeaderCell6.Text = "v1 (sum)";
        // 
        // crossTabHeaderCell7
        // 
        this.crossTabHeaderCell7.ColumnIndex = 3;
        this.crossTabHeaderCell7.Name = "crossTabHeaderCell7";
        this.crossTabHeaderCell7.RowIndex = 1;
        this.crossTabHeaderCell7.Text = "v1 (sum)";
        // 
        // crossTabHeaderCell8
        // 
        this.crossTabHeaderCell8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
        this.crossTabHeaderCell8.ColumnIndex = 2;
        this.crossTabHeaderCell8.Name = "crossTabHeaderCell8";
        this.crossTabHeaderCell8.RowIndex = 1;
        this.crossTabHeaderCell8.Text = "v2 (sum)";
        // 
        // crossTabHeaderCell9
        // 
        this.crossTabHeaderCell9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
        this.crossTabHeaderCell9.ColumnIndex = 4;
        this.crossTabHeaderCell9.Name = "crossTabHeaderCell9";
        this.crossTabHeaderCell9.RowIndex = 1;
        this.crossTabHeaderCell9.Text = "v2 (sum)";
        // 
        // crossTabDataCell2
        // 
        this.crossTabDataCell2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
        this.crossTabDataCell2.ColumnIndex = 2;
        this.crossTabDataCell2.Name = "crossTabDataCell2";
        this.crossTabDataCell2.RowIndex = 2;
        // 
        // crossTabTotalCell5
        // 
        this.crossTabTotalCell5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
        this.crossTabTotalCell5.ColumnIndex = 4;
        this.crossTabTotalCell5.Name = "crossTabTotalCell5";
        this.crossTabTotalCell5.RowIndex = 2;
        // 
        // crossTabTotalCell4
        // 
        this.crossTabTotalCell4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
        this.crossTabTotalCell4.ColumnIndex = 2;
        this.crossTabTotalCell4.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
        new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "ColumnVisible", "[value2] > 0\n")});
        this.crossTabTotalCell4.Name = "crossTabTotalCell4";
        this.crossTabTotalCell4.RowIndex = 3;
        // 
        // crossTabTotalCell6
        // 
        this.crossTabTotalCell6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
        this.crossTabTotalCell6.ColumnIndex = 4;
        this.crossTabTotalCell6.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
        new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "ColumnVisible", "[value2] > 0\n")});
        this.crossTabTotalCell6.Name = "crossTabTotalCell6";
        this.crossTabTotalCell6.RowIndex = 3;
        // 
        // jsonDataSource1
        // 
        customJsonSource1.Json = resources.GetString("customJsonSource1.Json");
        this.jsonDataSource1.JsonSource = customJsonSource1;
        this.jsonDataSource1.Name = "jsonDataSource1";
        jsonSchemaNode1.Nodes.Add(jsonSchemaNode2);
        jsonSchemaNode1.Nodes.Add(jsonSchemaNode3);
        jsonSchemaNode1.Nodes.Add(jsonSchemaNode4);
        jsonSchemaNode1.Nodes.Add(jsonSchemaNode5);
        jsonSchemaNode1.Nodes.Add(jsonSchemaNode6);
        this.jsonDataSource1.Schema = jsonSchemaNode1;
        // 
        // crossTabGeneralStyle1
        // 
        this.crossTabGeneralStyle1.BackColor = System.Drawing.Color.White;
        this.crossTabGeneralStyle1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(160)))), ((int)(((byte)(160)))));
        this.crossTabGeneralStyle1.Borders = ((DevExpress.XtraPrinting.BorderSide)((((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Top) 
        | DevExpress.XtraPrinting.BorderSide.Right) 
        | DevExpress.XtraPrinting.BorderSide.Bottom)));
        this.crossTabGeneralStyle1.Font = new System.Drawing.Font("Arial", 9.75F);
        this.crossTabGeneralStyle1.ForeColor = System.Drawing.Color.Black;
        this.crossTabGeneralStyle1.Name = "crossTabGeneralStyle1";
        this.crossTabGeneralStyle1.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
        // 
        // crossTabHeaderStyle1
        // 
        this.crossTabHeaderStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
        this.crossTabHeaderStyle1.Name = "crossTabHeaderStyle1";
        this.crossTabHeaderStyle1.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
        // 
        // crossTabDataStyle1
        // 
        this.crossTabDataStyle1.Name = "crossTabDataStyle1";
        this.crossTabDataStyle1.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight;
        // 
        // crossTabTotalStyle1
        // 
        this.crossTabTotalStyle1.Name = "crossTabTotalStyle1";
        this.crossTabTotalStyle1.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight;
        // 
        // HideWhenNoNonZeroValues
        // 
        this.Bands.AddRange(new DevExpress.XtraReports.UI.Band[] {
        this.TopMargin,
        this.Detail,
        this.BottomMargin,
        this.GroupHeader1});
        this.ComponentStorage.AddRange(new System.ComponentModel.IComponent[] {
        this.jsonDataSource1});
        this.DataSource = this.jsonDataSource1;
        this.Font = new System.Drawing.Font("Arial", 9.75F);
        this.Margins = new System.Drawing.Printing.Margins(109, 100, 100, 100);
        this.StyleSheet.AddRange(new DevExpress.XtraReports.UI.XRControlStyle[] {
        this.crossTabGeneralStyle1,
        this.crossTabHeaderStyle1,
        this.crossTabDataStyle1,
        this.crossTabTotalStyle1});
        this.Version = "22.1";
        ((System.ComponentModel.ISupportInitialize)(this.crossTab1)).EndInit();
        ((System.ComponentModel.ISupportInitialize)(this)).EndInit();

    }

    #endregion

    private DevExpress.XtraReports.UI.TopMarginBand TopMargin;
    private DevExpress.XtraReports.UI.DetailBand Detail;
    private DevExpress.XtraReports.UI.BottomMarginBand BottomMargin;
    private DevExpress.XtraReports.UI.GroupHeaderBand GroupHeader1;
    private DevExpress.XtraReports.UI.XRCrossTab crossTab1;
    private DevExpress.XtraReports.UI.CrossTab.XRCrossTabCell crossTabHeaderCell1;
    private DevExpress.XtraReports.UI.CrossTab.XRCrossTabCell crossTabDataCell1;
    private DevExpress.XtraReports.UI.CrossTab.XRCrossTabCell crossTabHeaderCell2;
    private DevExpress.XtraReports.UI.CrossTab.XRCrossTabCell crossTabHeaderCell3;
    private DevExpress.XtraReports.UI.CrossTab.XRCrossTabCell crossTabHeaderCell4;
    private DevExpress.XtraReports.UI.CrossTab.XRCrossTabCell crossTabTotalCell1;
    private DevExpress.XtraReports.UI.CrossTab.XRCrossTabCell crossTabHeaderCell5;
    private DevExpress.XtraReports.UI.CrossTab.XRCrossTabCell crossTabTotalCell2;
    private DevExpress.XtraReports.UI.CrossTab.XRCrossTabCell crossTabTotalCell3;
    private DevExpress.XtraReports.UI.CrossTab.XRCrossTabCell crossTabHeaderCell6;
    private DevExpress.XtraReports.UI.CrossTab.XRCrossTabCell crossTabHeaderCell7;
    private DevExpress.XtraReports.UI.CrossTab.XRCrossTabCell crossTabHeaderCell8;
    private DevExpress.XtraReports.UI.CrossTab.XRCrossTabCell crossTabHeaderCell9;
    private DevExpress.XtraReports.UI.CrossTab.XRCrossTabCell crossTabDataCell2;
    private DevExpress.XtraReports.UI.CrossTab.XRCrossTabCell crossTabTotalCell5;
    private DevExpress.XtraReports.UI.CrossTab.XRCrossTabCell crossTabTotalCell4;
    private DevExpress.XtraReports.UI.CrossTab.XRCrossTabCell crossTabTotalCell6;
    private DevExpress.DataAccess.Json.JsonDataSource jsonDataSource1;
    private DevExpress.XtraReports.UI.XRLabel label1;
    private DevExpress.XtraReports.UI.XRControlStyle crossTabGeneralStyle1;
    private DevExpress.XtraReports.UI.XRControlStyle crossTabHeaderStyle1;
    private DevExpress.XtraReports.UI.XRControlStyle crossTabDataStyle1;
    private DevExpress.XtraReports.UI.XRControlStyle crossTabTotalStyle1;
}

