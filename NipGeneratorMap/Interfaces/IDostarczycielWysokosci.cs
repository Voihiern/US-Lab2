﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NipGeneratorMap.Interfaces
{
    public interface IDostarczycielWysokosci
    {
        int[][] Wysokosci(string sciezkaPlikuWejsciowego);
    }
}
