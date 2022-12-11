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
    internal class MasterDataBase : DataBase, IMasterDataBase
    {

        public MasterDataBase() : base("Data Source=usersdata.db", "CREATE TABLE IF NOT EXISTS Users (_id INTEGER NOT NULL PRIMARY KEY AUTOINCREMENT UNIQUE, Name TEXT NOT NULL, PasswordHesh TEXT NOT NULL)")
        {

        }



        private SlaveDataBase TurnToSlave(string username, string password) //Создание новой ведомой таблицы
        {
            string heshpassword;
            heshpassword = (string)base.HashFunction(username, password);
            using (SqliteCommand cmd = new SqliteCommand($"SELECT * FROM Users WHERE Name = '{username}' AND PasswordHesh = '{heshpassword}';", GetConnection))
            {
                SqliteDataReader reader = cmd.ExecuteReader();
                if (reader.HasRows)
                {
                    return null;
                }
            }
            string command = $"INSERT INTO Users (Name, PasswordHesh) VALUES ('{username}', '{heshpassword}')";
            GetCommand.CommandText = command;
            try
            {
                GetCommand.ExecuteNonQuery(); //Сохраняем строчку оригинального имени и хеш пароля
                username = base.HashFunction(username, heshpassword);
                return new SlaveDataBase(username, password, base.GetConnection, base.GetCommand);
            }
            catch { return null; }//Шифррованное название и шифрование таблицы через ключ-пароль
        }

        public void RemoveSlave(string username)
        {
            GetCommand.CommandText = $"DROP TABLE IF EXISTS {username};";
        }

        public ISlaveDataBase Login(string username, string password)
        {
            string heshpassword;
            heshpassword = (string)base.HashFunction(username, password);
            SqliteCommand cmd = new SqliteCommand($"SELECT * FROM Users WHERE Name = '{username}' AND PasswordHesh = '{heshpassword};", GetConnection);
            SqliteDataReader reader = cmd.ExecuteReader();
            if (reader.HasRows)
            {
                username = base.HashFunction(username, heshpassword);
                return new SlaveDataBase(username, password, base.GetConnection, base.GetCommand);
            }
            else
            {
                return null;
            }
        }

        public ISlaveDataBase Registration(string login, string password)
        {
            return TurnToSlave(login, password);
        }




        private class SlaveDataBase : DataBase, ISlaveDataBase
        {
            string _password;
            string _heshusername;
            public SlaveDataBase(string user, string password, SqliteConnection connection, SqliteCommand command) : base(connection, command, $"CREATE TABLE IF NOT EXISTS User_{user} (_id INTEGER NOT NULL PRIMARY KEY AUTOINCREMENT UNIQUE, TextName TEXT UNIQUE NOT NULL, TextBody TEXT)")
            //Конструктор для новой таблицы
            {
                _heshusername = user;
                _password = password;
            }



            private string Encod(string word)
            {
                int[] StrByte = new int[word.Length];
                for (int i = 0; i < word.Length; i++)
                {
                    StrByte[i] = (int)word[i];
                }
                int[] PassByte = new int[_password.Length];
                for (int i = 0; i < PassByte.Length; i++)
                {
                    PassByte[i] = (int)_password[i];
                }
                char[] text = new char[StrByte.Length];
                for (int i = 0; StrByte.Length > i; i++)
                {
                    text[i] = (char)(StrByte[i] ^ PassByte[i % PassByte.Length]);
                }
                string str = "";
                foreach (char a in text)
                {
                    str += Char.ToString(a);
                }
                return str;
            }

            public string[] ProjectList()
            {
                SqliteCommand cmd = new SqliteCommand($"SELECT TextName FROM User_{_heshusername};", GetConnection);
                string[] str1 = new string[0];
                string[] str2 = new string[0];
                SqliteDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    str1 = new string[str1.Length + 1];
                    for (int i = 0; i < str2.Length; i++)
                    {
                        str1[i] = str2[i];
                    }
                    str1[^1] = reader.GetString(0);
                    str2 = str1;

                }
                reader.Close();
                return str1;
            }

            public string Data(string name) //Чтение данных из именованной строки
            {
                SqliteCommand cmd = new SqliteCommand($"SELECT * FROM User_{_heshusername} WHERE TextName = '{name}';", GetConnection);
                SqliteDataReader reader = cmd.ExecuteReader();
                reader.Read();
                return Encod(reader.GetString(2));
            }

            public void Data(string name, string data) //Запись в строку
            {
                GetCommand.CommandText = $"INSERT INTO User_{_heshusername} (TextName, TextBody) VALUES ('{name}', '{Encod(data)}')";
                try
                {
                    GetCommand.ExecuteNonQuery();
                }
                catch
                {
                    GetCommand.CommandText = $"UPDATE User_{_heshusername} SET TextBody = '{Encod(data)}' WHERE TextName = '{name}'";
                    GetCommand.ExecuteNonQuery();
                }
            }
        }
    }
}
