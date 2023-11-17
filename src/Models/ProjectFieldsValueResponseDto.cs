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
    /// A Project Field is a custom field defined within your Workspace for each Project. Each
    /// Project Field has a data type as well as options in how it is handled.
    /// </summary>
    public class ProjectFieldsValueResponseDto : ApiModel
    {

        /// <summary>
        /// The unique identifier of this Project Field.
        /// </summary>
        public Guid? Id { get; set; }

        /// <summary>
        /// The value currently set for this Project Field.
        /// </summary>
        public string Value { get; set; }

        /// <summary>
        /// The name of this Project Field.
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// The type of this Project Field.  Valid types are the following:
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
