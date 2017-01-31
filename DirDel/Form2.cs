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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        enum fileOrDir { FILE, DIR };
        fileOrDir Dirflag;  //store the item info style: FILE or DIR

        /// <summary>
        /// to fill listview 
        /// </summary>
        /// <param name="arr"> the searched item which will be fill in listview</param>
        public Form2(FileSystemInfo[] arr)
        {
            InitializeComponent();  //init all components in form2

            // First header
            ColumnHeader colHead = new ColumnHeader();

            //to acquire arr type: dirInfo or fileInfo
            //arr.GetType() == FileInfo[] ?
            if (arr.GetType() == typeof(FileInfo[]))
            {
                colHead.Text = "File name";
                Dirflag = fileOrDir.FILE;
            }
            else if (arr.GetType() == typeof(DirectoryInfo[]))
            {
                colHead.Text = "Directory name";
                Dirflag = fileOrDir.DIR;
            }

            //initialize listview view style
            listViewSearch.CheckBoxes = true;   //add checkbox into listview;
            listViewSearch.View = View.Details;
            listViewSearch.Columns.Add(colHead.Text.ToString(), -2, HorizontalAlignment.Center); // Insert the header
            listViewSearch.Columns.Add("Full name", -2, HorizontalAlignment.Left);


            //fill  out ListView control
            foreach (FileSystemInfo item in arr)
            {
                // Create the main ListViewItem.
                ListViewItem lvi = new ListViewItem();
                lvi.Text = item.Name; // name
                lvi.ImageIndex = 0; // The folder icon has index 0
                lvi.Tag = item.FullName; // Set the tag to the qualified path of the
                
                //2. Full path + name
                ListViewItem.ListViewSubItem lvsi = new ListViewItem.ListViewSubItem();
                lvsi.Text = item.FullName; // Size—a folder has no size and so this column
                // is empty
                lvi.SubItems.Add(lvsi); // Add the subitem to the ListViewItem

                listViewSearch.Items.Add(lvi);  //item vs Listview
            }

        }
        private void btnGiveup_Click(object sender, EventArgs e)
        {
             this.DialogResult = System.Windows.Forms.DialogResult.No;
        }

        /// <summary>
        /// to set all check state of item of Listview
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void checkAllSel_CheckedChanged(object sender, EventArgs e)
        {
            bool checkFlag = true;

            if (checkAllSel.Checked == false)
            {
                checkFlag = false;
            }

            foreach (ListViewItem item in listViewSearch.Items)
            {
                item.Checked = checkFlag;   //set all item's checkbox state
            }
        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("are you sure delete those files or directories?","Action!",
                MessageBoxButtons.YesNo);
            
            //now, to delete checked files or dir
            if (result == DialogResult.Yes)
            {
                foreach (ListViewItem item in listViewSearch.Items)
                {
                    if (item.Checked == true)
                    {
                        if (Dirflag == fileOrDir.FILE)
                            System.IO.File.Delete(@item.SubItems[1].Text);
                        else if (Dirflag == fileOrDir.DIR) //true -- 表示是否要递归删除
                            System.IO.Directory.Delete(@item.SubItems[1].Text,true); //ture denote recursively del

                        listViewSearch.Items.Remove(item);  //remove the selected item from listview
                    }                    
                }
            }

        }
    }
}
