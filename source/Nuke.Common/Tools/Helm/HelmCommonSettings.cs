// Copyright 2023 Maintainers of NUKE.
// Distributed under the MIT License.
// https://github.com/nuke-build/nuke/blob/master/LICENSE

using Nuke.Common.Tooling;
using System;
using System.Collections.Generic;

namespace Nuke.Common.Tools.Helm
{
    public partial class HelmCommonSettings
    {
        internal Arguments CreateArguments()
        {
            return ConfigureProcessArguments(new Arguments());
        }

        public override Action<OutputType, string, List<ConsoleColor>> ProcessCustomLogger { get; internal set; }
    }
}
