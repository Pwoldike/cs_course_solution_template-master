namespace Modul07
{
    internal class Terning
    {
        private int værdi;

        public int Værdi
        {
            get
            {
                return this.værdi;
            }
            set
            {
                if (value < 1 || value > 6)
                    value = 1;
                {

                }
                this.værdi = value;
            }
        }

        private bool snyd;

        public bool Snyd
        {
            get { return snyd; }
            //set { snyd = value; }
        }



    }
}
