using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace API_PRUEBA.Models
{
    public class Permissions
    {
        [Key]
        public int Id_Permissions { get; set; }
        public string  EmployeeForename { get; set; }
        public string   EmployeeSurname { get; set; }
        public int   Id_permissiontypes { get; set; }
        public DateTime   PermissionDate { get; set; }
    }
}
