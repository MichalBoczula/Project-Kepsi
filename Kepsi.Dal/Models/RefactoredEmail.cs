using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KeepItShort.Persistance.Models
{
    internal class RefactoredEmail
    {
        public int Id { get; set; }
        public int EmailId { get; set; }
        public Email EmailRef { get; set; }
        public string CustomerName { get; set; }
        public string Topic { get; set; }
        public string Summary { get; set; }
    }
}
