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

    public class WorkSpaceDto
    {

        public Guid? Id { get; set; }

        public string Company { get; set; }

        public string CustomProductDomain { get; set; }

        public Guid? CustomerId { get; set; }

        public bool? IsOwner { get; set; }

        public string OrganizationId { get; set; }

        public string Color { get; set; }

        public string RoleName { get; set; }

        public DateTime? RegisterDate { get; set; }

        public bool? IsInviteAccepted { get; set; }

        public Guid? BusinessUserId { get; set; }

        public bool? IsPaid { get; set; }
    }
}
