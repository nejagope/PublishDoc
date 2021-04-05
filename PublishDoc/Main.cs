using System;
using System.Windows.Forms;

namespace PublishDoc
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
            UIActions.InitConfig();
            UIActions.InitTreeView(Config.SOURCE_PATH, treeView1, listView1);
            listView1.Columns[0].Width = 200;
        }

        private void treeView1_NodeMouseClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            UIActions.treeView_NodeMouseClick(sender, e, listView1);
        }

        private void listView1_DoubleClick(object sender, EventArgs e)
        {
            UIActions.listView_DoubleClick(sender, e, treeView1);
        }

        private void bLargeIcons_Click(object sender, EventArgs e)
        {
            listView1.View = View.LargeIcon;
        }

        private void bDetails_Click(object sender, EventArgs e)
        {
            listView1.View = View.Details;
        }
    }
}
