﻿using GeneticAlgorithm.Concretes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeneticAlgorithm.Interfaces
{
    interface ICrossable
    {
        ChromosomePair CrossOver();
    }
}
