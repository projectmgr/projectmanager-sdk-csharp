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
    /// React grid layout item object
    /// </summary>
    public class ReactGridLayoutItemDto : ApiModel
    {

        /// <summary>
        /// Width
        /// </summary>
        public int? W { get; set; }

        /// <summary>
        /// Height
        /// </summary>
        public int? H { get; set; }

        /// <summary>
        /// X position
        /// </summary>
        public int? X { get; set; }

        /// <summary>
        /// Y position
        /// </summary>
        public int? Y { get; set; }

        /// <summary>
        /// ID
        /// </summary>
        public string I { get; set; }

        /// <summary>
        /// Moved indicator
        /// </summary>
        public bool? Moved { get; set; }

        /// <summary>
        /// If true, equal to `isDraggable: false, isResizable: false`
        /// </summary>
        public bool? Static { get; set; }
    }
}
