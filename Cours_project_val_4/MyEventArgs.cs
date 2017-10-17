using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cours_project_val_4
{
    public class MyEventArgs:EventArgs
    {
        public string Info { get; set; }
        public int Index { get; set; }
        public MyEventArgs(string info, int index)
        {
            Info = info;
            Index = index;
        }
    }
}
