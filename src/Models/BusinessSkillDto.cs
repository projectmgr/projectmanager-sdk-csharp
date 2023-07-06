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
    /// A ResourceSkill is a capability possessed by a Resource that can be used to distinguish
    /// different classes of Resources suitable for use by a Task.  You can specify that a Task
    /// requires a Resource with a particular set of ResourceSkills and then allocate Resources
    /// based on whether or not they have the suitable ResourceSkills.
    /// </summary>
    public class BusinessSkillDto
    {

        /// <summary>
        /// The unique identifier of this ResourceSkill
        /// </summary>
        public Guid? Id { get; set; }

        /// <summary>
        /// The friendly name of this ResourceSkill
        /// </summary>
        public string Name { get; set; }
    }
}
