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
    public class NewIntegrationInstanceDto : ApiModel
    {

        /// <summary>
        /// The unique identifier of the newly created IntegrationInstance.
        /// </summary>
        public Guid? Id { get; set; }
    }
}
