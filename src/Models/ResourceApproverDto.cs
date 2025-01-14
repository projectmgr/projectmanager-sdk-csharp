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
    /// When managing users, you can choose who will approve a person&#39;s Timesheets. This
    /// is a ResourceApprover.  You can specify this person within the Resource object.
    /// </summary>
    public class ResourceApproverDto : ApiModel
    {

        /// <summary>
        /// The unique identifier of this ResourceApprover
        /// </summary>
        public Guid? Id { get; set; }

        /// <summary>
        /// The name of this ResourceApprover
        /// </summary>
        public string Name { get; set; }
    }
}
