namespace _0001_Forms
{
    partial class FileManager
    {
        /// <summary>
        /// Требуется переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Обязательный метод для поддержки конструктора - не изменяйте
        /// содержимое данного метода при помощи редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FileManager));
            this.listView0 = new System.Windows.Forms.ListView();
            this.name_listView1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.type_listView1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lastWriteTime_listView1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.contextMenuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.createToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.folderToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.textFileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.infoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.imageList = new System.Windows.Forms.ImageList(this.components);
            this.listView1 = new System.Windows.Forms.ListView();
            this.name_listView2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.type_listView2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lastWriteTime_listView2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.up_listView0 = new System.Windows.Forms.Button();
            this.up_listView1 = new System.Windows.Forms.Button();
            this.fileSystemWatcher0 = new System.IO.FileSystemWatcher();
            this.fileSystemWatcher1 = new System.IO.FileSystemWatcher();
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.textEditorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.пошукToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher0)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).BeginInit();
            this.menuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // listView0
            // 
            this.listView0.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.name_listView1,
            this.type_listView1,
            this.lastWriteTime_listView1});
            this.listView0.ContextMenuStrip = this.contextMenuStrip;
            this.listView0.Location = new System.Drawing.Point(12, 63);
            this.listView0.Name = "listView0";
            this.listView0.Size = new System.Drawing.Size(385, 400);
            this.listView0.SmallImageList = this.imageList;
            this.listView0.TabIndex = 0;
            this.listView0.UseCompatibleStateImageBehavior = false;
            this.listView0.View = System.Windows.Forms.View.Details;
            this.listView0.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.listView_MouseDoubleClick);
            // 
            // name_listView1
            // 
            this.name_listView1.Text = "Ім\'я";
            this.name_listView1.Width = 141;
            // 
            // type_listView1
            // 
            this.type_listView1.Text = "Тип";
            this.type_listView1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.type_listView1.Width = 116;
            // 
            // lastWriteTime_listView1
            // 
            this.lastWriteTime_listView1.Text = "Час останніх змін";
            this.lastWriteTime_listView1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.lastWriteTime_listView1.Width = 124;
            // 
            // contextMenuStrip
            // 
            this.contextMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.createToolStripMenuItem,
            this.infoToolStripMenuItem});
            this.contextMenuStrip.Name = "contextMenuStrip1";
            this.contextMenuStrip.Size = new System.Drawing.Size(143, 48);
            this.contextMenuStrip.Opening += new System.ComponentModel.CancelEventHandler(this.contextMenuStrip_Opening);
            // 
            // createToolStripMenuItem
            // 
            this.createToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.folderToolStripMenuItem,
            this.textFileToolStripMenuItem});
            this.createToolStripMenuItem.Name = "createToolStripMenuItem";
            this.createToolStripMenuItem.Size = new System.Drawing.Size(142, 22);
            this.createToolStripMenuItem.Text = "Створити";
            // 
            // folderToolStripMenuItem
            // 
            this.folderToolStripMenuItem.Name = "folderToolStripMenuItem";
            this.folderToolStripMenuItem.Size = new System.Drawing.Size(163, 22);
            this.folderToolStripMenuItem.Text = "Папку";
            this.folderToolStripMenuItem.Click += new System.EventHandler(this.createFolderToolStripMenuItem_Click);
            // 
            // textFileToolStripMenuItem
            // 
            this.textFileToolStripMenuItem.Name = "textFileToolStripMenuItem";
            this.textFileToolStripMenuItem.Size = new System.Drawing.Size(163, 22);
            this.textFileToolStripMenuItem.Text = "Текстовий файл";
            this.textFileToolStripMenuItem.Click += new System.EventHandler(this.createTextFileToolStripMenuItem_Clic);
            // 
            // infoToolStripMenuItem
            // 
            this.infoToolStripMenuItem.Name = "infoToolStripMenuItem";
            this.infoToolStripMenuItem.Size = new System.Drawing.Size(142, 22);
            this.infoToolStripMenuItem.Text = " Властивості";
            this.infoToolStripMenuItem.Click += new System.EventHandler(this.infoToolStripMenuItem_Click);
            // 
            // imageList
            // 
            this.imageList.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList.ImageStream")));
            this.imageList.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList.Images.SetKeyName(0, "local drive.ico");
            this.imageList.Images.SetKeyName(1, "directory.ico");
            this.imageList.Images.SetKeyName(2, "file.ico");
            this.imageList.Images.SetKeyName(3, "textFile.ico");
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.name_listView2,
            this.type_listView2,
            this.lastWriteTime_listView2});
            this.listView1.ContextMenuStrip = this.contextMenuStrip;
            this.listView1.Location = new System.Drawing.Point(423, 63);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(385, 400);
            this.listView1.SmallImageList = this.imageList;
            this.listView1.TabIndex = 1;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            this.listView1.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.listView_MouseDoubleClick);
            // 
            // name_listView2
            // 
            this.name_listView2.Text = "Ім\'я";
            this.name_listView2.Width = 141;
            // 
            // type_listView2
            // 
            this.type_listView2.Text = "Тип";
            this.type_listView2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.type_listView2.Width = 116;
            // 
            // lastWriteTime_listView2
            // 
            this.lastWriteTime_listView2.Text = "Час останніх змін";
            this.lastWriteTime_listView2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.lastWriteTime_listView2.Width = 124;
            // 
            // up_listView0
            // 
            this.up_listView0.Location = new System.Drawing.Point(12, 34);
            this.up_listView0.Name = "up_listView0";
            this.up_listView0.Size = new System.Drawing.Size(54, 23);
            this.up_listView0.TabIndex = 2;
            this.up_listView0.Text = "Вгору";
            this.up_listView0.UseVisualStyleBackColor = true;
            this.up_listView0.Click += new System.EventHandler(this.up_listView_Click);
            // 
            // up_listView1
            // 
            this.up_listView1.Location = new System.Drawing.Point(423, 34);
            this.up_listView1.Name = "up_listView1";
            this.up_listView1.Size = new System.Drawing.Size(54, 23);
            this.up_listView1.TabIndex = 3;
            this.up_listView1.Text = "Вгору";
            this.up_listView1.UseVisualStyleBackColor = true;
            this.up_listView1.Click += new System.EventHandler(this.up_listView_Click);
            // 
            // fileSystemWatcher0
            // 
            this.fileSystemWatcher0.EnableRaisingEvents = true;
            this.fileSystemWatcher0.SynchronizingObject = this;
            this.fileSystemWatcher0.Changed += new System.IO.FileSystemEventHandler(this.fileSystemWatcher_Changed);
            this.fileSystemWatcher0.Created += new System.IO.FileSystemEventHandler(this.fileSystemWatcher_Changed);
            this.fileSystemWatcher0.Deleted += new System.IO.FileSystemEventHandler(this.fileSystemWatcher_Changed);
            // 
            // fileSystemWatcher1
            // 
            this.fileSystemWatcher1.EnableRaisingEvents = true;
            this.fileSystemWatcher1.SynchronizingObject = this;
            this.fileSystemWatcher1.Changed += new System.IO.FileSystemEventHandler(this.fileSystemWatcher_Changed);
            this.fileSystemWatcher1.Created += new System.IO.FileSystemEventHandler(this.fileSystemWatcher_Changed);
            this.fileSystemWatcher1.Deleted += new System.IO.FileSystemEventHandler(this.fileSystemWatcher_Changed);
            // 
            // menuStrip
            // 
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.textEditorToolStripMenuItem,
            this.пошукToolStripMenuItem});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(843, 24);
            this.menuStrip.TabIndex = 4;
            this.menuStrip.Text = "menuStrip";
            // 
            // textEditorToolStripMenuItem
            // 
            this.textEditorToolStripMenuItem.Name = "textEditorToolStripMenuItem";
            this.textEditorToolStripMenuItem.Size = new System.Drawing.Size(129, 20);
            this.textEditorToolStripMenuItem.Text = "Текстовий редактор";
            this.textEditorToolStripMenuItem.Click += new System.EventHandler(this.textEditorToolStripMenuItem_Click);
            // 
            // пошукToolStripMenuItem
            // 
            this.пошукToolStripMenuItem.Name = "пошукToolStripMenuItem";
            this.пошукToolStripMenuItem.Size = new System.Drawing.Size(58, 20);
            this.пошукToolStripMenuItem.Text = "Пошук";
            // 
            // FileManager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(843, 475);
            this.Controls.Add(this.menuStrip);
            this.Controls.Add(this.up_listView1);
            this.Controls.Add(this.up_listView0);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.listView0);
            this.MainMenuStrip = this.menuStrip;
            this.MaximizeBox = false;
            this.Name = "FileManager";
            this.Text = "File Manager";
            this.contextMenuStrip.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher0)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).EndInit();
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView listView0;
        private System.Windows.Forms.ColumnHeader name_listView1;
        private System.Windows.Forms.ColumnHeader type_listView1;
        private System.Windows.Forms.ColumnHeader lastWriteTime_listView1;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader name_listView2;
        private System.Windows.Forms.ColumnHeader type_listView2;
        private System.Windows.Forms.ColumnHeader lastWriteTime_listView2;
        private System.Windows.Forms.Button up_listView0;
        private System.Windows.Forms.Button up_listView1;
        private System.Windows.Forms.ImageList imageList;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem createToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem folderToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem textFileToolStripMenuItem;
        private System.IO.FileSystemWatcher fileSystemWatcher0;
        private System.IO.FileSystemWatcher fileSystemWatcher1;
        private System.Windows.Forms.ToolStripMenuItem infoToolStripMenuItem;
        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolStripMenuItem textEditorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem пошукToolStripMenuItem;
    }
}

