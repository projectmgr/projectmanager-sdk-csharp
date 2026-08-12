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
    /// A lightweight reference that pairs a unique identifier with a display name.
    ///
    /// To determine what the identifier and name represent, see the field to which this
    /// value is attached in the parent object.
    /// </summary>
    public class IdNameDto : ApiModel
    {

        /// <summary>
        /// A unique identifier.  To determine the meaning of this unique identifier,
        /// see the field to which this value is attached.
        /// </summary>
        public Guid? Id { get; set; }

        /// <summary>
        /// A name.  To determine the meaning of this name, see the field to which this
        /// value is attached in the parent object.
        /// </summary>
        public string Name { get; set; }
    }
}
