using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyClinic
{
    class ComboBoxItem
    {
        public string Text { get; set; }
        public DataRow Hidden { get; set; }

        public override string ToString()
        {
            return Text;
        }
    }
}
