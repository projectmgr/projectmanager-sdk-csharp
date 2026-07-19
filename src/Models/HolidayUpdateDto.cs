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
    /// Request body for updating a holiday. Only the reason can be changed.
    /// </summary>
    public class HolidayUpdateDto : ApiModel
    {

        /// <summary>
        /// Updated reason or label for the holiday.
        /// </summary>
        public string Reason { get; set; }
    }
}
