using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concretes
{
    public class Course : IEntity
    {
        public int Id { get; set; }
        public int CategoryId { get; set; } //Category Foreign Key yani bir kurs bir kategoriye sahip
        public int InstructorId { get; set; } // Instructor Foreign Key yani bir kurs bir eğitmen sahip
        public string Name { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }

    }
}
