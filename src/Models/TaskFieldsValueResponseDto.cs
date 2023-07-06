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
    /// A TaskField is a custom field defined within your Workspace for a specific Project.  You can
    /// define TaskFields for any integration purpose that is important to your business.  Each
    /// TaskField has a data type as well as options in how it is handled.  TaskFields can be edited
    /// for each Task inside this Project.
    /// </summary>
    public class TaskFieldsValueResponseDto
    {

        /// <summary>
        /// The unique identifier of this TaskField.
        /// </summary>
        public Guid? Id { get; set; }

        /// <summary>
        /// The value currently set for this TaskField for this Task.
        /// </summary>
        public string Value { get; set; }

        /// <summary>
        /// The name of this TaskField.
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// The type of this TaskField.  Valid types are the following:
        /// * Text
        /// * Number
        /// * Date
        /// * Checkbox
        /// * Currency
        /// * Dropdown
        /// </summary>
        public string Type { get; set; }
    }
}
