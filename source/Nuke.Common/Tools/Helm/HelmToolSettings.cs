// Copyright 2021 Maintainers of NUKE.
// Distributed under the MIT License.
// https://github.com/nuke-build/nuke/blob/master/LICENSE

using JetBrains.Annotations;
using Nuke.Common.Tooling;
using System;
using System.Collections.Generic;

namespace Nuke.Common.Tools.Helm
{
    [PublicAPI]
    [Serializable]
    public class HelmToolSettings : ToolSettings
    {
        /// <summary>
        /// Common settings for Helm, like kubecontext, Tiller namespace ...
        /// </summary>
        public HelmCommonSettings CommonSettings { get; internal set; }

        public override Action<OutputType, string, List<ConsoleColor>> ProcessCustomLogger { get; internal set; }

        protected override Arguments ConfigureProcessArguments([NotNull] Arguments arguments)
        {
            if (CommonSettings != null)
                arguments.Concatenate(CommonSettings.CreateArguments());
            return base.ConfigureProcessArguments(arguments);
        }
    }
}
