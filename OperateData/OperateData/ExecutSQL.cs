using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Data;
using System.Data.SQLite;

namespace OperateData
{
    public class ExecutSQL
    {
        static string conStr = "Data Source=database\\WMS;Version=3";
        static SQLiteConnection sqlitCon=new SQLiteConnection(conStr);
        static SQLiteCommand sqlitCom = new SQLiteCommand(sqlitCon);

        public static void CreateDatabse()
        {
            try
            {
                string rootPath = System.Environment.CurrentDirectory + "\\database";
                if(File.Exists(rootPath+"\\WMS.sqlite")==false)
                {
                    SQLiteConnection.CreateFile(rootPath + "\\WMS.sqlite");
                }
            }
            catch(Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }
            finally
            {

            }
        }

        public static SQLiteDataAdapter SelectData(object[] obj,string sqlStr)
        {
            sqlitCom.CommandText = sqlStr;
            SQLiteDataAdapter sQLiteDataAdapter = new SQLiteDataAdapter(sqlitCom);
            return sQLiteDataAdapter;

        }

        public static int ExecuteSQL(object[] obj,string sqlStr)
        {
            sqlitCom.CommandText = sqlStr;
            int result=sqlitCom.ExecuteNonQuery();
            return result;
        }

        public static SQLiteDataReader GetUserInfo(string userCode)
        {
            string sqlstr = "select id,name,password from employee t where t.code='" + userCode+"'";
            sqlitCom.CommandText = sqlstr;
            SQLiteDataReader userInfo = sqlitCom.ExecuteReader();
            return userInfo;
        }
    }
}
