/***
 * ProjectManager API for C#
 *
 * (c) 2023-2025 ProjectManager.com, Inc.
 *
 * For the full copyright and license information, please view the LICENSE
 * file that was distributed with this source code.
 *
 * @author     ProjectManager.com <support@projectmanager.com>
 * @copyright  2023-2025 ProjectManager.com, Inc.
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
    public class ProjectFieldCreateDto : ApiModel
    {

        /// <summary>
        /// The name of this Field
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// The type of the Field.
        ///
        /// Attempting to create a field with any Type other than these will
        /// return an error.
        ///
        /// For Dropdown Field types, specify the list of choices in the `Options`
        /// field.
        ///
        ///  Valid options are:
        ///  * string
        ///  * number
        ///  * date
        ///  * bool
        ///  * currency
        ///  * dropdown-single
        ///  * dropdown-multi
        /// </summary>
        public string Type { get; set; }

        /// <summary>
        /// The short Id of this field - human readable identity
        /// </summary>
        public string ShortId { get; set; }

        /// <summary>
        /// A list of options for use of this ProjectField.  This is only valid if
        /// the `Type` value is set to `Dropdown`.
        ///
        /// When a custom TaskField of type `DropDown` is shown to a user in the
        /// application, they will be able to choose one of the `Options` in this
        /// list.
        /// </summary>
        public string[] Options { get; set; }
    }
}
