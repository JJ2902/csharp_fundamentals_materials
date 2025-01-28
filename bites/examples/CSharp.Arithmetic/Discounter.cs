using System;

namespace CSharp.Arithmetic{
    public class Discounter{
        private int discount;

        public Discounter(int discount)
        {
            this.discount = discount;
        }

        public int ApplyTo (int number) {
            return number - this.discount;
        }
    }
}