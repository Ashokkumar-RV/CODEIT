namespace AXSELF
{
    class Databases_Tbl
    {
        public Databases_Tbl()
        {
            string q = QSQLite.CREATE(DATABASES.DATABASES_TBL);
            q += QSQLite.PRIMARY(DATABASES.DATABASES_ID);
            q += QSQLite.TEXT(DATABASES.DATABASES_NAME);
            q += QSQLite.TEXT(DATABASES.NOTES);
            q += QSQLite.INTEGER(DATABASES.ACTIVE_ID);
            q += QSQLite.EOF;
            new SQLITE_DAL().Execute(q);
        }

    }
}
