﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParqueDiversao
{
    internal interface IBrinquedoAssustador
    {
        int NivelMedo { get; set; }
        void assustar();
    }
}