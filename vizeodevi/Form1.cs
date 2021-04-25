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

namespace vizeodevi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public void btnxmlyazdır_Click(object sender, EventArgs e)
        {

            {

                XmlDocument doc1 = new XmlDocument();
                doc1.Load("http://95.0.225.161/yolDurumWS/yolDurumuRss.aspx");
                XmlElement root = doc1.DocumentElement;
                XmlNodeList nodes = root.SelectNodes("channel/item");

                foreach (XmlNode node in nodes)
                {
                    string bolge = node["title"].InnerText;
                    string durum = node["description"].InnerText;
                    string link = node["link"].InnerText;

                    label1.Text = bolge;
                    label2.Text = durum;
                    label3.Text = link;
                }


        }   }


}   }
            

