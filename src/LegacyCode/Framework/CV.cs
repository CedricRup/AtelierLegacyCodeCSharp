
namespace Framework
{
    public class CV {

        private long intId;
        private long nivCode;
        private int cuvPourcentFormation;

        public CV() {
        }

        public void SetCuvPourcentFormation(int @decimal)
        {
            cuvPourcentFormation = @decimal;
        }


        public int GetCuvPourcentFormation()
        {
            return cuvPourcentFormation;
        }


        public long IntId 
        {
            get
            {
                return intId;    
            }
            set
            {
                this.intId = value;    
            }
        }

        public long NivCode
        {
            get
            {
                return nivCode;    
            }
            set
            {
                this.nivCode = value;    
            }
        }
    }
}