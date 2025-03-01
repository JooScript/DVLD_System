using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DVLDWindowsFormsApp
{
    internal class clsUtil
    {
        static public bool CopyFile(string SourceFilePath, out string DestinationFilePath)
        {
            bool IsCopied = false;
            Guid guid = Guid.NewGuid();

            string FolderPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "DVLD-People-Images\\");

            DestinationFilePath = FolderPath + guid.ToString("N") + Path.GetExtension(SourceFilePath);

            try
            {
                File.Copy(SourceFilePath, DestinationFilePath, overwrite: true);
                IsCopied = true;
            }
            catch (Exception ex)
            {
                IsCopied = false;
                _ErrorLogger(ex, "CopyFile");
            }
            return IsCopied;
        }

        static public bool DeleteFile(string FilePath)
        {
            bool IsDeleted = false;

            try
            {
                if (File.Exists(FilePath))
                {
                    if (!_IsFileLocked(FilePath))
                    {
                        File.Delete(FilePath);
                        IsDeleted = true;
                    }
                    else
                    {
                        IsDeleted = false;
                    }
                }
                else
                {
                    IsDeleted = false;
                }
            }
            catch (IOException ex)
            {
                IsDeleted = false;
                _ErrorLogger(ex, "DeleteFile");
            }
            catch (Exception ex)
            {
                IsDeleted = false;
                _ErrorLogger(ex, "DeleteFile");
            }
            return IsDeleted;
        }

        static public void RememberUser(string UserName, string Password)
        {

            string FilePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Current User.txt");

            string[] Items = { UserName, Password };
            string Content = string.Join("*//##//*", Items);

            File.WriteAllText(FilePath, Content);
        }

        static public void GetUserRemembered(ref string UserName, ref string Password)
        {
            string FilePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Current User.txt");
            UserName = null;
            Password = null;
            if (File.Exists(FilePath))
            {
                string Content = File.ReadAllText(FilePath);
                string[] Words = Content.Split(new string[] { "*//##//*" }, StringSplitOptions.None);

                UserName = Words[0];
                Password = Words[1];
            }
        }

        static public string Default = "[?????]";

        static public int UserID = -1;

        private static void _ErrorLogger(Exception ex, string FunctionName)
        {
            string logFilePath = string.Empty;
            //logFilePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "error.log");
            logFilePath = Path.Combine("C:\\Users\\Yousef\\Desktop\\", "error.log");

            string ErrorMessage = $"[{DateTime.Now}] Error in {FunctionName} {Environment.NewLine}" +
                                    $"Message: {ex.Message}{Environment.NewLine}" +
                                    $"StackTrace: {ex.StackTrace}{Environment.NewLine}";
            File.AppendAllText(logFilePath, ErrorMessage);
        }

        static private bool _IsFileLocked(string FilePath)
        {
            try
            {
                using (FileStream Stream = new FileStream(FilePath, FileMode.Open, FileAccess.ReadWrite))
                {
                    return false;
                }
            }
            catch (IOException)
            {
                return true;
            }
        }
    }
}