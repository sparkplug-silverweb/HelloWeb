using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HelloWeb.Models
{
    public partial class WarrantyProvider
    {
        public int WarrantyProviderId { get; set; }
        public string ProviderName { get; set; }
        public int? SupportExtension { get; set; }
        public string SupportNumber { get; set; }

        public ICollection<MachineWarranty> MachineWarranty { get; set; }


        public WarrantyProvider()
        {
            MachineWarranty = new HashSet<MachineWarranty>();
        }
    }
    
}
