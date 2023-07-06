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
    /// A ChargeCode is a code used to identify costs within your Projects.  Each ChargeCode has
    /// a name and a unique identifier.  ChargeCodes are defined per Workspace and are shared
    /// among Projects.
    /// </summary>
    public class ProjectChargeCodeDto
    {

        /// <summary>
        /// The unique identifier of this ChargeCode
        /// </summary>
        public Guid? Id { get; set; }

        /// <summary>
        /// The name of this ChargeCode
        /// </summary>
        public string Name { get; set; }
    }
}
