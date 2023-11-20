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
    public class CreateProjectFieldDto : ApiModel
    {

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
        /// TODO - This object needs to support a list of options, in case dropdown is selected
        /// </summary>
        public string Type { get; set; }

        /// <summary>
        /// The short Id of this field - human readable identity
        /// </summary>
        public string ShortId { get; set; }
    }
}
