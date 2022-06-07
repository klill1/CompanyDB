using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace TARge20.Core.Domain
{
    public class Employee
    {
        [Key]
        public Guid Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string PersonalId { get; set; }
        public string Address { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public string ClosestPerson { get; set; }
        public string ClosestPersonPhone { get; set; }
        public DateTime WorkingSince { get; set; }
        public string Note { get; set; }
        //fk
        public Guid BranchOfficeId { get; set; }
        public BranchOffice BranchOffice { get; set; }
        //List
        public List<Children> Childrens { get; set; }
        public List<HealthInspection> HealthInspections { get; set; }
        public List<SickLeave> SickLeaves { get; set; }
        public List<JobTitle> JobTitles { get; set; }
        public List<Vacation> Vacations { get; set; }
        public List<AccessPermission> AccessPermissions { get; set; }
        public List<ItemsToRent> ItemsToRent { get; set; }
    }
}
