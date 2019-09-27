using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.Extensions.Logging;

namespace MyPortfolio
{
    public class DebugClass
    {
        public static ILogger _logger;
        public static DebugClass _instance;
        public DebugClass(ILogger<DebugClass> logger)
        {
            _instance = this;
            _logger = logger;
        }
        public static DebugClass GetInstance() => _instance;

    }
}
