using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _0001_Forms
{
    public partial class Info : Form
    {
        private const int DRIVE = 0;
        private const int FOLDER = 1;
        private const int FILE = 2;

        private string path;
        private string item;
        private int itemType;

        public Info(string _path, string _item, int _itemType)
        {
            InitializeComponent();
            path = _path;
            item = _item;
            itemType = _itemType;
        }


        private void ShowInfo()
        {
            name.Text = item;
            fullName.Text = path + item;

            if (itemType == DRIVE)
            {
                DriveInfo driveInfo = new DriveInfo(item);
                creationTimeSection.Visible = false;
                creationTime.Visible = false;
                if (driveInfo.IsReady)
                {
                    type.Text = driveInfo.DriveFormat.ToString();
                    memory.Text = driveInfo.TotalSize.ToString();
                }
                else
                {
                    typeSection.Visible = false;
                    type.Visible = false;
                    memorySection.Visible = false;
                    memory.Visible = false;
                }
            }
            else if (itemType == FOLDER)
            {
                DirectoryInfo dirInfo = new DirectoryInfo(fullName.Text);
                memorySection.Visible = false;
                memory.Visible = false;
                if (dirInfo.Exists)
                {
                    creationTime.Text = dirInfo.CreationTime.ToString();
                    type.Text = "Папка";
                }
                else
                {
                    creationTimeSection.Visible = false;
                    creationTime.Visible = false;
                    typeSection.Visible = false;
                    type.Visible = false;
                }
            }
            else if (itemType == FILE)
            {
                FileInfo fileInfo = new FileInfo(fullName.Text); //name with extension

                if (fileInfo.Exists)
                {
                    creationTime.Text = fileInfo.CreationTime.ToString();
                    type.Text = fileInfo.Extension;
                    memory.Text = fileInfo.Length.ToString();
                }
                else
                {
                    creationTimeSection.Visible = false;
                    creationTime.Visible = false;
                    typeSection.Visible = false;
                    type.Visible = false;
                    memorySection.Visible = false;
                    memory.Visible = false;
                }
            }
        }

        private void Info_Load(object sender, EventArgs e)
        {
            ShowInfo();
        }
    }
}
