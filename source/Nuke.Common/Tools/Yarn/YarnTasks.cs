// Copyright 2021 Maintainers of NUKE.
// Distributed under the MIT License.
// https://github.com/nuke-build/nuke/blob/master/LICENSE

using System;
using System.CodeDom;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.IO;
using System.Runtime.InteropServices;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using Nuke.Common.Tooling;
using Serilog;
using System.Diagnostics;

namespace Nuke.Common.Tools.Yarn
{
    partial class YarnTasks
    {
        public static void CustomLogger(
            OutputType type,
            string output,
            List<ConsoleColor> consoleColors
        )
        {
            switch (type)
            {
                case OutputType.Std:
                    Log.Debug(output);
                    break;
                case OutputType.Err:
                    {

                        if (consoleColors.Contains(ConsoleColor.Yellow))
                            Log.Warning(output);
                        else
                            Log.Error(output);

                        break;
                    }
            }
        }

    }
}
