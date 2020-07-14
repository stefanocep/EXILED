// -----------------------------------------------------------------------
// <copyright file="Config.cs" company="Exiled Team">
// Copyright (c) Exiled Team. All rights reserved.
// Licensed under the CC BY-SA 3.0 license.
// </copyright>
// -----------------------------------------------------------------------

namespace Exiled.Loader
{
    using System.ComponentModel;
    using Exiled.API.Enums;
    using Exiled.API.Interfaces;

    /// <summary>
    /// The configs of the loader.
    /// </summary>
    public sealed class Config : IConfig
    {
        /// <inheritdoc/>
        [Description("Indicates whether the plugin is enabled or not")]
        public bool IsEnabled { get; set; } = true;

        /// <summary>
        /// Gets or sets a value indicating whether outdated plugins should be loaded or not.
        /// </summary>
        [Description("Indicates whether outdated plugins should be loaded or not")]
        public bool ShouldLoadOutdatedPlugins { get; set; }

        /// <summary>
        /// Gets or sets the environment type.
        /// </summary>
        [Description("The working environment type")]
        public EnvironmentType Environment { get; set; } = EnvironmentType.Ptb;
    }
}
