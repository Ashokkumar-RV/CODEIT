namespace AXSELF
{
    #region[Properties]

    public class Databases
    {
        public string Databases_id { get; set; }
        public string Databases_name { get; set; }
        public string Notes { get; set; }
        public string Active_id { get; set; }
    }

    #endregion[Properties]

    #region[string Const]

    public class DATABASES
    {
        public const string DATABASES_ID = "DATABASES_ID";
        public const string DATABASES_NAME = "DATABASES_NAME";
        public const string NOTES = "NOTES";
        public const string ACTIVE_ID = "ACTIVE_ID";
        // 
        public const string DATABASES_TBL = "DATABASES_TBL";
    }

    #endregion[string Const]

}//ns
