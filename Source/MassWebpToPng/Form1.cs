using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace MassWebpToPng
{
    public partial class Form1 : Form
    {

        string filePath;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog fd = new FolderBrowserDialog();
            fd.ShowDialog();
            filePath = fd.SelectedPath;
            richTextBox1.Text = filePath;

            DirectoryInfo d = new DirectoryInfo(@filePath);
            FileInfo[] infos = d.GetFiles();

            foreach(FileInfo f in infos)
            {
                try
                {
                    if(checkBox1.Checked)
                        File.Move(f.FullName, f.FullName.Replace(".webp", ".png"));
                    if (checkBox2.Checked)
                        File.Move(f.FullName, f.FullName.Replace(".jpg", ".png"));
                    if (checkBox3.Checked)
                        File.Move(f.FullName, f.FullName.Replace(".jpeg", ".png"));
                    listBox1.Items.Add(f);
                }
                catch
                {
                    listBox1.Items.Add(f + " (!) File could not be converted (!) ");
                }
             
               
            }
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
