using System.Xml;
using System.Windows.Forms;
using System.Collections.Generic;
using System;

namespace Parser
{

    public class W2dParser
    {

        public void Parsing(string file)
        {
            try
            {
                var size = new List<List<string>>();

                XmlDocument xml = new XmlDocument();
                xml.LoadXml(file);
                XmlNodeList list1 = xml.GetElementsByTagName("wall");       // 벽
                                                                            //XmlNodeList list2 = xml.GetElementsByTagName("Basic wall"); // 기본 벽
                this.listbox = new ListBox();                                                         //XmlNodeList list3 = xml.GetElementsByTagName("size");       // 치수

                foreach (XmlNode node in list1)
                {
                    List<string> add = new List<string>();
                    add.Add(node["Basic wall"].InnerText);                  // 벽에 대한 하위 element <Basic wall> </Basic wall>      - 기본 벽
                    add.Add(node["size"].InnerText);                        // Basic wall에 대한 하위 element size <size> </size>     - 치수
                    add.Add(node["size"]["length"].InnerText);              // 치수에 대한 하위 element 와 치수의 하위 element length <size> <length> </length>  - 치수, 길이
                    add.Add(node["size"]["area"].InnerText);                // 치수의 하위 element area <area> </area>           - 치수, 넓이
                    add.Add(node["size"]["volumn"].InnerText);              // 치수의 하위 element volumn <volumn> </volumn>     - 치수, 체적

                    size.Add(add);
                }

                listbox.BeginUpdate();

                foreach (var row in size)
                {
                    var wall = new ListViewItem(listbox.Items.Count.ToString());
                    wall.SubItems.AddRange(row.ToArray());
                    listbox.Items.Add(wall);
                }

                listbox.EndUpdate();
            }
            catch(System.Exception e)
            {
                Console.WriteLine("Error Message : {0}",e.Message);
            }
        }

        private System.Windows.Forms.ListBox listbox;
    }
}