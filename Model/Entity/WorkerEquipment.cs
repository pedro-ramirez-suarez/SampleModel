using DataAccess.Scaffold.Attributes;
using Needletail.DataAccess.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Needletail.SampleModel.Model.Entity
{
    public class WorkerEquipment
    {
        [TableKey(CanInsertKey = true)]
        public Guid Id { get; set; }

        [Required]
        public string EquipmentName { get; set; }
        [Required]
        public decimal Price { get; set; }
        
        [Required]
        public Guid? UserId { get; set; }
    }
}
