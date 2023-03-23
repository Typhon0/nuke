// Copyright 2021 Maintainers of NUKE.
// Distributed under the MIT License.
// https://github.com/nuke-build/nuke/blob/master/LICENSE

using System;
using System.Collections.Generic;
using System.Linq;
using JetBrains.Annotations;

namespace Nuke.Common.Tooling
{
    [PublicAPI]
    public struct Output
    {
        public OutputType Type;
        public string Text;

        public List<ConsoleColor> ConsoleColor;
    }
}
