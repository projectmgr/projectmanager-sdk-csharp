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
    /// A ProjectVersionChangeData is information about a change made to a Project that took
    /// it from one Version to another.  The information in this object can help track the
    /// details of changes made by the user.
    /// </summary>
    public class ProjectVersionChangeDataDto : ApiModel
    {

        /// <summary>
        /// The type of change made
        /// </summary>
        public string Type { get; set; }

        /// <summary>
        /// The method used to make the change
        /// </summary>
        public string Method { get; set; }

        /// <summary>
        /// The property that was changed, if any
        /// </summary>
        public string Property { get; set; }

        /// <summary>
        /// The new value of the property, or null if the property was cleared
        /// </summary>
        public string Value { get; set; }

        /// <summary>
        /// The prior version number to restore to
        /// </summary>
        public int? RestoreVersion { get; set; }
    }
}
