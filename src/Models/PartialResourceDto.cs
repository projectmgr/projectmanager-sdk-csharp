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
    /// PartialResourceDto
    /// </summary>
    public class PartialResourceDto : ApiModel
    {

        /// <summary>
        /// The unique identifier of this Resource.
        /// </summary>
        public Guid? Id { get; set; }

        /// <summary>
        /// The resource initials.
        /// </summary>
        public string Initials { get; set; }

        /// <summary>
        /// The first name of the person Resource.
        ///
        /// Applies to personnel Resources only.
        /// </summary>
        public string FirstName { get; set; }

        /// <summary>
        /// The last name of the person Resource.
        ///
        /// Applies to personnel Resources only.
        /// </summary>
        public string LastName { get; set; }

        /// <summary>
        /// If this Resource is a person who can log on to ProjectManager.com, this value should be the email address of the
        /// person.  If this Resource is not a person, but you wish to receive email alerts for usage of this Resource, you
        /// can also add an email address here and notifications will be sent when this Resource is used.
        ///
        /// Otherwise this value should be `null`.
        /// </summary>
        public string Email { get; set; }
    }
}
