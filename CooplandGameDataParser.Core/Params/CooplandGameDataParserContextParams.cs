﻿using CooplandGameDataParser.DatabaseDefaultHandler.Abstractions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CooplandGameDataParser.Core.Params
{
    public class CooplandGameDataParserContextParams
    {
        public IDatabaseHandler Handler { get; set; }
    }
}
