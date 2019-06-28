using System;
using System.Windows.Forms;

namespace Examples {
  class MainForm : Form {
    public static void Main() {
      Application.EnableVisualStyles();
      Application.Run(new MainForm());
    }

    public MainForm() {
      this.Text = "TreeView example";
      this.ClientSize = new System.Drawing.Size(300, 300);

      this.treeView.Parent = this;
      this.treeView.Location = new System.Drawing.Point(10, 10);
      this.treeView.Size = new System.Drawing.Size(150, 200);
      this.treeView.CheckBoxes = true;
      this.treeView.Nodes.Add("Root");
      this.treeView.Nodes[0].Nodes.Add("First");
      this.treeView.Nodes[0].Nodes[0].Nodes.Add("Second");
      this.treeView.Nodes[0].Nodes[0].Nodes[0].Checked = true;
      this.treeView.Nodes[0].Nodes[0].Nodes.Add("Third");
      this.treeView.Nodes[0].Nodes.Add("Fourth");
      this.treeView.Nodes[0].Nodes[1].Nodes.Add("Fifth");
      this.treeView.Nodes[0].Nodes[1].Nodes.Add("Sixth");
      this.treeView.Nodes[0].Nodes[1].Nodes[1].Checked = true;
      this.treeView.Nodes[0].Nodes[1].Nodes.Add("Seventh");
      this.treeView.ExpandAll();
    }

    private TreeView treeView = new TreeView();
  }
}
