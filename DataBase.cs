using System;
using System.Collections.Specialized;
using System.Data.Common;
using System.Globalization;
using System.Reflection.Metadata.Ecma335;
using System.Xml.Linq;
using Microsoft.Data.Sqlite;
using System.Windows;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Тестовое_окно
{
    internal abstract class DataBase : IDataBase
    {

        private SqliteConnection _connection;
        private SqliteCommand _command;



        protected DataBase(string Connection, string table) : this(Connection) //connection - filename, table - tablename and rapametrs
        {
            _command.CommandText = table;
            _command.ExecuteNonQuery();
        }

        private DataBase(string Connection)
        {
            SqliteConnection connection = new SqliteConnection(Connection);
            connection.Open();
            SqliteCommand command = new SqliteCommand();
            command.Connection = connection;
            _connection = connection;
            _command = command;
        }

        protected DataBase(SqliteConnection connection, SqliteCommand command, string table)
        {
            _connection = connection;
            _command = command;
            _command.CommandText = table;
            _command.ExecuteNonQuery();
        }

        protected SqliteConnection GetConnection
        {
            get { return _connection; }
        }

        protected SqliteCommand GetCommand
        {
            get { return _command; }
        }

        protected string HashFunction(string x, string y)
        {
            int[] c = new int[x.Length > y.Length ? x.Length : y.Length];
            for (int i = 0; i < (x.Length > y.Length ? x.Length : y.Length); i++)
            {
                c[i] = (int)x[(i % x.Length) % 2 == 0 ? ((i % x.Length) / 2) % (x.Length - 1) : ((x.Length - 1) - (((i + 1) % x.Length) / 2)) % (x.Length - 1)]
                     ^ (int)y[(i % y.Length) % 2 != 0 ? ((i % y.Length) / 2) % (y.Length - 1) : ((y.Length - 1) - (((i + 1) % y.Length) / 2)) % (y.Length - 1)];
            }
            string output = "";
            for (int i = 0; i < c.Length; i++)
            {
                char timechar = Convert.ToChar(c[i]);
                output += Convert.ToString(c[i]);
            }
            string timeout = "";
            output = output.Length % 2 == 0 ? output : output + "0";
            for (int i = 0; i < output.Length; i += 2)
            {
                timeout += Char.ToString(Convert.ToChar(Convert.ToInt32(output[i] + output[i + 1])));
            }
            return timeout;
        }
    }
}

    

