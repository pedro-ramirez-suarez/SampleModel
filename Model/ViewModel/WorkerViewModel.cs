using DataAccess.Scaffold.Attributes;
using DataAccess.Scaffold.ViewModels;
using Needletail.SampleModel.Model.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Needletail.SampleModel.Model.ViewModel
{
    [NeedletailViewModel]
    public class WorkerViewModel : ViewModelAutoLoadAndSave
    {

        [HasOne("UserAddress","AddressId","Address","Id")]
        [SelectFrom("DepartmentList","DepartmentId", "Department", "Id", "DepartmentName")]
        [Autocomplete("CityId","City","Id","CityName","CityName","CityName")]
        [HasMany("EquipmentList","Id","WorkerEquipment","UserId")]
        [HasManyNtoN("ProjectList","Id","WorkerProject","UserId","ProjectId","Project","Id")]
        public Worker Worker { get; set; }

        public Address UserAddress { get; set; }

        public Address WorkerAddress { get; set; }

        public IList<Department> DepartmentList { get; set; }

        public IList<Project> ProjectList { get; set; }

        public IList<WorkerEquipment> EquipmentList { get; set; }


    }
}
