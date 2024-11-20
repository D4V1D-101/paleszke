using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace CA24111202
{
    internal class Palinka
    {
        private int alkoholfok;
        private string gyomolcs;
        private int mennyiseg;

        public Palinka(int alkoholfok, string gyomolcs, int mennyiseg, int kesziteseve, int ara)
        {
            Alkoholfok = alkoholfok;
            Gyomolcs = gyomolcs;
            Mennyiseg = mennyiseg;
            Kesziteseve = kesziteseve;
            Ara = ara;
        }

        public int Alkoholfok 
        {
            get => alkoholfok;
            set
            {
                if (value< 30 || value > 87 )
               
                    throw new Exception(
                        $"a péinka fokszáma nem lehet kevesebb mint 30 és nem lehet magasabb mint 87"
                        );
                    alkoholfok = value;
            }
        }
        //-------------------------Gyümölcs---------------------------//
        public string Gyomolcs
        { get => gyomolcs;
            set {
                if (value is null) throw new Exception(
                    $"A gyümölcs értéke nem lehet null");
                if (value.Length < 3 || value.Length > 20) throw new Exception(
                   $"a gyűmölcs hossza nem lehet hoszabb mint 20" +
                   $" illetven nem lehet rövidebb mint 3. a te gyümölcsöd karaktereinek hossza: {value.Length}");
                gyomolcs = value;
                }
        }
        public int Mennyiseg {
            get => mennyiseg;
            set => mennyiseg = value; }
        public int Kesziteseve { get; set; }
        public int Ara { get; set; }
    }
}
