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
    /// Represents an update to the type and/or lag of an existing link (dependency) between two Tasks.
    /// </summary>
    public class TaskLinkUpdateDto : ApiModel
    {

        /// <summary>
        /// The type of dependency between the two Tasks. Case-insensitive; stored and returned in camelCase.
        ///
        /// Valid values: finishToStart, startToStart, finishToFinish, startToFinish.
        /// </summary>
        public string LinkType { get; set; }

        /// <summary>
        /// The number of days of lag (or lead, if negative) between the two Tasks.
        /// </summary>
        public int? Lag { get; set; }
    }
}
