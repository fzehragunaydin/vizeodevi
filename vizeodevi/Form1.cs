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
        string yoldurumubultenLink = "http://95.0.225.161/yolDurumWS/yolDurumuRss.aspx"; 
        public Form1()
        {
            InitializeComponent();
        }

        private void btnxmlyazdır_Click(object sender, EventArgs e)
        {
            XmlDocument veri = new XmlDocument();
           veri.Load(yoldurumubultenLink);
            XmlElement root = veri.DocumentElement;
            XmlNodeList nodes = root.SelectNodes("items");

            foreach (XmlNode node in nodes)
            {
                string konum = node["tittle"].InnerText;
                string aciklama = node["description"].InnerText;
                string site = node["link"].InnerText;

            }


        }
    }
}
