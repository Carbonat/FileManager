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

        public const int NUMBER_OF_LISTVIEWS = 2;
        

        private string[] currentPath = new String[NUMBER_OF_LISTVIEWS];

        private FileManagerActions fmActions = new FileManagerActions();

        public FileManager()
        {
            InitializeComponent();
            FileManagerActions fmActions = new FileManagerActions();
            ListView[] allListViews = new ListView[NUMBER_OF_LISTVIEWS] { listView1, listView2 };
            
            for (int i = 0; i < NUMBER_OF_LISTVIEWS; ++i)
            {
                fmActions.CreateList(allListViews[i]);
            }

        }

        private void listView1_DoubleClick(object sender, EventArgs e)
        {
            fmActions.Double_Click(listView1, ref currentPath[0]);
        }

        private void listView2_DoubleClick(object sender, EventArgs e)
        {
            fmActions.Double_Click(listView2, ref currentPath[1]);
        }

        private void up_listView1_Click(object sender, EventArgs e)
        {
            fmActions.UpClick(listView1, ref currentPath[0]);
        }

        private void up_listView2_Click(object sender, EventArgs e)
        {
            fmActions.UpClick(listView2, ref currentPath[1]);
        }

    }
}
