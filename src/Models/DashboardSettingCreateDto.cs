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
    /// User dashboard create or update dto
    /// </summary>
    public class DashboardSettingCreateDto : ApiModel
    {

        /// <summary>
        /// Unique ID
        /// </summary>
        public Guid? Id { get; set; }

        /// <summary>
        /// User ID
        /// </summary>
        public Guid? UserId { get; set; }

        /// <summary>
        /// Either custom or one of DashboardType enum
        /// </summary>
        public string Type { get; set; }

        /// <summary>
        /// React grid layout configuration
        /// </summary>
        public ReactGridLayoutDto ReactGridLayout { get; set; }
    }
}
