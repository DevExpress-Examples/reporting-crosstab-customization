Imports System
Imports System.Collections.Generic
Imports System.Linq
Imports System.Text
Imports System.Threading.Tasks

Namespace CrossTabControlCustomizationExample
	Public Class ReportDescriptionData

		Private Const string1 As String = "The report hides the 'Gr1' and 'Gr2' totals, so only the 'Gr3' total remains.

Implementation:

Select the row header cell for the Totals row. The cell's coordinates are [0, 2], the name is crossTabHeaderCell3, and the cell displays the 'Total[group]' text in the Report Designer.
Invoke the Expression Editor and assign the following expression to the RowVisible property:
[group] == 'Gr3'"

		Private Const string2 As String = "The report hides the records in the 'Gr1' group. The 'Gr1' group total remains, the records and totals for other groups remain as well.

Implementation:

Select the row header cell in the row bound to the [group] field. The cell coordinates are [0, 1], the cell name is crossTabHeaderCell2, and the cell displays the '[group]' text in the Report Designer.
Invoke the Expression Editor and assign the following expression to the RowVisible property:
[group] != 'Gr1'
Note that a cell located in a nested group can access a data field bound to the parent (outer) group, but cannot access a data field bound to the child (inner) group. This means that this expression would work when assigned to the adjacent row header at the left with coordinates [1,1], which displays the [name] text in the Report Designer. However, this is impractical, because the number of calculations increases several times.
"
		Private Const string3 As String = "The report hides a column/row if it has no non-zero values (missing, equal to null, or equal to 0).

An empty column/row can appear in the following situations: 
- Certain column/row items have no values for a particular field when the control displays several data fields.
- Column/row values are null (a 0 (zero) may be displayed, but there is no value).
Depending on the location of the data fields, horizontally or vertically, an empty column or an empty row may appear.

In this example, the 'value2' field has no values for multiple records, but multiple records contain a 0 (zero) value, which we want to show in the report.  

Implementation:

Select the Total cell for the column bound to the [value2] field. The cell coordinates are [2, 3]; the cell name is crossTabTotalCell4.
Invoke the Expression Editor and assign the following expression to the ColumnVisible property:
[value2] > 0
Assign the same expression to the ColumnVisible property of the crossTabTotalCell6 with coordinates [4,3] to hide the corresponding totals.
"
		Private Const string4 As String = "The report hides the column/row if it has no values (or values equal to null), but displays the column/row if it has any values (including 0).

An empty column/row can appear in the following situations: 
- Certain column/row items have no values for a particular field when the control displays several data fields.
- Column/row values are null (a 0 (zero) may be displayed, but there is no value).
Depending on the location of the data fields, horizontally or vertically, an empty column or an empty row may appear.

In this example, the 'value2' field has no values for several records.

Implementation:

1. Create a 'cfValue2' calculated field with the following expression:
[value2]
2. Drag the newly created calculated field from the Field List window and drop it onto the CrossTab control's data area.
3. Select the cell bound to the 'cfValue2' field and change the SummaryType to Count.
4. Select the Total cell for the column bound to the [value2] field. The cell coordinates are [2, 3]; the cell name is crossTabTotalCell4.
Invoke the Expression Editor and assign the following expression to the ColumnVisible property:
[cfValue2] > 0
5. Select the Total cell for another column bound to the [value2] field. The cell coordinates are [5, 3]; the cell name is crossTabTotalCell6.
Invoke the Expression Editor and assign the following expression to the ColumnVisible property:
[cfValue2] > 0 
6. Hide all columns and rows bound to the 'cfValue2' calculated field. For this, set the ColumnVisible property to false for cells [3,3] and [6,3] in the data area.
"
		Public Shared Function GetData() As List(Of DataItem)
			Return New List(Of DataItem)() From {
				New DataItem("HideCertainTotals", "Hide Totals", string1),
				New DataItem("HideGroupDetails", "Hide Detailed Records and Show the Total for the Specified Group", string2),
				New DataItem("HideWhenNoNonZeroValues", "Hide Rows/Columns With Null, Zero or No Values", string3),
				New DataItem("HideWhenNoOrNullValues", "Hide Rows/Columns With Null or No Values", string4)
			}
		End Function

		Friend Shared Function GetNames() As String()
			Return New String() { "HideCertainTotals" }
		End Function
	End Class
	Public Class DataItem
		Public Sub New(ByVal name As String, ByVal heading As String, ByVal text As String)
			ReportName = name
			DisplayName = heading
			Description = text
		End Sub
		Public Property ReportName() As String
		Public Property DisplayName() As String
		Public Property Description() As String
	End Class
End Namespace
