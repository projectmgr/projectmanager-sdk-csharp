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
    /// A ProjectStatus is a code used to identify costs within your Projects.  Each
    /// ProjectStatus has a name and a unique identifier.  Status are defined per
    /// Workspace and are shared among Projects.
    /// </summary>
    public class ProjectStatusCreateDto : ApiModel
    {

        /// <summary>
        /// The name of this ProjectStatus
        /// </summary>
        public string Name { get; set; }
    }
}
