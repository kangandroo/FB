using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ipost.others
{
    public partial class f500_open_save_file : Form
    {
        public f500_open_save_file()
        {
            InitializeComponent();
        }

        private void f500_open_save_file_Load(object sender, EventArgs e)
        {
            createListFile();
        }

        #region io file
        public Queue readfile(string filename)
        {
            Queue line = new Queue() ;
            try
            {
                string file = Application.StartupPath + @"\" + filename;
                // Read the file and display it line by line.
                System.IO.StreamReader fileStr = new System.IO.StreamReader(file);
                while (fileStr.ReadLine() != null)
                {
                    line.Enqueue(fileStr.ReadLine());
                }
                fileStr.Close();
                if (line.Count==0) MessageBox.Show("Nội dung file không đúng.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Nội dung file không đúng." + ex);             
            }
            return line;

        }
        public void savefile(string fileName, string value)
        {
            string path = Application.StartupPath+ @"\"+fileName ;
            if (!File.Exists(path))
            {
                //  File.Create(path);
                File.WriteAllText(path, value);
            }
            else
                using (StreamWriter sw = new StreamWriter(path, false))
                {
                    sw.WriteLine(value);
                    sw.Close();
                }
        }

        public void createListFile()
        {
            DirectoryInfo dinfo = new DirectoryInfo(Application.StartupPath);
            FileInfo[] Files = dinfo.GetFiles("*.txt");
            m_listbox_file.Items.Clear();
            foreach (FileInfo file in Files)
            {
                m_listbox_file.Items.Add(file.Name);
            }
        }
        #endregion

        
    }
}
