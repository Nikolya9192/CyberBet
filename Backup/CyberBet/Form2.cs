using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Collections;
using System.Web;
using System.Net;
using System.Data.OleDb;


namespace CyberBet
{

    public partial class Form2 : Form
    {
        //private string Data;
        //public string Com1;
        //public string Com2;
        //public string Goal1;
        //public string Def;
        //public string Goal2;

        public Form2()
        {
            InitializeComponent();
        }
    }
    public class TextFromFile
    {
        //private const string FILE_NAME = @"D:\Sport\kiberbet\1.txt";
        //public string pathTEP = @"D:\Sport\kiberbet\england\tableEng-Premier.txt";

       

        public static string Razbor(string str)
        {
            string sl = @"<";
            string sr = @".htm";
            int x = str.IndexOf(sr);
            int y = x + 6;
            string s1;
            int y2;
            string s2;
            if (x > 0)
            {
                s1 = str.Substring(y);
                y2 = s1.IndexOf(sl);
                s2 = s1.Substring(0, y2);
                return s2;
            }
            return "";
        }

        public static ArrayList streader()
        {
            ////создаем объект запроса
            //WebRequest req = WebRequest.Create(@"http://www.sportskeeping.com/online/leagues/England-Premier/table/England-Premier.htm");
            ////получаем ответ и используем его
            //WebResponse resp = req.GetResponse();
            //Stream stream = resp.GetResponseStream();
            //StreamReader srw = new StreamReader(stream);
            //string s = srw.ReadToEnd();
            ////запись в файл
            string pathTEP = @"C:\Cyberbet\Football\england\tableEng-Premier.txt";
            //File.WriteAllText(pathTEP, s);
            //string pathTEP2 = @"C:\Cyberbet\Football\england\tableEng-Premier.txt";
            ArrayList al = new ArrayList();
            using (StreamReader sr = File.OpenText(pathTEP))
            {

                string input;
                while ((input = sr.ReadLine()) != null)
                {

                    string tmp = Razbor(input);
                    al.Add(tmp);

                    // Create an instance of StringReader and attach it to the string.                    
                    StringReader stread = new StringReader(input);
                    stread.ReadToEnd();
                    // Close the StringReader.                    
                    stread.Close();
                }
                sr.Close();
            }
            return al;

        }
        //class ConnMDB
        //{
        //    string MyConn = @"Provider= Microsoft.Jet.OLEDB.4.0; Data Source=D:\Sport\Kiberbet\kiberbase.mdb";
        //    DataColumn El = new DataColumn("Country");
        //}

        class prog
        {
            
            public static void Main()
            {
                TextFromFile.streader();

            }
        }
       


        public static string RazborGPEP(string str)
        {
           
            //змінні (вирізаємо дату)
            string sl = @"<";
            string sr = @"<td>";
            string amp = @"&";
            int x = str.IndexOf(sr);
            int y = x + 4;            
            int ns = str.IndexOf(amp);
            int z = str.LastIndexOf(sl);

            //int sns = y + 1;
            //string sns = ns.ToString();
            string s1;
            int y2;

            string Data;
            
            //змінні (вирізаємо команду 1)
            string sc1 = @"0>";
            string sc2 = @"</";
            int xc = str.IndexOf(sc1);
            int yc = xc + 2;
            
            string c1;
            string Com1;

            //змінні (вирізаємо команду 2)
            string sk1 = @"0>";
            string sk2 = @"</";
            int y3;
            string k;
            string k1;
            string Com2;

            //змінні (вирізаємо рахунок команди 1)
            string Def = @"-";
            string dk1 = @"0>";
            string dk2 = @"-";
            int y4;
            string kd;
            string kd1;
            string Goal1;
            
            //змінні (вирізаємо рахунок команди 2)            
            string Goal2;

            if (x > 0 && ns != y && z != y && x != z)
            {
                //вирізаємо дату
                s1 = str.Substring(y);
                y2 = s1.IndexOf(sl);
                Data = s1.Substring(0, y2);

                //вирізаємо команду 1
                c1 = str.Substring(yc);
                y2 = c1.IndexOf(sc2);
                y3 = c1.LastIndexOf(sk2);
                Com1 = c1.Substring(0, y2);
                
                //вирізаємо команду 2    
                k = c1.Substring(0, y3);
                int xn = k.IndexOf(sk1);
                int yn = xn + 2;
                k1 = k.Substring(yn);
                y2 = k1.IndexOf(sk2);
                y4 = k1.LastIndexOf(sk2);
                Com2 = k1.Substring(0, y2);
                
                //вирізаємо рахунок команди 1
                kd = k1.Substring(0, y4);
                int xd = kd.IndexOf(dk1);
                int yd = xd + 2;
                kd1 = kd.Substring(yd);
                y2 = kd1.IndexOf(dk2);
                Goal1 = kd1.Substring(0, y2);
                
                //string Def = @"-";
               
                //вирізаємо рахунок команди 2
                int xv = kd1.IndexOf(dk2);
                int yv = xv + 1;
                Goal2 = kd1.Substring(yv);
                CyberBet.Table.Ins_table.InsertGPengPL(Data, Com1, Com2, Goal1, Def, Goal2);          
                //return data;
                
                //return com1;
                ////CyberBet.Table.Ins_table.InsertGPendPL(com1);
                //return com2;
                ////CyberBet.Table.Ins_table.InsertGPendPL(com2);
                //return goal1;
                ////CyberBet.Table.Ins_table.InsertGPendPL(goal1);
                //return goal2;
                //CyberBet.Table.Ins_table.InsertGPendPL(goal2);
                
            }
            
            return "";
            
        }
        
        public static ArrayList streaderGPEP()
        {
            // Сохраняем в файл данные

            ////создаем объект запроса
            //WebRequest req = WebRequest.Create(@"http://www.sportskeeping.com/online/leagues/England-Premier/gamesplayed/England-Premier.htm");
            ////получаем ответ и используем его
            //WebResponse resp = req.GetResponse();
            //Stream stream = resp.GetResponseStream();
            //StreamReader srw = new StreamReader(stream);
            //string s = srw.ReadToEnd();
            ////запись в файл
            //string pathGPEP = @"C:\Cyberbet\Football\england\GPEng-Premier.txt";
            //File.WriteAllText(pathGPEP, s);
            string pathTEP2 = @"C:\Cyberbet\Football\england\tableeng-Prem.txt";
            ArrayList al = new ArrayList();
            using (StreamReader sr = File.OpenText(pathTEP2))
            {

                string input;
                while ((input = sr.ReadLine()) != null)
                {

                    string tmp = RazborGPEP(input);                   
                    al.Add(tmp);

                    // Create an instance of StringReader and attach it to the string.                    
                    StringReader stread = new StringReader(input);
                    stread.ReadToEnd();
                    // Close the StringReader.                    
                    stread.Close();
                }
                sr.Close();
            }
            return al;

        }



    }


}