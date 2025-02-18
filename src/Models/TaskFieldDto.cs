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
    public class TaskFieldDto : ApiModel
    {

        /// <summary>
        /// The unique identifier of this TaskField
        /// </summary>
        public Guid? Id { get; set; }

        /// <summary>
        /// The name of this TaskField
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
        ///
        /// Attempting to create a field with any Type other than these will
        /// return an error.
        ///
        /// For Dropdown TaskFields, specify the list of choices in the `Options`
        /// field.
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
        /// The short Id of this TaskField - human readable identity
        /// </summary>
        public string ShortId { get; set; }

        /// <summary>
        /// The Project to which this TaskField belongs.
        /// </summary>
        public TaskFieldProjectDto Project { get; set; }

        /// <summary>
        /// Date and time (in UTC) that this TaskField was created.
        /// </summary>
        public DateTime? CreatedDate { get; set; }

        /// <summary>
        /// Date and time (in UTC) that this TaskField was last modified.
        /// </summary>
        public DateTime? ModifiedDate { get; set; }
    }
}
