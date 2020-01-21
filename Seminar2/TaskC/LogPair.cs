using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class LogPair
{
    public Print Method { get; set; }

    public string Log { get; set; }

    public LogPair(Print m, string l)
    {
        Method = m;
        Log = l;
    }
}

