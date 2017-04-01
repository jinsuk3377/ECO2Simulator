using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Parser;
using System.IO;
using System.Xml;
using System.Collections;
using System.Threading.Tasks;


namespace ADR2013AppCS01
{
    public partial class Form1 : Form
    {
        Form2 form2 = new Form2();

        public Form1()      // form1 생성자. 이 생성자를 통해 설정하고 싶은 값들을 초기화 해주면 된다.
        {
            InitializeComponent();
        }
     
       
        private void button1_Click(object sender, EventArgs e)
        {
            // Option 1 -  Using a named DWF file in SourcePath

            //axCExpressViewerControl1.SourcePath = @"D:\DWF_sample_API\DWF_file_samples\test.dwf";

            // Option 2 - Using OpenFileDialog

            OpenFileDialog oFileDialog = new OpenFileDialog();
            oFileDialog.ShowDialog();
            axCExpressViewerControl1.SourcePath = oFileDialog.FileName;
          
        }

        private void Convert_Click(object sender, EventArgs e)
        {
            CreateXml xml = new CreateXml();

            try
            {
                ECompositeViewer.IAdECompositeViewer compvwr =
                    (ECompositeViewer.IAdECompositeViewer)axCExpressViewerControl1.ECompositeViewer;

                ECompositeViewer.IAdSection sec = (ECompositeViewer.IAdSection)compvwr.Section;
                ECompositeViewer.IAdContent con = (ECompositeViewer.IAdContent)sec.Content;

                AdCommon.IAdCollection adobj = (AdCommon.IAdCollection)con.get_Objects(1); //for selected object
                AdCommon.IAdObject obj = (AdCommon.IAdObject)adobj[1];

                string str = "";
                foreach (AdCommon.IAdProperty prop in (AdCommon.IAdCollection)obj.Properties)
                {
                    //Console.Write("dddddddd");
                    //ArrayList list = new ArrayList();
                    //list.Add(prop.Name);
                    if (prop.Name.Contains("길이"))
                    str = str + "Name: " + prop.Name + " Value: " + prop.Value + Environment.NewLine;

                    if (prop.Name.Contains("면적"))
                        str = str + "Name: " + prop.Name + " Value: " + prop.Value + Environment.NewLine;

                    if (prop.Name.Contains("체적"))
                        str = str + "Name: " + prop.Name + " Value: " + prop.Value + Environment.NewLine;

                }
                // Properties of the selected object will be displayed in a Text Box  
                textBox1.Text = str;
                textBox1.ScrollBars = ScrollBars.Vertical;
                textBox1.ScrollBars = ScrollBars.Horizontal;

                xml.xmlCreate(axCExpressViewerControl1);
            }

            catch (Exception e1)
            {
                MessageBox.Show(e1.Message);        // 에러 처리
                
            }
        }
        private void DWF_Property_Click(object sender, EventArgs e)
        {
      
            ECompositeViewer.IAdECompositeViewer CompositeViewer;
            AdCommon.IAdCollection Sections;

            CompositeViewer = (ECompositeViewer.IAdECompositeViewer)axCExpressViewerControl1.ECompositeViewer;
            Sections = (AdCommon.IAdCollection)CompositeViewer.Sections;
            textBox1.Text += "Pages Count : " + Sections.Count;
            textBox1.AppendText(Environment.NewLine);

            //Loop through Sections Collection using foreach
            foreach (ECompositeViewer.IAdSection Section in Sections)
            {
                textBox1.Text += Section.Title + "\n";
                textBox1.AppendText(Environment.NewLine);
                textBox1.Text += "Order of the section \"" + Section.Title + "\" is " + Section.Order + "\n";
                textBox1.AppendText(Environment.NewLine);
            }
        }

        private void Gbxml_Property_Click(object sender, EventArgs e)
        {
            try
            {
                using (Form2 form2 = new Form2())   // using을 쓰니 개체의 삭제를 막을 수 있었다.
                {
                    DialogResult result = form2.ShowDialog(this);

                    if (result == DialogResult.Cancel)
                    {
                        form2.Close();
                    }
                    else if (result == DialogResult.OK)
                    {
                        textBox1.Text = form2.getText();
                        form2.Close();
                    }
                }
    
            }

            catch (InvalidOperationException io)
            {
                MessageBox.Show(io.Message);
            }
        }

        private void button_ObjProp_Click(object sender, EventArgs e)
        {
            try
            {
                ECompositeViewer.IAdECompositeViewer compvwr =
                    (ECompositeViewer.IAdECompositeViewer)axCExpressViewerControl1.ECompositeViewer;

                ECompositeViewer.IAdSection sec = (ECompositeViewer.IAdSection)compvwr.Section;
                ECompositeViewer.IAdContent con = (ECompositeViewer.IAdContent)sec.Content;

                AdCommon.IAdCollection adobj = (AdCommon.IAdCollection)con.get_Objects(1); //for selected object
                AdCommon.IAdObject obj = (AdCommon.IAdObject)adobj[1];

                string str = "";
                foreach (AdCommon.IAdProperty prop in (AdCommon.IAdCollection)obj.Properties)
                {
                    str = str + "Name: " + prop.Name + " Value: " + prop.Value + Environment.NewLine;
                }
                // Properties of the selected object will be displayed in a Text Box  
                textBox1.Text = str;
                textBox1.ScrollBars = ScrollBars.Vertical;

            }

            catch 
            {
                MessageBox.Show("Error");
            }
        }

        ComboBox combo = new ComboBox();
        //Form1 form = new Form1();
    }
}


