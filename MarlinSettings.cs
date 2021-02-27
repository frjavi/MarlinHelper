using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Dynamic;
using System.Xml;
using System.Xml.Schema;
using System.Xml.Serialization;
using System.IO;

namespace WindowsFormsApp2
{

[XmlRoot("MarlingConfig")]
public class cMarlinSettings : Dictionary<string, object>,IXmlSerializable
    {
        public string Title;
/*        public XmlSerializer serializer;
        public void Save() {
            serializer = new XmlSerializer(typeof(cMarlinSettings));
            TextWriter textWriter = new StreamWriter(@"languages.xml");
            serializer.Serialize(textWriter, this);
            textWriter.Close();
        }*/
        public XmlSchema GetSchema() { return null; }

        public void ReadXml(XmlReader reader)
        {
            if (reader.IsEmptyElement) { return; }

            reader.Read();
            while (reader.NodeType != XmlNodeType.EndElement)
            {
                object key = reader.GetAttribute("Title");
                object value = reader.GetAttribute("Value");
                //this.Add((TKey)key, (TValue)value);
                this.Add((string)key, (string)value);
                reader.Read();
            }
        }

        public void WriteSettings(cMarlinSettings MSetting, XmlWriter writer){
          foreach (var key in MSetting.Keys){
            if (MSetting[key] is cMarlinSettings){ 
              writer.WriteStartElement("Setting");
              writer.WriteAttributeString("Title", (MSetting[key] as cMarlinSettings).Title);
              writer.WriteAttributeString("Type", "Group");
              WriteSettings((MSetting[key] as cMarlinSettings), writer);
              writer.WriteEndElement();
            }
            else {  
              writer.WriteStartElement("Setting");
              writer.WriteAttributeString("Title", key.ToString());
              string EntryTypeStr = MSetting[key].GetType().ToString();
              writer.WriteAttributeString("Type", EntryTypeStr);
              writer.WriteAttributeString("Value", MSetting[key].ToString());
              writer.WriteEndElement();
            }
          }
        }
        public void WriteXml(XmlWriter writer)
        {
            WriteSettings(this, writer);
            /*foreach (var key in this.Keys)
            {
                //if (key is cMarlinSettings)
                //  serializer.Serialize(writer, this[key] as cMarlinSettings);
                //else
                {
                    writer.WriteStartElement("Setting");
                    writer.WriteStartElement("Setting2");
                    writer.WriteAttributeString("Title", key.ToString());
                    writer.WriteAttributeString("Value", this[key].ToString());
                    writer.WriteEndElement();
                    writer.WriteEndElement();
                }
            }*/
        }
    }
    public static class MarlingRWConfig
    {
        static public void ReadConfig(cMarlinSettings MarlingSettings, string PathFile) {
            try
            {   //"D:\Marlin-2.0.7.2\Marlin\Configuration.h"
                // Create an instance of StreamReader to read from a file.
                // The using statement also closes the StreamReader.
                using (StreamReader sr = new StreamReader(PathFile))
                {
                    string DefineStr = "#define";
                    string[] DefineParams;
                    string line;
                    
                    // Read and display lines from the file until the end of
                    // the file is reached.
                    while ((line = sr.ReadLine()) != null)
                    {
                        bool LineComment = false;
                        line.Trim();
                        if (line.IndexOf("//") == 0)
                          LineComment = true;
                        int DefinePos = line.IndexOf("#define");
                        if (DefinePos > -1){ // #define was found
                          string DefineContentStr = line.Substring(DefinePos + DefineStr.Length + 1);
                          DefineParams = System.Text.RegularExpressions.Regex.Split(DefineContentStr, @"\s+");
                          int ParamCount = 0;
                          foreach (string Param in DefineParams)
                            if (Param.IndexOf("//") == 0)
                              break;
                            else
                              ParamCount++;
                            //DefineContentStr.Split(' ');
                            //if (DefineParams.Length == 1)
                          if (ParamCount == 1)
                            MarlingSettings.Add(DefineParams[0], !LineComment);
                          if (ParamCount == 2) {
                            Double ParamDouble;
                            Int32 ParamInt;
                            if (Int32.TryParse(DefineParams[1], out ParamInt))
                              MarlingSettings.Add(DefineParams[0], ParamInt);
                            else
                            if (double.TryParse(DefineParams[1], out ParamDouble))
                              MarlingSettings.Add(DefineParams[0], ParamDouble);
                            else
                              MarlingSettings.Add(DefineParams[0], DefineParams[1]);
                          }
                        }   
                                
                        Console.WriteLine(line);
                    }
                }
            }
            catch (Exception e)
            {
                // Let the user know what went wrong.
                Console.WriteLine("The file could not be read:");
                Console.WriteLine(e.Message);
            }
        }
    }
}