using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace ExecutiveSceinceAccadmy.classes
{
    internal class Db
    {
        //this  class is for the database connection and queries
        // make it a singleton class
        private string connectionString;
        private static Db instance;
        private Db()
        {
            //initialize the database connection here
        }
        public static Db Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new Db();
                }
                return instance;
            }
        }
        public static void Init()
        {
            //initialize the database connection here

        }
        public void ExecuteQuery(string query)
        {
            //execute the query here
        }
        public void CloseConnection()
        {
            //close the database connection here
        }
        public void Dispose()
        {
            //dispose the database connection here

        }
        public void OpenConnection()
        {
            //open the database connection here
        }
        public void Close()
        {
            //close the database connection here

        }
        public string getConnectionString()
        {
            //return the connection string here
            return "your connection string here";
        }
        public void setConnectionString(string connectionString)
        {
            //set the connection string here
        }
        public void ExecuteNonQuery(string query)
        {
            //execute a non-query here
        }
        public string ExecuteScalar(string query)
        {
            //execute a scalar query here
            return "result of scalar query here";
        }
    }

}

