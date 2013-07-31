
using log4net;

namespace Framework
{
    public class CVFactory {

        private static ILog logger = LogManager.GetLogger(typeof(CVFactory));

        public static void InsertFormation(CV cv)
        {
            Database.cvTable[cv.IntId] = cv;
            logger.Info("inserting CV :" + cv.ToString());
        }

        public static CV GetTableauBord(long intId) {
            return Database.cvTable[intId];
        }

    
    }
}