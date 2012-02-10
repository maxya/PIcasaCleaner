namespace LogRemover
{
    partial class Form1
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
            this.pathBox = new System.Windows.Forms.ComboBox();
            this.searchbutton = new System.Windows.Forms.Button();
            this.fileListBox = new System.Windows.Forms.ListBox();
            this.selectAllButton = new System.Windows.Forms.Button();
            this.deleteButton = new System.Windows.Forms.Button();
            this.disselectButton = new System.Windows.Forms.Button();
            this.fileTypeBox = new System.Windows.Forms.ComboBox();
            this.logBox = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.button_test = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // pathBox
            // 
            this.pathBox.FormattingEnabled = true;
            this.pathBox.Items.AddRange(new object[] {
            "C:\\Users\\maxim\\Pictures\\",
            "."});
            this.pathBox.Location = new System.Drawing.Point(12, 33);
            this.pathBox.Name = "pathBox";
            this.pathBox.Size = new System.Drawing.Size(346, 21);
            this.pathBox.TabIndex = 0;
            this.pathBox.Text = "C:\\Users\\maxim\\Pictures\\";
            // 
            // searchbutton
            // 
            this.searchbutton.Location = new System.Drawing.Point(663, 76);
            this.searchbutton.Name = "searchbutton";
            this.searchbutton.Size = new System.Drawing.Size(66, 24);
            this.searchbutton.TabIndex = 1;
            this.searchbutton.Text = "Search";
            this.searchbutton.UseVisualStyleBackColor = true;
            this.searchbutton.Click += new System.EventHandler(this.searchbutton_Click);
            // 
            // fileListBox
            // 
            this.fileListBox.FormattingEnabled = true;
            this.fileListBox.HorizontalScrollbar = true;
            this.fileListBox.Location = new System.Drawing.Point(12, 77);
            this.fileListBox.Name = "fileListBox";
            this.fileListBox.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
            this.fileListBox.Size = new System.Drawing.Size(623, 212);
            this.fileListBox.TabIndex = 2;
            // 
            // selectAllButton
            // 
            this.selectAllButton.Location = new System.Drawing.Point(663, 119);
            this.selectAllButton.Name = "selectAllButton";
            this.selectAllButton.Size = new System.Drawing.Size(67, 24);
            this.selectAllButton.TabIndex = 3;
            this.selectAllButton.Text = "Select All";
            this.selectAllButton.UseVisualStyleBackColor = true;
            this.selectAllButton.Click += new System.EventHandler(this.selectAllButton_Click);
            // 
            // deleteButton
            // 
            this.deleteButton.Location = new System.Drawing.Point(664, 347);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(67, 29);
            this.deleteButton.TabIndex = 4;
            this.deleteButton.Text = "Delete";
            this.deleteButton.UseVisualStyleBackColor = true;
            this.deleteButton.Click += new System.EventHandler(this.deleteButton_Click);
            // 
            // disselectButton
            // 
            this.disselectButton.Location = new System.Drawing.Point(664, 158);
            this.disselectButton.Name = "disselectButton";
            this.disselectButton.Size = new System.Drawing.Size(66, 23);
            this.disselectButton.TabIndex = 5;
            this.disselectButton.Text = "Disselect";
            this.disselectButton.UseVisualStyleBackColor = true;
            this.disselectButton.Click += new System.EventHandler(this.disselectButton_Click);
            // 
            // fileTypeBox
            // 
            this.fileTypeBox.DisplayMember = "*.log";
            this.fileTypeBox.FormattingEnabled = true;
            this.fileTypeBox.Items.AddRange(new object[] {
            "*.jpg",
            "*.jpeg",
            "*.log"});
            this.fileTypeBox.Location = new System.Drawing.Point(364, 33);
            this.fileTypeBox.Name = "fileTypeBox";
            this.fileTypeBox.Size = new System.Drawing.Size(70, 21);
            this.fileTypeBox.TabIndex = 6;
            this.fileTypeBox.Text = "*.jpg";
            // 
            // logBox
            // 
            this.logBox.FormattingEnabled = true;
            this.logBox.Location = new System.Drawing.Point(12, 308);
            this.logBox.Name = "logBox";
            this.logBox.Size = new System.Drawing.Size(623, 69);
            this.logBox.TabIndex = 7;
            this.logBox.UseTabStops = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Path to files";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(361, 17);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "File Type";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 57);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "Files List";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(9, 292);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(28, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "Log:";
            // 
            // button_test
            // 
            this.button_test.Location = new System.Drawing.Point(664, 308);
            this.button_test.Name = "button_test";
            this.button_test.Size = new System.Drawing.Size(67, 23);
            this.button_test.TabIndex = 12;
            this.button_test.Text = "Test";
            this.button_test.UseVisualStyleBackColor = true;
            this.button_test.Click += new System.EventHandler(this.button_test_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(742, 466);
            this.Controls.Add(this.button_test);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.logBox);
            this.Controls.Add(this.fileTypeBox);
            this.Controls.Add(this.disselectButton);
            this.Controls.Add(this.deleteButton);
            this.Controls.Add(this.selectAllButton);
            this.Controls.Add(this.fileListBox);
            this.Controls.Add(this.searchbutton);
            this.Controls.Add(this.pathBox);
            this.Name = "Form1";
            this.Text = "PicasaCleaner";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox pathBox;
        private System.Windows.Forms.Button searchbutton;
        private System.Windows.Forms.ListBox fileListBox;
        private System.Windows.Forms.Button selectAllButton;
        private System.Windows.Forms.Button deleteButton;
        private System.Windows.Forms.Button disselectButton;
        private System.Windows.Forms.ComboBox fileTypeBox;
        private System.Windows.Forms.ListBox logBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button_test;
    }
}

