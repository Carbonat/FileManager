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
    public partial class NameOfNewFileOrFolder : Form
    {
        private const int MAX_PATH = 260;
        private const string WRONG_SYMBOLS_WARNING = "Ім'я не може містити \\ / : * ? \" < > | \nБути пустим чи містити лише пропуски.";
        private const string LONG_NAME_WARNING = "Ім'я не може складатися з більше ніж більше 260 символів.";

        FileManagerActions fmAction = new FileManagerActions();
        private char[] forbiddenSymbols = { '\\', '/', ':', '*', '?', '"', '<', '>', '|' }; 
        static public string NewName { get; set; }
        private string currentPath = "";

        public NameOfNewFileOrFolder()
        {
            InitializeComponent();
        }

        public NameOfNewFileOrFolder(string title, string path)
        {
            InitializeComponent();
            this.Text = title;
            currentPath = path;
        }


        private void button1_Click(object sender, EventArgs e)
        {
            string name;
            do
            {
                name = textBox1.Text;
            }
            while (!isPossibleName(name));
            NewName = name;
            this.Close();
        }

        private bool isPossibleName(string name)
        {
            bool isCorrectName;
            bool isFolderAlreadyCreated;
            string fullName = currentPath + name + "\\";
            
            isCorrectName = CheckName(name);
            isFolderAlreadyCreated =  Directory.Exists(fullName);
            if(isCorrectName && !isFolderAlreadyCreated)
            {
                return true;
            }
            if (fullName.Length > MAX_PATH)
            {
                MessageBox.Show(LONG_NAME_WARNING);
            }
            return false;
        }


        private bool CheckName(string name)
        {
            int length = forbiddenSymbols.Length;
            for (int i = 0; i < length; ++i)
            {
                if (name.Contains(forbiddenSymbols[i])
                    || string.IsNullOrWhiteSpace(name)
                    || name.Length > MAX_PATH)
                {
                    MessageBox.Show(WRONG_SYMBOLS_WARNING, "Увага");
                    return false;
                }
            }
            return true;
        }
    }
}
