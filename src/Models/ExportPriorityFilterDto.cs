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
    /// Priority filter settings
    /// </summary>
    public class ExportPriorityFilterDto : ApiModel
    {

        /// <summary>
        /// Include items with no priority
        /// </summary>
        public bool? IsNone { get; set; }

        /// <summary>
        /// Include items with very low priority
        /// </summary>
        public bool? IsVeryLow { get; set; }

        /// <summary>
        /// Include items with low priority
        /// </summary>
        public bool? IsLow { get; set; }

        /// <summary>
        /// Include items with medium priority
        /// </summary>
        public bool? IsMedium { get; set; }

        /// <summary>
        /// Include items with high priority
        /// </summary>
        public bool? IsHigh { get; set; }

        /// <summary>
        /// Include items with very high priority
        /// </summary>
        public bool? IsVeryHigh { get; set; }

        /// <summary>
        /// Include items with critical priority
        /// </summary>
        public bool? IsCritical { get; set; }
    }
}
