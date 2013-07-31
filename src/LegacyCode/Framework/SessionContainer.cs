namespace Framework
{
    public class SessionContainer {

        private Internaute internaute;

        public SessionContainer() {
            this.internaute = new Internaute();
        }

        public Internaute Internaute {
            get
            {
                return internaute;
            }
            
        }
    }
}
