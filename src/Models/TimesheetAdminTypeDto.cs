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
    /// Represents admin task to track time
    /// </summary>
    public class TimesheetAdminTypeDto : ApiModel
    {

        /// <summary>
        /// admin task id
        /// </summary>
        public Guid? Id { get; set; }

        /// <summary>
        /// admin task name
        /// </summary>
        public string Name { get; set; }
    }
}
