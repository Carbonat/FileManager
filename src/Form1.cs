using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.IO;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _0001_Forms
{
    public partial class FileManager : Form
    {
        public const int FIRST_ELEMENT = 0;
        public const int NUMBER_OF_LISTVIEWS = 2;
        public const int INDEX_OF_LEFT_LIST = 0;
        public const int INDEX_OF_RIGHT_LIST = 1;
        public const string LEFT_LIST = "0";
        public const string RIGHT_LIST = "1";

        public const string txt = "txt";
        public const string TXT = "TXT";


        //items of contextMenuStrip (name can be different)
        public const string CREATE_CONTEXT_MENU = "createToolStripMenuItem";

        private string[] currentPath = new String[NUMBER_OF_LISTVIEWS];
        private string copyPath = "";
        private int selectedList = -1; //for toolStripMenuItem 
        private ListView[] allListViews;
        private FileManagerActions fmActions = new FileManagerActions();
        private FileSystemWatcher[] allWatchers;

        public FileManager()
        {
            InitializeComponent();
            FileManagerActions fmActions = new FileManagerActions();
            allListViews = new ListView[NUMBER_OF_LISTVIEWS] { listView0, listView1 };
            allWatchers = new FileSystemWatcher[NUMBER_OF_LISTVIEWS] { fileSystemWatcher0, fileSystemWatcher1 };
            listView0.Name = LEFT_LIST;
            listView1.Name = RIGHT_LIST;
            for (int i = 0; i < NUMBER_OF_LISTVIEWS; ++i)
            {
                fmActions.CreateList(allListViews[i]);
            }

        }

        private void up_listView_Click(object sender, EventArgs e)
        {
            int currentList = GetNumberOfList(sender);
            fmActions.UpClick(allListViews[currentList], ref currentPath[currentList]);
            if (currentPath[currentList] != null)
                allWatchers[currentList].Path = currentPath[currentList];
        }

        private void listView_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            int currentList = GetNumberOfList(sender);
            fmActions.Mouse_DoubleClick(allListViews[currentList], ref currentPath[currentList]);
            allWatchers[currentList].Path = currentPath[currentList];
        }

       
        private void contextMenuStrip_Opening(object sender, CancelEventArgs e)
        {
            ContextMenuStrip contr = sender as ContextMenuStrip;
            string name = contr.SourceControl.Name;
            selectedList = int.Parse(name);
            //local drivers
            if (allListViews[selectedList].SelectedItems.Count == 0 && currentPath[selectedList] == "")
            {
                contextMenuStrip.Items[CREATE_CONTEXT_MENU].Visible = false;

            }
            //free space in listView
            else if (allListViews[selectedList].SelectedItems.Count == 0)
            {
                contextMenuStrip.Items[CREATE_CONTEXT_MENU].Visible = true;
            }
            //selected txt file
            else if (allListViews[selectedList].SelectedItems.Count == 1 &&
                        (allListViews[selectedList].SelectedItems[FIRST_ELEMENT].Text.EndsWith(TXT) ||
                         allListViews[selectedList].SelectedItems[FIRST_ELEMENT].Text.EndsWith(txt)))
            {
                contextMenuStrip.Items[CREATE_CONTEXT_MENU].Visible = false;

            }
            //selected folder or not txt file
            else if (allListViews[selectedList].SelectedItems.Count == 1)
            {
                contextMenuStrip.Items[CREATE_CONTEXT_MENU].Visible = false;

            }
        }


        private int GetNumberOfList(object sender)
        {
            Control control = sender as Control;
            String name = control.Name;

            if (name.Contains(LEFT_LIST))
            {
                return INDEX_OF_LEFT_LIST;
            }
            return INDEX_OF_RIGHT_LIST;
        }

        private void createFolderToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fmActions.CreateFolder(currentPath[selectedList]);
            fmActions.ChangeList(allListViews[selectedList], currentPath[selectedList]);
        }

        private void createTextFileToolStripMenuItem_Clic(object sender, EventArgs e)
        {
            fmActions.CreateTextFile(currentPath[selectedList]);
            fmActions.ChangeList(allListViews[selectedList], currentPath[selectedList]);
        }

        private void fileSystemWatcher_Changed(object sender, FileSystemEventArgs e)
        {
            FileSystemWatcher fsw = sender as FileSystemWatcher;
            int index = Array.IndexOf(currentPath, fsw.Path);
            fmActions.ChangeList(allListViews[index], currentPath[index]);
            
            //костыль
            if (currentPath[0].Equals(currentPath[1]))
            {
                fmActions.ChangeList(allListViews[1], currentPath[1]);
            }
        }

       

    }
}
