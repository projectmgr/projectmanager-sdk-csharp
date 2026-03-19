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
    /// DTO for updating a project field definition (e.g. rename).
    /// </summary>
    public class UpdateProjectFieldDto : ApiModel
    {

        /// <summary>
        /// The new name of the field.
        /// </summary>
        public string Name { get; set; }
    }
}
