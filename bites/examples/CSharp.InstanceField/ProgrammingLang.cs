using System;

namespace CSharp.InstanceField{
    public class ProgLang{
        public String Name { get; private set; }
        public Int32 YearOfCreation { get; private set; }
        public String Creator { get; private set; }

        public ProgLang(String Name, Int32 YearOfCreation, String Creator)
        {
            this.Name = Name;
            this.YearOfCreation = YearOfCreation;
            this.Creator = Creator;
        }
        
    }
}