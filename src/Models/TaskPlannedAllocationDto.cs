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
    /// Planned minutes attributed to a single calendar day for a resource.
    /// </summary>
    public class TaskPlannedAllocationDto : ApiModel
    {

        /// <summary>
        /// Calendar date for this planned segment (date-only; workspace calendar applies).
        ///
        /// This is a date-only field stored as a string in ISO 8601 (YYYY-MM-DD) format.
        /// </summary>
        public string Date { get; set; }

        /// <summary>
        /// Planned minutes on date for this resource.
        /// </summary>
        public int? Minutes { get; set; }
    }
}
