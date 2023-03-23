// Generated from https://github.com/Typhon0/nuke/blob/master/source/Nuke.Common/Tools/Yarn/Yarn.json

using JetBrains.Annotations;
using Newtonsoft.Json;
using Nuke.Common;
using Nuke.Common.Tooling;
using Nuke.Common.Tools;
using Nuke.Common.Utilities.Collections;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Diagnostics.CodeAnalysis;
using System.IO;
using System.Linq;
using System.Text;

namespace Nuke.Common.Tools.Yarn
{
    /// <summary>
    ///   <p>Yarn is a package manager that doubles down as project manager. Whether you work on one-shot projects or large monorepos, as a hobbyist or an enterprise user, we've got you covered.</p>
    ///   <p>For more details, visit the <a href="https://yarnpkg.com/">official website</a>.</p>
    /// </summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [PathToolRequirement(YarnPathExecutable)]
    public partial class YarnTasks
        : IRequirePathTool
    {
        public const string YarnPathExecutable = "yarn";
        /// <summary>
        ///   Path to the Yarn executable.
        /// </summary>
        public static string YarnPath =>
            ToolPathResolver.TryGetEnvironmentExecutable("YARN_EXE") ??
            ToolPathResolver.GetPathExecutable("yarn");
        public static Action<OutputType, string,List<ConsoleColor>> YarnLogger { get; set; } = CustomLogger;
        /// <summary>
        ///   <p>Yarn is a package manager that doubles down as project manager. Whether you work on one-shot projects or large monorepos, as a hobbyist or an enterprise user, we've got you covered.</p>
        ///   <p>For more details, visit the <a href="https://yarnpkg.com/">official website</a>.</p>
        /// </summary>
        public static IReadOnlyCollection<Output> Yarn(ref ArgumentStringHandler arguments, string workingDirectory = null, IReadOnlyDictionary<string, string> environmentVariables = null, int? timeout = null, bool? logOutput = null, bool? logInvocation = null, Action<OutputType, string,List<ConsoleColor>> customLogger = null)
        {
            using var process = ProcessTasks.StartProcess(YarnPath, ref arguments, workingDirectory, environmentVariables, timeout, logOutput, logInvocation, customLogger ?? YarnLogger);
            process.AssertZeroExitCode();
            return process.Output;
        }
        /// <summary>
        ///   <p>Install the project dependencies.</p>
        ///   <p>For more details, visit the <a href="https://yarnpkg.com/">official website</a>.</p>
        /// </summary>
        /// <remarks>
        ///   <p>This is a <a href="http://www.nuke.build/docs/authoring-builds/cli-tools.html#fluent-apis">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p>
        ///   <ul>
        ///     <li><c>--check-cache</c> via <see cref="YarnInstallSettings.CheckCache"/></li>
        ///     <li><c>--cwd</c> via <see cref="YarnInstallSettings.WorkingDirectory"/></li>
        ///     <li><c>--immutable</c> via <see cref="YarnInstallSettings.Immutable"/></li>
        ///     <li><c>--immutable-cache</c> via <see cref="YarnInstallSettings.ImmutableCache"/></li>
        ///     <li><c>--inline-builds</c> via <see cref="YarnInstallSettings.InlineBuilds"/></li>
        ///     <li><c>--json</c> via <see cref="YarnInstallSettings.JSON"/></li>
        ///     <li><c>--mode</c> via <see cref="YarnInstallSettings.Mode"/></li>
        ///   </ul>
        /// </remarks>
        public static IReadOnlyCollection<Output> YarnInstall(YarnInstallSettings toolSettings = null)
        {
            toolSettings = toolSettings ?? new YarnInstallSettings();
            using var process = ProcessTasks.StartProcess(toolSettings);
            process.AssertZeroExitCode();
            return process.Output;
        }
        /// <summary>
        ///   <p>Install the project dependencies.</p>
        ///   <p>For more details, visit the <a href="https://yarnpkg.com/">official website</a>.</p>
        /// </summary>
        /// <remarks>
        ///   <p>This is a <a href="http://www.nuke.build/docs/authoring-builds/cli-tools.html#fluent-apis">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p>
        ///   <ul>
        ///     <li><c>--check-cache</c> via <see cref="YarnInstallSettings.CheckCache"/></li>
        ///     <li><c>--cwd</c> via <see cref="YarnInstallSettings.WorkingDirectory"/></li>
        ///     <li><c>--immutable</c> via <see cref="YarnInstallSettings.Immutable"/></li>
        ///     <li><c>--immutable-cache</c> via <see cref="YarnInstallSettings.ImmutableCache"/></li>
        ///     <li><c>--inline-builds</c> via <see cref="YarnInstallSettings.InlineBuilds"/></li>
        ///     <li><c>--json</c> via <see cref="YarnInstallSettings.JSON"/></li>
        ///     <li><c>--mode</c> via <see cref="YarnInstallSettings.Mode"/></li>
        ///   </ul>
        /// </remarks>
        public static IReadOnlyCollection<Output> YarnInstall(Configure<YarnInstallSettings> configurator)
        {
            return YarnInstall(configurator(new YarnInstallSettings()));
        }
        /// <summary>
        ///   <p>Install the project dependencies.</p>
        ///   <p>For more details, visit the <a href="https://yarnpkg.com/">official website</a>.</p>
        /// </summary>
        /// <remarks>
        ///   <p>This is a <a href="http://www.nuke.build/docs/authoring-builds/cli-tools.html#fluent-apis">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p>
        ///   <ul>
        ///     <li><c>--check-cache</c> via <see cref="YarnInstallSettings.CheckCache"/></li>
        ///     <li><c>--cwd</c> via <see cref="YarnInstallSettings.WorkingDirectory"/></li>
        ///     <li><c>--immutable</c> via <see cref="YarnInstallSettings.Immutable"/></li>
        ///     <li><c>--immutable-cache</c> via <see cref="YarnInstallSettings.ImmutableCache"/></li>
        ///     <li><c>--inline-builds</c> via <see cref="YarnInstallSettings.InlineBuilds"/></li>
        ///     <li><c>--json</c> via <see cref="YarnInstallSettings.JSON"/></li>
        ///     <li><c>--mode</c> via <see cref="YarnInstallSettings.Mode"/></li>
        ///   </ul>
        /// </remarks>
        public static IEnumerable<(YarnInstallSettings Settings, IReadOnlyCollection<Output> Output)> YarnInstall(CombinatorialConfigure<YarnInstallSettings> configurator, int degreeOfParallelism = 1, bool completeOnFailure = false)
        {
            return configurator.Invoke(YarnInstall, YarnLogger, degreeOfParallelism, completeOnFailure);
        }
        /// <summary>
        ///   <p>Add dependencies to the project.</p>
        ///   <p>For more details, visit the <a href="https://yarnpkg.com/">official website</a>.</p>
        /// </summary>
        /// <remarks>
        ///   <p>This is a <a href="http://www.nuke.build/docs/authoring-builds/cli-tools.html#fluent-apis">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p>
        ///   <ul>
        ///     <li><c>&lt;packages&gt;</c> via <see cref="YarnAddSettings.Packages"/></li>
        ///     <li><c>--cached</c> via <see cref="YarnAddSettings.Cached"/></li>
        ///     <li><c>--caret</c> via <see cref="YarnAddSettings.Caret"/></li>
        ///     <li><c>--dev</c> via <see cref="YarnAddSettings.Dev"/></li>
        ///     <li><c>--exact</c> via <see cref="YarnAddSettings.Exact"/></li>
        ///     <li><c>--interactive</c> via <see cref="YarnAddSettings.Interactive"/></li>
        ///     <li><c>--json</c> via <see cref="YarnAddSettings.JSON"/></li>
        ///     <li><c>--mode</c> via <see cref="YarnAddSettings.Mode"/></li>
        ///     <li><c>--optional</c> via <see cref="YarnAddSettings.Optional"/></li>
        ///     <li><c>--peer</c> via <see cref="YarnAddSettings.Peer"/></li>
        ///     <li><c>--prefer-dev</c> via <see cref="YarnAddSettings.PreferDev"/></li>
        ///     <li><c>--tilde</c> via <see cref="YarnAddSettings.Tilde"/></li>
        ///   </ul>
        /// </remarks>
        public static IReadOnlyCollection<Output> YarnAdd(YarnAddSettings toolSettings = null)
        {
            toolSettings = toolSettings ?? new YarnAddSettings();
            using var process = ProcessTasks.StartProcess(toolSettings);
            process.AssertZeroExitCode();
            return process.Output;
        }
        /// <summary>
        ///   <p>Add dependencies to the project.</p>
        ///   <p>For more details, visit the <a href="https://yarnpkg.com/">official website</a>.</p>
        /// </summary>
        /// <remarks>
        ///   <p>This is a <a href="http://www.nuke.build/docs/authoring-builds/cli-tools.html#fluent-apis">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p>
        ///   <ul>
        ///     <li><c>&lt;packages&gt;</c> via <see cref="YarnAddSettings.Packages"/></li>
        ///     <li><c>--cached</c> via <see cref="YarnAddSettings.Cached"/></li>
        ///     <li><c>--caret</c> via <see cref="YarnAddSettings.Caret"/></li>
        ///     <li><c>--dev</c> via <see cref="YarnAddSettings.Dev"/></li>
        ///     <li><c>--exact</c> via <see cref="YarnAddSettings.Exact"/></li>
        ///     <li><c>--interactive</c> via <see cref="YarnAddSettings.Interactive"/></li>
        ///     <li><c>--json</c> via <see cref="YarnAddSettings.JSON"/></li>
        ///     <li><c>--mode</c> via <see cref="YarnAddSettings.Mode"/></li>
        ///     <li><c>--optional</c> via <see cref="YarnAddSettings.Optional"/></li>
        ///     <li><c>--peer</c> via <see cref="YarnAddSettings.Peer"/></li>
        ///     <li><c>--prefer-dev</c> via <see cref="YarnAddSettings.PreferDev"/></li>
        ///     <li><c>--tilde</c> via <see cref="YarnAddSettings.Tilde"/></li>
        ///   </ul>
        /// </remarks>
        public static IReadOnlyCollection<Output> YarnAdd(Configure<YarnAddSettings> configurator)
        {
            return YarnAdd(configurator(new YarnAddSettings()));
        }
        /// <summary>
        ///   <p>Add dependencies to the project.</p>
        ///   <p>For more details, visit the <a href="https://yarnpkg.com/">official website</a>.</p>
        /// </summary>
        /// <remarks>
        ///   <p>This is a <a href="http://www.nuke.build/docs/authoring-builds/cli-tools.html#fluent-apis">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p>
        ///   <ul>
        ///     <li><c>&lt;packages&gt;</c> via <see cref="YarnAddSettings.Packages"/></li>
        ///     <li><c>--cached</c> via <see cref="YarnAddSettings.Cached"/></li>
        ///     <li><c>--caret</c> via <see cref="YarnAddSettings.Caret"/></li>
        ///     <li><c>--dev</c> via <see cref="YarnAddSettings.Dev"/></li>
        ///     <li><c>--exact</c> via <see cref="YarnAddSettings.Exact"/></li>
        ///     <li><c>--interactive</c> via <see cref="YarnAddSettings.Interactive"/></li>
        ///     <li><c>--json</c> via <see cref="YarnAddSettings.JSON"/></li>
        ///     <li><c>--mode</c> via <see cref="YarnAddSettings.Mode"/></li>
        ///     <li><c>--optional</c> via <see cref="YarnAddSettings.Optional"/></li>
        ///     <li><c>--peer</c> via <see cref="YarnAddSettings.Peer"/></li>
        ///     <li><c>--prefer-dev</c> via <see cref="YarnAddSettings.PreferDev"/></li>
        ///     <li><c>--tilde</c> via <see cref="YarnAddSettings.Tilde"/></li>
        ///   </ul>
        /// </remarks>
        public static IEnumerable<(YarnAddSettings Settings, IReadOnlyCollection<Output> Output)> YarnAdd(CombinatorialConfigure<YarnAddSettings> configurator, int degreeOfParallelism = 1, bool completeOnFailure = false)
        {
            return configurator.Invoke(YarnAdd, YarnLogger, degreeOfParallelism, completeOnFailure);
        }
        /// <summary>
        ///   <p>Run a script defined in the package.json.</p>
        ///   <p>For more details, visit the <a href="https://yarnpkg.com/">official website</a>.</p>
        /// </summary>
        /// <remarks>
        ///   <p>This is a <a href="http://www.nuke.build/docs/authoring-builds/cli-tools.html#fluent-apis">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p>
        ///   <ul>
        ///     <li><c>&lt;command&gt;</c> via <see cref="YarnRunSettings.Command"/></li>
        ///     <li><c>--</c> via <see cref="YarnRunSettings.Arguments"/></li>
        ///     <li><c>--binaries-only</c> via <see cref="YarnRunSettings.BinariesOnly"/></li>
        ///     <li><c>--inspect</c> via <see cref="YarnRunSettings.Inspect"/></li>
        ///     <li><c>--inspect-brk</c> via <see cref="YarnRunSettings.InspectBrk"/></li>
        ///     <li><c>--top-level</c> via <see cref="YarnRunSettings.TopLevel"/></li>
        ///   </ul>
        /// </remarks>
        public static IReadOnlyCollection<Output> YarnRun(YarnRunSettings toolSettings = null)
        {
            toolSettings = toolSettings ?? new YarnRunSettings();
            using var process = ProcessTasks.StartProcess(toolSettings);
            process.AssertZeroExitCode();
            return process.Output;
        }
        /// <summary>
        ///   <p>Run a script defined in the package.json.</p>
        ///   <p>For more details, visit the <a href="https://yarnpkg.com/">official website</a>.</p>
        /// </summary>
        /// <remarks>
        ///   <p>This is a <a href="http://www.nuke.build/docs/authoring-builds/cli-tools.html#fluent-apis">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p>
        ///   <ul>
        ///     <li><c>&lt;command&gt;</c> via <see cref="YarnRunSettings.Command"/></li>
        ///     <li><c>--</c> via <see cref="YarnRunSettings.Arguments"/></li>
        ///     <li><c>--binaries-only</c> via <see cref="YarnRunSettings.BinariesOnly"/></li>
        ///     <li><c>--inspect</c> via <see cref="YarnRunSettings.Inspect"/></li>
        ///     <li><c>--inspect-brk</c> via <see cref="YarnRunSettings.InspectBrk"/></li>
        ///     <li><c>--top-level</c> via <see cref="YarnRunSettings.TopLevel"/></li>
        ///   </ul>
        /// </remarks>
        public static IReadOnlyCollection<Output> YarnRun(Configure<YarnRunSettings> configurator)
        {
            return YarnRun(configurator(new YarnRunSettings()));
        }
        /// <summary>
        ///   <p>Run a script defined in the package.json.</p>
        ///   <p>For more details, visit the <a href="https://yarnpkg.com/">official website</a>.</p>
        /// </summary>
        /// <remarks>
        ///   <p>This is a <a href="http://www.nuke.build/docs/authoring-builds/cli-tools.html#fluent-apis">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p>
        ///   <ul>
        ///     <li><c>&lt;command&gt;</c> via <see cref="YarnRunSettings.Command"/></li>
        ///     <li><c>--</c> via <see cref="YarnRunSettings.Arguments"/></li>
        ///     <li><c>--binaries-only</c> via <see cref="YarnRunSettings.BinariesOnly"/></li>
        ///     <li><c>--inspect</c> via <see cref="YarnRunSettings.Inspect"/></li>
        ///     <li><c>--inspect-brk</c> via <see cref="YarnRunSettings.InspectBrk"/></li>
        ///     <li><c>--top-level</c> via <see cref="YarnRunSettings.TopLevel"/></li>
        ///   </ul>
        /// </remarks>
        public static IEnumerable<(YarnRunSettings Settings, IReadOnlyCollection<Output> Output)> YarnRun(CombinatorialConfigure<YarnRunSettings> configurator, int degreeOfParallelism = 1, bool completeOnFailure = false)
        {
            return configurator.Invoke(YarnRun, YarnLogger, degreeOfParallelism, completeOnFailure);
        }
        /// <summary>
        ///   <p>Generate a tarball from the active workspace.</p>
        ///   <p>For more details, visit the <a href="https://yarnpkg.com/">official website</a>.</p>
        /// </summary>
        /// <remarks>
        ///   <p>This is a <a href="http://www.nuke.build/docs/authoring-builds/cli-tools.html#fluent-apis">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p>
        ///   <ul>
        ///     <li><c>--dry-run</c> via <see cref="YarnPackSettings.DryRun"/></li>
        ///     <li><c>--install-if-needed</c> via <see cref="YarnPackSettings.InstallIfNeeded"/></li>
        ///     <li><c>--json</c> via <see cref="YarnPackSettings.JSON"/></li>
        ///     <li><c>--out</c> via <see cref="YarnPackSettings.Out"/></li>
        ///   </ul>
        /// </remarks>
        public static IReadOnlyCollection<Output> YarnPack(YarnPackSettings toolSettings = null)
        {
            toolSettings = toolSettings ?? new YarnPackSettings();
            using var process = ProcessTasks.StartProcess(toolSettings);
            process.AssertZeroExitCode();
            return process.Output;
        }
        /// <summary>
        ///   <p>Generate a tarball from the active workspace.</p>
        ///   <p>For more details, visit the <a href="https://yarnpkg.com/">official website</a>.</p>
        /// </summary>
        /// <remarks>
        ///   <p>This is a <a href="http://www.nuke.build/docs/authoring-builds/cli-tools.html#fluent-apis">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p>
        ///   <ul>
        ///     <li><c>--dry-run</c> via <see cref="YarnPackSettings.DryRun"/></li>
        ///     <li><c>--install-if-needed</c> via <see cref="YarnPackSettings.InstallIfNeeded"/></li>
        ///     <li><c>--json</c> via <see cref="YarnPackSettings.JSON"/></li>
        ///     <li><c>--out</c> via <see cref="YarnPackSettings.Out"/></li>
        ///   </ul>
        /// </remarks>
        public static IReadOnlyCollection<Output> YarnPack(Configure<YarnPackSettings> configurator)
        {
            return YarnPack(configurator(new YarnPackSettings()));
        }
        /// <summary>
        ///   <p>Generate a tarball from the active workspace.</p>
        ///   <p>For more details, visit the <a href="https://yarnpkg.com/">official website</a>.</p>
        /// </summary>
        /// <remarks>
        ///   <p>This is a <a href="http://www.nuke.build/docs/authoring-builds/cli-tools.html#fluent-apis">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p>
        ///   <ul>
        ///     <li><c>--dry-run</c> via <see cref="YarnPackSettings.DryRun"/></li>
        ///     <li><c>--install-if-needed</c> via <see cref="YarnPackSettings.InstallIfNeeded"/></li>
        ///     <li><c>--json</c> via <see cref="YarnPackSettings.JSON"/></li>
        ///     <li><c>--out</c> via <see cref="YarnPackSettings.Out"/></li>
        ///   </ul>
        /// </remarks>
        public static IEnumerable<(YarnPackSettings Settings, IReadOnlyCollection<Output> Output)> YarnPack(CombinatorialConfigure<YarnPackSettings> configurator, int degreeOfParallelism = 1, bool completeOnFailure = false)
        {
            return configurator.Invoke(YarnPack, YarnLogger, degreeOfParallelism, completeOnFailure);
        }
    }
    #region YarnInstallSettings
    /// <summary>
    ///   Used within <see cref="YarnTasks"/>.
    /// </summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class YarnInstallSettings : ToolSettings
    {
        /// <summary>
        ///   Path to the Yarn executable.
        /// </summary>
        public override string ProcessToolPath => base.ProcessToolPath ?? YarnTasks.YarnPath;
        public override Action<OutputType, string,List<ConsoleColor>> ProcessCustomLogger => base.ProcessCustomLogger ?? YarnTasks.YarnLogger;
        /// <summary>
        ///   Format the output as an NDJSON stream
        /// </summary>
        public virtual bool? JSON { get; internal set; }
        /// <summary>
        ///   Abort with an error exit code if the lockfile was to be modified
        /// </summary>
        public virtual bool? Immutable { get; internal set; }
        /// <summary>
        ///   The directory to run the command in
        /// </summary>
        public virtual string WorkingDirectory { get; internal set; }
        /// <summary>
        ///   Abort with an error exit code if the cache folder was to be modified
        /// </summary>
        public virtual bool? ImmutableCache { get; internal set; }
        /// <summary>
        ///   Always refetch the packages and ensure that their checksums are consistent
        /// </summary>
        public virtual bool? CheckCache { get; internal set; }
        /// <summary>
        ///   Verbosely print the output of the build steps of dependencies
        /// </summary>
        public virtual bool? InlineBuilds { get; internal set; }
        /// <summary>
        ///   Change what artifacts installs generate
        /// </summary>
        public virtual YarnMode Mode { get; internal set; }
        protected override Arguments ConfigureProcessArguments(Arguments arguments)
        {
            arguments
              .Add("install")
              .Add("--json", JSON)
              .Add("--immutable", Immutable)
              .Add("--cwd", WorkingDirectory)
              .Add("--immutable-cache", ImmutableCache)
              .Add("--check-cache", CheckCache)
              .Add("--inline-builds", InlineBuilds)
              .Add("--mode", Mode);
            return base.ConfigureProcessArguments(arguments);
        }
    }
    #endregion
    #region YarnAddSettings
    /// <summary>
    ///   Used within <see cref="YarnTasks"/>.
    /// </summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class YarnAddSettings : ToolSettings
    {
        /// <summary>
        ///   Path to the Yarn executable.
        /// </summary>
        public override string ProcessToolPath => base.ProcessToolPath ?? YarnTasks.YarnPath;
        public override Action<OutputType, string,List<ConsoleColor>> ProcessCustomLogger => base.ProcessCustomLogger ?? YarnTasks.YarnLogger;
        /// <summary>
        ///   List of packages to be installed.
        /// </summary>
        public virtual IReadOnlyList<string> Packages => PackagesInternal.AsReadOnly();
        internal List<string> PackagesInternal { get; set; } = new List<string>();
        /// <summary>
        ///   Format the output as an NDJSON stream
        /// </summary>
        public virtual bool? JSON { get; internal set; }
        /// <summary>
        ///   Don't use any semver modifier on the resolved range
        /// </summary>
        public virtual bool? Exact { get; internal set; }
        /// <summary>
        ///   Use the ~ semver modifier on the resolved range
        /// </summary>
        public virtual bool? Tilde { get; internal set; }
        /// <summary>
        ///   Use the ^ semver modifier on the resolved range
        /// </summary>
        public virtual bool? Caret { get; internal set; }
        /// <summary>
        ///   Add a package as a dev dependency
        /// </summary>
        public virtual bool? Dev { get; internal set; }
        /// <summary>
        ///   Add a package as a peer dependency
        /// </summary>
        public virtual bool? Peer { get; internal set; }
        /// <summary>
        ///   Add / upgrade a package to an optional regular / peer dependency
        /// </summary>
        public virtual bool? Optional { get; internal set; }
        /// <summary>
        ///   Add / upgrade a package to a dev dependency
        /// </summary>
        public virtual bool? PreferDev { get; internal set; }
        /// <summary>
        ///   Reuse the specified package from other workspaces in the project
        /// </summary>
        public virtual bool? Interactive { get; internal set; }
        /// <summary>
        ///   Reuse the highest version already used somewhere within the project
        /// </summary>
        public virtual bool? Cached { get; internal set; }
        /// <summary>
        ///   Change what artifacts installs generate
        /// </summary>
        public virtual YarnMode Mode { get; internal set; }
        protected override Arguments ConfigureProcessArguments(Arguments arguments)
        {
            arguments
              .Add("add")
              .Add("{value}", Packages)
              .Add("--json", JSON)
              .Add("--exact", Exact)
              .Add("--tilde", Tilde)
              .Add("--caret", Caret)
              .Add("--dev", Dev)
              .Add("--peer", Peer)
              .Add("--optional", Optional)
              .Add("--prefer-dev", PreferDev)
              .Add("--interactive", Interactive)
              .Add("--cached", Cached)
              .Add("--mode", Mode);
            return base.ConfigureProcessArguments(arguments);
        }
    }
    #endregion
    #region YarnRunSettings
    /// <summary>
    ///   Used within <see cref="YarnTasks"/>.
    /// </summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class YarnRunSettings : ToolSettings
    {
        /// <summary>
        ///   Path to the Yarn executable.
        /// </summary>
        public override string ProcessToolPath => base.ProcessToolPath ?? YarnTasks.YarnPath;
        public override Action<OutputType, string,List<ConsoleColor>> ProcessCustomLogger => base.ProcessCustomLogger ?? YarnTasks.YarnLogger;
        /// <summary>
        ///   Forwarded to the underlying Node process when executing a binary
        /// </summary>
        public virtual bool? Inspect { get; internal set; }
        /// <summary>
        ///   Forwarded to the underlying Node process when executing a binary
        /// </summary>
        public virtual bool? InspectBrk { get; internal set; }
        /// <summary>
        ///   Check the root workspace for scripts and/or binaries instead of the current one
        /// </summary>
        public virtual bool? TopLevel { get; internal set; }
        /// <summary>
        ///   Ignore any user defined scripts and only check for binaries
        /// </summary>
        public virtual bool? BinariesOnly { get; internal set; }
        /// <summary>
        ///   The command to be executed.
        /// </summary>
        public virtual string Command { get; internal set; }
        /// <summary>
        ///   Arguments passed to the script.
        /// </summary>
        public virtual IReadOnlyList<string> Arguments => ArgumentsInternal.AsReadOnly();
        internal List<string> ArgumentsInternal { get; set; } = new List<string>();
        protected override Arguments ConfigureProcessArguments(Arguments arguments)
        {
            arguments
              .Add("run")
              .Add("--inspect", Inspect)
              .Add("--inspect-brk", InspectBrk)
              .Add("--top-level", TopLevel)
              .Add("--binaries-only", BinariesOnly)
              .Add("{value}", Command)
              .Add("-- {value}", Arguments, separator: ' ');
            return base.ConfigureProcessArguments(arguments);
        }
    }
    #endregion
    #region YarnPackSettings
    /// <summary>
    ///   Used within <see cref="YarnTasks"/>.
    /// </summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class YarnPackSettings : ToolSettings
    {
        /// <summary>
        ///   Path to the Yarn executable.
        /// </summary>
        public override string ProcessToolPath => base.ProcessToolPath ?? YarnTasks.YarnPath;
        public override Action<OutputType, string,List<ConsoleColor>> ProcessCustomLogger => base.ProcessCustomLogger ?? YarnTasks.YarnLogger;
        /// <summary>
        ///   Run a preliminary yarn install if the package contains build scripts
        /// </summary>
        public virtual bool? InstallIfNeeded { get; internal set; }
        /// <summary>
        ///   Print the file paths without actually generating the package archive
        /// </summary>
        public virtual bool? DryRun { get; internal set; }
        /// <summary>
        ///   Format the output as an NDJSON stream
        /// </summary>
        public virtual bool? JSON { get; internal set; }
        /// <summary>
        ///   Create the archive at the specified path
        /// </summary>
        public virtual string Out { get; internal set; }
        protected override Arguments ConfigureProcessArguments(Arguments arguments)
        {
            arguments
              .Add("pack")
              .Add("--install-if-needed", InstallIfNeeded)
              .Add("--dry-run", DryRun)
              .Add("--json", JSON)
              .Add("--out", Out);
            return base.ConfigureProcessArguments(arguments);
        }
    }
    #endregion
    #region YarnInstallSettingsExtensions
    /// <summary>
    ///   Used within <see cref="YarnTasks"/>.
    /// </summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class YarnInstallSettingsExtensions
    {
        #region JSON
        /// <summary>
        ///   <p><em>Sets <see cref="YarnInstallSettings.JSON"/></em></p>
        ///   <p>Format the output as an NDJSON stream</p>
        /// </summary>
        [Pure]
        public static T SetJSON<T>(this T toolSettings, bool? json) where T : YarnInstallSettings
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.JSON = json;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="YarnInstallSettings.JSON"/></em></p>
        ///   <p>Format the output as an NDJSON stream</p>
        /// </summary>
        [Pure]
        public static T ResetJSON<T>(this T toolSettings) where T : YarnInstallSettings
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.JSON = null;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Enables <see cref="YarnInstallSettings.JSON"/></em></p>
        ///   <p>Format the output as an NDJSON stream</p>
        /// </summary>
        [Pure]
        public static T EnableJSON<T>(this T toolSettings) where T : YarnInstallSettings
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.JSON = true;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Disables <see cref="YarnInstallSettings.JSON"/></em></p>
        ///   <p>Format the output as an NDJSON stream</p>
        /// </summary>
        [Pure]
        public static T DisableJSON<T>(this T toolSettings) where T : YarnInstallSettings
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.JSON = false;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Toggles <see cref="YarnInstallSettings.JSON"/></em></p>
        ///   <p>Format the output as an NDJSON stream</p>
        /// </summary>
        [Pure]
        public static T ToggleJSON<T>(this T toolSettings) where T : YarnInstallSettings
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.JSON = !toolSettings.JSON;
            return toolSettings;
        }
        #endregion
        #region Immutable
        /// <summary>
        ///   <p><em>Sets <see cref="YarnInstallSettings.Immutable"/></em></p>
        ///   <p>Abort with an error exit code if the lockfile was to be modified</p>
        /// </summary>
        [Pure]
        public static T SetImmutable<T>(this T toolSettings, bool? immutable) where T : YarnInstallSettings
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Immutable = immutable;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="YarnInstallSettings.Immutable"/></em></p>
        ///   <p>Abort with an error exit code if the lockfile was to be modified</p>
        /// </summary>
        [Pure]
        public static T ResetImmutable<T>(this T toolSettings) where T : YarnInstallSettings
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Immutable = null;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Enables <see cref="YarnInstallSettings.Immutable"/></em></p>
        ///   <p>Abort with an error exit code if the lockfile was to be modified</p>
        /// </summary>
        [Pure]
        public static T EnableImmutable<T>(this T toolSettings) where T : YarnInstallSettings
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Immutable = true;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Disables <see cref="YarnInstallSettings.Immutable"/></em></p>
        ///   <p>Abort with an error exit code if the lockfile was to be modified</p>
        /// </summary>
        [Pure]
        public static T DisableImmutable<T>(this T toolSettings) where T : YarnInstallSettings
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Immutable = false;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Toggles <see cref="YarnInstallSettings.Immutable"/></em></p>
        ///   <p>Abort with an error exit code if the lockfile was to be modified</p>
        /// </summary>
        [Pure]
        public static T ToggleImmutable<T>(this T toolSettings) where T : YarnInstallSettings
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Immutable = !toolSettings.Immutable;
            return toolSettings;
        }
        #endregion
        #region WorkingDirectory
        /// <summary>
        ///   <p><em>Sets <see cref="YarnInstallSettings.WorkingDirectory"/></em></p>
        ///   <p>The directory to run the command in</p>
        /// </summary>
        [Pure]
        public static T SetWorkingDirectory<T>(this T toolSettings, string workingDirectory) where T : YarnInstallSettings
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.WorkingDirectory = workingDirectory;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="YarnInstallSettings.WorkingDirectory"/></em></p>
        ///   <p>The directory to run the command in</p>
        /// </summary>
        [Pure]
        public static T ResetWorkingDirectory<T>(this T toolSettings) where T : YarnInstallSettings
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.WorkingDirectory = null;
            return toolSettings;
        }
        #endregion
        #region ImmutableCache
        /// <summary>
        ///   <p><em>Sets <see cref="YarnInstallSettings.ImmutableCache"/></em></p>
        ///   <p>Abort with an error exit code if the cache folder was to be modified</p>
        /// </summary>
        [Pure]
        public static T SetImmutableCache<T>(this T toolSettings, bool? immutableCache) where T : YarnInstallSettings
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ImmutableCache = immutableCache;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="YarnInstallSettings.ImmutableCache"/></em></p>
        ///   <p>Abort with an error exit code if the cache folder was to be modified</p>
        /// </summary>
        [Pure]
        public static T ResetImmutableCache<T>(this T toolSettings) where T : YarnInstallSettings
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ImmutableCache = null;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Enables <see cref="YarnInstallSettings.ImmutableCache"/></em></p>
        ///   <p>Abort with an error exit code if the cache folder was to be modified</p>
        /// </summary>
        [Pure]
        public static T EnableImmutableCache<T>(this T toolSettings) where T : YarnInstallSettings
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ImmutableCache = true;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Disables <see cref="YarnInstallSettings.ImmutableCache"/></em></p>
        ///   <p>Abort with an error exit code if the cache folder was to be modified</p>
        /// </summary>
        [Pure]
        public static T DisableImmutableCache<T>(this T toolSettings) where T : YarnInstallSettings
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ImmutableCache = false;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Toggles <see cref="YarnInstallSettings.ImmutableCache"/></em></p>
        ///   <p>Abort with an error exit code if the cache folder was to be modified</p>
        /// </summary>
        [Pure]
        public static T ToggleImmutableCache<T>(this T toolSettings) where T : YarnInstallSettings
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ImmutableCache = !toolSettings.ImmutableCache;
            return toolSettings;
        }
        #endregion
        #region CheckCache
        /// <summary>
        ///   <p><em>Sets <see cref="YarnInstallSettings.CheckCache"/></em></p>
        ///   <p>Always refetch the packages and ensure that their checksums are consistent</p>
        /// </summary>
        [Pure]
        public static T SetCheckCache<T>(this T toolSettings, bool? checkCache) where T : YarnInstallSettings
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.CheckCache = checkCache;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="YarnInstallSettings.CheckCache"/></em></p>
        ///   <p>Always refetch the packages and ensure that their checksums are consistent</p>
        /// </summary>
        [Pure]
        public static T ResetCheckCache<T>(this T toolSettings) where T : YarnInstallSettings
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.CheckCache = null;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Enables <see cref="YarnInstallSettings.CheckCache"/></em></p>
        ///   <p>Always refetch the packages and ensure that their checksums are consistent</p>
        /// </summary>
        [Pure]
        public static T EnableCheckCache<T>(this T toolSettings) where T : YarnInstallSettings
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.CheckCache = true;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Disables <see cref="YarnInstallSettings.CheckCache"/></em></p>
        ///   <p>Always refetch the packages and ensure that their checksums are consistent</p>
        /// </summary>
        [Pure]
        public static T DisableCheckCache<T>(this T toolSettings) where T : YarnInstallSettings
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.CheckCache = false;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Toggles <see cref="YarnInstallSettings.CheckCache"/></em></p>
        ///   <p>Always refetch the packages and ensure that their checksums are consistent</p>
        /// </summary>
        [Pure]
        public static T ToggleCheckCache<T>(this T toolSettings) where T : YarnInstallSettings
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.CheckCache = !toolSettings.CheckCache;
            return toolSettings;
        }
        #endregion
        #region InlineBuilds
        /// <summary>
        ///   <p><em>Sets <see cref="YarnInstallSettings.InlineBuilds"/></em></p>
        ///   <p>Verbosely print the output of the build steps of dependencies</p>
        /// </summary>
        [Pure]
        public static T SetInlineBuilds<T>(this T toolSettings, bool? inlineBuilds) where T : YarnInstallSettings
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.InlineBuilds = inlineBuilds;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="YarnInstallSettings.InlineBuilds"/></em></p>
        ///   <p>Verbosely print the output of the build steps of dependencies</p>
        /// </summary>
        [Pure]
        public static T ResetInlineBuilds<T>(this T toolSettings) where T : YarnInstallSettings
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.InlineBuilds = null;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Enables <see cref="YarnInstallSettings.InlineBuilds"/></em></p>
        ///   <p>Verbosely print the output of the build steps of dependencies</p>
        /// </summary>
        [Pure]
        public static T EnableInlineBuilds<T>(this T toolSettings) where T : YarnInstallSettings
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.InlineBuilds = true;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Disables <see cref="YarnInstallSettings.InlineBuilds"/></em></p>
        ///   <p>Verbosely print the output of the build steps of dependencies</p>
        /// </summary>
        [Pure]
        public static T DisableInlineBuilds<T>(this T toolSettings) where T : YarnInstallSettings
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.InlineBuilds = false;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Toggles <see cref="YarnInstallSettings.InlineBuilds"/></em></p>
        ///   <p>Verbosely print the output of the build steps of dependencies</p>
        /// </summary>
        [Pure]
        public static T ToggleInlineBuilds<T>(this T toolSettings) where T : YarnInstallSettings
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.InlineBuilds = !toolSettings.InlineBuilds;
            return toolSettings;
        }
        #endregion
        #region Mode
        /// <summary>
        ///   <p><em>Sets <see cref="YarnInstallSettings.Mode"/></em></p>
        ///   <p>Change what artifacts installs generate</p>
        /// </summary>
        [Pure]
        public static T SetMode<T>(this T toolSettings, YarnMode mode) where T : YarnInstallSettings
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Mode = mode;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="YarnInstallSettings.Mode"/></em></p>
        ///   <p>Change what artifacts installs generate</p>
        /// </summary>
        [Pure]
        public static T ResetMode<T>(this T toolSettings) where T : YarnInstallSettings
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Mode = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region YarnAddSettingsExtensions
    /// <summary>
    ///   Used within <see cref="YarnTasks"/>.
    /// </summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class YarnAddSettingsExtensions
    {
        #region Packages
        /// <summary>
        ///   <p><em>Sets <see cref="YarnAddSettings.Packages"/> to a new list</em></p>
        ///   <p>List of packages to be installed.</p>
        /// </summary>
        [Pure]
        public static T SetPackages<T>(this T toolSettings, params string[] packages) where T : YarnAddSettings
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.PackagesInternal = packages.ToList();
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Sets <see cref="YarnAddSettings.Packages"/> to a new list</em></p>
        ///   <p>List of packages to be installed.</p>
        /// </summary>
        [Pure]
        public static T SetPackages<T>(this T toolSettings, IEnumerable<string> packages) where T : YarnAddSettings
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.PackagesInternal = packages.ToList();
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Adds values to <see cref="YarnAddSettings.Packages"/></em></p>
        ///   <p>List of packages to be installed.</p>
        /// </summary>
        [Pure]
        public static T AddPackages<T>(this T toolSettings, params string[] packages) where T : YarnAddSettings
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.PackagesInternal.AddRange(packages);
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Adds values to <see cref="YarnAddSettings.Packages"/></em></p>
        ///   <p>List of packages to be installed.</p>
        /// </summary>
        [Pure]
        public static T AddPackages<T>(this T toolSettings, IEnumerable<string> packages) where T : YarnAddSettings
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.PackagesInternal.AddRange(packages);
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Clears <see cref="YarnAddSettings.Packages"/></em></p>
        ///   <p>List of packages to be installed.</p>
        /// </summary>
        [Pure]
        public static T ClearPackages<T>(this T toolSettings) where T : YarnAddSettings
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.PackagesInternal.Clear();
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Removes values from <see cref="YarnAddSettings.Packages"/></em></p>
        ///   <p>List of packages to be installed.</p>
        /// </summary>
        [Pure]
        public static T RemovePackages<T>(this T toolSettings, params string[] packages) where T : YarnAddSettings
        {
            toolSettings = toolSettings.NewInstance();
            var hashSet = new HashSet<string>(packages);
            toolSettings.PackagesInternal.RemoveAll(x => hashSet.Contains(x));
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Removes values from <see cref="YarnAddSettings.Packages"/></em></p>
        ///   <p>List of packages to be installed.</p>
        /// </summary>
        [Pure]
        public static T RemovePackages<T>(this T toolSettings, IEnumerable<string> packages) where T : YarnAddSettings
        {
            toolSettings = toolSettings.NewInstance();
            var hashSet = new HashSet<string>(packages);
            toolSettings.PackagesInternal.RemoveAll(x => hashSet.Contains(x));
            return toolSettings;
        }
        #endregion
        #region JSON
        /// <summary>
        ///   <p><em>Sets <see cref="YarnAddSettings.JSON"/></em></p>
        ///   <p>Format the output as an NDJSON stream</p>
        /// </summary>
        [Pure]
        public static T SetJSON<T>(this T toolSettings, bool? json) where T : YarnAddSettings
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.JSON = json;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="YarnAddSettings.JSON"/></em></p>
        ///   <p>Format the output as an NDJSON stream</p>
        /// </summary>
        [Pure]
        public static T ResetJSON<T>(this T toolSettings) where T : YarnAddSettings
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.JSON = null;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Enables <see cref="YarnAddSettings.JSON"/></em></p>
        ///   <p>Format the output as an NDJSON stream</p>
        /// </summary>
        [Pure]
        public static T EnableJSON<T>(this T toolSettings) where T : YarnAddSettings
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.JSON = true;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Disables <see cref="YarnAddSettings.JSON"/></em></p>
        ///   <p>Format the output as an NDJSON stream</p>
        /// </summary>
        [Pure]
        public static T DisableJSON<T>(this T toolSettings) where T : YarnAddSettings
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.JSON = false;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Toggles <see cref="YarnAddSettings.JSON"/></em></p>
        ///   <p>Format the output as an NDJSON stream</p>
        /// </summary>
        [Pure]
        public static T ToggleJSON<T>(this T toolSettings) where T : YarnAddSettings
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.JSON = !toolSettings.JSON;
            return toolSettings;
        }
        #endregion
        #region Exact
        /// <summary>
        ///   <p><em>Sets <see cref="YarnAddSettings.Exact"/></em></p>
        ///   <p>Don't use any semver modifier on the resolved range</p>
        /// </summary>
        [Pure]
        public static T SetExact<T>(this T toolSettings, bool? exact) where T : YarnAddSettings
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Exact = exact;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="YarnAddSettings.Exact"/></em></p>
        ///   <p>Don't use any semver modifier on the resolved range</p>
        /// </summary>
        [Pure]
        public static T ResetExact<T>(this T toolSettings) where T : YarnAddSettings
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Exact = null;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Enables <see cref="YarnAddSettings.Exact"/></em></p>
        ///   <p>Don't use any semver modifier on the resolved range</p>
        /// </summary>
        [Pure]
        public static T EnableExact<T>(this T toolSettings) where T : YarnAddSettings
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Exact = true;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Disables <see cref="YarnAddSettings.Exact"/></em></p>
        ///   <p>Don't use any semver modifier on the resolved range</p>
        /// </summary>
        [Pure]
        public static T DisableExact<T>(this T toolSettings) where T : YarnAddSettings
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Exact = false;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Toggles <see cref="YarnAddSettings.Exact"/></em></p>
        ///   <p>Don't use any semver modifier on the resolved range</p>
        /// </summary>
        [Pure]
        public static T ToggleExact<T>(this T toolSettings) where T : YarnAddSettings
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Exact = !toolSettings.Exact;
            return toolSettings;
        }
        #endregion
        #region Tilde
        /// <summary>
        ///   <p><em>Sets <see cref="YarnAddSettings.Tilde"/></em></p>
        ///   <p>Use the ~ semver modifier on the resolved range</p>
        /// </summary>
        [Pure]
        public static T SetTilde<T>(this T toolSettings, bool? tilde) where T : YarnAddSettings
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Tilde = tilde;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="YarnAddSettings.Tilde"/></em></p>
        ///   <p>Use the ~ semver modifier on the resolved range</p>
        /// </summary>
        [Pure]
        public static T ResetTilde<T>(this T toolSettings) where T : YarnAddSettings
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Tilde = null;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Enables <see cref="YarnAddSettings.Tilde"/></em></p>
        ///   <p>Use the ~ semver modifier on the resolved range</p>
        /// </summary>
        [Pure]
        public static T EnableTilde<T>(this T toolSettings) where T : YarnAddSettings
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Tilde = true;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Disables <see cref="YarnAddSettings.Tilde"/></em></p>
        ///   <p>Use the ~ semver modifier on the resolved range</p>
        /// </summary>
        [Pure]
        public static T DisableTilde<T>(this T toolSettings) where T : YarnAddSettings
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Tilde = false;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Toggles <see cref="YarnAddSettings.Tilde"/></em></p>
        ///   <p>Use the ~ semver modifier on the resolved range</p>
        /// </summary>
        [Pure]
        public static T ToggleTilde<T>(this T toolSettings) where T : YarnAddSettings
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Tilde = !toolSettings.Tilde;
            return toolSettings;
        }
        #endregion
        #region Caret
        /// <summary>
        ///   <p><em>Sets <see cref="YarnAddSettings.Caret"/></em></p>
        ///   <p>Use the ^ semver modifier on the resolved range</p>
        /// </summary>
        [Pure]
        public static T SetCaret<T>(this T toolSettings, bool? caret) where T : YarnAddSettings
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Caret = caret;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="YarnAddSettings.Caret"/></em></p>
        ///   <p>Use the ^ semver modifier on the resolved range</p>
        /// </summary>
        [Pure]
        public static T ResetCaret<T>(this T toolSettings) where T : YarnAddSettings
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Caret = null;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Enables <see cref="YarnAddSettings.Caret"/></em></p>
        ///   <p>Use the ^ semver modifier on the resolved range</p>
        /// </summary>
        [Pure]
        public static T EnableCaret<T>(this T toolSettings) where T : YarnAddSettings
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Caret = true;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Disables <see cref="YarnAddSettings.Caret"/></em></p>
        ///   <p>Use the ^ semver modifier on the resolved range</p>
        /// </summary>
        [Pure]
        public static T DisableCaret<T>(this T toolSettings) where T : YarnAddSettings
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Caret = false;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Toggles <see cref="YarnAddSettings.Caret"/></em></p>
        ///   <p>Use the ^ semver modifier on the resolved range</p>
        /// </summary>
        [Pure]
        public static T ToggleCaret<T>(this T toolSettings) where T : YarnAddSettings
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Caret = !toolSettings.Caret;
            return toolSettings;
        }
        #endregion
        #region Dev
        /// <summary>
        ///   <p><em>Sets <see cref="YarnAddSettings.Dev"/></em></p>
        ///   <p>Add a package as a dev dependency</p>
        /// </summary>
        [Pure]
        public static T SetDev<T>(this T toolSettings, bool? dev) where T : YarnAddSettings
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Dev = dev;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="YarnAddSettings.Dev"/></em></p>
        ///   <p>Add a package as a dev dependency</p>
        /// </summary>
        [Pure]
        public static T ResetDev<T>(this T toolSettings) where T : YarnAddSettings
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Dev = null;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Enables <see cref="YarnAddSettings.Dev"/></em></p>
        ///   <p>Add a package as a dev dependency</p>
        /// </summary>
        [Pure]
        public static T EnableDev<T>(this T toolSettings) where T : YarnAddSettings
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Dev = true;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Disables <see cref="YarnAddSettings.Dev"/></em></p>
        ///   <p>Add a package as a dev dependency</p>
        /// </summary>
        [Pure]
        public static T DisableDev<T>(this T toolSettings) where T : YarnAddSettings
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Dev = false;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Toggles <see cref="YarnAddSettings.Dev"/></em></p>
        ///   <p>Add a package as a dev dependency</p>
        /// </summary>
        [Pure]
        public static T ToggleDev<T>(this T toolSettings) where T : YarnAddSettings
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Dev = !toolSettings.Dev;
            return toolSettings;
        }
        #endregion
        #region Peer
        /// <summary>
        ///   <p><em>Sets <see cref="YarnAddSettings.Peer"/></em></p>
        ///   <p>Add a package as a peer dependency</p>
        /// </summary>
        [Pure]
        public static T SetPeer<T>(this T toolSettings, bool? peer) where T : YarnAddSettings
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Peer = peer;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="YarnAddSettings.Peer"/></em></p>
        ///   <p>Add a package as a peer dependency</p>
        /// </summary>
        [Pure]
        public static T ResetPeer<T>(this T toolSettings) where T : YarnAddSettings
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Peer = null;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Enables <see cref="YarnAddSettings.Peer"/></em></p>
        ///   <p>Add a package as a peer dependency</p>
        /// </summary>
        [Pure]
        public static T EnablePeer<T>(this T toolSettings) where T : YarnAddSettings
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Peer = true;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Disables <see cref="YarnAddSettings.Peer"/></em></p>
        ///   <p>Add a package as a peer dependency</p>
        /// </summary>
        [Pure]
        public static T DisablePeer<T>(this T toolSettings) where T : YarnAddSettings
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Peer = false;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Toggles <see cref="YarnAddSettings.Peer"/></em></p>
        ///   <p>Add a package as a peer dependency</p>
        /// </summary>
        [Pure]
        public static T TogglePeer<T>(this T toolSettings) where T : YarnAddSettings
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Peer = !toolSettings.Peer;
            return toolSettings;
        }
        #endregion
        #region Optional
        /// <summary>
        ///   <p><em>Sets <see cref="YarnAddSettings.Optional"/></em></p>
        ///   <p>Add / upgrade a package to an optional regular / peer dependency</p>
        /// </summary>
        [Pure]
        public static T SetOptional<T>(this T toolSettings, bool? optional) where T : YarnAddSettings
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Optional = optional;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="YarnAddSettings.Optional"/></em></p>
        ///   <p>Add / upgrade a package to an optional regular / peer dependency</p>
        /// </summary>
        [Pure]
        public static T ResetOptional<T>(this T toolSettings) where T : YarnAddSettings
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Optional = null;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Enables <see cref="YarnAddSettings.Optional"/></em></p>
        ///   <p>Add / upgrade a package to an optional regular / peer dependency</p>
        /// </summary>
        [Pure]
        public static T EnableOptional<T>(this T toolSettings) where T : YarnAddSettings
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Optional = true;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Disables <see cref="YarnAddSettings.Optional"/></em></p>
        ///   <p>Add / upgrade a package to an optional regular / peer dependency</p>
        /// </summary>
        [Pure]
        public static T DisableOptional<T>(this T toolSettings) where T : YarnAddSettings
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Optional = false;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Toggles <see cref="YarnAddSettings.Optional"/></em></p>
        ///   <p>Add / upgrade a package to an optional regular / peer dependency</p>
        /// </summary>
        [Pure]
        public static T ToggleOptional<T>(this T toolSettings) where T : YarnAddSettings
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Optional = !toolSettings.Optional;
            return toolSettings;
        }
        #endregion
        #region PreferDev
        /// <summary>
        ///   <p><em>Sets <see cref="YarnAddSettings.PreferDev"/></em></p>
        ///   <p>Add / upgrade a package to a dev dependency</p>
        /// </summary>
        [Pure]
        public static T SetPreferDev<T>(this T toolSettings, bool? preferDev) where T : YarnAddSettings
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.PreferDev = preferDev;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="YarnAddSettings.PreferDev"/></em></p>
        ///   <p>Add / upgrade a package to a dev dependency</p>
        /// </summary>
        [Pure]
        public static T ResetPreferDev<T>(this T toolSettings) where T : YarnAddSettings
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.PreferDev = null;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Enables <see cref="YarnAddSettings.PreferDev"/></em></p>
        ///   <p>Add / upgrade a package to a dev dependency</p>
        /// </summary>
        [Pure]
        public static T EnablePreferDev<T>(this T toolSettings) where T : YarnAddSettings
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.PreferDev = true;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Disables <see cref="YarnAddSettings.PreferDev"/></em></p>
        ///   <p>Add / upgrade a package to a dev dependency</p>
        /// </summary>
        [Pure]
        public static T DisablePreferDev<T>(this T toolSettings) where T : YarnAddSettings
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.PreferDev = false;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Toggles <see cref="YarnAddSettings.PreferDev"/></em></p>
        ///   <p>Add / upgrade a package to a dev dependency</p>
        /// </summary>
        [Pure]
        public static T TogglePreferDev<T>(this T toolSettings) where T : YarnAddSettings
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.PreferDev = !toolSettings.PreferDev;
            return toolSettings;
        }
        #endregion
        #region Interactive
        /// <summary>
        ///   <p><em>Sets <see cref="YarnAddSettings.Interactive"/></em></p>
        ///   <p>Reuse the specified package from other workspaces in the project</p>
        /// </summary>
        [Pure]
        public static T SetInteractive<T>(this T toolSettings, bool? interactive) where T : YarnAddSettings
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Interactive = interactive;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="YarnAddSettings.Interactive"/></em></p>
        ///   <p>Reuse the specified package from other workspaces in the project</p>
        /// </summary>
        [Pure]
        public static T ResetInteractive<T>(this T toolSettings) where T : YarnAddSettings
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Interactive = null;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Enables <see cref="YarnAddSettings.Interactive"/></em></p>
        ///   <p>Reuse the specified package from other workspaces in the project</p>
        /// </summary>
        [Pure]
        public static T EnableInteractive<T>(this T toolSettings) where T : YarnAddSettings
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Interactive = true;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Disables <see cref="YarnAddSettings.Interactive"/></em></p>
        ///   <p>Reuse the specified package from other workspaces in the project</p>
        /// </summary>
        [Pure]
        public static T DisableInteractive<T>(this T toolSettings) where T : YarnAddSettings
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Interactive = false;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Toggles <see cref="YarnAddSettings.Interactive"/></em></p>
        ///   <p>Reuse the specified package from other workspaces in the project</p>
        /// </summary>
        [Pure]
        public static T ToggleInteractive<T>(this T toolSettings) where T : YarnAddSettings
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Interactive = !toolSettings.Interactive;
            return toolSettings;
        }
        #endregion
        #region Cached
        /// <summary>
        ///   <p><em>Sets <see cref="YarnAddSettings.Cached"/></em></p>
        ///   <p>Reuse the highest version already used somewhere within the project</p>
        /// </summary>
        [Pure]
        public static T SetCached<T>(this T toolSettings, bool? cached) where T : YarnAddSettings
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Cached = cached;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="YarnAddSettings.Cached"/></em></p>
        ///   <p>Reuse the highest version already used somewhere within the project</p>
        /// </summary>
        [Pure]
        public static T ResetCached<T>(this T toolSettings) where T : YarnAddSettings
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Cached = null;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Enables <see cref="YarnAddSettings.Cached"/></em></p>
        ///   <p>Reuse the highest version already used somewhere within the project</p>
        /// </summary>
        [Pure]
        public static T EnableCached<T>(this T toolSettings) where T : YarnAddSettings
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Cached = true;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Disables <see cref="YarnAddSettings.Cached"/></em></p>
        ///   <p>Reuse the highest version already used somewhere within the project</p>
        /// </summary>
        [Pure]
        public static T DisableCached<T>(this T toolSettings) where T : YarnAddSettings
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Cached = false;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Toggles <see cref="YarnAddSettings.Cached"/></em></p>
        ///   <p>Reuse the highest version already used somewhere within the project</p>
        /// </summary>
        [Pure]
        public static T ToggleCached<T>(this T toolSettings) where T : YarnAddSettings
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Cached = !toolSettings.Cached;
            return toolSettings;
        }
        #endregion
        #region Mode
        /// <summary>
        ///   <p><em>Sets <see cref="YarnAddSettings.Mode"/></em></p>
        ///   <p>Change what artifacts installs generate</p>
        /// </summary>
        [Pure]
        public static T SetMode<T>(this T toolSettings, YarnMode mode) where T : YarnAddSettings
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Mode = mode;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="YarnAddSettings.Mode"/></em></p>
        ///   <p>Change what artifacts installs generate</p>
        /// </summary>
        [Pure]
        public static T ResetMode<T>(this T toolSettings) where T : YarnAddSettings
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Mode = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region YarnRunSettingsExtensions
    /// <summary>
    ///   Used within <see cref="YarnTasks"/>.
    /// </summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class YarnRunSettingsExtensions
    {
        #region Inspect
        /// <summary>
        ///   <p><em>Sets <see cref="YarnRunSettings.Inspect"/></em></p>
        ///   <p>Forwarded to the underlying Node process when executing a binary</p>
        /// </summary>
        [Pure]
        public static T SetInspect<T>(this T toolSettings, bool? inspect) where T : YarnRunSettings
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Inspect = inspect;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="YarnRunSettings.Inspect"/></em></p>
        ///   <p>Forwarded to the underlying Node process when executing a binary</p>
        /// </summary>
        [Pure]
        public static T ResetInspect<T>(this T toolSettings) where T : YarnRunSettings
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Inspect = null;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Enables <see cref="YarnRunSettings.Inspect"/></em></p>
        ///   <p>Forwarded to the underlying Node process when executing a binary</p>
        /// </summary>
        [Pure]
        public static T EnableInspect<T>(this T toolSettings) where T : YarnRunSettings
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Inspect = true;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Disables <see cref="YarnRunSettings.Inspect"/></em></p>
        ///   <p>Forwarded to the underlying Node process when executing a binary</p>
        /// </summary>
        [Pure]
        public static T DisableInspect<T>(this T toolSettings) where T : YarnRunSettings
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Inspect = false;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Toggles <see cref="YarnRunSettings.Inspect"/></em></p>
        ///   <p>Forwarded to the underlying Node process when executing a binary</p>
        /// </summary>
        [Pure]
        public static T ToggleInspect<T>(this T toolSettings) where T : YarnRunSettings
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Inspect = !toolSettings.Inspect;
            return toolSettings;
        }
        #endregion
        #region InspectBrk
        /// <summary>
        ///   <p><em>Sets <see cref="YarnRunSettings.InspectBrk"/></em></p>
        ///   <p>Forwarded to the underlying Node process when executing a binary</p>
        /// </summary>
        [Pure]
        public static T SetInspectBrk<T>(this T toolSettings, bool? inspectBrk) where T : YarnRunSettings
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.InspectBrk = inspectBrk;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="YarnRunSettings.InspectBrk"/></em></p>
        ///   <p>Forwarded to the underlying Node process when executing a binary</p>
        /// </summary>
        [Pure]
        public static T ResetInspectBrk<T>(this T toolSettings) where T : YarnRunSettings
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.InspectBrk = null;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Enables <see cref="YarnRunSettings.InspectBrk"/></em></p>
        ///   <p>Forwarded to the underlying Node process when executing a binary</p>
        /// </summary>
        [Pure]
        public static T EnableInspectBrk<T>(this T toolSettings) where T : YarnRunSettings
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.InspectBrk = true;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Disables <see cref="YarnRunSettings.InspectBrk"/></em></p>
        ///   <p>Forwarded to the underlying Node process when executing a binary</p>
        /// </summary>
        [Pure]
        public static T DisableInspectBrk<T>(this T toolSettings) where T : YarnRunSettings
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.InspectBrk = false;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Toggles <see cref="YarnRunSettings.InspectBrk"/></em></p>
        ///   <p>Forwarded to the underlying Node process when executing a binary</p>
        /// </summary>
        [Pure]
        public static T ToggleInspectBrk<T>(this T toolSettings) where T : YarnRunSettings
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.InspectBrk = !toolSettings.InspectBrk;
            return toolSettings;
        }
        #endregion
        #region TopLevel
        /// <summary>
        ///   <p><em>Sets <see cref="YarnRunSettings.TopLevel"/></em></p>
        ///   <p>Check the root workspace for scripts and/or binaries instead of the current one</p>
        /// </summary>
        [Pure]
        public static T SetTopLevel<T>(this T toolSettings, bool? topLevel) where T : YarnRunSettings
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.TopLevel = topLevel;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="YarnRunSettings.TopLevel"/></em></p>
        ///   <p>Check the root workspace for scripts and/or binaries instead of the current one</p>
        /// </summary>
        [Pure]
        public static T ResetTopLevel<T>(this T toolSettings) where T : YarnRunSettings
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.TopLevel = null;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Enables <see cref="YarnRunSettings.TopLevel"/></em></p>
        ///   <p>Check the root workspace for scripts and/or binaries instead of the current one</p>
        /// </summary>
        [Pure]
        public static T EnableTopLevel<T>(this T toolSettings) where T : YarnRunSettings
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.TopLevel = true;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Disables <see cref="YarnRunSettings.TopLevel"/></em></p>
        ///   <p>Check the root workspace for scripts and/or binaries instead of the current one</p>
        /// </summary>
        [Pure]
        public static T DisableTopLevel<T>(this T toolSettings) where T : YarnRunSettings
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.TopLevel = false;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Toggles <see cref="YarnRunSettings.TopLevel"/></em></p>
        ///   <p>Check the root workspace for scripts and/or binaries instead of the current one</p>
        /// </summary>
        [Pure]
        public static T ToggleTopLevel<T>(this T toolSettings) where T : YarnRunSettings
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.TopLevel = !toolSettings.TopLevel;
            return toolSettings;
        }
        #endregion
        #region BinariesOnly
        /// <summary>
        ///   <p><em>Sets <see cref="YarnRunSettings.BinariesOnly"/></em></p>
        ///   <p>Ignore any user defined scripts and only check for binaries</p>
        /// </summary>
        [Pure]
        public static T SetBinariesOnly<T>(this T toolSettings, bool? binariesOnly) where T : YarnRunSettings
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.BinariesOnly = binariesOnly;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="YarnRunSettings.BinariesOnly"/></em></p>
        ///   <p>Ignore any user defined scripts and only check for binaries</p>
        /// </summary>
        [Pure]
        public static T ResetBinariesOnly<T>(this T toolSettings) where T : YarnRunSettings
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.BinariesOnly = null;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Enables <see cref="YarnRunSettings.BinariesOnly"/></em></p>
        ///   <p>Ignore any user defined scripts and only check for binaries</p>
        /// </summary>
        [Pure]
        public static T EnableBinariesOnly<T>(this T toolSettings) where T : YarnRunSettings
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.BinariesOnly = true;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Disables <see cref="YarnRunSettings.BinariesOnly"/></em></p>
        ///   <p>Ignore any user defined scripts and only check for binaries</p>
        /// </summary>
        [Pure]
        public static T DisableBinariesOnly<T>(this T toolSettings) where T : YarnRunSettings
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.BinariesOnly = false;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Toggles <see cref="YarnRunSettings.BinariesOnly"/></em></p>
        ///   <p>Ignore any user defined scripts and only check for binaries</p>
        /// </summary>
        [Pure]
        public static T ToggleBinariesOnly<T>(this T toolSettings) where T : YarnRunSettings
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.BinariesOnly = !toolSettings.BinariesOnly;
            return toolSettings;
        }
        #endregion
        #region Command
        /// <summary>
        ///   <p><em>Sets <see cref="YarnRunSettings.Command"/></em></p>
        ///   <p>The command to be executed.</p>
        /// </summary>
        [Pure]
        public static T SetCommand<T>(this T toolSettings, string command) where T : YarnRunSettings
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Command = command;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="YarnRunSettings.Command"/></em></p>
        ///   <p>The command to be executed.</p>
        /// </summary>
        [Pure]
        public static T ResetCommand<T>(this T toolSettings) where T : YarnRunSettings
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Command = null;
            return toolSettings;
        }
        #endregion
        #region Arguments
        /// <summary>
        ///   <p><em>Sets <see cref="YarnRunSettings.Arguments"/> to a new list</em></p>
        ///   <p>Arguments passed to the script.</p>
        /// </summary>
        [Pure]
        public static T SetArguments<T>(this T toolSettings, params string[] arguments) where T : YarnRunSettings
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ArgumentsInternal = arguments.ToList();
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Sets <see cref="YarnRunSettings.Arguments"/> to a new list</em></p>
        ///   <p>Arguments passed to the script.</p>
        /// </summary>
        [Pure]
        public static T SetArguments<T>(this T toolSettings, IEnumerable<string> arguments) where T : YarnRunSettings
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ArgumentsInternal = arguments.ToList();
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Adds values to <see cref="YarnRunSettings.Arguments"/></em></p>
        ///   <p>Arguments passed to the script.</p>
        /// </summary>
        [Pure]
        public static T AddArguments<T>(this T toolSettings, params string[] arguments) where T : YarnRunSettings
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ArgumentsInternal.AddRange(arguments);
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Adds values to <see cref="YarnRunSettings.Arguments"/></em></p>
        ///   <p>Arguments passed to the script.</p>
        /// </summary>
        [Pure]
        public static T AddArguments<T>(this T toolSettings, IEnumerable<string> arguments) where T : YarnRunSettings
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ArgumentsInternal.AddRange(arguments);
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Clears <see cref="YarnRunSettings.Arguments"/></em></p>
        ///   <p>Arguments passed to the script.</p>
        /// </summary>
        [Pure]
        public static T ClearArguments<T>(this T toolSettings) where T : YarnRunSettings
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ArgumentsInternal.Clear();
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Removes values from <see cref="YarnRunSettings.Arguments"/></em></p>
        ///   <p>Arguments passed to the script.</p>
        /// </summary>
        [Pure]
        public static T RemoveArguments<T>(this T toolSettings, params string[] arguments) where T : YarnRunSettings
        {
            toolSettings = toolSettings.NewInstance();
            var hashSet = new HashSet<string>(arguments);
            toolSettings.ArgumentsInternal.RemoveAll(x => hashSet.Contains(x));
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Removes values from <see cref="YarnRunSettings.Arguments"/></em></p>
        ///   <p>Arguments passed to the script.</p>
        /// </summary>
        [Pure]
        public static T RemoveArguments<T>(this T toolSettings, IEnumerable<string> arguments) where T : YarnRunSettings
        {
            toolSettings = toolSettings.NewInstance();
            var hashSet = new HashSet<string>(arguments);
            toolSettings.ArgumentsInternal.RemoveAll(x => hashSet.Contains(x));
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region YarnPackSettingsExtensions
    /// <summary>
    ///   Used within <see cref="YarnTasks"/>.
    /// </summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class YarnPackSettingsExtensions
    {
        #region InstallIfNeeded
        /// <summary>
        ///   <p><em>Sets <see cref="YarnPackSettings.InstallIfNeeded"/></em></p>
        ///   <p>Run a preliminary yarn install if the package contains build scripts</p>
        /// </summary>
        [Pure]
        public static T SetInstallIfNeeded<T>(this T toolSettings, bool? installIfNeeded) where T : YarnPackSettings
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.InstallIfNeeded = installIfNeeded;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="YarnPackSettings.InstallIfNeeded"/></em></p>
        ///   <p>Run a preliminary yarn install if the package contains build scripts</p>
        /// </summary>
        [Pure]
        public static T ResetInstallIfNeeded<T>(this T toolSettings) where T : YarnPackSettings
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.InstallIfNeeded = null;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Enables <see cref="YarnPackSettings.InstallIfNeeded"/></em></p>
        ///   <p>Run a preliminary yarn install if the package contains build scripts</p>
        /// </summary>
        [Pure]
        public static T EnableInstallIfNeeded<T>(this T toolSettings) where T : YarnPackSettings
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.InstallIfNeeded = true;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Disables <see cref="YarnPackSettings.InstallIfNeeded"/></em></p>
        ///   <p>Run a preliminary yarn install if the package contains build scripts</p>
        /// </summary>
        [Pure]
        public static T DisableInstallIfNeeded<T>(this T toolSettings) where T : YarnPackSettings
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.InstallIfNeeded = false;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Toggles <see cref="YarnPackSettings.InstallIfNeeded"/></em></p>
        ///   <p>Run a preliminary yarn install if the package contains build scripts</p>
        /// </summary>
        [Pure]
        public static T ToggleInstallIfNeeded<T>(this T toolSettings) where T : YarnPackSettings
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.InstallIfNeeded = !toolSettings.InstallIfNeeded;
            return toolSettings;
        }
        #endregion
        #region DryRun
        /// <summary>
        ///   <p><em>Sets <see cref="YarnPackSettings.DryRun"/></em></p>
        ///   <p>Print the file paths without actually generating the package archive</p>
        /// </summary>
        [Pure]
        public static T SetDryRun<T>(this T toolSettings, bool? dryRun) where T : YarnPackSettings
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.DryRun = dryRun;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="YarnPackSettings.DryRun"/></em></p>
        ///   <p>Print the file paths without actually generating the package archive</p>
        /// </summary>
        [Pure]
        public static T ResetDryRun<T>(this T toolSettings) where T : YarnPackSettings
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.DryRun = null;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Enables <see cref="YarnPackSettings.DryRun"/></em></p>
        ///   <p>Print the file paths without actually generating the package archive</p>
        /// </summary>
        [Pure]
        public static T EnableDryRun<T>(this T toolSettings) where T : YarnPackSettings
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.DryRun = true;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Disables <see cref="YarnPackSettings.DryRun"/></em></p>
        ///   <p>Print the file paths without actually generating the package archive</p>
        /// </summary>
        [Pure]
        public static T DisableDryRun<T>(this T toolSettings) where T : YarnPackSettings
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.DryRun = false;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Toggles <see cref="YarnPackSettings.DryRun"/></em></p>
        ///   <p>Print the file paths without actually generating the package archive</p>
        /// </summary>
        [Pure]
        public static T ToggleDryRun<T>(this T toolSettings) where T : YarnPackSettings
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.DryRun = !toolSettings.DryRun;
            return toolSettings;
        }
        #endregion
        #region JSON
        /// <summary>
        ///   <p><em>Sets <see cref="YarnPackSettings.JSON"/></em></p>
        ///   <p>Format the output as an NDJSON stream</p>
        /// </summary>
        [Pure]
        public static T SetJSON<T>(this T toolSettings, bool? json) where T : YarnPackSettings
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.JSON = json;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="YarnPackSettings.JSON"/></em></p>
        ///   <p>Format the output as an NDJSON stream</p>
        /// </summary>
        [Pure]
        public static T ResetJSON<T>(this T toolSettings) where T : YarnPackSettings
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.JSON = null;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Enables <see cref="YarnPackSettings.JSON"/></em></p>
        ///   <p>Format the output as an NDJSON stream</p>
        /// </summary>
        [Pure]
        public static T EnableJSON<T>(this T toolSettings) where T : YarnPackSettings
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.JSON = true;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Disables <see cref="YarnPackSettings.JSON"/></em></p>
        ///   <p>Format the output as an NDJSON stream</p>
        /// </summary>
        [Pure]
        public static T DisableJSON<T>(this T toolSettings) where T : YarnPackSettings
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.JSON = false;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Toggles <see cref="YarnPackSettings.JSON"/></em></p>
        ///   <p>Format the output as an NDJSON stream</p>
        /// </summary>
        [Pure]
        public static T ToggleJSON<T>(this T toolSettings) where T : YarnPackSettings
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.JSON = !toolSettings.JSON;
            return toolSettings;
        }
        #endregion
        #region Out
        /// <summary>
        ///   <p><em>Sets <see cref="YarnPackSettings.Out"/></em></p>
        ///   <p>Create the archive at the specified path</p>
        /// </summary>
        [Pure]
        public static T SetOut<T>(this T toolSettings, string @out) where T : YarnPackSettings
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Out = @out;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="YarnPackSettings.Out"/></em></p>
        ///   <p>Create the archive at the specified path</p>
        /// </summary>
        [Pure]
        public static T ResetOut<T>(this T toolSettings) where T : YarnPackSettings
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Out = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region YarnMode
    /// <summary>
    ///   Used within <see cref="YarnTasks"/>.
    /// </summary>
    [PublicAPI]
    [Serializable]
    [ExcludeFromCodeCoverage]
    [TypeConverter(typeof(TypeConverter<YarnMode>))]
    public partial class YarnMode : Enumeration
    {
        public static YarnMode skip_build = (YarnMode) "skip-build";
        public static YarnMode update_lockfile = (YarnMode) "update-lockfile";
        public static implicit operator YarnMode(string value)
        {
            return new YarnMode { Value = value };
        }
    }
    #endregion
}
