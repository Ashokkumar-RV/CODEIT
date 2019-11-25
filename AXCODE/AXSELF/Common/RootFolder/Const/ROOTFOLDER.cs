namespace AXSELF
{
    #region[Properties]

    public class Rootfolder
    {
        public string Rootfolder_id { get; set; }
        public string Rootfolder_name { get; set; }
        public string Path { get; set; }
        public string Notes { get; set; }
        public string Active_id { get; set; }
    }

    #endregion[Properties]

    #region[string Const]

    public class ROOTFOLDER
    {
        public const string ROOTFOLDER_ID = "ROOTFOLDER_ID";
        public const string ROOTFOLDER_NAME = "ROOTFOLDER_NAME";
        public const string PATH = "PATH";
        public const string NOTES = "NOTES";
        public const string ACTIVE_ID = "ACTIVE_ID";
        // 
        public const string ROOTFOLDER_TBL = "ROOTFOLDER_TBL";
    }

    #endregion[string Const]

}//ns
