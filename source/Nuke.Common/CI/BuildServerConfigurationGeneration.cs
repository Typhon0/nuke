// Copyright 2022 Maintainers of NUKE.
// Distributed under the MIT License.
// https://github.com/nuke-build/nuke/blob/master/LICENSE

using System;
using System.Linq;

namespace Nuke.Common.CI
{
    public static class BuildServerConfigurationGeneration
    {
        public static bool IsActive { get; } = EnvironmentInfo.GetParameter<string>(ConfigurationParameterName) != null;

        public const string ConfigurationParameterName = "generate-configuration";
    }
}
