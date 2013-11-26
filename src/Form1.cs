using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FM
{
    public partial class FileManager : Form
    {
        public const int NUMBER_OF_LISTVIEWS = 2;
        public const int FIRST_ELEMENT = 0;

        string[] currentPath = new String[NUMBER_OF_LISTVIEWS];
        


        public FileManager()
        {
            InitializeComponent();
            FileManagerActions addFunctionWindow = new FileManagerActions();
            ListView[] allListViews = new ListView[NUMBER_OF_LISTVIEWS] { listView1, listView2 };

            for (int i = 0; i < NUMBER_OF_LISTVIEWS; ++i)
            {
                addFunctionWindow.CreateList(allListViews[i], currentPath[i]);
            }
        }

        private void listView1_DoubleClick(object sender, EventArgs e)
        {
            string item = listView1.SelectedItems[FIRST_ELEMENT].Text;
            currentPath[0] = currentPath[0] + item + "\\";


            FileManagerActions fmActions = new FileManagerActions();
            fmActions.ChangeList(listView1, currentPath[0]);
        }

        private void listView2_DoubleClick(object sender, EventArgs e)
        {
            string item = listView2.SelectedItems[FIRST_ELEMENT].Text;
            currentPath[1] = currentPath[1] + item + "\\";


            FileManagerActions fmActions = new FileManagerActions();
            fmActions.ChangeList(listView2, currentPath[1]);
        }
      






    }
}
