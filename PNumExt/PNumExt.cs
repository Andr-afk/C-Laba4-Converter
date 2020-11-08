using System;


namespace developingClasses
{
    public class PNumExt:PNumber
    {
        string valueNumber;
        int base_value;
        int accuracy;


        public PNumExt(string value, string base_value, string accuracy) 
            :base(value, base_value, accuracy)
        {

        }

        public int getterBaseValue
        {
            set
            {
                if (value >= 2 && value <= 16) this.base_value = value;
                else throw new Exception("Недопустимая система счисления");

            }
            get { return this.base_value; }
        }
    }
}
