namespace Singenton
{
    public class Singenton
    {
        private static Singenton intanciar = null;

        private Singenton()
        {
            
        }

        public static Singenton GetSingenton()
        {
            if(intanciar == null)
            {
                return new Singenton();
            }
            else
            {
                return intanciar;   
            }
        }


    }
}
