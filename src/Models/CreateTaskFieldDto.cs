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
    /// A TaskField is a custom field defined within your Workspace for a specific Project.  You can
    /// define TaskFields for any integration purpose that is important to your business.  Each
    /// TaskField has a data type as well as options in how it is handled.  TaskFields can be edited
    /// for each Task inside this Project.
    /// </summary>
    public class CreateTaskFieldDto : ApiModel
    {

        /// <summary>
        /// The name of the TaskField
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// The type of this TaskField.  Valid types are the following:
        /// * Text
        /// * Number
        /// * Date
        /// * Checkbox
        /// * Currency
        /// * DropdownSingle
        /// * DropdownMulti
        /// </summary>
        public string Type { get; set; }

        /// <summary>
        /// A list of options for use of this TaskField.  This is only valid if
        /// the `Type` value is set to `Dropdown`.
        ///
        /// When a custom TaskField of type `DropDown` is shown to a user in the
        /// application, they will be able to choose one of the `Options` in this
        /// list.
        /// </summary>
        public string[] Options { get; set; }

        /// <summary>
        /// The short Id of this field - human readable identity
        /// </summary>
        public string ShortId { get; set; }
    }
}
