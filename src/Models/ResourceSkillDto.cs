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
    /// A ResourceSkill is a capability possessed by this Resource that can be used to
    /// determine appropriate assignments.  Some Resources may have ResourceSkills that
    /// are in high demand and some Tasks may have a requirement for Resources with particular
    /// ResourceSkills.
    /// </summary>
    public class ResourceSkillDto
    {

        /// <summary>
        /// The unique identifier of this ResourceSkill
        /// </summary>
        public Guid? Id { get; set; }

        /// <summary>
        /// The name of this ResourceSkill
        /// </summary>
        public string Name { get; set; }
    }
}
