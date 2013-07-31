
using System.Collections.Generic;

namespace Framework
{
    public class Database {

        public static Dictionary<long, Formation> formationTable = new Dictionary<long, Formation>();
        public static Dictionary<long, CV> cvTable = new Dictionary<long, CV>();
	
        static Database()
        {
            CV initialCV = new CV();
            initialCV.IntId = 1L;
            initialCV.SetCuvPourcentFormation(0);
            initialCV.NivCode = 2L;
            cvTable.Add(1L, initialCV);
        }
    }
}
