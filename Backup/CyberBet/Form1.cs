using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Collections;
using System.IO;
namespace CyberBet
{
    public partial class Form1 : Form
    {
    #region Strings
        private string lt3 = "";
        private string pathldu = @"C:\Cyberbet\Football\footldu.txt";
        private ArrayList arl;
        private ArrayList arlGPEP;
        

        
        
		
		
    #endregion

        public Form1()
        {
            InitializeComponent();
        }

        //public void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
        //{
            
        //    string Eng = "England";
        //    string Pl = "Premier";
        //    if (treeView1.Nodes = Eng)
        //        tabControl2.TabPages[6].Select = CyberBet.Table.Ins_table.InsertGPengPL(Data, Com1, Com2, Goal1, Def, Goal2);
        //}

        private void commandsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Form2 obj = new Form2();
            //obj.Show();

        }

        private void menuStrip1_MouseLeave(object sender, EventArgs e)
        {

        }

        private void updateToolStripMenuItem_MouseLeave(object sender, EventArgs e)
        {
            updateToolStripMenuItem.ShowDropDown();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'cyberbaseDataSet.GPengPL' table. You can move, or remove it, as needed.
            this.gPengPLTableAdapter.Fill(this.cyberbaseDataSet.GPengPL);

            footballToolStripMenuItem_Click(this, null);
            timer1.Enabled = true;


        }
        
    

  

    #region footbToolStripMenuItem_Click
        
        public void footballToolStripMenuItem_Click(object sender, EventArgs e)
        {
            toolStripStatusLabel1.Text = "";
            arl = TextFromFile.streader();

            for (int i = 0; i < arl.Count; )
            {
                //Delete "" string in the Array arl 
                string tmp = (string)arl[i];
                if (tmp != "")
                    i++;
                else
                    arl.RemoveAt(i);
            }
            treeView1.Nodes.Clear();


            int x = 0;
            int z = 0;

            for (int i = 0; i < arl.Count; i++)
            {
               string tmp = (string)arl[i];

                switch (arl[i].ToString())
                {

                    case "Div 1":
                        if (tmp == "Div 1")
                            treeView1.Nodes[x].Nodes.Add(tmp);

                        z = z + 1;
                        break;
                    case "Div 2":
                        if (tmp == "Div 2")
                            treeView1.Nodes[x].Nodes.Add(tmp);
                        z = z + 1;
                        break;
                    case "Premier":
                        if (tmp == "Premier")
                            treeView1.Nodes[x].Nodes.Add(tmp);
                        z = z + 1;
                        break;
                    case "Ch-ship":
                        if (tmp == "Ch-ship")
                            treeView1.Nodes[x].Nodes.Add(tmp);
                        z = z + 1;
                        break;
                    case "Conf.":
                        if (tmp == "Conf.")
                            treeView1.Nodes[x].Nodes.Add(tmp);
                        z = z + 1;
                        break;
                    case "National":
                        if (tmp == "National")
                            treeView1.Nodes[x].Nodes.Add(tmp);
                        z = z + 1;
                        break;
                    case "Div 3N":
                        if (tmp == "Div 3N")
                            treeView1.Nodes[x].Nodes.Add(tmp);
                        z = z + 1;
                        break;
                    case "Div 3S":
                        if (tmp == "Div 3S")
                            treeView1.Nodes[x].Nodes.Add(tmp);
                        z = z + 1;
                        break;
                    case "Serie A":
                        if (tmp == "Serie A")
                            treeView1.Nodes[x].Nodes.Add(tmp);
                        z = z + 1;
                        break;
                    case "Serie B":
                        if (tmp == "Serie B")
                            treeView1.Nodes[x].Nodes.Add(tmp);
                        z = z + 1;
                        break;
                    case "Serie C1A":
                        if (tmp == "Serie C1A")
                            treeView1.Nodes[x].Nodes.Add(tmp);
                        z = z + 1;
                        break;
                    case "Serie C1B":
                        if (tmp == "Serie C1B")
                            treeView1.Nodes[x].Nodes.Add(tmp);
                        z = z + 1;
                        break;
                    case "Serie C2A":
                        if (tmp == "Serie C2A")
                            treeView1.Nodes[x].Nodes.Add(tmp);
                        z = z + 1;
                        break;
                    case "Serie C2B":
                        if (tmp == "Serie C2B")
                            treeView1.Nodes[x].Nodes.Add(tmp);
                        z = z + 1;
                        break;
                    case "Serie C2C":
                        if (tmp == "Serie C2C")
                            treeView1.Nodes[x].Nodes.Add(tmp);
                        z = z + 1;
                        break;
                    case "Div B1":
                        if (tmp == "Div B1")
                            treeView1.Nodes[x].Nodes.Add(tmp);
                        z = z + 1;
                        break;
                    case "Div B2":
                        if (tmp == "Div B2")
                            treeView1.Nodes[x].Nodes.Add(tmp);
                        z = z + 1;
                        break;
                    case "Div 3":
                        if (tmp == "Div 3")
                            treeView1.Nodes[x].Nodes.Add(tmp);
                        z = z + 1;
                        break;

                    default:
                        treeView1.Nodes.Add(tmp);
                        break;
                }
                x = i - z;
            }
            label3.Text = File.ReadAllText(pathldu);
        }
               
        private void timer1_Tick(object sender, EventArgs e)
        {
            label1.Text = DateTime.Now.ToString();
        }

        private void europeansLeaguesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            toolStripStatusLabel1.Text = "Wait, an update goes... ";
            this.Refresh();
            footballToolStripMenuItem_Click(this, null);
            toolStripStatusLabel1.Text = "";
            this.Refresh();
            label3.Text = "Last Update " + DateTime.Now.ToShortDateString();
            lt3 = label3.Text.ToString();
            File.WriteAllText(pathldu, lt3);
        }
        
        
        private void rezultsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            arlGPEP = TextFromFile.streaderGPEP();

            for (int i = 0; i < arl.Count; )
            {
                //Delete "" string in the Array arl 
                string tmp = (string)arl[i];
                if (tmp != "")
                    i++;
                else
                    arlGPEP.RemoveAt(i);
            }



        }

    #endregion

        private void fillByToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.gPengPLTableAdapter.FillBy(this.cyberbaseDataSet.GPengPL);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void fillByToolStripButton1_Click(object sender, EventArgs e)
        {
            try
            {
                this.gPengPLTableAdapter.FillBy(this.cyberbaseDataSet.GPengPL);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }
         

        private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {
           
            if (treeView1.SelectedNode.Parent == null) return;
               string tnd = treeView1.SelectedNode.Parent.Text;
               
            //if ((tabControl2.SelectedIndex == 3 && treeView1.SelectedNode.Index == 0) && tnd == "England")
            //       dataGridView1.Visible = true;
            //   CyberBet.Table.Ins_table.SelectGPengPL("Gpengpl");

               if ((treeView1.SelectedNode.Index == 0 && tnd == "England")&& tabControl2.SelectedIndex == 3)
                       dataGridView1.Visible = true;
                   CyberBet.Table.Ins_table.SelectGPengPL("Gpengpl");
               
                     
        }      


    }


}