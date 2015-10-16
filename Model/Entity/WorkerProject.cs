using Needletail.DataAccess.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Needletail.SampleModel.Model.Entity
{
    public class WorkerProject
    {
        [TableKey(CanInsertKey= true)]
        public Guid Id { get; set; }

        public Guid UserId { get; set; }

        public Guid ProjectId { get; set; }
    }
}
