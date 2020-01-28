using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pkAccounting.Models
{
    public class TTN
    {
        public int Id { get; set; }
        public string TtnNumber { get; set; }
        public DateTime TtnDate { get; set; }
        public int TtnWeight { get; set; }
        public int AktNumber { get; set; }
        public DateTime AktDate { get; set; }
        public int AktWeight { get; set; }
        public int AccType { get; set; }
        

    }
}
