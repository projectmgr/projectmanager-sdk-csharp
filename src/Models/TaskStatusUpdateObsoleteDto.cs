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

    public class TaskStatusUpdateObsoleteDto : ApiModel
    {

        /// <summary>
        /// The name of this TaskStatus.
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// A numerical value that can be used to sort TaskStatus values according to the
        /// needs of your business.
        /// </summary>
        public int? Order { get; set; }

        /// <summary>
        /// The unique identifier of this TaskStatus.
        /// </summary>
        public Guid? Id { get; set; }
    }
}
