﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parcial.Domain
{
    internal interface IObserver
    {
        void Actualizar(Ciudad ciudad, Clima clima);
    }
}
