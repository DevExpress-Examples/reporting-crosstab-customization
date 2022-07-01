# Reporting - CrossTab Control Customization

The project contains sample reports in which you can learn how to customize the XRCrossTab control.
Run the project, in the application window select the desired example, and click the **Design** button to show the report. 

## Table of Contents:
- [How to Hide Cells, Rows and Columns That Meet Certain Conditions](#how-to-hide-cells-rows-and-columns-that-meet-certain-conditions)
    - [Hide Totals](#hide-totals)
    - [Hide Detailed Records and Show the Total for the Specified Group](#hide-detailed-records-and-show-the-total-for-the-specified-group)
    - [Hide Empty Rows or Columns With Null, Zero or No Values](#hide-empty-rows-or-columns-with-null-zero-or-no-values)
    - [Hide Rows or Columns With Null or No Values](#hide-rows-or-columns-with-null-or-no-values)
- [Use CountDistinct, Mode and Median Summary Types](#use-countdistinct-mode-and-median-summary-types)
- [Html-Inspired Text Formatting](#html-inspired-text-formatting)

## How to Hide Cells, Rows and Columns That Meet Certain Conditions


### Hide Totals

The Crosstab control has the `name` data field in rows, the `store` data field in columns, the `value` data field in data area. The `name` rows are grouped by the `group` data field.

The original report preview is shown below:

![Original Report Preview](Images/original-report-hidetotals-preview.png)

The report in this example hides the totals for the **Gr1** and **Gr2** group field values, so only the **Gr3** total remains.

Implementation:

Select the row header cell for the Totals row. The cell's coordinates are [0, 2], the name is _crossTabHeaderCell3_, and the cell displays the 'Total[group]' text in the Report Designer.
Invoke the Expression Editor and assign the following expression to the [RowVisible](https://docs.devexpress.com/XtraReports/DevExpress.XtraReports.UI.CrossTab.XRCrossTabCell.RowVisible) property:
```
[group] == 'Gr3'"
```
The resulting report preview is shown in the follolwing image:

![Hide Totals](Images/hide-totals.png)

### Hide Detailed Records and Show the Total for the Specified Group

The Crosstab control has the `name` data field in rows, the `store` data field in columns, the `value` data field in data area. The `name` rows are grouped by the `group` data field.

The original report preview is shown below:

![Original Report Preview](Images/original-report-hidetotals-preview.png)

The report in this example hides the records in the **Gr1** group. The **Gr1** group total remains, the records and totals for other groups remain as well.

Implementation:

Select the row header cell in the row bound to the `[group]` field. The cell coordinates are [0, 1], the cell name is _crossTabHeaderCell2_, and the cell displays the `[group]` text in the Report Designer.
Invoke the Expression Editor and assign the following expression to the [RowVisible](https://docs.devexpress.com/XtraReports/DevExpress.XtraReports.UI.CrossTab.XRCrossTabCell.RowVisible) property:
```
[group] != 'Gr1'
```
Note that a cell located in a nested group can access a data field bound to the parent (outer) group, but cannot access a data field bound to the child (inner) group. This means that this expression would work when assigned to the adjacent row header at the left with coordinates [1,1], which displays the `[name]` text in the Report Designer. However, this is impractical, because the number of calculations increases several times.

The resulting report preview is shown in the following image:

![Hide Details and Show Total](Images/hide-details-and-show-total.png)

### Hide Empty Rows or Columns With Null, Zero or No Values

The Crosstab control has the `elementID` data field in rows, the `season` data field in columns, the `value1` and `value2` data fields in the data area. The `value2` field is 0 (zero) for several records whose `elementType` field is **Type A**, and is missing for the records whose `elementType` field is **Type B**.


An empty column/row can appear in the following situations: 

- **Type A.** Certain column/row items have no values for a particular field when the control displays several data fields.
- **Type B.** Column/row values are null (a 0 (zero) may be displayed, but there is no value).

Depending on the location of the data fields, horizontally or vertically, an empty column or an empty row may appear. 

The original report preview is shown below:

![Original Report with Empty Columns Preview](Images/original-report-hide-empty-columns.png)

The report in this example hides a column/row if it has no non-zero values (missing, equal to null, or equal to 0).

Implementation:

Select the Total cell for the column bound to the `[value2]` field. The cell coordinates are [2, 3]; the cell name is _crossTabTotalCell4_.
Invoke the Expression Editor and assign the following expression to the [ColumnVisible](https://docs.devexpress.com/XtraReports/DevExpress.XtraReports.UI.CrossTab.XRCrossTabCell.ColumnVisible) property:

```
[value2] > 0
```

Assign the same expression to the [ColumnVisible](https://docs.devexpress.com/XtraReports/DevExpress.XtraReports.UI.CrossTab.XRCrossTabCell.ColumnVisible) property of the _crossTabTotalCell6_ with coordinates [4,3] to hide the corresponding totals.

The resulting report preview is shown in the following image:

![Hide Empty Rows or Columns ](Images/hide-empty-rows-columns.png)

### Hide Rows or Columns With Null or No Values

The Crosstab control has the `elementID` data field in rows, the `season` data field in columns, the `value1` and `value2` data fields in the data area. The `value2` field is 0 (zero) for several records whose `elementType` field is **Type A**, and is missing for the records whose `elementType` field is **Type B**.

An empty column/row can appear in the following situations: 
- **Type A.** Certain column/row items have no values for a particular field when the control displays several data fields.
- **Type B.** Column/row values are null (a 0 (zero) may be displayed, but there is no value).

The original report preview is shown below:

![Original Report with Empty Columns Preview](Images/original-report-hide-empty-columns.png)

The report in this example hides the column/row if it has no values (or values equal to null), but displays the column/row if it has any values, including 0 (zero).

Implementation:

1. Create a `cfValue2` calculated field with the following expression:
    ```
    [value2]
    ```
2. Drag the newly created calculated field from the Field List window and drop it onto the CrossTab control's data area.
3. Select the cell bound to the `cfValue2` field and change the [SummaryType](https://docs.devexpress.com/XtraReports/DevExpress.XtraReports.UI.CrossTab.CrossTabDataField.SummaryType) to **Count**.
4. Select the **Total** cell for the column bound to the `[value2]` field. The cell coordinates are [2, 3]; the cell name is _crossTabTotalCell4_.
    Invoke the Expression Editor and assign the following expression to the [ColumnVisible](https://docs.devexpress.com/XtraReports/DevExpress.XtraReports.UI.CrossTab.XRCrossTabCell.ColumnVisible) property:

    ```
    [cfValue2] > 0
    ```
5. Select the **Total** cell for another column bound to the `[value2]` field. The cell coordinates are [5, 3]; the cell name is _crossTabTotalCell6_.
    Invoke the Expression Editor and assign the following expression to the [ColumnVisible](https://docs.devexpress.com/XtraReports/DevExpress.XtraReports.UI.CrossTab.XRCrossTabCell.ColumnVisible) property:

    ```
    [cfValue2] > 0 
    ```
6. Hide all columns and rows bound to the `cfValue2` calculated field. For this, set the [ColumnVisible](https://docs.devexpress.com/XtraReports/DevExpress.XtraReports.UI.CrossTab.XRCrossTabCell.ColumnVisible) property to **false** for cells [3,3] and [6,3] in the data area.

The resulting report preview is shown in the following image:

![Hide Empty Show Zero Rows or Columns](Images/hide-null-show-zero-rows-columns.png)
 
## Use CountDistinct, Mode and Median Summary Types

The report demonstrates the use of the **CountDistinct**, **Mode** and **Median** summary types in the CrossTab control.

The CrossTab control can display only one column for a single field. To show aggregates for mutilple functions in adjacent columns, the report uses [calculated fields](https://docs.devexpress.com/XtraReports/4813/detailed-guide-to-devexpress-reporting/shape-report-data/use-calculated-fields/calculated-fields-overview) - each field is used to calculate values for a certain function. 


## Html-Inspired Text Formatting

The Cross Tab cells take advantage of the [AllowMarkupText](https://docs.devexpress.com/XtraReports/DevExpress.XtraReports.UI.CrossTab.XRCrossTabCell.AllowMarkupText) option to display formatted text and images within cells. 

In this example the Cross Tab **Count** header cell displays the formatted text using the following `Text` expression:
```
<href=https://docs.devexpress.com/XtraReports/DevExpress.XtraReports.UI.CrossTab.SummaryType>Count</href><br><size=-3>The number of values.</size>
```
The **CountDistinct** summary type data cells display the down arrow when the **CountDistinct** value is less than the **Count** value. The down-arrow image is added to the [XtraReport.ImageResources](https://docs.devexpress.com/XtraReports/DevExpress.XtraReports.UI.XtraReport.ImageResources) collection. The expression for the `XRCrossTabCell.Text` property contains the Image tag with the [ImageItem.Id](https://docs.devexpress.com/CoreLibraries/DevExpress.XtraPrinting.Drawing.ImageItem.Id) property value:  

```
IIF([QtyCount]>[QtyCountDistinct],[QtyCountDistinct] + '<image=downarrowbmp>', [QtyCountDistinct])
```

## Documentation

- [XRCrossTab](https://docs.devexpress.com/XtraReports/DevExpress.XtraReports.UI.XRCrossTab)
- [ColumnVisible](https://docs.devexpress.com/XtraReports/DevExpress.XtraReports.UI.CrossTab.XRCrossTabCell.ColumnVisible)
- [RowVisible](https://docs.devexpress.com/XtraReports/DevExpress.XtraReports.UI.CrossTab.XRCrossTabCell.RowVisible)
- [CrossTabDataField.SummaryType](https://docs.devexpress.com/XtraReports/DevExpress.XtraReports.UI.CrossTab.CrossTabDataField.SummaryType)
- [AllowMarkupText](https://docs.devexpress.com/XtraReports/DevExpress.XtraReports.UI.CrossTab.XRCrossTabCell.AllowMarkupText)
- [HTML-inspired Text Formatting](https://docs.devexpress.com/WindowsForms/4874/common-features/html-text-formatting)

