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

        public void yazdirma()
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

        DataGridViewRow row = (DataGridViewRow)dataGridView1.Rows[0].Clone();
        row.Cells[0].Value = bolge;
                    row.Cells[1].Value = durum;
                    row.Cells[2].Value = link;
                    dataGridView1.Rows.Add(row);
                }
}

    public void btnxmlyazdır_Click(object sender, EventArgs e)
        {
            yazdirma();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            timer1.Interval = 3600;
            yazdirma();
        }
    }   
}
            

