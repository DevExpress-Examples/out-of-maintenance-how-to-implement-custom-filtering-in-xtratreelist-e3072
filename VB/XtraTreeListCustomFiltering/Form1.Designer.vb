Imports Microsoft.VisualBasic
Imports System
Namespace XtraTreeListCustomFiltering
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
			Me.applyFilterButton = New DevExpress.XtraEditors.SimpleButton()
			Me.textEdit1 = New DevExpress.XtraEditors.TextEdit()
			Me.treeList1 = New DevExpress.XtraTreeList.TreeList()
			CType(Me.textEdit1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.treeList1, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.SuspendLayout()
			' 
			' applyFilterButton
			' 
			Me.applyFilterButton.Location = New System.Drawing.Point(258, 173)
			Me.applyFilterButton.Name = "applyFilterButton"
			Me.applyFilterButton.Size = New System.Drawing.Size(75, 23)
			Me.applyFilterButton.TabIndex = 1
			Me.applyFilterButton.Text = "Apply Filter"
'			Me.applyFilterButton.Click += New System.EventHandler(Me.applyFilterButton_Click);
			' 
			' textEdit1
			' 
			Me.textEdit1.Location = New System.Drawing.Point(13, 175)
			Me.textEdit1.Name = "textEdit1"
			Me.textEdit1.Size = New System.Drawing.Size(239, 20)
			Me.textEdit1.TabIndex = 2
			' 
			' treeList1
			' 
			Me.treeList1.Location = New System.Drawing.Point(12, 12)
			Me.treeList1.Name = "treeList1"
			Me.treeList1.Size = New System.Drawing.Size(321, 154)
			Me.treeList1.TabIndex = 3
			' 
			' Form1
			' 
			Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
			Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
			Me.ClientSize = New System.Drawing.Size(344, 202)
			Me.Controls.Add(Me.treeList1)
			Me.Controls.Add(Me.textEdit1)
			Me.Controls.Add(Me.applyFilterButton)
			Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
			Me.Name = "Form1"
			Me.Text = "Form1"
'			Me.Load += New System.EventHandler(Me.Form1_Load);
			CType(Me.textEdit1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.treeList1, System.ComponentModel.ISupportInitialize).EndInit()
			Me.ResumeLayout(False)

		End Sub

		#End Region

		Private WithEvents applyFilterButton As DevExpress.XtraEditors.SimpleButton
		Private textEdit1 As DevExpress.XtraEditors.TextEdit
		Private treeList1 As DevExpress.XtraTreeList.TreeList


	End Class
End Namespace

