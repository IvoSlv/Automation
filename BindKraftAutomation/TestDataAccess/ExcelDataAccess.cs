using Dapper;
using System.Configuration;
using System.Data.OleDb;
using System.Linq;

namespace BindKraftAutomation.TestDataAccess
{
    class ExcelDataAccess
    {
        //var userData = ExcelDataAccess.GetTestData(LogInTest);
        //Email.SendKeys(userData.Username);
        //Password.SendKeys(userData.Password);
        public static string TestDataFileConnection()
        {
            var fileName = ConfigurationManager.AppSettings["C:\\Users\\islavchev\\source\\repos\\Automation\\BindKraftAutomation\\TestDataAccess\\TestData.xlsx"];
            var con = string.Format(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source = {0}; Extended Properties=Excel 12.0;", fileName);
            return con;
        }

        public static UserData GetTestData(string keyName)
        {
            using (var connection = new OleDbConnection(TestDataFileConnection()))
            {
                connection.Open();
                var query = string.Format("select * from [DataSet$] where key='{0}'", keyName);
                var value = connection.Query<UserData>(query).FirstOrDefault();
                connection.Close();
                return value;
            }
        }
    }
}
