/***
 * ProjectManager API for C#
 *
 * (c) 2023-2024 ProjectManager.com, Inc.
 *
 * For the full copyright and license information, please view the LICENSE
 * file that was distributed with this source code.
 *
 * @author     ProjectManager.com <support@projectmanager.com>
 * @copyright  2023-2024 ProjectManager.com, Inc.
 * @link       https://github.com/projectmgr/projectmanager-sdk-csharp
 */



#pragma warning disable CS8618

using System;

namespace ProjectManager.SDK.Models
{

    /// <summary>
    /// A Resource represents a person, material, or tool that is used within your Projects.
    /// When you attach a Resources to more than one Task, the software will schedule the usage
    /// of your Resource so that it is not allocated to more than one Task at the same time.
    /// The users in your Workspace are also considered Resources.  To invite a new User to your
    /// Workspace, create a new Resource for that user.
    /// </summary>
    public class ResourcesDto : ApiModel
    {

        public ResourceDto[] Resources { get; set; }

        public UserError[] Errors { get; set; }
    }
}
