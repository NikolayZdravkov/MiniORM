using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MiniORM.app.Data.Entities
{
    public class EmployeeProject
    {
        [Key]
        [ForeignKey(nameof(Employee))]

        public int Id { get; set; }

        [Key]
        [ForeignKey(nameof(Project))]

        public int ProjectId { get; set; }

        public Employee Employee { get; set; }

        public Project Project { get; set; }


    }
}
