﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RacingGame.Command
{
    abstract class Command
    {
          public abstract void Execute(KeyEventArgs e);
    }
}
