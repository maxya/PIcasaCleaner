using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;


namespace LogRemover
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

        }
        #region Constants
        private string fileExt = "*.jpg";
        private string firstDir = ".picasaoriginals";
        private string secondDir = "Originals";
        #endregion

        private void searchbutton_Click(object sender, EventArgs e)
        {
            //Check path
            if (!Directory.Exists(pathBox.Text))
            {
                MessageBox.Show("Directory does not exist");
                goto EndProc;
            }
            //Clear list box
            if(fileListBox.Items.Count != 0)
                fileListBox.Items.Clear();

            string[] fileList = new string[1024];            

            if (fileTypeBox.SelectedItem != null)
                fileExt = fileTypeBox.SelectedItem.ToString();
            else
                fileExt = fileTypeBox.Text;
            if (pathBox.SelectedItem != null)
            {
                fileList = System.IO.Directory.GetFiles(pathBox.SelectedItem.ToString(), fileExt, SearchOption.AllDirectories);
            }
            else
            {
                fileList = System.IO.Directory.GetFiles(pathBox.Text, fileExt, SearchOption.AllDirectories);
            }
            List<string> newfileList = CleanUrls(fileList, firstDir);
            List<string> anotherfileList = CleanUrls(fileList, secondDir);
            newfileList.AddRange(anotherfileList);
            foreach (string curFile in newfileList)
            {
                string filePath = Path.GetFullPath(curFile);
                fileListBox.Items.Add(filePath);
            }
            logBox.Items.Add(getSize(newfileList).ToString() + " Mb");
        EndProc: ;            
            for (int i = 0; i < fileListBox.Items.Count; i++)
                fileListBox.SetSelected(i, true);
        }
        
        private List<string> CleanUrls(string[] dirtiLinks, string linkPatern)
        {
            List<string> cleanList = new List<string>();
            //string patern = ".picasaoriginals";
            foreach (string str in dirtiLinks)
            {
                if (str != null)
                    if (str.Contains(linkPatern))
                        cleanList.Add(str);
            }            
            return cleanList;
        }

        private void selectAllButton_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < fileListBox.Items.Count; i++)
                fileListBox.SetSelected(i, true);
        }

        private void disselectButton_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < fileListBox.Items.Count; i++)
                fileListBox.SetSelected(i, false);
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            //string [] deleteList = new string[1024];
            int i = 0;
            string delStatus = "Removing file ";
            foreach (string item in fileListBox.SelectedItems)
            {                
                //deleteList[i] = item;
                logBox.Items.Add(delStatus+item);
                //Delete file
                System.IO.File.Delete(item);
                logBox.SelectedIndex = i;
                i++;
            }
            logBox.Items.Add("Delete commplete");
            logBox.Items.Add("Total files removed: " + i.ToString());
            logBox.SelectedIndex = (logBox.Items.Count-1);    
            //deleteList = fileListBox.SelectedItems;
        }

        private void button_test_Click(object sender, EventArgs e)
        {
            int i = 0;
            string delStatus = "Processing file ";
            foreach (string item in fileListBox.SelectedItems)
            {
                //deleteList[i] = item;
                logBox.Items.Add(delStatus + item);
                //Delete file
                //System.IO.File.Delete(item);
                logBox.SelectedIndex = i;
                i++;
            }
            logBox.Items.Add("Test commplete");
            logBox.Items.Add("Total files to be removed: " + i.ToString());
            logBox.SelectedIndex = (logBox.Items.Count - 1);
        }
        private int getSize(List<string> filePath)
        {
            int totalSize = 0;
            
            foreach(string curFile in filePath)
            {
                System.IO.FileInfo fi= new FileInfo(curFile);
                totalSize += (int)fi.Length;
            }
            totalSize = totalSize / 1024 / 1024;
            return totalSize;
        }
    }
}
