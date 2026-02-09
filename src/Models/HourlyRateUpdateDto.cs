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
    /// The payload to update a hourly rate
    /// </summary>
    public class HourlyRateUpdateDto : ApiModel
    {

        /// <summary>
        /// Update the status of the rate from Active to InActive.
        ///
        /// An InActive rate will still be used in calculating the cost of a project
        /// but will not be displayed in the ui.
        /// </summary>
        public bool? IsActive { get; set; }
    }
}
