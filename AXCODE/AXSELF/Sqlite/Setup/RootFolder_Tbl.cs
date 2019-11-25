namespace AXSELF
{
    class RootFolder_Tbl
    {
        public RootFolder_Tbl()
        {
            string q = QSQLite.CREATE(ROOTFOLDER.ROOTFOLDER_TBL);
            q += QSQLite.PRIMARY(ROOTFOLDER.ROOTFOLDER_ID);
            q += QSQLite.TEXT(ROOTFOLDER.ROOTFOLDER_NAME);
            q += QSQLite.TEXT(ROOTFOLDER.PATH);
            q += QSQLite.TEXT(ROOTFOLDER.NOTES);
            q += QSQLite.INTEGER(ROOTFOLDER.ACTIVE_ID);
            q += QSQLite.EOF;
            new SQLITE_DAL().Execute(q);
        }

    }
}
