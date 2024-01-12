/***
 * ProjectManager API for C#
 *
 * (c) 2023-2024 ProjectManager.com, Inc.
 *
 * For the full copyright and license information, please view the LICENSE
 * file that was distributed with this source code.
 *
 * @author     ProjectManager.com <support@projectmanager.com>
 * @copyright  2023-2024 ProjectManager.com, Inc.
 * @link       https://github.com/projectmgr/projectmanager-sdk-csharp
 */



#pragma warning disable CS8618

using System;

namespace ProjectManager.SDK.Models
{

    /// <summary>
    /// The Integrations API is intended for use by ProjectManager and its business
    /// development partners.  Please contact ProjectManager&#39;s sales team to request use of this API.
    /// </summary>
    public class IntegrationDto : ApiModel
    {

        /// <summary>
        /// The unique identifier of this Integration
        /// </summary>
        public Guid? Id { get; set; }

        /// <summary>
        /// The friendly name of this Integration
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// A description of this Integration that can be shared with users
        /// </summary>
        public string Description { get; set; }

        /// <summary>
        /// A short ID that uniquely identifies this Integration
        /// </summary>
        public string ShortId { get; set; }

        /// <summary>
        /// True if this Integration allows multiple Instances.
        ///
        /// An example of a multi-Instance Integration is one that can be connected to many
        /// different folders or channels within a remote application.
        /// </summary>
        public bool? IsMultiInstance { get; set; }

        /// <summary>
        /// Extra configuration metadata for this Instance.
        /// </summary>
        public object Config { get; set; }

        /// <summary>
        /// The list of SKUS for this Integration.
        /// </summary>
        public string[] LicenseSkus { get; set; }

        /// <summary>
        /// For multi-Instance Integrations, this contains the list of IntegrationInstances.
        /// </summary>
        public IntegrationInstanceDto[] Instances { get; set; }

        /// <summary>
        /// True if this Integration is enabled for the current Workspace.
        /// </summary>
        public bool? Enabled { get; set; }

        /// <summary>
        /// True if the user has authenticated
        /// </summary>
        public bool? Authenticated { get; set; }

        /// <summary>
        /// True if the integration is auto-enabled
        /// </summary>
        public bool? AutoEnabled { get; set; }
    }
}
