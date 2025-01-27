using System;

namespace CSharp.InstanceField{
    class Bagel{
        internal string Seeds;
        internal string Filling;
        internal int Price;

        internal Bagel(string Seeds,string Filling, int Price)
        {
            this.Seeds = Seeds;
            this.Filling = Filling;
            this.Price = Price;
        }
    }
}