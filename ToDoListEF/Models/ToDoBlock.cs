using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace ToDoListEF.Models
{
    public class ToDoBlock
    {
        [Key]
        public int Id { get; set; }
        [StringLength(300)]
        public string Text { get; set; }

    }
}
