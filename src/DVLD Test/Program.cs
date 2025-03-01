using DataAccessLayer;
using BusinessLayer;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Net;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using DVLDWindowsFormsApp;
using System.Reflection;
using System.ComponentModel;

namespace DVLD_Test
{
    class Program
    {
        static void Main()
        {
            clsLocalDrivingLicenseApplication _App = clsLocalDrivingLicenseApplication.Find(2047);

            Console.WriteLine(_App.GeneralAppID);
            Console.ReadLine();
        }
    }
}