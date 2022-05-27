Imports DevExpress.XtraReports.UI
Imports DevExpress.XtraReports.UserDesigner
Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Data
Imports System.Drawing
Imports System.Linq
Imports System.Text
Imports System.Windows.Forms



Namespace CrossTabControlCustomizationExample
	Partial Public Class Form1
		Inherits DevExpress.XtraEditors.XtraForm

		Public Sub New()
			InitializeComponent()
			listBoxControl1.DataSource = ReportDescriptionData.GetData()
		End Sub

		Private Sub Form1_Load(ByVal sender As Object, ByVal e As EventArgs) Handles Me.Load
			If listBoxControl1.Items.Count > 0 Then
				listBoxControl1.SelectedIndex = 0
			End If
		End Sub

		Private Sub btnDesign_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnDesign.Click
			' Open a selected report in the report designer.
			Dim form As New XRDesignForm()
			'INSTANT VB NOTE: The variable name was renamed since Visual Basic does not handle local variables named the same as class members well:
			Dim name_Renamed As String = GetSelectedName()
			If Not String.IsNullOrEmpty(name_Renamed) Then
				Dim report As XtraReport = DirectCast(Activator.CreateInstance(Type.GetType(name_Renamed)), XtraReport)
				form.OpenReport(report)
			End If
			form.ShowDialog(Me)

			Dim selectedItem As Object = listBoxControl1.SelectedItem
			If selectedItem IsNot Nothing AndAlso listBoxControl1.Items.Contains(selectedItem) Then
				listBoxControl1.SelectedItem = selectedItem
			End If
		End Sub

		Private Function GetSelectedName() As String
			Return DirectCast(listBoxControl1.SelectedItem, DataItem).ReportName
		End Function
	End Class
End Namespace
