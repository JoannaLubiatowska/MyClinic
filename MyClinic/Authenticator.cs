﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyClinic
{
    class Authenticator
    {
        #region Singleton instance invoker
        private static Authenticator instance;
        public static Authenticator Instance
        {
            get
            {
                return instance = instance ?? new Authenticator();
            }
        }
        #endregion

        private SqlConnection connection;
        private SqlDataAdapter adapter;

        private Authenticator()
        {
            connection = new SqlConnection("Data Source=ASIA-HP;Initial Catalog=Clinic;Persist Security Info=True;User ID=sa;Password=praktyka");
            adapter = new SqlDataAdapter();
        }

        public bool LoginForm(string login, string password)
        {
            DataTable temp = new DataTable();

            password = EncodeText(password);

            SqlCommand command = new SqlCommand("select * from ClinicEmployees where UserLogin = @login and UserPassword = @password", connection);
            adapter.SelectCommand = command;
            adapter.SelectCommand.Parameters.AddWithValue("@login", login);
            adapter.SelectCommand.Parameters.AddWithValue("@password", password);
            adapter.Fill(temp);
            adapter.Update(temp);

            return temp.Rows.Count != 0;
        }

        public void Logout()
        {

        }

        private string EncodeText(string value)
        {
            using (SHA256 hash = SHA256Managed.Create())
            {
                return String.Concat(hash
                  .ComputeHash(Encoding.UTF8.GetBytes(value))
                  .Select(item => item.ToString("x2")));
            }
        }
    }
}
