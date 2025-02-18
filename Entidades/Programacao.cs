﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AndreysGym.Entidades
{
    public class Programacao
    {
        public UInt64 Id { get; set; }
        [Required]
        public DateTime DataInicio { get; set; }
        [Required]
        public List<Treino> Treinos { get; set; }
    }
}
