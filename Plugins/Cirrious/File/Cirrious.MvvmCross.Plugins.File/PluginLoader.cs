﻿// PluginLoader.cs
// (c) Copyright Cirrious Ltd. http://www.cirrious.com
// MvvmCross is licensed using Microsoft Public License (Ms-PL)
// Contributions and inspirations noted in readme.md and license.txt
// 
// Project Lead - Stuart Lodge, @slodge, me@slodge.com

using Cirrious.CrossCore.Interfaces.IoC;
using Cirrious.CrossCore.Interfaces.Plugins;

namespace Cirrious.MvvmCross.Plugins.File
{
    public class PluginLoader
        : IMvxPluginLoader
          , IMvxConsumer
    {
        public static readonly PluginLoader Instance = new PluginLoader();

        #region Implementation of IMvxPluginLoader

        public void EnsureLoaded()
        {
            var manager = this.GetService<IMvxPluginManager>();
            manager.EnsureLoaded<PluginLoader>();
        }

        #endregion
    }
}