namespace DirDel
{
    partial class Form2
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.checkAllSel = new System.Windows.Forms.CheckBox();
            this.btnDel = new System.Windows.Forms.Button();
            this.btnGiveup = new System.Windows.Forms.Button();
            this.listViewSearch = new System.Windows.Forms.ListView();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // checkAllSel
            // 
            this.checkAllSel.AutoSize = true;
            this.checkAllSel.Location = new System.Drawing.Point(12, 243);
            this.checkAllSel.Name = "checkAllSel";
            this.checkAllSel.Size = new System.Drawing.Size(109, 19);
            this.checkAllSel.TabIndex = 2;
            this.checkAllSel.Text = "All select";
            this.checkAllSel.UseVisualStyleBackColor = true;
            this.checkAllSel.CheckedChanged += new System.EventHandler(this.checkAllSel_CheckedChanged);
            // 
            // btnDel
            // 
            this.btnDel.Location = new System.Drawing.Point(206, 240);
            this.btnDel.Name = "btnDel";
            this.btnDel.Size = new System.Drawing.Size(113, 23);
            this.btnDel.TabIndex = 3;
            this.btnDel.Text = "Delete now?";
            this.btnDel.UseVisualStyleBackColor = true;
            this.btnDel.Click += new System.EventHandler(this.btnDel_Click);
            // 
            // btnGiveup
            // 
            this.btnGiveup.Location = new System.Drawing.Point(351, 239);
            this.btnGiveup.Name = "btnGiveup";
            this.btnGiveup.Size = new System.Drawing.Size(100, 23);
            this.btnGiveup.TabIndex = 4;
            this.btnGiveup.Text = "Give up!";
            this.btnGiveup.UseVisualStyleBackColor = true;
            this.btnGiveup.Click += new System.EventHandler(this.btnGiveup_Click);
            // 
            // listViewSearch
            // 
            this.listViewSearch.Location = new System.Drawing.Point(3, 5);
            this.listViewSearch.Name = "listViewSearch";
            this.listViewSearch.Size = new System.Drawing.Size(464, 228);
            this.listViewSearch.TabIndex = 10;
            this.listViewSearch.UseCompatibleStateImageBehavior = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 5);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 15);
            this.label1.TabIndex = 11;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(472, 267);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnGiveup);
            this.Controls.Add(this.listViewSearch);
            this.Controls.Add(this.btnDel);
            this.Controls.Add(this.checkAllSel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "Form2";
            this.Text = "Search results";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox checkAllSel;
        private System.Windows.Forms.Button btnDel;
        private System.Windows.Forms.Button btnGiveup;
        private System.Windows.Forms.ListView listViewSearch;
        private System.Windows.Forms.Label label1;
    }
}