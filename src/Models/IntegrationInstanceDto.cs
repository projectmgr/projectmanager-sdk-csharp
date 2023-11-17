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
    public class IntegrationInstanceDto : ApiModel
    {

        /// <summary>
        /// The unique identifier of this IntegrationInstance
        /// </summary>
        public Guid? Id { get; set; }

        /// <summary>
        /// A short ID that uniquely identifies this IntegrationInstance
        /// </summary>
        public string IntegrationShortId { get; set; }

        /// <summary>
        /// The unique identifier of the user who enabled this IntegrationInstance
        /// </summary>
        public Guid? EnabledBy { get; set; }

        /// <summary>
        /// Timestamp when this record was created
        /// </summary>
        public DateTime? CreateDate { get; set; }

        /// <summary>
        /// Timestamp when this record was most recently modified
        /// </summary>
        public DateTime? ModifyDate { get; set; }

        /// <summary>
        /// The id of the project manager project this instance is related to
        /// </summary>
        public Guid? ProjectId { get; set; }

        /// <summary>
        /// The identifier in the integration provider, could be a reference to a file, task, project.
        /// </summary>
        public string ProviderItemId { get; set; }

        /// <summary>
        /// The name of the item in the integration provider.
        /// </summary>
        public string ProviderItemName { get; set; }
    }
}
