/***
 * ProjectManager API for C#
 *
 * (c) 2023-2023 ProjectManager.com, Inc.
 *
 * For the full copyright and license information, please view the LICENSE
 * file that was distributed with this source code.
 *
 * @author     ProjectManager.com <support@projectmanager.com>
 * @copyright  2023-2023 ProjectManager.com, Inc.
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
    public class IntegrationProviderDto : ApiModel
    {

        /// <summary>
        /// The unique identifier of this Provider.
        /// </summary>
        public Guid? Id { get; set; }

        /// <summary>
        /// The friendly name of this Provider.
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// A short ID that uniquely identifies this Provider.
        /// </summary>
        public string ShortId { get; set; }

        /// <summary>
        /// A short summary of this Provider and their service.
        /// </summary>
        public string Summary { get; set; }

        /// <summary>
        /// A longer description of this Provider and their service.
        /// </summary>
        public string Description { get; set; }

        /// <summary>
        /// A list of available license SKUs for this Provider.
        /// </summary>
        public string[] LicenseSkus { get; set; }

        /// <summary>
        /// A list of category IDs that this Provider exists within.
        /// </summary>
        public string[] CategoryShortIds { get; set; }

        /// <summary>
        /// True if this Provider is available for use.
        /// </summary>
        public bool? Activated { get; set; }

        /// <summary>
        /// True if this Provider requires authentication.
        /// </summary>
        public bool? Authenticated { get; set; }

        /// <summary>
        /// The list of available Integrations for this Provider.
        /// </summary>
        public IntegrationDto[] Integrations { get; set; }
    }
}
