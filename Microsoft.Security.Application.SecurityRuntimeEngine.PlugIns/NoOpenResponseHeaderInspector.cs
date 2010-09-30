﻿// --------------------------------------------------------------------------------------------------------------------
// <copyright file="NoOpenResponseHeaderInspector.cs" company="Microsoft Corporation">
//   Copyright (c) 2010 All Rights Reserved, Microsoft Corporation
//
//   This source is subject to the Microsoft Permissive License.
//   Please see the License.txt file for more information.
//   All other rights reserved.
//
//   THIS CODE AND INFORMATION ARE PROVIDED "AS IS" WITHOUT WARRANTY OF ANY 
//   KIND, EITHER EXPRESSED OR IMPLIED, INCLUDING BUT NOT LIMITED TO THE
//   IMPLIED WARRANTIES OF MERCHANTABILITY AND/OR FITNESS FOR A
//   PARTICULAR PURPOSE.
// </copyright>
// <summary>
//   Header inspector which adds the X-Download-Options header to all responses.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace Microsoft.Security.Application.SecurityRuntimeEngine.PlugIns
{
    using System;
    using System.ComponentModel.Composition;
    using System.Web;

    /// <summary>
    /// Header inspector which adds the X-Download-Options header to all responses.
    /// </summary>
    [Export(typeof(IResponseHeaderInspector))]
    public sealed class NoOpenResponseHeaderInspector : IResponseHeaderInspector, IConfigurablePlugIn
    {
        /// <summary>
        /// The configuration section name,
        /// </summary>
        private const string ConfigSectionName = "sreNoOpenSettings";

        /// <summary>
        /// Internal, strongly typed settings.
        /// </summary>
        private NoOpenHeaderInspectorSettings internalSettings = new NoOpenHeaderInspectorSettings();

        /// <summary>
        /// Gets the list of excluded paths for the plug-in.
        /// </summary>
        /// <value>The list of excluded paths for the plug-in.</value>
        public ExcludedPathCollection ExcludedPaths
        {
            get
            {
                return this.internalSettings == null ? null : this.internalSettings.ExcludedPaths;
            }
        }

        /// <summary>
        /// Gets or sets the settings for the plug-in.
        /// </summary>
        /// <value>The settings for the plug-in.</value>
        public BasePlugInConfiguration Settings
        {
            get
            {
                return this.internalSettings;
            }

            set
            {
                this.internalSettings = (NoOpenHeaderInspectorSettings)value;
            }
        }

        /// <summary>
        /// Gets the configuration section name for the plug-in.
        /// </summary>
        /// <value>The configuration section name for the plug-in.</value>
        public string ConfigurationSectionName
        {
            get
            {
                return ConfigSectionName;
            }
        }

        /// <summary>
        /// Inspects an HTTP response's headers for potential problems.
        /// </summary>
        /// <param name="request">The original <see cref="HttpRequestBase"/> for this response.</param>
        /// <param name="response">A <see cref="HttpResponseBase"/> to inspect.</param>
        /// <returns>
        /// An <see cref="IInspectionResult"/> containing the results of the inspection.
        /// </returns>
        /// <remarks>
        /// <para>This method is called at the point in the ASP.NET pipeline where you may still edit response headers
        /// via <see cref="HttpResponse.AppendHeader"/>.</para>
        /// <para>Accessing the <see cref="HttpResponse.Headers"/> property is only supported with the IIS 7.0 integrated pipeline mode
        /// and at least the .NET Framework 3.0. When you try to access the Headers property and either of these two conditions
        /// is not met, a PlatformNotSupportedException is thrown.</para>
        /// </remarks>
        public IInspectionResult Inspect(HttpRequestBase request, HttpResponseBase response)
        {
            if (response == null)
            {
                throw new ArgumentNullException("response");
            }

            response.AppendHeader("X-Download-Options", "noopen");
            return new ResponseInspectionResult(InspectionResultSeverity.Continue);
        }
    }
}
