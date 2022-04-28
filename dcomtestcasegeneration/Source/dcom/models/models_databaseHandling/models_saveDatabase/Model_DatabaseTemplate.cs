using dcom.controllers.controllers_middleware;
using dcom.declaration;
using Microsoft.Office.Interop.Excel;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dcom.models.models_databaseHandling.models_saveDatabase
{
    class Model_DatabaseTemplate
    {
        public static void ExportDatabase()
        {

            // Update the database file
            if (Controller_FileHandling.IsFileExisted(DatabaseVariables.PathOutputDatabase) == false)
            {
                Console.WriteLine(DatabaseVariables.PathOutputDatabase);
                DatabaseVariables.WbOutputDatabase = Controller_ExcelHandling.CreateExcel(DatabaseVariables.PathOutputDatabase);
            }
            // Open the testcase file
            DatabaseVariables.WbOutputDatabase = Controller_ExcelHandling.OpenExcel(TestcaseVariables.PathOutputTestcase);


        }
    }
}
