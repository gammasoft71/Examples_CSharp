using System;
using System.Windows.Forms;

namespace Examples {
  class MainForm : Form {
    public static void Main() {
      Application.EnableVisualStyles();
      Application.Run(new MainForm());
    }

    public MainForm() {
      Text = "TreeView example";
      ClientSize = new System.Drawing.Size(300, 300);

      treeView.Parent = this;
      treeView.Location = new System.Drawing.Point(10, 10);
      treeView.Size = new System.Drawing.Size(150, 200);
      treeView.CheckBoxes = true;
      treeView.Nodes.Add("Root");
      treeView.Nodes[0].Nodes.Add("First");
      treeView.Nodes[0].Nodes[0].Nodes.Add("Second");
      treeView.Nodes[0].Nodes[0].Nodes[0].Checked = true;
      treeView.Nodes[0].Nodes[0].Nodes.Add("Third");
      treeView.Nodes[0].Nodes.Add("Fourth");
      treeView.Nodes[0].Nodes[1].Nodes.Add("Fifth");
      treeView.Nodes[0].Nodes[1].Nodes.Add("Sixth");
      treeView.Nodes[0].Nodes[1].Nodes[1].Checked = true;
      treeView.Nodes[0].Nodes[1].Nodes.Add("Seventh");
      treeView.ExpandAll();
    }

    private TreeView treeView = new TreeView();
  }
}
