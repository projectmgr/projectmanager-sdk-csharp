/***
 * ProjectManager API for C#
 *
 * (c) ProjectManager.com, Inc.
 *
 * For the full copyright and license information, please view the LICENSE
 * file that was distributed with this source code.
 *
 * @author     ProjectManager.com <support@projectmanager.com>
 * @copyright  ProjectManager.com, Inc.
 * @link       https://github.com/projectmgr/projectmanager-sdk-csharp
 */



#pragma warning disable CS8618

using System;

namespace ProjectManager.SDK.Models
{

    /// <summary>
    /// Represents a single entitlement for the current Workspace.
    /// </summary>
    public class EntitlementDto : ApiModel
    {

        /// <summary>
        /// The unique identifier for this entitlement.
        /// </summary>
        public string ShortId { get; set; }

        /// <summary>
        /// The human-readable name of the entitlement.
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Indicates whether this is a boolean toggle (&quot;switch&quot;) or a numeric cap (&quot;limit&quot;).
        /// </summary>
        public string Type { get; set; }

        /// <summary>
        /// For switch-type entitlements, indicates whether the feature is enabled.
        /// Null for limit-type entitlements.
        /// </summary>
        public bool? Enabled { get; set; }

        /// <summary>
        /// For limit-type entitlements, the numeric cap value.
        /// Null for switch-type entitlements.
        /// </summary>
        public decimal? Limit { get; set; }
    }
}
