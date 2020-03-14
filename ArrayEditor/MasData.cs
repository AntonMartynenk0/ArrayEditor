using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace ArrayEditor
{
    [Serializable]
    public class MasData
    {
        public int count { get; set; }
        public int value { get; set; }
        

        public MasData(int count, int value, int size, int min, int max)
        {
            this.count = count;
            this.value = value;
        }
       
        public MasData() { }
    }
}
