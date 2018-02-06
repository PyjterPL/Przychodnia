using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Przychodnia.Obiekty_Bazy
{
    class Grafik
    {
        public int ID { get; private set; }
        public int IdLekarza { get; set; }
        public DateTime Dzien_od { get; set; }
        public int? IdPacjenta { get; set; }//może być nullem  
        public string Opis { get; set; }
        public int IdOddzialu { get; set; }

        public Grafik(int id,int idlekarza,DateTime dzienod,int? idpacjenta,string opis,int idodzialu)
        {
            this.ID = id;
            this.IdLekarza = idlekarza;
            this.Dzien_od = dzienod;
            this.IdPacjenta = idpacjenta;
            this.Opis = opis;
            this.IdOddzialu = idodzialu;
        }
    }
}
