using System;
using System.ComponentModel.Design;

namespace Sube1.EmlakciLib
{
    public abstract class Ev
    {
        public static int Evsayisi { get; private set; }

        public Ev()
        {
            Evsayisi++;
        }

        public Ev(int odasayisi, int katno, double alan, string semt = "Kızılay")
        {
            this.Odasayisi = odasayisi;
            this.Katno = katno;
            this.Semt = semt;
            this.Alan = alan;
            Evsayisi++;
        }

        public Ev(int odasayisi, int katno, double alan)
        {
            this.Odasayisi = odasayisi;
            this.Katno = katno;
            this.Semt = "Kızılay";
            this.Alan = alan;
            Evsayisi++;
        }


        private string semt;
        public string Buyukluk { get; private set; }

        
        public int Katno { get; set; }
    
        public string Semt { get => semt; set => semt = value.ToUpper(); }

        private int odasayisi;   
        public int Odasayisi { get => odasayisi; set => odasayisi = Math.Abs(value); }

    
        private double alan;

        public double Alan
        {

            get { return alan; }
            set
            {
                if (value < 50)
                {
                    throw new Exception("Min alan değeri 50 olmalıdır");
                }
                alan = value;
                if (this.alan > 50 && this.alan < 75)
                {
                    this.Buyukluk = "Küçük Ev";
                }
                else if (this.alan > 75 && this.alan < 120)
                {
                    this.Buyukluk = "Orta büyüklükte ev";
                }
                else
                {
                    this.Buyukluk = "Büyük ev";
                }
            }
        }
        protected string TemelBilgiler()
        {
            return $"Semt: {Semt}\nOda Sayısı: {Odasayisi}\nKat No: {Katno}\nAlan: {Alan}\nBüyüklük: {Buyukluk}";
        }

        public abstract string EvBilgileri();
    }
}
