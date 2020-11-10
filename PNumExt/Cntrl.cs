using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace developingClasses
{
    public class Cntrl: Editor
    {
        PNumExt pValue;

        public Cntrl():base()
        {
            
        }

        public string Converter(string inBase, string resBase, string accuracy = "0")
        {
            pValue = new PNumExt(this.Number, inBase, accuracy);
            return pValue.translateToNeedBaseValue(Convert.ToInt32(resBase), Convert.ToInt32(accuracy));
            
        }
    }
}
