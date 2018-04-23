using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraTreeList.Nodes.Operations;
using DevExpress.XtraTreeList.Columns;
using DevExpress.XtraTreeList.Nodes;

namespace XtraTreeListCustomFiltering
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            treeList1.DataSource = FillDataTable();
            treeList1.ExpandAll();
        }

        private void applyFilterButton_Click(object sender, EventArgs e)
        {
            FilterNodeOperation operation = new FilterNodeOperation(textEdit1.EditValue != null ? textEdit1.EditValue.ToString() : "");
            treeList1.NodesIterator.DoOperation(operation);
        }

        class FilterNodeOperation : TreeListOperation
        {
            string pattern;

            public FilterNodeOperation(string _pattern)
            { pattern = _pattern; }
            
            public override void Execute(TreeListNode node)
            {
                if (NodeContainsPattern(node, pattern))
                {
                    node.Visible = true;
                    if (node.ParentNode != null)
                        node.ParentNode.Visible = true;
                }
                else
                    node.Visible = false;
            }

            bool NodeContainsPattern(TreeListNode node, string pattern)
            {
                foreach (TreeListColumn col in node.TreeList.Columns)
                    if (node.GetValue(col).ToString().Contains(pattern))
                        return true;
                return false;
            }
        }

        DataTable FillDataTable()
        {
            DataTable _dataTable = new DataTable();
            DataColumn col;
            DataRow row;

            col = new DataColumn();
            col.ColumnName = "Text";
            col.DataType = System.Type.GetType("System.String");
            _dataTable.Columns.Add(col);

            col = new DataColumn();
            col.ColumnName = "Details";
            col.DataType = System.Type.GetType("System.String");
            _dataTable.Columns.Add(col);

            col = new DataColumn();
            col.ColumnName = "ID";
            col.DataType = System.Type.GetType("System.Int32");
            col.Unique = true;
            _dataTable.Columns.Add(col);

            col = new DataColumn();
            col.ColumnName = "ParentID";
            col.DataType = System.Type.GetType("System.Int32");
            _dataTable.Columns.Add(col);

            row = _dataTable.NewRow();
            row["ID"] = 1; row["ParentID"] = 0; row["Text"] = "Master Node 1"; 
            _dataTable.Rows.Add(row);
            row = _dataTable.NewRow();
            row["ID"] = 2; row["ParentID"] = 1; row["Text"] = "Some text + pattern";
            _dataTable.Rows.Add(row);
            row = _dataTable.NewRow();
            row["ID"] = 3; row["ParentID"] = 1; row["Text"] = "Some text"; row["Details"] = "pattern";
            _dataTable.Rows.Add(row);
            row = _dataTable.NewRow();
            row["ID"] = 4; row["ParentID"] = 0; row["Text"] = "Master Node 2";
            _dataTable.Rows.Add(row);
            row = _dataTable.NewRow();
            row["ID"] = 5; row["ParentID"] = 4; row["Text"] = "Some text";
            _dataTable.Rows.Add(row);
            row = _dataTable.NewRow();
            row["ID"] = 6; row["ParentID"] = 4; row["Text"] = "Some text";
            _dataTable.Rows.Add(row);

            return _dataTable;
        }
    }
}
