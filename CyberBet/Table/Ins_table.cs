using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.OleDb;

namespace CyberBet.Table
{
    class Ins_table
    {
        public Ins_table()
		{

		}
        #region Insert
        public static void InsertGPengPL (string Data, string Com1, string Com2, string Goal1, string Def, string Goal2)
        {
           
            //string query = @"UPDATE GPengPL SET " +  
            //    "Data='" + Data + "', " +
            //    "Com1='" + Com1 + "', " +
            //    "Com2='" + Com2 + "', " +
            //    "Goal1=" + Goal1 + ", " + 
            //    "Def=" + Def + "'," +
            //    "Goal2=" + " ";

            //@"UPDATE TDBF SET " +
            //    "DataImport=" + DataImport + " " +
            //    "WHERE Id_DBF=" + ID +" ";

            string query = @"INSERT INTO GPengPL (Data, Com1, Com2, Goal1, Def, Goal2) Values ('" +
               Data + "','" +
               Com1 + "','" +
               Com2 + "'," +
               Goal1 + ",'" +
               Def + "'," +
               Goal2 + ")";
            bool tmp = Conn.SetAccessDB(Conn.pathmdb);
            OleDbCommand command = new OleDbCommand (query, Conn.connectionACC);
            //DataSet ds = new DataSet("cyberbase");
            
            Conn.connectionACC.Open();
             try
            {
                int i = command.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                string ggg = ex.Message;
            }
            Conn.connectionACC.Close();

        }

        #endregion

        #region select
        //public static void SelectGPengPL()
        //{
        //    string query = "SELECT * FROM GPengPL";
        //    bool tmp = Conn.SetAccessDB(Conn.pathmdb);
        //    OleDbCommand command = new OleDbCommand(query, Conn.connectionACC);
        //    Conn.connectionACC.Open();
        //    try
        //    {
        //        int i = command.ExecuteNonQuery();
        //    }
        //    catch (Exception ex)
        //    {
        //        string ggg = ex.Message;
        //    }
        //    Conn.connectionACC.Close();

        //}


        public static void SelectGPengPL(string engpl)
        {
                      
            string query = "SELECT * FROM " + engpl;
            bool tmp = Conn.SetAccessDB(Conn.pathmdb);
            OleDbCommand command = new OleDbCommand(query, Conn.connectionACC);
            Conn.connectionACC.Open();
            try
            {
                int i = command.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                string ggg = ex.Message;
            }
            Conn.connectionACC.Close();

        }

        #endregion

        internal static void SelectGPengPL()
        {
            throw new Exception("The method or operation is not implemented.");
        }
    }
}
