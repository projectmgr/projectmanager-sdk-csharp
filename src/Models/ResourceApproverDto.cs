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
    /// TODO - What is a ResourceApprover?  Ted&#39;s theory is that this is a Workflow stage &quot;name&quot;.
    /// </summary>
    public class ResourceApproverDto
    {

        /// <summary>
        /// The unique identifier of this ResourceApprover
        /// </summary>
        public Guid? Id { get; set; }

        /// <summary>
        /// The name of this ResourceApprover
        /// </summary>
        public string Name { get; set; }
    }
}
