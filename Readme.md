<!-- default badges list -->
![](https://img.shields.io/endpoint?url=https://codecentral.devexpress.com/api/v1/VersionRange/128637707/10.2.3%2B)
[![](https://img.shields.io/badge/Open_in_DevExpress_Support_Center-FF7200?style=flat-square&logo=DevExpress&logoColor=white)](https://supportcenter.devexpress.com/ticket/details/E3072)
[![](https://img.shields.io/badge/📖_How_to_use_DevExpress_Examples-e9f6fc?style=flat-square)](https://docs.devexpress.com/GeneralInformation/403183)
<!-- default badges end -->
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


