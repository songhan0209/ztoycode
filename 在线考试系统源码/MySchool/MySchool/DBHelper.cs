using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Runtime.CompilerServices;
using System.Text;
using  System.Configuration;

namespace MySchool
{
   public   class DBHelper
   {
       public static readonly String conString = "SERVER=.;DATABASE=MySchool;PWD=123;UID=sa;";
       public static SqlConnection getCon()
       {
           SqlConnection con=new SqlConnection(conString);
           if (con.State != ConnectionState.Open)
           {
               con.Open();
           }
           return con;
       }
       public static void CloseCon(SqlConnection con)
       {
           if (con != null && con.State == ConnectionState.Open)
           {
               con.Close();
           }
       }
       public static SqlDataReader getReader(string sql)
       {
           SqlCommand cmd = new SqlCommand(sql,getCon());
           return cmd.ExecuteReader(CommandBehavior.CloseConnection);
       }
       public static DataTable getTable(string sql)
       {
           SqlCommand cmd=new SqlCommand(sql,getCon());
           SqlDataAdapter apt=new SqlDataAdapter(cmd);
           DataTable dt=new DataTable();
           apt.Fill(dt);
           return dt;
       }
       public static bool ExecuteNonQuery(string sql)
       {
           bool flag = false;
           using (SqlConnection con=new SqlConnection(conString))
           {
			   if(con.State==ConnectionState.Closed)
			   {
				   con.Open();
			   }
               try
               {
                   SqlCommand cmd = new SqlCommand(sql,con);
                   int rust = cmd.ExecuteNonQuery();
                   if (rust > 0)
                   {
                       flag = true;
                   }
               }
               catch
               {

                   ;
               }
               finally
               {
                   CloseCon(con);
               }
               return flag;

           }
       }

   }
}
