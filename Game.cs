using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Multiformapp_chachulova
{
    public class Game
    {
        public int Radky { get; private set; }
        public int Sloupce { get; private set; }
        public int PocetKaret => Radky * Sloupce;
        public string AktualniSada { get; private set; } = "Zvirata";

        private string[] symboly = [];
        private bool[] otocene = [];
        private bool[] shodne = [];

        private int prvni = -1;
        private int druha = -1;
        public bool CekaNaSkryti { get; private set; }

        public int Tahy { get; private set; }
        public int NalezenePary { get; private set; }
        public bool KonecHry => NalezenePary == (PocetKaret / 2);

        public static string[] SadyNazvy = { "Zvirata", "Ovoce", "Oblicej" };

        public static string[] GetSadu(string nazev)
        {
            return nazev switch
            {
                "Zvirata" => ["🐶", "🐱", "🐭", "🐰", "🦊", "🐻", "🐼", "🐯", "🦁", "🐸", "🐵", "🐔", "🦆", "🦉", "🐺", "🐴", "🐧", "🦋", "🐢", "🦀"],
                "Ovoce" => ["🍎", "🍊", "🍋", "🍇", "🍓", "🍒", "🍑", "🥝", "🍍", "🥭", "🍈", "🍌", "🍉", "🍐", "🥥", "🫐", "🍆", "🥑", "🥕", "🌽"],
                "Oblicej" => ["😀", "😎", "🥳", "😍", "🤩", "😜", "🤯", "😱", "🥺", "😂", "😏", "🤔", "😴", "🤗", "😤", "😈", "👻", "🤖", "👽", "🎃"]
            };
        }

        public void NovaHra(int radky, int sloupce, string sada)
        {
            Radky = radky; Sloupce = sloupce; AktualniSada = sada;
            Tahy = 0; NalezenePary = 0; prvni = -1; druha = -1; CekaNaSkryti = false;

            string[] zdroj = GetSadu(sada);
            var balicek = new List<string>();
            for (int i = 0; i < (radky * sloupce) / 2; i++)
            {
                balicek.Add(zdroj[i % zdroj.Length]);
                balicek.Add(zdroj[i % zdroj.Length]);
            }

            Random rng = new();
            balicek = balicek.OrderBy(x => rng.Next()).ToList();

            symboly = balicek.ToArray();
            otocene = new bool[PocetKaret];
            shodne = new bool[PocetKaret];
        }

        public string OtocKartu(int index)
        {
            if (shodne[index] || otocene[index] || CekaNaSkryti) return "preskoc";
            otocene[index] = true;

            if (prvni == -1) { prvni = index; return "ok"; }

            druha = index;
            Tahy++;
            if (symboly[prvni] == symboly[druha])
            {
                shodne[prvni] = shodne[druha] = true;
                NalezenePary++;
                prvni = druha = -1;
                return "shoda";
            }
            CekaNaSkryti = true;
            return "neshoda";
        }

        public (int a, int b) SkryjNeshodu()
        {
            int a = prvni; int b = druha;
            otocene[a] = otocene[b] = false;
            prvni = druha = -1;
            CekaNaSkryti = false;
            return (a, b);
        }

        public bool JeShodna(int i) => shodne[i];
        public string GetSymbol(int i) => symboly[i];
        public string GetSkore() => $"Tahy: {Tahy}   Pary: {NalezenePary} / {PocetKaret / 2}";
    
    }
}
