using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.OleDb;

namespace CyberBet
{
    class Conn
    {
        
        #region Static String & other members
        
        public static string pathmdb = @"C:\Cyberbet\cyberbase.mdb";
        public static string connectionStrACC = "";
        public static OleDbConnection connectionACC;
        



        #endregion

        #region Connect to MDB
        public static bool SetAccessDB(string Pathmdb)
        {
            
            //int i = Pathmdb.IndexOf("CYBERBASE.MDB") - 1;
            //if (i <= 0)
            //    return false;
            //pathDir = Pathmdb.Substring(0, i);
            //connectionStrACC = @"Jet OLEDB:Global Partial Bulk Ops=2;Jet OLEDB:Registry Pathmdb=;Jet OLEDB:Database Locking Mode=1;Jet OLEDB:Database Password=;Data Source=" + Pathmdb + @";Password=;Jet OLEDB:Engine Type=5;Jet OLEDB:Global Bulk Transactions=1;Provider=""Microsoft.Jet.OLEDB.4.0"";Jet OLEDB:System database=;Jet OLEDB:SFP=False;Extended Properties=;Mode=Share Deny None;Jet OLEDB:New Database Password=;Jet OLEDB:Create System Database=False;Jet OLEDB:Don't Copy Locale on Compact=False;Jet OLEDB:Compact Without Replica Repair=False;User ID=Admin;Jet OLEDB:Encrypt Database=False";

            connectionStrACC = @"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:\Cyberbet\cyberbase.mdb";
            connectionACC = new OleDbConnection(connectionStrACC);

            try
            {
                connectionACC.Open();
            }
            catch (Exception ex)
            {
                string tmp = ex.ToString();
                return false;
            }
            connectionACC.Close();
            return true;
        }
        
        #endregion
    }
}
