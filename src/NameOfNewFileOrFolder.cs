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
        public const int FOLDER = 0;
        public const int TEXT_FILE = 1;

        FileManagerActions fmAction = new FileManagerActions();
        private char[] forbiddenSymbols = { '\\', '/', ':', '*', '?', '"', '<', '>', '|' }; 
        static public string NewName { get; set; }
        private string currentPath = "";
        private int typeCreationObject = -1;

        public NameOfNewFileOrFolder()
        {
            InitializeComponent();
        }

        public NameOfNewFileOrFolder(string title, string path, int type)
        {
            InitializeComponent();
            this.Text = title;
            currentPath = path;
            typeCreationObject = type;
        }


        private void okButton1_Click(object sender, EventArgs e)
        {
            string name;
            name = textBox1.Text;
            bool isNameOK = isPossibleName(name);
            if (isNameOK)
            {
                NewName = name;
                Close();
            }
        }

        private bool isPossibleName(string name)
        {
            bool isCorrectName;
            bool isObjectAlreadyCreated;
            string fullName = currentPath + name;
            
            isCorrectName = CheckName(name);
            if (typeCreationObject == FOLDER)
            {
                fullName += "\\";
                isObjectAlreadyCreated = Directory.Exists(fullName);
            }
            else
            {
                fullName += ".txt";
                isObjectAlreadyCreated = File.Exists(fullName);
            }

            if(isCorrectName && !isObjectAlreadyCreated)
            {
                return true;
            }
            if (isObjectAlreadyCreated)
            {
                MessageBox.Show("Папка/файл з таким іменем вже існує", "Увага");
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

        private void cancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}
