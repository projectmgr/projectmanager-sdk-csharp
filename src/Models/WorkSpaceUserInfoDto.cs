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

    public class WorkSpaceUserInfoDto
    {

        public WorkSpaceLinksDto Links { get; set; }

        public string EmailAddress { get; set; }

        public Guid? Id { get; set; }

        public string FullName { get; set; }

        public string WorkSpaceName { get; set; }
    }
}
