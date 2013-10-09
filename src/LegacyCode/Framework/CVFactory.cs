
using log4net;

namespace Framework
{
    public class CVFactory {

        private static ILog logger = LogManager.GetLogger(typeof(CVFactory));

        public void InsertFormation(CV cv)
        {
            Database.cvTable[cv.IntId] = cv;
            logger.Info("inserting CV :" + cv.ToString());
        }

        public CV GetTableauBord(long intId) {
            return Database.cvTable[intId];
        }

    
    }
}