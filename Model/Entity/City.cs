using DataAccess.Scaffold.Attributes;
using Needletail.DataAccess.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Needletail.SampleModel.Model.Entity
{
    public class City
    {
        [TableKey(CanInsertKey = true)]
        public Guid Id { get; set; }


        [Required, MaxLen(50)]
        public string CityName { get; set; }
    }
}
