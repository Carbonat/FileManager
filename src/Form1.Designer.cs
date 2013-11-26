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
            this.listView1 = new System.Windows.Forms.ListView();
            this.name_listView1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.type_listView1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lastWriteTime_listView1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.listView2 = new System.Windows.Forms.ListView();
            this.name_listView2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.type_listView2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lastWriteTime_listView2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.up_listView1 = new System.Windows.Forms.Button();
            this.up_listView2 = new System.Windows.Forms.Button();
            this.imageList = new System.Windows.Forms.ImageList(this.components);
            this.SuspendLayout();
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.name_listView1,
            this.type_listView1,
            this.lastWriteTime_listView1});
            this.listView1.Location = new System.Drawing.Point(12, 44);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(385, 419);
            this.listView1.SmallImageList = this.imageList;
            this.listView1.TabIndex = 0;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            this.listView1.DoubleClick += new System.EventHandler(this.listView1_DoubleClick);
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
            // listView2
            // 
            this.listView2.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.name_listView2,
            this.type_listView2,
            this.lastWriteTime_listView2});
            this.listView2.Location = new System.Drawing.Point(423, 44);
            this.listView2.Name = "listView2";
            this.listView2.Size = new System.Drawing.Size(385, 419);
            this.listView2.SmallImageList = this.imageList;
            this.listView2.TabIndex = 1;
            this.listView2.UseCompatibleStateImageBehavior = false;
            this.listView2.View = System.Windows.Forms.View.Details;
            this.listView2.DoubleClick += new System.EventHandler(this.listView2_DoubleClick);
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
            // up_listView1
            // 
            this.up_listView1.Location = new System.Drawing.Point(12, 15);
            this.up_listView1.Name = "up_listView1";
            this.up_listView1.Size = new System.Drawing.Size(54, 23);
            this.up_listView1.TabIndex = 2;
            this.up_listView1.Text = "Вгору";
            this.up_listView1.UseVisualStyleBackColor = true;
            this.up_listView1.Click += new System.EventHandler(this.up_listView1_Click);
            // 
            // up_listView2
            // 
            this.up_listView2.Location = new System.Drawing.Point(423, 15);
            this.up_listView2.Name = "up_listView2";
            this.up_listView2.Size = new System.Drawing.Size(54, 23);
            this.up_listView2.TabIndex = 3;
            this.up_listView2.Text = "Вгору";
            this.up_listView2.UseVisualStyleBackColor = true;
            this.up_listView2.Click += new System.EventHandler(this.up_listView2_Click);
            // 
            // imageList
            // 
            this.imageList.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList.ImageStream")));
            this.imageList.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList.Images.SetKeyName(0, "local drive.ico");
            this.imageList.Images.SetKeyName(1, "directory.ico");
            this.imageList.Images.SetKeyName(2, "file.ico");
            // 
            // FileManager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(843, 475);
            this.Controls.Add(this.up_listView2);
            this.Controls.Add(this.up_listView1);
            this.Controls.Add(this.listView2);
            this.Controls.Add(this.listView1);
            this.Name = "FileManager";
            this.Text = "File Manager";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader name_listView1;
        private System.Windows.Forms.ColumnHeader type_listView1;
        private System.Windows.Forms.ColumnHeader lastWriteTime_listView1;
        private System.Windows.Forms.ListView listView2;
        private System.Windows.Forms.ColumnHeader name_listView2;
        private System.Windows.Forms.ColumnHeader type_listView2;
        private System.Windows.Forms.ColumnHeader lastWriteTime_listView2;
        private System.Windows.Forms.Button up_listView1;
        private System.Windows.Forms.Button up_listView2;
        private System.Windows.Forms.ImageList imageList;
    }
}

