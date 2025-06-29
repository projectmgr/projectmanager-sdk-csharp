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
    /// User assigned to task or risk
    /// </summary>
    public class AssignmentDto : ApiModel
    {

        /// <summary>
        /// Task or risk the user is assigned to
        /// </summary>
        public Guid? TaskId { get; set; }

        /// <summary>
        /// The task or risk project Id
        /// </summary>
        public Guid? ProjectId { get; set; }

        /// <summary>
        /// Resource identifier
        /// </summary>
        public Guid? ResourceId { get; set; }
    }
}
