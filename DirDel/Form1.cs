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

namespace DirDel
{
    
    
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            //initialize default value
            txtDir.Text = "c:\\";
            radioFile.Checked = true;
        }

        /// <summary>
        /// Select a specified directory (folder)
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnOpenDir_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog DirDlg = new FolderBrowserDialog();

            DirDlg.Description = "Please choose folder!";
            if (DirDlg.ShowDialog() == DialogResult.OK)
            {
                txtDir.Text = DirDlg.SelectedPath;  //selected working dir
            }
        }

        /// <summary>
        /// close windows form and exit this application
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();    //关闭当前窗体或对象 
            Application.Exit();     //关闭所有应用程序窗口
        }        

        /// <summary>
        /// to search all specified directories or files  in a sepcified directory recursively.
        /// </summary>
        /// 
        private void btnSearch_Click(object sender, EventArgs e)
        {
            FileSystemInfo[] infoArr={}; //abstract class of fileInfo and DirInfo

            try {
                DirectoryInfo di = new DirectoryInfo(@txtDir.Text); // txtDir.Tex -> working path 
                string strWildcard = txtWildcard.Text;  //searchPattern

                //search files
                if (radioFile.Checked == true)
                {
                    //search 
                    //FileInfo[] files 
                    infoArr = di.GetFiles(strWildcard, SearchOption.AllDirectories);
                }
                else if (radioDir.Checked == true)
                {
                    //search all files in the current dir and it's subdir
                    //DirectoryInfo[] directories
                    infoArr = di.GetDirectories(strWildcard, SearchOption.AllDirectories);
                }

                //dynanically create Listview on the bottom of GUI
                //infoArr is parameter array
                Form2 formSearch = new Form2(infoArr);

                if (formSearch.ShowDialog() == System.Windows.Forms.DialogResult.No)
                {
                    //Close this form: formSearch
                    formSearch.Close();
                }
            }
             catch (Exception err)
            {
                MessageBox.Show(err.Message);
            }                 
        }        
    }
}
