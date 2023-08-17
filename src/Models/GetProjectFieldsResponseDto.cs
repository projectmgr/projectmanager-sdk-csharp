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
    /// Represents either a ProjectField or a TaskField, depending on the value of the
    /// `EntityType` for this object.
    ///
    /// A ProjectField is a custom field defined within your Workspace.  You can define ProjectFields
    /// for any integration purpose that is important to your business.  Each ProjectField has a data
    /// type as well as options in how it is handled.  ProjectFields can be edited for each Project
    /// within your Workspace.
    ///
    /// A TaskField is a custom field defined within your Workspace for a specific Project.  You can
    /// define TaskFields for any integration purpose that is important to your business.  Each
    /// TaskField has a data type as well as options in how it is handled.  TaskFields can be edited
    /// for each Task inside this Project.
    /// </summary>
    public class GetProjectFieldsResponseDto : ApiModel
    {

        /// <summary>
        /// The unique identifier of this Field
        /// </summary>
        public Guid? Id { get; set; }

        /// <summary>
        /// The name of this Field
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// The type of the Field.  Valid types are the following:
        /// * Text
        /// * Number
        /// * Date
        /// * Currency
        /// * Dropdown
        ///
        /// Attempting to create a field with any Type other than these will
        /// return an error.
        ///
        /// For Dropdown Field, specify the list of choices in the `Options`
        /// field.
        /// </summary>
        public string Type { get; set; }

        /// <summary>
        /// The entity type of the Field, either `projects` or `tasks`.
        /// </summary>
        public string EntityType { get; set; }

        /// <summary>
        /// A list of options for use of this Field.  This is only valid if
        /// the `Type` value is set to `Dropdown`.
        ///
        /// When a custom Field of type `DropDown` is shown to a user in the
        /// application, they will be able to choose one of the `Options` in this
        /// list.
        /// </summary>
        public string[] Options { get; set; }
    }
}
