using ChecklistProject.Objects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChecklistProject.Interfaces
{
    interface ISQLLogic
    {
        void SendMasterListToSQLServer();
        void ReadMasterListFromSQL();
    }
}
