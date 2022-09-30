namespace CA220930
{
    public class Ember
    {
        private int _eletkor = 20;
        private string _igSzam;

        public int Eletkor
        {
            get
            {
                return _eletkor;
            }
            set
            {
                if (value < 0)
                    throw new Exception("az életkor nem lehet negatív");

                if (value > 120)
                    throw new Exception("túl magas érték életkorra");

                _eletkor = value;
            }
        }

        public string IgSzam 
        {
            get => _igSzam;
            private set => _igSzam = value;
        }

        public Ember(int eletkor, string igSzam)
        {
            Eletkor = eletkor;
            IgSzam = igSzam;
        }



        #region Setter and Getter Methods
        //public void SetEletkor(int eletkor)
        //{
        //    if (eletkor < 0)
        //        throw new Exception("az életkor nem lehet negatív!");

        //    else if (eletkor > 120)
        //        throw new Exception("az életkor túl magas!");

        //    this.eletkor = eletkor;
        //}

        //public int GetEletkor()
        //{
        //    return this.eletkor;
        //}
        #endregion
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Ember e = new Ember(20, "243546423");

            Console.WriteLine($"emberünk életkora: {e.Eletkor}");
            Console.WriteLine($"emberünk szigszáma: {e.IgSzam}");

            e.Eletkor++;

            // e.IgSzam = "00000000";
        }
    }
}