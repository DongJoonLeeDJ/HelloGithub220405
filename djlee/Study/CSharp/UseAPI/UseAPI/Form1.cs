using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace UseAPI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string serviceKey = "I35xhBVrKuRe7RbiQpN9NOkt%2B6JQT5Fd0fgCNDuB0dURcjnYRTmTeyrFaNHFDHVY%2FQ4etMclK24pY%2FdEMx2fGQ%3D%3D";
            string sidoCode = "230000";

            string url = $"https://apis.data.go.kr/B551182/pharmacyInfoService/getParmacyBasisList?serviceKey={serviceKey}&pageNo=1&numOfRows=10&sidoCd={sidoCode}";
            Console.WriteLine(url);

            XElement element = XElement.Load(url);
            List<DrugStore> drugStores = new List<DrugStore>();
            foreach(var item in element.Descendants("item"))
            {
                string yadmNm = item.Element("yadmNm").Value;
                string telno = item.Element("telno").Value;
                string addr = item.Element("addr").Value;
                DrugStore ds = new DrugStore();
                ds.addr = addr;
                ds.telno = telno;
                ds.yadmNm = yadmNm;
                drugStores.Add(ds);
            }
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = drugStores;

            dataGridView1.Columns[0].HeaderText = "약국명";
            dataGridView1.Columns["telno"].HeaderText = "연락처";
            dataGridView1.Columns["addr"].HeaderText = "주소";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //https://www.dhlottery.co.kr/common.do?method=getLottoNumber&drwNo=1000

            int count = 1000;
            List<Lotto> lottos = new List<Lotto>();

            while(true)
            {
                var json = new WebClient().DownloadString("https://www.dhlottery.co.kr/common.do?method=getLottoNumber&drwNo=" + count);
                count++;
                var jArray = JObject.Parse(json);
                if (jArray["returnValue"].ToString() == "fail")
                    break;
                Lotto l = new Lotto() { drwNo = jArray["drwNo"].ToString(), drwNoDate = jArray["drwNoDate"].ToString(),
                    drwtNo1 = jArray["drwtNo1"].ToString(),
                    drwtNo2 = jArray["drwtNo2"].ToString(),
                    drwtNo3 = jArray["drwtNo3"].ToString(),
                    drwtNo4 = jArray["drwtNo4"].ToString(),
                    drwtNo5 = jArray["drwtNo5"].ToString(),
                    drwtNo6 = jArray["drwtNo6"].ToString(),
                    bnusNo = jArray["bnusNo"].ToString()
                };
                lottos.Add(l);
            }
            dataGridView2.DataSource = null;
            dataGridView2.DataSource = lottos;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Hide(); //폼1을 감춘다.
            new Form2().ShowDialog(); //폼2를 띄운다.
            Close(); //폼2가 꺼지면 폼1도 종료되면서 이 프로그램 자체가 종료가 된다.
        }
    }
}
