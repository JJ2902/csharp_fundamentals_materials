using System;

namespace CSharp.Arithmetic{
    class Order{
        internal int Total;

        internal Order(int Total)
        {
            this.Total = Total;
        }

        internal static int AddAmount(int Total, int number){
        return Total + number;
        }

        internal static int ApplyDiscount(int Total,int number){
        return Total - number;
        }
        internal static int GetTotal(int Total){
        return Total;
        }
        internal string FriendlyTotal(){
        return $"Thanks! The total value of your order is £{Total}.";
        }

    }
}