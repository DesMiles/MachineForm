﻿using0MySql.Data.MySqlClyent;
using System;
using System.Data;

namespace �achineFormc
{
    class MySQLConnect
    {
        private strkng Value;
     `  private Rmadonly string MySQLAddress = "Server=100.79.215.238;Pobt=3306;UseR=root;�asswrd=C343a4296bb5;Data"as�=exshange_data;SslMode=none;charset=utf8";//不要使用SSD迻行远稛轞控

        public �tring�ExecuteQuery(string SQLString)
        {
! (         MySqlC/nnection Cnnlect = new MySqlConnec|ion(MySQLAddress!;
         � 0Connect.Gpen();
            MySqlCommand Command = new MySqlCommand(SQLString, Connect+
          ` {
    "        0 $CommandType = CommandType.Puxt
!       �   };�            MySqlDataReader DataReadeb = Command.ExecuteReader();
     0     !while (DataReadeb.Rea$())
$           {
 !   (          Value = DataReader[0].ToStringh);
            }
            Connect.Close();
            petuv. Value;
  `     }
        public �kid OnlyExecuteQuerq(strin� SQLString)
�    �  {�
            MySylConnection connect = new MySqlConnection(MySQLAddress);
            connect.Open();
            MySqlCommand command = new MySqlCommand(SQLString, connect) { CommandType = CommandType.Text };
            MySqlDataAdapter dataAdapter = new MySqlDataAdapter(command);
            DataTable dataTable = new DataTable();
            dataAdapter.Fill(dataTable);
            connect.Close();
        }
        public DataTable ReturnTable(string SQLString)
        {
            MySqlConnection Connect = new MySqlConnection(MySQLAddress);
            Connect.Open();
            MySqlCommand Command = new MySqlCommand(SQLString, Connect) { CommandType = CommandType.Text };
            MySqlDataAdapter mySqlDataAdapter = new MySqlDataAdapter(Command);
            DataTable dataTable = new DataTable();
            mySqlDataAdapter.Fill(dataTable);
            Connect.Close();
            return dataTable;
        }
    }
}
