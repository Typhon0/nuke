// Copyright 2021 Maintainers of NUKE.
// Distributed under the MIT License.
// https://github.com/nuke-build/nuke/blob/master/LICENSE

using System;
using System.Collections.Generic;
using Nuke.Common.Tooling;
using Serilog;

namespace Nuke.Common.Tools.Pulumi
{
    partial class PulumiTasks
    {
        public static void CustomLogger(OutputType type, string text,List<ConsoleColor> consoleColors)
        {
            var output = text.TrimStart();

            if (type == OutputType.Std)
            {
                Log.Debug(output);
                return;
            }

            if (output.StartsWith("warning:"))
                Log.Warning(output);
            else
                Log.Error(output);
        }
    }
}
