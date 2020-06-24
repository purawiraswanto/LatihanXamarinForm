
using LatihanXamarinForm.Models;
using SQLite;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using Xamarin.Essentials;

namespace LatihanXamarinForm.DAL
{
    public class DataAccess
    {
        private SQLiteConnection conn;
                
        public DataAccess()
        {
            string dbName = "MyDb.db3";
            string dbPath = Path.Combine(FileSystem.AppDataDirectory, dbName);
            conn = new SQLiteConnection(dbPath);
            conn.CreateTable<Employee>();
        }
            
        public IEnumerable<Employee> GetAllEmployee()
        {
            //1. Cara biasa
            //return conn.Query<Employee>("select * from Employee order by EmpID asc");
            
            //2. Cara Pake LinQ (Lebih fleksibel, jika misal backend database berubah dari SQL ke Oracle, tidak perlu rubah syntax
            var results = from e in conn.Table<Employee>()
                          orderby e.EmpName
                          select e;

            //3. Cara pake Lambda
            //var results = conn.Table<Employee>().OrderBy(e => e.EmpName).ToList();

            return results.ToList();
        }

        public int InsertEmployee(Employee employee)
        {

            return conn.Insert(employee);
        }

        public int EditEmployee(Employee employee)
        {

            return conn.Update(employee);
        }

        public int DeleteEmployee(Employee employee)
        {

            return conn.Delete(employee);
        }
    }
}
