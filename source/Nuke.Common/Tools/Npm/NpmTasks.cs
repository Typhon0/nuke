﻿// Copyright 2023 Maintainers of NUKE.
// Distributed under the MIT License.
// https://github.com/nuke-build/nuke/blob/master/LICENSE

using System;
using System.Collections.Generic;
using Nuke.Common.Tooling;
using Serilog;

namespace Nuke.Common.Tools.Npm
{
    partial class NpmTasks
    {
        public static void CustomLogger(OutputType type, string output,List<ConsoleColor> consoleColors)
        {
            switch (type)
            {
                case OutputType.Std:
                    Log.Debug(output);
                    break;
                case OutputType.Err:
                {
                    if (output.StartsWith("npmWARN") || output.StartsWith("npm WARN"))
                        Log.Warning(output);
                    else
                        Log.Error(output);

                    break;
                }
            }
        }
    }
}
