using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AtendenteVirtual.Entities
{
    public class Treatment
    {
        #region Properties
        public Guid ID { get; set; } = Guid.NewGuid();
        public string UserName { get; set; } = string.Empty;
        public DateTime DataHora { get; set; } = DateTime.Now;
        public string Question { get; set; } = string.Empty;
        public string Answer { get; set; } = string.Empty;
        #endregion
    }
}
