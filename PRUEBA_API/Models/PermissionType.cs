using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace API_PRUEBA.Models
{
    public class PermissionsTypes
    {
        [Key]
        public int Id_permissiontypes { get; set; }
        
        public string  Description { get; set; }
    }
}
