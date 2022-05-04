﻿using dcom.controllers.controllers_middleware;
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
        public static void SaveDatabase()
        {

            //// Update the database file
            //if (Controller_FileHandling.IsFileExisted(DatabaseVariables.PathOutputDatabase) == false)
            //{
            //    Console.WriteLine(DatabaseVariables.PathOutputDatabase);
            //    DatabaseVariables.WbOutputDatabase = Controller_ExcelHandling.CreateExcel(DatabaseVariables.PathOutputDatabase);
            //}

            // Open the database_template file
            DatabaseVariables.WbOutputDatabase = Controller_ExcelHandling.OpenExcel(DatabaseVariables.TemplatePath);

            // Select the first sheet to push all data
            DatabaseVariables.WsOutputDatabase = DatabaseVariables.WbOutputDatabase.Sheets[1];

            // Push data to the database
            FillCommonSettingDatabase(DatabaseVariables.WsOutputDatabase);

            //CreateTestcaseHeader(TestcaseVariables.WsOutputTestcase);
            //CreateTestcaseBodyHeader(TestcaseVariables.WsOutputTestcase);
            //CreateTestcaseBody(TestcaseVariables.WsOutputTestcase);

            // Save the database
            Controller_ExcelHandling.SaveExcel(DatabaseVariables.PathOutputDatabase, DatabaseVariables.WbOutputDatabase);

            // After Handling, close the testcase file
            Controller_ExcelHandling.CloseExcel(DatabaseVariables.PathOutputDatabase, DatabaseVariables.WbOutputDatabase);

        }

        public static void FillCommonSettingDatabase(Worksheet Ws)
        {
            DatabaseVariables.WsOutputDatabase
        }
    }
}
