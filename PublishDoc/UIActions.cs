using System;
using System.IO;
using System.Windows.Forms;

namespace PublishDoc
{
    class UIActions
    {
        private const int SYNCHRONIZED = 0;
        private const int NOT_SYNCHRONIZED = 1;
        private const int MISSING = 2;
        public static bool InitConfig()
        {

            string Mensaje = "";
            var validConfig = Config.Init(ref Mensaje);

            if (!validConfig)
            {
                MessageBox.Show(Mensaje, "Error de configuración", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            if (!File.Exists(Config.DB_PATH))
            {
                DB.CreateDB();
            }
            else
            {
                Mensaje = "";
                if (!DB.IsValid(ref Mensaje))
                {
                    MessageBox.Show(Mensaje, "Error de base de datos", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            //IOActions.CloneDirectory(Config.SOURCE_PATH, Config.PUBLISH_PATH);
            return validConfig;
        }

        public static void InitTreeView(string RootPath, TreeView treeView, ListView listView)
        {
            TreeNode rootNode = PopulateTreeView(Config.SOURCE_PATH, treeView);

            if (rootNode != null)
            {
                rootNode.Expand();
                selectNode(rootNode, listView);
            }
        }

        public static TreeNode PopulateTreeView(string RootPaht, TreeView treeView)
        {
            TreeNode rootNode = null;
            DirectoryInfo info = new DirectoryInfo(RootPaht);
            if (info.Exists)
            {
                rootNode = new TreeNode(info.Name);
                rootNode.Tag = info;
                GetDirectories(info.GetDirectories(), rootNode);
                treeView.Nodes.Add(rootNode);
            }

            return rootNode;
        }

        private static void GetDirectories(DirectoryInfo[] subDirs, TreeNode nodeToAddTo)
        {
            TreeNode aNode;
            DirectoryInfo[] subSubDirs;
            foreach (DirectoryInfo subDir in subDirs)
            {
                aNode = new TreeNode(subDir.Name, 0, 0);
                aNode.Name = subDir.Name;
                aNode.Tag = subDir;
                aNode.ImageKey = "folder";
                subSubDirs = subDir.GetDirectories();
                if (subSubDirs.Length != 0)
                {
                    GetDirectories(subSubDirs, aNode);
                }
                nodeToAddTo.Nodes.Add(aNode);
            }
        }

        public static void selectNode(TreeNode newSelected, ListView listView)
        {
            if (newSelected == null)
                return;

            listView.Items.Clear();
            DirectoryInfo nodeDirInfo = (DirectoryInfo)newSelected.Tag;
            ListViewItem.ListViewSubItem[] subItems;
            ListViewItem item = null;

            foreach (DirectoryInfo dir in nodeDirInfo.GetDirectories())
            {
                string estadoPublicado = "No publicado";
                int imageIndex = 0;
                int directorySyncStatus = PublishUtils.DirectoryStatus(dir); //DirectorySyncStatus(dir);
                DateTime? fechaPublicacion = DB.GetPublicationDate(dir.FullName);
                string fechaPublicacionStr = fechaPublicacion == null ? null : ((DateTime)fechaPublicacion).ToString("dd/MM/yyyy HH:mm:ss");

                switch (directorySyncStatus)
                {
                    case SYNCHRONIZED:
                        imageIndex = 2;
                        estadoPublicado = "Publicado";
                        break;
                    case NOT_SYNCHRONIZED:
                        imageIndex = 4;
                        estadoPublicado = "Contenido no publicado";
                        break;
                }

                item = new ListViewItem(dir.Name, imageIndex);
                item.Name = dir.Name;
                subItems = new ListViewItem.ListViewSubItem[]
                    {
                        new ListViewItem.ListViewSubItem(item, "Carpeta"),
                        new ListViewItem.ListViewSubItem(item, dir.LastAccessTime.ToString("dd/MM/yyyy HH:mm:ss")),
                        new ListViewItem.ListViewSubItem(item, estadoPublicado),
                        new ListViewItem.ListViewSubItem(item, fechaPublicacionStr),
                        new ListViewItem.ListViewSubItem(item, dir.FullName),
                    };
                item.SubItems.AddRange(subItems);
                listView.Items.Add(item);
            }
            foreach (FileInfo file in nodeDirInfo.GetFiles())
            {
                DateTime? fechaPublicacion = DB.GetPublicationDate(file.FullName);
                string fechaPublicacionStr = fechaPublicacion == null ? null : ((DateTime)fechaPublicacion).ToString("dd/MM/yyyy HH:mm:ss");
                string estadoPublicado = "No publicado";
                int imageIndex = 1;
                int fileStatus = PublishUtils.FileStatus(file);

                switch (fileStatus)
                {
                    case SYNCHRONIZED:
                        imageIndex = 3;
                        estadoPublicado = "Publicado";
                        break;
                    case NOT_SYNCHRONIZED:
                        imageIndex = 5;
                        estadoPublicado = "Cambios no publicados";
                        break;
                }

                item = new ListViewItem(file.Name, imageIndex);

                subItems = new ListViewItem.ListViewSubItem[]
                    {
                        new ListViewItem.ListViewSubItem(item, "Documento"),
                        new ListViewItem.ListViewSubItem(item, file.LastAccessTime.ToString("dd/MM/yyyy HH:mm:ss")),
                        new ListViewItem.ListViewSubItem(item, estadoPublicado),
                        new ListViewItem.ListViewSubItem(item, fechaPublicacionStr),
                        new ListViewItem.ListViewSubItem(item, file.FullName),
                };
                item.SubItems.AddRange(subItems);

                listView.Items.Add(item);

            }

            listView.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
        }


        private static int DirectorySyncStatus(DirectoryInfo dir)
        {
            bool isPublished = IsPublished(dir.FullName, true);

            if (!isPublished)
                return MISSING;

            foreach (var subDir in dir.EnumerateDirectories())
            {
                var subdirStatus = DirectorySyncStatus(subDir);
                if (subdirStatus == MISSING || subdirStatus == NOT_SYNCHRONIZED)
                    return NOT_SYNCHRONIZED;
            }

            foreach (var file in dir.EnumerateFiles())
            {
                if (!IsPublished(file.FullName, false))
                    return NOT_SYNCHRONIZED;
            }
            return SYNCHRONIZED;

        }

        private static bool IsPublished(string sourcePath, bool isDirectory)
        {
            var relativePath = sourcePath.Remove(0, Config.SOURCE_PATH.Length);
            var publishPath = Config.PUBLISH_PATH;
            if (publishPath.EndsWith("/") || publishPath.EndsWith("\\"))
            {
                publishPath = publishPath.Remove(publishPath.Length - 1);
            }
            var publishedPath = Config.PUBLISH_PATH + relativePath;

            var sync = false;
            if (isDirectory)
                sync = Directory.Exists(publishedPath);
            else
                sync = File.Exists(publishedPath);

            return sync;
        }

        //ui events
        public static void treeView_NodeMouseClick(object sender, TreeNodeMouseClickEventArgs e, ListView listView)
        {
            TreeNode newSelected = e.Node;
            selectNode(newSelected, listView);
        }

        public static void listView_DoubleClick(object sender, EventArgs e, TreeView treeView)
        {
            var listView = sender as ListView;

            var selectedItems = listView.SelectedItems;
            if (selectedItems.Count == 1)
            {
                var selectedItem = selectedItems[0];
                var treeViewSelectedNode = treeView.SelectedNode;
                var correspondingNode = treeViewSelectedNode.Nodes.Find(selectedItem.Name, false)[0];

                selectNode(correspondingNode, listView);

                correspondingNode.Expand();
                treeView.SelectedNode = correspondingNode;
                treeView.Select();
            }
        }
    }
}
