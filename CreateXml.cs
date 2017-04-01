using AxExpressViewerDll;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Xml;

namespace ADR2013AppCS01
{
    public class CreateXml
    {
        //private ECompositeViewer.IAdECompositeViewer CompositeViewer;
        //private ECompositeViewer.IAdSection Section;
        //private AxExpressViewerDll.AxCExpressViewerControl axCExpressViewerControl1;

        public void xmlCreate(AxCExpressViewerControl axCExpressViewerControl1)
        {
  

            XmlTextWriter writer = new XmlTextWriter("BuildingSample.xml", System.Text.Encoding.UTF8);


           // MessageBox.Show("에러 검출 1 ");


            writer.WriteStartDocument(true);
            writer.Formatting = Formatting.Indented;
            writer.Indentation = 2;
            writer.WriteStartElement("wall");
            writer.WriteStartElement("size");

            ECompositeViewer.IAdECompositeViewer compvwr =
                    (ECompositeViewer.IAdECompositeViewer)axCExpressViewerControl1.ECompositeViewer;

            ECompositeViewer.IAdSection sec = (ECompositeViewer.IAdSection)compvwr.Section;
            ECompositeViewer.IAdContent con = (ECompositeViewer.IAdContent)sec.Content;

            AdCommon.IAdCollection adobj = (AdCommon.IAdCollection)con.get_Objects(1); 
            AdCommon.IAdObject obj = (AdCommon.IAdObject)adobj[1];

           // MessageBox.Show("에러 검출 2");

            foreach (AdCommon.IAdProperty prop in (AdCommon.IAdCollection)obj.Properties)
            {
               // MessageBox.Show("에러 검출 3");
                if (prop.Name.Contains("길이"))
                {
                    createLength(prop, writer);
                }

                if (prop.Name.Contains("면적"))
                {
                    createArea(prop, writer);
                }

                if (prop.Name.Contains("체적"))
                {
                    createVolumn(prop, writer);
                }
            }

            writer.WriteEndElement();
            writer.WriteEndDocument();
            writer.Close();
            MessageBox.Show("XML File is created by Jk!!! ");
        }

        private void createLength(AdCommon.IAdProperty length, XmlTextWriter writer)
        {
            writer.WriteStartElement("Length");
            writer.WriteString(length.Value);
            writer.WriteEndElement();
        }

        private void createArea(AdCommon.IAdProperty area, XmlTextWriter writer)
        {
            writer.WriteStartElement("area");
            writer.WriteString(area.Value);
            writer.WriteEndElement();
        }

        private void createVolumn(AdCommon.IAdProperty volumn, XmlTextWriter writer)
        {
            writer.WriteStartElement("volumn");
            writer.WriteString(volumn.Value);
            writer.WriteEndElement();
        }
    }
}
