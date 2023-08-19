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
    /// A ProjectField is a custom field defined within your Workspace.  You can define ProjectFields
    /// for any integration purpose that is important to your business.  Each ProjectField has a data
    /// type as well as options in how it is handled.  ProjectFields can be edited for each Project
    /// within your Workspace.
    /// </summary>
    public class DeleteProjectFieldDto : ApiModel
    {

        /// <summary>
        /// The unique identifier of the ProjectField being deleted
        /// </summary>
        public Guid? Id { get; set; }

        /// <summary>
        /// The name of the ProjectField being deleted
        /// </summary>
        public string Name { get; set; }
    }
}
