﻿using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace LiftService.Models.Entities
{
    public class City
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public int Order { get; set; }

        public virtual List<State> States { get; set; }
    }
}
