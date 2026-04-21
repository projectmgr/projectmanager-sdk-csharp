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
    /// One cell in the workspace role permissions matrix: grant state plus subscription / feature metadata when the action is Chargebee-gated.
    /// </summary>
    public class RolePermissionFeatureDto : ApiModel
    {

        /// <summary>
        /// Whether this permission is granted for the role in the workspace (persisted access).
        /// </summary>
        public bool? IsGranted { get; set; }

        /// <summary>
        /// Whether the current workspace subscription entitles this action. May be false while isGranted is true for legacy data.
        /// </summary>
        public bool? IsEntitled { get; set; }

        /// <summary>
        /// Whether the feature flag for this permission is enabled for the workspace (display / upsell context).
        /// </summary>
        public bool? IsFeatureEnabled { get; set; }

        /// <summary>
        /// Primary Chargebee feature id used for entitlement (e.g. print-and-export), when applicable.
        /// </summary>
        public string FeatureId { get; set; }

        /// <summary>
        /// Human-readable feature name for UI or documentation, when applicable.
        /// </summary>
        public string FeatureName { get; set; }
    }
}
