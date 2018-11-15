<!-- default file list -->
*Files to look at*:

* [Form1.cs](./CS/XtraTreeListCustomFiltering/Form1.cs) (VB: [Form1.vb](./VB/XtraTreeListCustomFiltering/Form1.vb))
* [Program.cs](./CS/XtraTreeListCustomFiltering/Program.cs) (VB: [Program.vb](./VB/XtraTreeListCustomFiltering/Program.vb))
<!-- default file list end -->
# How to implement custom filtering in XtraTreeList


<p>The current example demonstrates how a custom filtering algorithm in XtraTreeList can be implemented. The current example implements logic as follows:<br />
- If a current node matches the filtering pattern, then this node and all its antecedent nodes should be shown; otherwise, the node should be hidden;<br />
- If a parent node doesn't have any visible child nodes, then such node should be hidden.</p>

<br/>


