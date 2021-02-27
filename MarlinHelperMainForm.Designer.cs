
namespace WindowsFormsApp2
{
    partial class MarlinHelperMainForm
    {
        //dynamic MarlinConfig=new cMarlinConfig();
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
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.label1 = new System.Windows.Forms.Label();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.GBNewEnumeration = new System.Windows.Forms.GroupBox();
            this.CBDuplicatedOptions = new System.Windows.Forms.CheckBox();
            this.LblErrMsg = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.LBNewEnumerationValue = new System.Windows.Forms.Label();
            this.LBNewEnumerationName = new System.Windows.Forms.Label();
            this.TBNewEnumOptionVal = new System.Windows.Forms.TextBox();
            this.TBNewEnumOptionName = new System.Windows.Forms.TextBox();
            this.btnAddEnumOption = new System.Windows.Forms.Button();
            this.BtnDelEnumOpt = new System.Windows.Forms.Button();
            this.btnLoadEnumOptions = new System.Windows.Forms.Button();
            this.LBEnumerationName = new System.Windows.Forms.Label();
            this.TBEnumName = new System.Windows.Forms.TextBox();
            this.LBLoadedEnumOptions = new System.Windows.Forms.ListBox();
            this.LBFinalEnumOptions = new System.Windows.Forms.ListBox();
            this.BtnRightEnumOptions = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.listView1 = new System.Windows.Forms.ListView();
            this.GBNewEnumeration.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(6, 15);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(86, 26);
            this.button1.TabIndex = 0;
            this.button1.Text = "Read Settings";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(6, 42);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(86, 25);
            this.button2.TabIndex = 1;
            this.button2.Text = "button2";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(6, 67);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(119, 23);
            this.button3.TabIndex = 3;
            this.button3.Text = "Select Marlin Directiry";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(121, 67);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(235, 23);
            this.label1.TabIndex = 5;
            this.label1.Text = "label1";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // GBNewEnumeration
            // 
            this.GBNewEnumeration.Controls.Add(this.CBDuplicatedOptions);
            this.GBNewEnumeration.Controls.Add(this.LblErrMsg);
            this.GBNewEnumeration.Controls.Add(this.label2);
            this.GBNewEnumeration.Controls.Add(this.LBNewEnumerationValue);
            this.GBNewEnumeration.Controls.Add(this.LBNewEnumerationName);
            this.GBNewEnumeration.Controls.Add(this.TBNewEnumOptionVal);
            this.GBNewEnumeration.Controls.Add(this.TBNewEnumOptionName);
            this.GBNewEnumeration.Controls.Add(this.btnAddEnumOption);
            this.GBNewEnumeration.Controls.Add(this.BtnDelEnumOpt);
            this.GBNewEnumeration.Controls.Add(this.btnLoadEnumOptions);
            this.GBNewEnumeration.Controls.Add(this.LBEnumerationName);
            this.GBNewEnumeration.Controls.Add(this.TBEnumName);
            this.GBNewEnumeration.Controls.Add(this.LBLoadedEnumOptions);
            this.GBNewEnumeration.Controls.Add(this.LBFinalEnumOptions);
            this.GBNewEnumeration.Controls.Add(this.BtnRightEnumOptions);
            this.GBNewEnumeration.Controls.Add(this.button4);
            this.GBNewEnumeration.Location = new System.Drawing.Point(0, 0);
            this.GBNewEnumeration.Name = "GBNewEnumeration";
            this.GBNewEnumeration.Size = new System.Drawing.Size(436, 266);
            this.GBNewEnumeration.TabIndex = 13;
            this.GBNewEnumeration.TabStop = false;
            this.GBNewEnumeration.Text = "New Enumeration";
            // 
            // CBDuplicatedOptions
            // 
            this.CBDuplicatedOptions.AutoSize = true;
            this.CBDuplicatedOptions.Location = new System.Drawing.Point(242, 156);
            this.CBDuplicatedOptions.Name = "CBDuplicatedOptions";
            this.CBDuplicatedOptions.Size = new System.Drawing.Size(77, 17);
            this.CBDuplicatedOptions.TabIndex = 29;
            this.CBDuplicatedOptions.Text = "Duplicated";
            this.CBDuplicatedOptions.UseVisualStyleBackColor = true;
            this.CBDuplicatedOptions.CheckedChanged += new System.EventHandler(this.CBDuplicatedOptions_CheckedChanged);
            // 
            // LblErrMsg
            // 
            this.LblErrMsg.Location = new System.Drawing.Point(211, 171);
            this.LblErrMsg.Name = "LblErrMsg";
            this.LblErrMsg.Size = new System.Drawing.Size(219, 53);
            this.LblErrMsg.TabIndex = 28;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 43);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(105, 13);
            this.label2.TabIndex = 27;
            this.label2.Text = "Enumetation Options";
            // 
            // LBNewEnumerationValue
            // 
            this.LBNewEnumerationValue.AutoSize = true;
            this.LBNewEnumerationValue.Location = new System.Drawing.Point(7, 195);
            this.LBNewEnumerationValue.Name = "LBNewEnumerationValue";
            this.LBNewEnumerationValue.Size = new System.Drawing.Size(90, 13);
            this.LBNewEnumerationValue.TabIndex = 26;
            this.LBNewEnumerationValue.Text = "New option value";
            // 
            // LBNewEnumerationName
            // 
            this.LBNewEnumerationName.AutoSize = true;
            this.LBNewEnumerationName.Location = new System.Drawing.Point(7, 157);
            this.LBNewEnumerationName.Name = "LBNewEnumerationName";
            this.LBNewEnumerationName.Size = new System.Drawing.Size(90, 13);
            this.LBNewEnumerationName.TabIndex = 25;
            this.LBNewEnumerationName.Text = "New option name";
            // 
            // TBNewEnumOptionVal
            // 
            this.TBNewEnumOptionVal.Location = new System.Drawing.Point(6, 208);
            this.TBNewEnumOptionVal.Name = "TBNewEnumOptionVal";
            this.TBNewEnumOptionVal.Size = new System.Drawing.Size(187, 20);
            this.TBNewEnumOptionVal.TabIndex = 24;
            // 
            // TBNewEnumOptionName
            // 
            this.TBNewEnumOptionName.Location = new System.Drawing.Point(6, 171);
            this.TBNewEnumOptionName.Name = "TBNewEnumOptionName";
            this.TBNewEnumOptionName.Size = new System.Drawing.Size(187, 20);
            this.TBNewEnumOptionName.TabIndex = 23;
            // 
            // btnAddEnumOption
            // 
            this.btnAddEnumOption.Location = new System.Drawing.Point(101, 233);
            this.btnAddEnumOption.Name = "btnAddEnumOption";
            this.btnAddEnumOption.Size = new System.Drawing.Size(92, 23);
            this.btnAddEnumOption.TabIndex = 22;
            this.btnAddEnumOption.Text = "Add option";
            this.btnAddEnumOption.UseVisualStyleBackColor = true;
            this.btnAddEnumOption.Click += new System.EventHandler(this.btnAddEnumOption_Click);
            // 
            // BtnDelEnumOpt
            // 
            this.BtnDelEnumOpt.Location = new System.Drawing.Point(6, 233);
            this.BtnDelEnumOpt.Name = "BtnDelEnumOpt";
            this.BtnDelEnumOpt.Size = new System.Drawing.Size(89, 23);
            this.BtnDelEnumOpt.TabIndex = 21;
            this.BtnDelEnumOpt.Text = "Delete option";
            this.BtnDelEnumOpt.UseVisualStyleBackColor = true;
            // 
            // btnLoadEnumOptions
            // 
            this.btnLoadEnumOptions.Location = new System.Drawing.Point(242, 32);
            this.btnLoadEnumOptions.Name = "btnLoadEnumOptions";
            this.btnLoadEnumOptions.Size = new System.Drawing.Size(188, 23);
            this.btnLoadEnumOptions.TabIndex = 20;
            this.btnLoadEnumOptions.Text = "Load options from .h";
            this.btnLoadEnumOptions.UseVisualStyleBackColor = true;
            this.btnLoadEnumOptions.Click += new System.EventHandler(this.btnLoadEnumOptions_Click);
            // 
            // LBEnumerationName
            // 
            this.LBEnumerationName.AutoSize = true;
            this.LBEnumerationName.Location = new System.Drawing.Point(139, 16);
            this.LBEnumerationName.Name = "LBEnumerationName";
            this.LBEnumerationName.Size = new System.Drawing.Size(97, 13);
            this.LBEnumerationName.TabIndex = 16;
            this.LBEnumerationName.Text = "Enumeration Name";
            // 
            // TBEnumName
            // 
            this.TBEnumName.Location = new System.Drawing.Point(7, 13);
            this.TBEnumName.Name = "TBEnumName";
            this.TBEnumName.Size = new System.Drawing.Size(131, 20);
            this.TBEnumName.TabIndex = 13;
            // 
            // LBLoadedEnumOptions
            // 
            this.LBLoadedEnumOptions.FormattingEnabled = true;
            this.LBLoadedEnumOptions.Location = new System.Drawing.Point(242, 59);
            this.LBLoadedEnumOptions.Name = "LBLoadedEnumOptions";
            this.LBLoadedEnumOptions.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.LBLoadedEnumOptions.Size = new System.Drawing.Size(188, 95);
            this.LBLoadedEnumOptions.TabIndex = 17;
            // 
            // LBFinalEnumOptions
            // 
            this.LBFinalEnumOptions.FormattingEnabled = true;
            this.LBFinalEnumOptions.Location = new System.Drawing.Point(6, 59);
            this.LBFinalEnumOptions.Name = "LBFinalEnumOptions";
            this.LBFinalEnumOptions.Size = new System.Drawing.Size(188, 95);
            this.LBFinalEnumOptions.TabIndex = 15;
            this.LBFinalEnumOptions.Click += new System.EventHandler(this.LBFinalEnumOptions_Click);
            this.LBFinalEnumOptions.SelectedIndexChanged += new System.EventHandler(this.LBFinalEnumOptions_SelectedIndexChanged);
            this.LBFinalEnumOptions.SelectedValueChanged += new System.EventHandler(this.LBFinalEnumOptions_SelectedValueChanged);
            // 
            // BtnRightEnumOptions
            // 
            this.BtnRightEnumOptions.Location = new System.Drawing.Point(200, 95);
            this.BtnRightEnumOptions.Name = "BtnRightEnumOptions";
            this.BtnRightEnumOptions.Size = new System.Drawing.Size(36, 23);
            this.BtnRightEnumOptions.TabIndex = 18;
            this.BtnRightEnumOptions.Text = "<<";
            this.BtnRightEnumOptions.UseVisualStyleBackColor = true;
            this.BtnRightEnumOptions.Click += new System.EventHandler(this.BtnRightEnumOptions_Click);
            // 
            // button4
            // 
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.Location = new System.Drawing.Point(253, 227);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(177, 29);
            this.button4.TabIndex = 14;
            this.button4.Text = "Add new enumeration";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(6, 92);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(228, 238);
            this.listBox1.TabIndex = 14;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(918, 450);
            this.tabControl1.TabIndex = 15;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.groupBox1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(910, 424);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "tabPage1";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.button2);
            this.groupBox1.Controls.Add(this.button3);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.listBox1);
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(240, 342);
            this.groupBox1.TabIndex = 16;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.listView1);
            this.tabPage2.Controls.Add(this.GBNewEnumeration);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(910, 424);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "tabPage2";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // listView1
            // 
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(559, 20);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(121, 97);
            this.listView1.TabIndex = 14;
            this.listView1.UseCompatibleStateImageBehavior = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(918, 450);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.GBNewEnumeration.ResumeLayout(false);
            this.GBNewEnumeration.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.GroupBox GBNewEnumeration;
        private System.Windows.Forms.Button btnLoadEnumOptions;
        private System.Windows.Forms.TextBox TBEnumName;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button BtnRightEnumOptions;
        private System.Windows.Forms.ListBox LBFinalEnumOptions;
        private System.Windows.Forms.ListBox LBLoadedEnumOptions;
        private System.Windows.Forms.Label LBEnumerationName;
        private System.Windows.Forms.Label LBNewEnumerationValue;
        private System.Windows.Forms.Label LBNewEnumerationName;
        private System.Windows.Forms.TextBox TBNewEnumOptionVal;
        private System.Windows.Forms.TextBox TBNewEnumOptionName;
        private System.Windows.Forms.Button btnAddEnumOption;
        private System.Windows.Forms.Button BtnDelEnumOpt;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label LblErrMsg;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox CBDuplicatedOptions;
        private System.Windows.Forms.ListView listView1;
    }
}

