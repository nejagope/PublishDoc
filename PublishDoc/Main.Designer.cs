namespace PublishDoc
{
    partial class Main
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.splitContainerControl1 = new System.Windows.Forms.SplitContainer();
            this.treeView1 = new System.Windows.Forms.TreeView();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.listView1 = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.imageList2 = new System.Windows.Forms.ImageList(this.components);
            this.bPublish = new System.Windows.Forms.Button();
            this.imgListIcons = new System.Windows.Forms.ImageList(this.components);
            this.bCancelPublish = new System.Windows.Forms.Button();
            this.bLargeIcons = new System.Windows.Forms.Button();
            this.imgListSmallIncons = new System.Windows.Forms.ImageList(this.components);
            this.bDetails = new System.Windows.Forms.Button();
            this.lAcciones = new System.Windows.Forms.Label();
            this.lVista = new System.Windows.Forms.Label();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1)).BeginInit();
            this.splitContainerControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 4;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 122F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 122F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 57F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.Controls.Add(this.splitContainerControl1, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.bPublish, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.bCancelPublish, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.bLargeIcons, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.bDetails, 2, 2);
            this.tableLayoutPanel1.Controls.Add(this.lAcciones, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.lVista, 2, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 4;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 23F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 54F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 54F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1200, 692);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // splitContainerControl1
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.splitContainerControl1, 4);
            this.splitContainerControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainerControl1.Location = new System.Drawing.Point(4, 136);
            this.splitContainerControl1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.splitContainerControl1.Name = "splitContainerControl1";
            this.splitContainerControl1.Panel1.Controls.Add(this.treeView1);
            this.splitContainerControl1.Panel1.Text = "Panel1";
            this.splitContainerControl1.Panel2.Controls.Add(this.listView1);
            this.splitContainerControl1.Panel2.Text = "Panel2";
            this.splitContainerControl1.Size = new System.Drawing.Size(1192, 552);            
            this.splitContainerControl1.TabIndex = 0;
            this.splitContainerControl1.Text = "splitContainerControl1";
            // 
            // treeView1
            // 
            this.treeView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.treeView1.ImageIndex = 0;
            this.treeView1.ImageList = this.imageList1;
            this.treeView1.Location = new System.Drawing.Point(0, 0);
            this.treeView1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.treeView1.Name = "treeView1";
            this.treeView1.SelectedImageIndex = 0;
            this.treeView1.Size = new System.Drawing.Size(375, 552);
            this.treeView1.TabIndex = 0;
            this.treeView1.NodeMouseClick += new System.Windows.Forms.TreeNodeMouseClickEventHandler(this.treeView1_NodeMouseClick);
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "folder.png");
            this.imageList1.Images.SetKeyName(1, "document.png");
            this.imageList1.Images.SetKeyName(2, "folder-sync.png");
            this.imageList1.Images.SetKeyName(3, "document-sync.png");
            this.imageList1.Images.SetKeyName(4, "folder-info.png");
            this.imageList1.Images.SetKeyName(5, "doument-info.png");
            // 
            // listView1
            // 
            this.listView1.AllowColumnReorder = true;
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5,
            this.columnHeader6});
            this.listView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listView1.HideSelection = false;
            this.listView1.LargeImageList = this.imageList2;
            this.listView1.Location = new System.Drawing.Point(0, 0);
            this.listView1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.listView1.Name = "listView1";
            this.listView1.ShowItemToolTips = true;
            this.listView1.Size = new System.Drawing.Size(802, 552);
            this.listView1.SmallImageList = this.imageList1;
            this.listView1.TabIndex = 1;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            this.listView1.DoubleClick += new System.EventHandler(this.listView1_DoubleClick);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Nombre";
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Tipo";
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Modificado";
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Estado";
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Fecha publicación";
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "Ruta";
            // 
            // imageList2
            // 
            this.imageList2.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList2.ImageStream")));
            this.imageList2.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList2.Images.SetKeyName(0, "folder.png");
            this.imageList2.Images.SetKeyName(1, "document.png");
            this.imageList2.Images.SetKeyName(2, "folder-sync.png");
            this.imageList2.Images.SetKeyName(3, "document-sync.png");
            this.imageList2.Images.SetKeyName(4, "folder-info.png");
            this.imageList2.Images.SetKeyName(5, "doument-info.png");
            // 
            // bPublish
            // 
            this.bPublish.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bPublish.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.bPublish.ImageIndex = 0;
            this.bPublish.ImageList = this.imgListIcons;
            this.bPublish.Location = new System.Drawing.Point(4, 28);
            this.bPublish.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.bPublish.Name = "bPublish";
            this.bPublish.Padding = new System.Windows.Forms.Padding(0, 8, 0, 0);
            this.tableLayoutPanel1.SetRowSpan(this.bPublish, 2);
            this.bPublish.Size = new System.Drawing.Size(114, 98);
            this.bPublish.TabIndex = 1;
            this.bPublish.Text = "Publicar";
            this.bPublish.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.bPublish.UseVisualStyleBackColor = true;
            // 
            // imgListIcons
            // 
            this.imgListIcons.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imgListIcons.ImageStream")));
            this.imgListIcons.TransparentColor = System.Drawing.Color.Transparent;
            this.imgListIcons.Images.SetKeyName(0, "check.png");
            this.imgListIcons.Images.SetKeyName(1, "check-disabled.png");
            this.imgListIcons.Images.SetKeyName(2, "delete.png");
            this.imgListIcons.Images.SetKeyName(3, "delete-disabled.png");
            this.imgListIcons.Images.SetKeyName(4, "application_view_detail.png");
            this.imgListIcons.Images.SetKeyName(5, "application_view_icons.png");
            // 
            // bCancelPublish
            // 
            this.bCancelPublish.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bCancelPublish.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.bCancelPublish.ImageIndex = 2;
            this.bCancelPublish.ImageList = this.imgListIcons;
            this.bCancelPublish.Location = new System.Drawing.Point(126, 28);
            this.bCancelPublish.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.bCancelPublish.Name = "bCancelPublish";
            this.bCancelPublish.Padding = new System.Windows.Forms.Padding(0, 8, 0, 0);
            this.tableLayoutPanel1.SetRowSpan(this.bCancelPublish, 2);
            this.bCancelPublish.Size = new System.Drawing.Size(114, 98);
            this.bCancelPublish.TabIndex = 2;
            this.bCancelPublish.Text = "No publicar";
            this.bCancelPublish.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.bCancelPublish.UseVisualStyleBackColor = true;
            // 
            // bLargeIcons
            // 
            this.bLargeIcons.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bLargeIcons.ImageIndex = 5;
            this.bLargeIcons.ImageList = this.imgListSmallIncons;
            this.bLargeIcons.Location = new System.Drawing.Point(248, 28);
            this.bLargeIcons.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.bLargeIcons.Name = "bLargeIcons";
            this.bLargeIcons.Size = new System.Drawing.Size(49, 44);
            this.bLargeIcons.TabIndex = 3;
            this.bLargeIcons.UseVisualStyleBackColor = true;
            this.bLargeIcons.Click += new System.EventHandler(this.bLargeIcons_Click);
            // 
            // imgListSmallIncons
            // 
            this.imgListSmallIncons.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imgListSmallIncons.ImageStream")));
            this.imgListSmallIncons.TransparentColor = System.Drawing.Color.Transparent;
            this.imgListSmallIncons.Images.SetKeyName(0, "check.png");
            this.imgListSmallIncons.Images.SetKeyName(1, "check-disabled.png");
            this.imgListSmallIncons.Images.SetKeyName(2, "delete.png");
            this.imgListSmallIncons.Images.SetKeyName(3, "delete-disabled.png");
            this.imgListSmallIncons.Images.SetKeyName(4, "application_view_detail.png");
            this.imgListSmallIncons.Images.SetKeyName(5, "application_view_icons.png");
            // 
            // bDetails
            // 
            this.bDetails.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bDetails.ImageIndex = 4;
            this.bDetails.ImageList = this.imgListSmallIncons;
            this.bDetails.Location = new System.Drawing.Point(248, 82);
            this.bDetails.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.bDetails.Name = "bDetails";
            this.bDetails.Size = new System.Drawing.Size(49, 44);
            this.bDetails.TabIndex = 4;
            this.bDetails.UseVisualStyleBackColor = true;
            this.bDetails.Click += new System.EventHandler(this.bDetails_Click);
            // 
            // lAcciones
            // 
            this.lAcciones.AutoSize = true;
            this.tableLayoutPanel1.SetColumnSpan(this.lAcciones, 2);
            this.lAcciones.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lAcciones.Location = new System.Drawing.Point(4, 0);
            this.lAcciones.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lAcciones.Name = "lAcciones";
            this.lAcciones.Size = new System.Drawing.Size(236, 23);
            this.lAcciones.TabIndex = 5;
            this.lAcciones.Text = "Acciones";
            this.lAcciones.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lVista
            // 
            this.lVista.AutoSize = true;
            this.lVista.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lVista.Location = new System.Drawing.Point(248, 0);
            this.lVista.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lVista.Name = "lVista";
            this.lVista.Size = new System.Drawing.Size(49, 23);
            this.lVista.TabIndex = 6;
            this.lVista.Text = "Vista";
            this.lVista.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1200, 692);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Main";
            this.Text = "PublishDoc";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1)).EndInit();
            this.splitContainerControl1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.SplitContainer splitContainerControl1;
        private System.Windows.Forms.TreeView treeView1;
        private System.Windows.Forms.Button bPublish;
        private System.Windows.Forms.Button bCancelPublish;
        private System.Windows.Forms.Button bLargeIcons;
        private System.Windows.Forms.Button bDetails;
        private System.Windows.Forms.Label lAcciones;
        private System.Windows.Forms.Label lVista;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.ImageList imageList2;
        private System.Windows.Forms.ImageList imgListIcons;
        private System.Windows.Forms.ImageList imgListSmallIncons;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
    }
}