using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace cpFiles
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            folderBrowserDialog1.ShowDialog();
            this.txtSelectFolder.Text = folderBrowserDialog1.SelectedPath;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            folderBrowserDialog1.ShowDialog();
            this.txtTargetFolder.Text = folderBrowserDialog1.SelectedPath;
        }

        public void FindFile(string dirPath) //引數dirPath為指定的目錄
        {
            //在指定目錄及子目錄下查詢檔案,在listBox1中列出子目錄及檔案
            DirectoryInfo Dir = new DirectoryInfo(dirPath);

            foreach (DirectoryInfo d in Dir.GetDirectories())//查詢子目錄
            {
                FindFile(Dir + d.ToString() + @"\");
                //listBox1.Items.Add(Dir + d.ToString() + @"\"); //listBox1中填加目錄名
            }
            foreach (FileInfo f in Dir.GetFiles(this.txtFileExtension.Text)) //查詢檔案
            {
                if (!File.Exists(this.txtTargetFolder.Text + @"\" + f.Name))
                    File.Move(f.FullName, this.txtTargetFolder.Text + @"\" + f.Name);
                //listBox1.Items.Add(Dir + f.ToString()); //listBox1中填加檔名
            }
        }

        private void btnRun2Copy_Click(object sender, EventArgs e)
        {
            try
            {
                FindFile(txtSelectFolder.Text + @"\");
                //MessageBox.Show("Success!!!");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            txtSelectFolder.Text = Properties.Settings.Default.selectFolder;
            txtTargetFolder.Text = Properties.Settings.Default.targetFolder;
            txtFileExtension.Text = Properties.Settings.Default.fileExetension;
            if (String.IsNullOrWhiteSpace(txtSelectFolder.Text) && String.IsNullOrWhiteSpace(txtTargetFolder.Text))
            {
                MessageBox.Show("get config floderPath error，plz run manually!!!");
            }
            else
            {
                btnRun2Copy_Click(null, null);
                this.Close();
                this.Dispose();
            }
        }
    }
}

