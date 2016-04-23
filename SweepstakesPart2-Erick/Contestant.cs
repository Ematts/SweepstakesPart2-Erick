using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SweepstakesPart2_Erick
{
    class Contestant
    {
        public string name;
        public int ticketNumber;
        public string result;

        public Contestant(string Name, int TicketNumber, string Result)
        {

            name = Name;
            ticketNumber = TicketNumber;
            result = Result;

        }
    }
}
