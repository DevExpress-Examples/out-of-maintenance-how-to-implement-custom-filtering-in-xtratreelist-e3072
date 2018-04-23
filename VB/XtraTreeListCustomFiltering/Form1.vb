Imports Microsoft.VisualBasic
Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Data
Imports System.Drawing
Imports System.Linq
Imports System.Text
Imports System.Windows.Forms
Imports DevExpress.XtraTreeList.Nodes.Operations
Imports DevExpress.XtraTreeList.Columns
Imports DevExpress.XtraTreeList.Nodes

Namespace XtraTreeListCustomFiltering
	Partial Public Class Form1
		Inherits Form
		Public Sub New()
			InitializeComponent()
		End Sub

		Private Sub Form1_Load(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load
			treeList1.DataSource = FillDataTable()
			treeList1.ExpandAll()
		End Sub

		Private Sub applyFilterButton_Click(ByVal sender As Object, ByVal e As EventArgs) Handles applyFilterButton.Click
			Dim operation As New FilterNodeOperation(If(textEdit1.EditValue IsNot Nothing, textEdit1.EditValue.ToString(), ""))
			treeList1.NodesIterator.DoOperation(operation)
		End Sub

		Private Class FilterNodeOperation
			Inherits TreeListOperation
			Private pattern As String

			Public Sub New(ByVal _pattern As String)
				pattern = _pattern
			End Sub

			Public Overrides Sub Execute(ByVal node As TreeListNode)
				If NodeContainsPattern(node, pattern) Then
					node.Visible = True
					If node.ParentNode IsNot Nothing Then
						node.ParentNode.Visible = True
					End If
				Else
					node.Visible = False
				End If
			End Sub

			Private Function NodeContainsPattern(ByVal node As TreeListNode, ByVal pattern As String) As Boolean
				For Each col As TreeListColumn In node.TreeList.Columns
					If node.GetValue(col).ToString().Contains(pattern) Then
						Return True
					End If
				Next col
				Return False
			End Function
		End Class

		Private Function FillDataTable() As DataTable
			Dim _dataTable As New DataTable()
			Dim col As DataColumn
			Dim row As DataRow

			col = New DataColumn()
			col.ColumnName = "Text"
			col.DataType = System.Type.GetType("System.String")
			_dataTable.Columns.Add(col)

			col = New DataColumn()
			col.ColumnName = "Details"
			col.DataType = System.Type.GetType("System.String")
			_dataTable.Columns.Add(col)

			col = New DataColumn()
			col.ColumnName = "ID"
			col.DataType = System.Type.GetType("System.Int32")
			col.Unique = True
			_dataTable.Columns.Add(col)

			col = New DataColumn()
			col.ColumnName = "ParentID"
			col.DataType = System.Type.GetType("System.Int32")
			_dataTable.Columns.Add(col)

			row = _dataTable.NewRow()
			row("ID") = 1
			row("ParentID") = 0
			row("Text") = "Master Node 1"
			_dataTable.Rows.Add(row)
			row = _dataTable.NewRow()
			row("ID") = 2
			row("ParentID") = 1
			row("Text") = "Some text + pattern"
			_dataTable.Rows.Add(row)
			row = _dataTable.NewRow()
			row("ID") = 3
			row("ParentID") = 1
			row("Text") = "Some text"
			row("Details") = "pattern"
			_dataTable.Rows.Add(row)
			row = _dataTable.NewRow()
			row("ID") = 4
			row("ParentID") = 0
			row("Text") = "Master Node 2"
			_dataTable.Rows.Add(row)
			row = _dataTable.NewRow()
			row("ID") = 5
			row("ParentID") = 4
			row("Text") = "Some text"
			_dataTable.Rows.Add(row)
			row = _dataTable.NewRow()
			row("ID") = 6
			row("ParentID") = 4
			row("Text") = "Some text"
			_dataTable.Rows.Add(row)

			Return _dataTable
		End Function
	End Class
End Namespace
