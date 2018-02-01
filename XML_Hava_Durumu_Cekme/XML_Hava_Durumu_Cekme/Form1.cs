using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;

using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using System.Net;
namespace XML_Hava_Durumu_Cekme
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            string url = "https://www.mgm.gov.tr/FTPDATA/analiz/sonSOA.xml";
            WebClient wc = new WebClient();
            string XmlData = wc.DownloadString(url);
            XmlDocument xdoc = new XmlDocument();
            xdoc.LoadXml(XmlData);
            //---------------
            XmlNodeList sehirlerlistesi = xdoc.DocumentElement.SelectNodes("sehirler");
            foreach (XmlNode item in sehirlerlistesi)
            {
                try
                {
                    sehirler sehir = new sehirler()
                    {
                        Bolge = item.SelectSingleNode("Bolge").InnerText,
                        Peryot=item.SelectSingleNode("Peryot").InnerText,
                        ili=item.SelectSingleNode("ili").InnerText,
                        Durum=item.SelectSingleNode("Durum").InnerText
                    };
                }
                catch (Exception)
                {

                    continue;
                }
            }
        }

        private void btnhavadurumu_Click(object sender, EventArgs e)
        {
            string url = "https://www.mgm.gov.tr/FTPDATA/analiz/sonSOA.xml";
            WebClient wc = new WebClient();
            string XmlData = wc.DownloadString(url);
            XmlDocument xdoc = new XmlDocument();
            xdoc.LoadXml(XmlData);
            //---------------
            txtbolge.Text = xdoc.DocumentElement.ChildNodes[1].ChildNodes[0].InnerText;
            txtperyot.Text = xdoc.DocumentElement.ChildNodes[1].ChildNodes[1].InnerText;
            txtil.Text = xdoc.DocumentElement.ChildNodes[1].ChildNodes[2].InnerText;
            txtdurum.Text = xdoc.DocumentElement.ChildNodes[1].ChildNodes[4].InnerText;

            for (int i = 1; i < 6; i++)
            {
                comboBox1.Items.Add(xdoc.DocumentElement.ChildNodes[i].ChildNodes[0].InnerText);
            }
            
        }
    }

    public class sehirler
    {
        public string Bolge { get; set; }

        public string Peryot { get; set; }
        public string ili { get; set; }
        public string Durum { get; set; }
    }
}
