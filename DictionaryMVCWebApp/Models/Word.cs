using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DictionaryMVCWebApp.Models
{
    public class Word
    {
        public int Id { get; set; }
        public string Words { get; set; }
        public string Definition { get; set; }

        public Word()
        {

        }
    }
}
