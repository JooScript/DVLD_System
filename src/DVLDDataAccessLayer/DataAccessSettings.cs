using System;
using System.IO;

namespace DataAccessLayer
{
    public class clsDataAccessSettings
    {
        public static string ConnectionString = "Server=.; Database=DVLD; User Id=sa; Password=sa123456;";

        public static void ErrorLogger(Exception ex, string FunctionName)
        {
            string logFilePath = string.Empty;
            //logFilePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "error.log");
            logFilePath = Path.Combine("C:\\Users\\youse\\Desktop\\", "error.log");

            string ErrorMessage = $"[{DateTime.Now}] Error in {FunctionName} {Environment.NewLine}" +
                                    $"Message: {ex.Message}{Environment.NewLine}" +
                                    $"StackTrace: {ex.StackTrace}{Environment.NewLine}\n\n\n\n\n";
            File.AppendAllText(logFilePath, ErrorMessage);
        }

    }
}