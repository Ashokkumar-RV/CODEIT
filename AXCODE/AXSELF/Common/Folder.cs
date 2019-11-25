using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AXSELF
{
    [TestClass]
    public class Folder
    {

        #region[Current Folder]

        public static string RootFolder()
        {
            string RootFolder = System.IO.Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().Location);

            var v = RootFolder.Replace(@"AXCODE\AXSELF\bin\Debug", "");

            return v;
        }

        [TestMethod]
        public void TestFolder()
        {

            System.Diagnostics.Debug.WriteLine(RootFolder());
        }

        #endregion[Current Folder]
    }
}
