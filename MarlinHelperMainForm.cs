using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//using System.Windows.Controls;
using System.Dynamic;
using System.Xml;
using System.Xml.Schema;
using System.Xml.Serialization;
using System.IO;

namespace WindowsFormsApp2
{
    public partial class MarlinHelperMainForm : Form
    {
        cMarlinSettings MarlinSettings = new cMarlinSettings();
        Dictionary<string, Int32> EnumOptions = new Dictionary<string, Int32>();
        Dictionary<string, Int32> LoadedEnumOptions = new Dictionary<string, Int32>();
        int LBFinalEnumOptionsLastSel=-1;
        bool SelIndexChangedEnabled=true;
        string MarlinDirectory="";
        public MarlinHelperMainForm()
        {
            InitializeComponent();
        }

        private void Form1_Load(EventArgs e)
        {
           //
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MarlingRWConfig.ReadConfig(MarlinSettings, Properties.Settings.Default.MarlinDirectory+"\\Marlin\\Configuration.h");
            
            foreach (var key in MarlinSettings.Keys)
                listBox1.Items.Add(key + ' '+ MarlinSettings[key]);
            /*
            MarlinSettings.Add("Prop1","Value1");
            MarlinSettings.Add("Prop2", 38);
            
              cMarlinSettings Group1 = new cMarlinSettings();
              Group1.Title = "Group1";
              Group1.Add("Prop1", true);

                cMarlinSettings Group11 = new cMarlinSettings();
                Group11.Title = "Group11";
                Group11.Add("Prop1", "Value1");
                Group11.Add("Prop2", 128);
                Group1.Add("Group11", Group11);

              Group1.Add("Prop2", 0.381);
              Group1.Add("Prop3", 12);
              MarlinSettings.Add("Group1", Group1);

              cMarlinSettings Group2 = new cMarlinSettings();
              Group2.Title = "Group2";
              Group2.Add("Prop1",false);
              Group2.Add("Prop2", 0.167);
              MarlinSettings.Add("Group2", Group1);

            MarlinSettings.Add("Prop3", "Value3");*/
            //((IDictionary<String, Object>)MarlinConfig).Add("Prop1", a);

        }

        private void button2_Click(object sender, EventArgs e)
        {
            XmlSerializer serializer = new XmlSerializer(typeof(cMarlinSettings));
            TextWriter textWriter = new StreamWriter(@"languages.xml");
            serializer.Serialize(textWriter, MarlinSettings);
            textWriter.Close();
            /*
            MarlinConfig.title = "Serialization Overview";
            System.Xml.Serialization.XmlSerializer writer =
                new System.Xml.Serialization.XmlSerializer(MarlinConfig.GetType());

            var path = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + "//SerializationOverview.xml";
            System.IO.FileStream file = System.IO.File.Create(path);

            writer.Serialize(file, MarlinConfig);
            file.Close();
            */
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (folderBrowserDialog1.ShowDialog() == DialogResult.OK)
            {
                Properties.Settings.Default.MarlinDirectory = folderBrowserDialog1.SelectedPath;
                Properties.Settings.Default.Save();
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            label1.Text= Properties.Settings.Default.MarlinDirectory; 
            folderBrowserDialog1.SelectedPath = Properties.Settings.Default.MarlinDirectory;
        }

        private void button4_Click(object sender, EventArgs e)
        {

        }
        private void FillListBoxLoadedOptions()
        {
            // Fill the right listbox
            LBLoadedEnumOptions.Items.Clear();
            foreach (var key in LoadedEnumOptions.Keys)
                LBLoadedEnumOptions.Items.Add(key + ' ' + LoadedEnumOptions[key]);

            // Select all items in Right ListBox
            LBLoadedEnumOptions.BeginUpdate();
            for (int i = 0; i < LBLoadedEnumOptions.Items.Count; i++)
                LBLoadedEnumOptions.SetSelected(i, true);
            LBLoadedEnumOptions.EndUpdate();
        }
        private void btnLoadEnumOptions_Click(object sender, EventArgs e)
        {
            //Prepare OpenFileDialog parameters
            openFileDialog1.InitialDirectory = Properties.Settings.Default.MarlinDirectory;
            openFileDialog1.Filter = "h files (*.h)|*.h";
            openFileDialog1.FilterIndex = 1;
            openFileDialog1.RestoreDirectory = true;
            openFileDialog1.FileName = "";
            
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                //Get the path of specified file
                string filePath = openFileDialog1.FileName;

                //Allitems will have all #defines in choosen .h file
                cMarlinSettings AllItems=new cMarlinSettings();

                //LoadedEnumOptions will have only the integer #defines of AllItems
                //cMarlinSettings EnumOptions = new cMarlinSettings();
                LoadedEnumOptions.Clear();
                
                //Load #defines from .h and store in AllItems
                MarlingRWConfig.ReadConfig(AllItems, filePath);
                
                // Filter the integer #defines and store them in LoadedEnumOptions
                foreach (var key in AllItems.Keys)
                  if (AllItems[key] is Int32)
                    LoadedEnumOptions.Add(key, (Int32)AllItems[key]);
                FillListBoxLoadedOptions();

            }
        }

        private void CBDuplicatedOptions_CheckedChanged(object sender, EventArgs e)
        {
            /*DuplicatedOptions checkbox makes left listbox only show options loaded from .h
             * prone to merge with same options names but different asociated value in Left Listbox. 
             * by example in Left list box you have ZBoard 12 and in loaded values in right list box
             * you have  ZBoard 13, then ZBoard 13 will appears in Right ListBox.
             * But if you have ZBoard 12 at the left and ZBoard 12 at the right then
             * ZBoard will not appears because have same 12 value and is not necesary to be merged*/

            if ((CBDuplicatedOptions as CheckBox).Checked)
            {
                //LoadedEnumOptions.Clear();
                Dictionary<string, Int32> FilteredEnumOptions = new Dictionary<string, Int32>();
                LBLoadedEnumOptions.Items.Clear();
                foreach (var LeftKey in EnumOptions.Keys)
                    foreach (var RightKey in LoadedEnumOptions.Keys)
                        if ((LeftKey == RightKey) && (EnumOptions[LeftKey] != LoadedEnumOptions[LeftKey]))
                            FilteredEnumOptions.Add(LeftKey, LoadedEnumOptions[LeftKey]);
                LoadedEnumOptions.Clear();
                foreach (var key in FilteredEnumOptions.Keys)
                    LoadedEnumOptions.Add(key, FilteredEnumOptions[key]);
                FillListBoxLoadedOptions();
            }
            else
            {

            }     
        }
        private void FillListBoxEnumOptions(string SelItemName = "")
        {
            try
            {
                int i = 0;
                int SelItemIndex = -1;
                LBFinalEnumOptions.BeginUpdate();
                LBFinalEnumOptions.Items.Clear();
                foreach (var key in EnumOptions.Keys)
                {
                    LBFinalEnumOptions.Items.Add(key + " " + EnumOptions[key]);
                    if (key == SelItemName)
                        SelItemIndex = i;
                    i++;
                }
                //LBFinalEnumOptionsLastSel = -1;
                SelIndexChangedEnabled = false;
                LBFinalEnumOptions.SelectedIndex = SelItemIndex;
                LBFinalEnumOptions.EndUpdate();
                LBFinalEnumOptionsLastSel = LBFinalEnumOptions.SelectedIndex;
            }
            finally
            {
                SelIndexChangedEnabled = true;
            }
        }
        private void BtnRightEnumOptions_Click(object sender, EventArgs e)
        {
            foreach (var key in LoadedEnumOptions.Keys)
                EnumOptions[key] = LoadedEnumOptions[key];
            FillListBoxEnumOptions();

        }

        private void LBFinalEnumOptions_Click(object sender, EventArgs e)
        {
            
            //LBFinalEnumOptions.SelectedItems.Clear();
        }

        private void LBFinalEnumOptions_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (!SelIndexChangedEnabled) return;
                if (LBFinalEnumOptionsLastSel == LBFinalEnumOptions.SelectedIndex)
                { 
                    SelIndexChangedEnabled = false;
                    LBFinalEnumOptions.SelectedIndex = -1;
                }
                else
                {
                    TBNewEnumOptionName.Text = EnumOptions.ElementAt(LBFinalEnumOptions.SelectedIndex).Key;
                    TBNewEnumOptionVal.Text = EnumOptions.ElementAt(LBFinalEnumOptions.SelectedIndex).Value.ToString();
                }

                LBFinalEnumOptionsLastSel = LBFinalEnumOptions.SelectedIndex;
            }
            finally
            {
                SelIndexChangedEnabled = true;
            }

        }

        private void LBFinalEnumOptions_SelectedValueChanged(object sender, EventArgs e)
        {
            
            //SelectionChangedEventArgs eArgs = (SelectionChangedEventArgs)e;
        }

        private void btnAddEnumOption_Click(object sender, EventArgs e)
        {
            string EnumOptionName = TBNewEnumOptionName.Text.Trim();
            if (EnumOptionName == "")
            { 
                LblErrMsg.Text = "Option Name is empty";
                return;
            }
            int EnumOptionVal;
            if (int.TryParse(TBNewEnumOptionVal.Text, out EnumOptionVal))
            {
                EnumOptions[EnumOptionName] = EnumOptionVal;
                FillListBoxEnumOptions(EnumOptionName);
                
            }
            else
                LblErrMsg.Text = "Option value invalid";
        }
    }
}
