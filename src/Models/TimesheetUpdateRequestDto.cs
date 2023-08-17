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
    /// Payload to update time entry
    /// </summary>
    public class TimesheetUpdateRequestDto : ApiModel
    {

        /// <summary>
        /// Reported hours
        /// </summary>
        public decimal? Hours { get; set; }

        /// <summary>
        /// Notes
        /// </summary>
        public string Notes { get; set; }
    }
}
