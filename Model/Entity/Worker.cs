﻿using DataAccess.Scaffold.Attributes;
using Needletail.DataAccess.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Needletail.SampleModel.Model.Entity
{
    public class Worker
    {
        [TableKey(CanInsertKey = true)]
        public Guid Id { get; set; }
        
        [Required]
        public string Name { get; set; }

        [Email]
        public string Email { get; set; }

        public int Age { get; set; }

        public DateTime SubscriptionDate { get; set; }
        
        public Guid DepartmentId {get;set;}

        public Guid AddressId { get; set;}

        public Guid CityId { get; set; }
    }
}
