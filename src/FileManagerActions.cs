using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _0001_Forms
{
    class FileManagerActions
    {
        public const char DOT = '.';
        public const int FIRST_ELEMENT = 0;

        public void CreateList(ListView list)
        {
            list.Items.Clear();
            
            DriveInfo[] allDrivers = DriveInfo.GetDrives();
            foreach (DriveInfo driver in allDrivers)
            {
                ListViewItem listViewItem = new ListViewItem();
                ListViewItem.ListViewSubItem listViewSubItems = new ListViewItem.ListViewSubItem();
                listViewItem.Text = driver.Name;
                listViewSubItems.Text = driver.DriveType.ToString();
                listViewItem.SubItems.Add(listViewSubItems);
                list.Items.Add(listViewItem);

            }
        }

        public void ChangeList(ListView list, String path)
        {
            
            DirectoryInfo dir = new DirectoryInfo(path);

            int numberOfItems = list.Items.Count;
                                
            //clear all items in list
            for (int i = numberOfItems - 1; i >= 0; --i)
            {
                list.Items[i].Remove();
            }

            //create list of folders
            DirectoryInfo[] folders = dir.GetDirectories();
            foreach (DirectoryInfo folderinfo in folders)
            {
                ListViewItem listViewItem = new ListViewItem();
                ListViewItem.ListViewSubItem listViewSubItems1 = new ListViewItem.ListViewSubItem();
                ListViewItem.ListViewSubItem listViewSubItems2 = new ListViewItem.ListViewSubItem();
                listViewItem.Text = folderinfo.Name;
                listViewSubItems1.Text = "";
                listViewSubItems2.Text = folderinfo.LastWriteTime.ToString();
                listViewItem.SubItems.Add(listViewSubItems1);
                listViewItem.SubItems.Add(listViewSubItems2);
                list.Items.Add(listViewItem);
            }

            //create list of files
            FileInfo[] files = dir.GetFiles();
            string nameWithExtension;
            string extensionWithDot;
            int indexOfDot;
             
            foreach (FileInfo fileinfo in files)
            {
                ListViewItem listViewItem = new ListViewItem();
                ListViewItem.ListViewSubItem listViewSubItems1 = new ListViewItem.ListViewSubItem();
                ListViewItem.ListViewSubItem listViewSubItems2 = new ListViewItem.ListViewSubItem();
                nameWithExtension = fileinfo.Name;
                indexOfDot = nameWithExtension.IndexOf(DOT);
                if (indexOfDot > 0)
                {
                    listViewItem.Text = nameWithExtension.Remove(indexOfDot);
                }
                else
                {
                    listViewItem.Text = nameWithExtension;
                }
                extensionWithDot = fileinfo.Extension;
                listViewSubItems1.Text = extensionWithDot.TrimStart(DOT);
                listViewSubItems2.Text = fileinfo.LastWriteTime.ToString();
                listViewItem.SubItems.Add(listViewSubItems1);
                listViewItem.SubItems.Add(listViewSubItems2);
                list.Items.Add(listViewItem);
            }
        }

        public bool IsFolderExists(String path)
        {
            DirectoryInfo dir = new DirectoryInfo(path);
            if (!dir.Exists)
            {
                MessageBox.Show("Відкритя каталогу неможливе.\nПапки не існує", "Попередження");
                return false;
            }
            return true;
        }

        public bool IsFolderCanBeOpen(String path)
        {
            try
            {
                DirectoryInfo dir = new DirectoryInfo(path);
                FileInfo[] files = dir.GetFiles();
            }
            catch (UnauthorizedAccessException exception)
            {
                MessageBox.Show("Немає доступу до об'екта.\nНемає дозволу на доступ.", "Об'єкт недоступний");
                return false;
            }
            return true;
        }
        public string UpParentFolder(String path)
        {
            if (path != null)
            {
                DirectoryInfo dir = new DirectoryInfo(path);
                DirectoryInfo parentDir = dir.Parent;
                if (parentDir != null)
                {
                    return parentDir.FullName + "\\";
                }
            }
            return null;
        }

        public void UpClick(ListView list, ref String path)
        {
            path = UpParentFolder(path);
            if (path == null)
            {
                CreateList(list);
            }
            else
            {
                ChangeList(list, path);
            }
        }

        public void Double_Click(ListView list, ref String path)
        {
            string item = list.SelectedItems[FIRST_ELEMENT].Text;
            string triedOpenDir = path + item + "\\";
            if (IsFolderExists(triedOpenDir)
                && IsFolderCanBeOpen(triedOpenDir))
            {
                path = triedOpenDir;
                ChangeList(list, path);
            }
        }
    }
}
