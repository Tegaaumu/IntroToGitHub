using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataLibrary.DataAccess;
using DataLibrary.Models;

namespace DataLibrary.BusinessLogis
{
    public static class EmpoyeeProcessor
    {
        public static int CreateEmployee(int employeeID, string firstname,
            string lastname, string emailAdress)
        {
            EployeeModel data = new EployeeModel
            {
                EmployeeID = employeeID,
                FirstName = firstname,
                LastName = lastname,
                EmailAdress = emailAdress
            };

            string sql = @"insert into dbo.Employees (EmployeeId, FirstName, LastName, EmailAdress) 
                            values (@EmployeeID, @FisrtName, @LastName, @EmailAdress)";

            return SQLDataAccess.SaveData(sql, data);
        }

            public static List<EployeeModel> LoadEmployees()
            {
                string sql = @"select Id, EmployeeId, FirstName, LastName, EmailAdress
                                from dbo.Employees;";

                return SQLDataAccess.LoadData<EployeeModel>(sql);
            }
    }
}
