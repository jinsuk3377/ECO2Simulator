using System;
using System.Xml;
using System.IO;
using System.Text;

namespace ADR2013AppCS01
{
    public class XmlWriter
    {
        private const string filename = "C:\building.xml";
        private ECompositeViewer.IAdECompositeViewer CompositeViewer;
        private ECompositeViewer.IAdSection Section;
        private AxExpressViewerDll.AxCExpressViewerControl axCExpressViewerControl1;        // axCExpressViewerControl1 값이 null이다.

        public void XmlWrite()
        {
            ECompositeViewer.IAdECompositeViewer compvwr =
                    (ECompositeViewer.IAdECompositeViewer)axCExpressViewerControl1.ECompositeViewer;    // axCExpressViewerControl1 값이 null이기 때문에 값을 불러올 수 없다.

            ECompositeViewer.IAdSection sec = (ECompositeViewer.IAdSection)compvwr.Section;
            ECompositeViewer.IAdContent con = (ECompositeViewer.IAdContent)sec.Content;

            AdCommon.IAdCollection adobj = (AdCommon.IAdCollection)con.get_Objects(1); //for selected object
            AdCommon.IAdObject obj = (AdCommon.IAdObject)adobj[1];

            XmlTextWriter writer = new XmlTextWriter(filename, null);

            writer.Formatting = Formatting.Indented;

            writer.WriteStartDocument();
            
            //String PItext = "type='text/xsl' href='book.xsl'";
            //writer.WriteProcessingInstruction("xml-stylesheet", PItext);

            //writer.WriteDocType("wall", null, null, "<!ENTITY h 'hardcover'>");

            writer.WriteComment("XML");
            writer.WriteStartElement("wall");

            foreach (AdCommon.IAdProperty prop in (AdCommon.IAdCollection)obj.Properties)
            {
                writer.WriteStartElement("size");

                if (prop.Name.Contains("길이"))
                {

                    writer.WriteElementString("length",prop.Value);
                    //writer.WriteValue(prop.Value);
                }

                if (prop.Name.Contains("면적"))
                {
                    writer.WriteElementString("area", prop.Value);
                    //writer.WriteValue(prop.Value);
                }

                if (prop.Name.Contains("체적"))
                {
                    writer.WriteElementString("volumn", prop.Value);
                    //writer.WriteValue(prop.Value);
                }

                writer.WriteEndElement();
            }

            writer.WriteEndDocument();

            writer.Flush();
            writer.Close();

            XmlDocument doc = new XmlDocument();

            doc.PreserveWhitespace = true;

            doc.Load(filename);

            Console.Write(doc.InnerXml);
        }
    }
}
