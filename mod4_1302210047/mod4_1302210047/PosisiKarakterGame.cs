using mod4_1302210047;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static mod4_1302210047.PosisiKarakterGame;

namespace mod4_1302210047
{
    internal class PosisiKarakterGame
    {
        public enum posisi{Jongkok,Berdiri, Terbang, Tengkurap}
        public enum tombol{tombolW,tombolS,tombolX}
        public posisi saatIni = posisi.Berdiri,
        public gantiposisi(posisi sebelum, posisi sesudah, tombol trigger)
        {
            this.sebelum = sebelum;
            this.sesudah = sesudah;
            this.trigger = trigger;
        }

    }
}
gantiposisi[] argent.posisi
{
new gantiposisi(posisi.Jongkok, posisi.Berdiri,tombol.tombolW),
new gantiposisi(posisi.Berdiri, posisi.Terbang, tombol.tombolW),
new gantiposisi(posisi.Terbang, posisi.Jongkok, tombol.tombolX),
new gantiposisi(posisi.Berdiri, posisi.Jongkok, tombol.tombolS),
new gantiposisi(posisi.Terbang, posisi.Berdiri, tombol.tombolS),
new gantiposisi(posisi.Jongkok, posisi.Tengkurap, tombol.tombolS),
new gantiposisi(posisi.Tengkurap, posisi.Jongkok, tombol.tombolW),
}

