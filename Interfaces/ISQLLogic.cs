namespace ChecklistProject.Interfaces
{
    interface ISQLLogic
    {
        void SendMasterListToSQLServer();
        void ReadMasterListFromSQL();
    }
}
