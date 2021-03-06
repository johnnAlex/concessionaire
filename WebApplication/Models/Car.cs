﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication.Models
{
    public class Car
    {
        public string Brand { get; set; }
        public string Model { get; set; }
        public string Color { get; set; }
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public string Plate { get; set; }
        public string City { get; set; }
        public Int16 Checked { get; set; }

        [NotMapped]
        public bool Selected
        {
            get { return Checked == 1; }
            set { Checked = value ? Convert.ToInt16(1) : Convert.ToInt16(0); }
        }
    }
}
