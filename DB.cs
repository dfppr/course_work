using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicTacToe
{
    internal class DB
    {
        private readonly string dataSource;
        public DB(string dataSource)
        {
            this.dataSource = dataSource;
        }
        public bool InitializeDatabase()
        {
            SQLiteConnection connect = new SQLiteConnection(dataSource);
            try
            {
                connect.Open();
                if (connect.State == ConnectionState.Open)
                {
                    SQLiteCommand command = connect.CreateCommand();
                    string sqlCommand = "DROP TABLE IF EXISTS users;"
                                + "CREATE TABLE users("
                                + "id INTEGER PRIMARY KEY AUTOINCREMENT, "
                                + "name TEXT, "
                                + "surname TEXT, "
                                + "login TEXT, "
                                + "password TEXT);";
                    command.CommandText = sqlCommand;
                    command.ExecuteNonQuery();
                }
            }
            catch
            {
                return false;
            }
            finally
            {
                connect.Dispose();
            }
            return true;
        }
        public int UserID()
        {
            SQLiteConnection connect = new SQLiteConnection(dataSource);
            try
            {
                connect.Open();
                if (connect.State == ConnectionState.Open)
                {
                    SQLiteCommand command = connect.CreateCommand();
                    string sqlCommand = "SELECT count(id) FROM users";
                    command.CommandText = sqlCommand;
                    return (int)command.ExecuteScalar();
                }
            }
            catch
            {
                return -1;
            }
            finally
            {
                connect.Dispose();
            }
            return -1;
        }
        public bool ValidUser(string username, string password)
        {
            SQLiteConnection connect = new SQLiteConnection(dataSource);
            try
            {
                connect.Open();
                if (connect.State == ConnectionState.Open)
                {
                    SQLiteCommand command = connect.CreateCommand();
                    command.CommandText = string.Format("SELECT surname, name, login, password"
                    + "FROM users"
                    + "where login = '{0}' AND"
                    + "password = '{1}'",
                   username, password);
                    var userCount = (int)command.ExecuteScalar();
                    return userCount > 0;
                }
            }
            catch
            {
                return false;
            }
            finally
            {
                connect.Dispose();
            }
            return false;
        }
    }
}
