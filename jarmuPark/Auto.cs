using Microsoft.Win32.SafeHandles;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace jarmuPark
{
    class Auto
    {

        private string szin;
        private string tipus;
        private double uzemAnyag;
        public double UZEMANYAG { get { return uzemAnyag; } }
        private double fogyaszt;
        private double km;
        public double KM { get { return km; } }
        private double megteheto;
        public double MEGTEHETO { get { return megteheto; } }
        public Auto(string szin,string tipus, double fogyaszt)
        {
            this.szin = szin;
            this.tipus = tipus;
            this.fogyaszt = fogyaszt;
            this.uzemAnyag = 0;
            this.km = 0;
            this.megteheto = 0;
        }
        public void Tankol(double mennyit)
        {
            uzemAnyag += mennyit;
            Megteheto();
        }
        private void Megteheto()
        {
            megteheto = uzemAnyag / fogyaszt * 100;
        }
        public void Megy(double km)
        {
            this.km = km;
            uzemAnyag -= (km* fogyaszt / 100);
            Megteheto();
        }
        public void Allapot()
        {
            Console.WriteLine("------------------");
            Console.WriteLine($"{tipus} - {szin}");
            Console.WriteLine($"Km óra: {km} km");
            Console.WriteLine($"Üzemanyag: {uzemAnyag} L");
            Console.WriteLine($"Megtehető km: {megteheto}");
            Console.WriteLine("------------------");
        }
    }
}
