using dcom.declaration;
using dcom.controllers.controllers_middleware;
using Microsoft.Office.Interop.Excel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dcom.models.models_databaseHandling.models_saveDatabase
{
    class Model_SaveCommonSettingDatabase
    {
        public static int[] startRowIndexDatabaseTable = DatabaseVariables.StartRowIndexDatabaseTables;
        public static int[] startColumnIndexDatabaseTable = DatabaseVariables.StartColumnIndexDatabaseTables;

        public static string sheetName = Controller_ServiceHandling.GetSheetNameOfService("0");

        public static List<string[]> ProjectInformation()
        {
            List<string[]> dataTable = new List<string[]>();
            string[] dataRow;
            // Definition worksheet
            DatabaseVariables.WsDatabase = DatabaseVariables.WbDatabase?.Sheets[sheetName];
            Worksheet ws = DatabaseVariables.WsDatabase;

            for (int rowIndex = startRowIndexDatabaseTable[8]; ws.Cells[rowIndex, startColumnIndexDatabaseTable[8]].Text != ""; rowIndex++)
            {
                dataRow = new string[]
                {
                    dcom.views.views_ToolBar.View_Setting.ProjectInformation.ElementAt(1)[1],

                    ws.Cells[rowIndex, startColumnIndexDatabaseTable[8]   ].Text,  // Project Information
                    ws.Cells[rowIndex, startColumnIndexDatabaseTable[8] + 1].Text, // Information
                };

                dataTable.Add(dataRow);
            }
            return dataTable;
        }

        public static List<string[]> DataPathInformation()
        {
            List<string[]> dataTable = new List<string[]>();
            string[] dataRow;
            // Definition worksheet
            DatabaseVariables.WsDatabase = DatabaseVariables.WbDatabase?.Sheets[sheetName];
            Worksheet ws = DatabaseVariables.WsDatabase;

            for (int rowIndex = startRowIndexDatabaseTable[9]; ws.Cells[rowIndex, startColumnIndexDatabaseTable[9]].Text != ""; rowIndex++)
            {
                dataRow = new string[]
                {
                    ws.Cells[rowIndex, startColumnIndexDatabaseTable[9]   ].Text,  // Data Path Information
                    ws.Cells[rowIndex, startColumnIndexDatabaseTable[9] + 1].Text, // Information
                };

                dataTable.Add(dataRow);
            }
            return dataTable;
        }

        public static List<string[]> SelectedServiceInformation()
        {
            List<string[]> dataTable = new List<string[]>();
            string[] dataRow;
            // Definition worksheet
            DatabaseVariables.WsDatabase = DatabaseVariables.WbDatabase?.Sheets[sheetName];
            Worksheet ws = DatabaseVariables.WsDatabase;

            for (int rowIndex = startRowIndexDatabaseTable[10]; ws.Cells[rowIndex, startColumnIndexDatabaseTable[10]].Text != ""; rowIndex++)
            {
                dataRow = new string[]
                {
                    ws.Cells[rowIndex, startColumnIndexDatabaseTable[10]   ].Text,  // Selected Service
                    ws.Cells[rowIndex, startColumnIndexDatabaseTable[10] + 1].Text, // Status
                };

                dataTable.Add(dataRow);
            }
            return dataTable;
        }
    }
}
