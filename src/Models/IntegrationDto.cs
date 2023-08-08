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

    public class IntegrationDto
    {

        public Guid? Id { get; set; }

        public string Name { get; set; }

        public string Description { get; set; }

        public string ShortId { get; set; }

        public bool? IsMultiInstance { get; set; }

        public object Config { get; set; }

        public string[] LicenseSkus { get; set; }

        public IntegrationInstanceDto[] Instances { get; set; }

        public bool? Enabled { get; set; }
    }
}
