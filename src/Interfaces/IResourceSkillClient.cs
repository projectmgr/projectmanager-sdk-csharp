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



using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using ProjectManager.SDK.Models;


namespace ProjectManager.SDK.Interfaces
{
    /// <summary>
    /// API methods related to ResourceSkill
    /// </summary>
    public interface IResourceSkillClient
    {

        /// <summary>
        /// Retrieves all ResourceSkills defined within your Workspace.
        ///
        /// A ResourceSkill is a capability possessed by a Resource that can be used to distinguish different classes of Resources suitable for use by a Task.  You can specify that a Task requires a Resource with a particular set of ResourceSkills and then allocate Resources based on whether or not they have the suitable ResourceSkills.
        ///
        /// </summary>
        /// <param name="top">The number of records to return</param>
        /// <param name="skip">Skips the given number of records and then returns $top records</param>
        /// <param name="filter">Filter the expression according to oData queries</param>
        /// <param name="select">Specify which properties should be returned</param>
        /// <param name="orderby">Order collection by this field.</param>
        /// <param name="expand">Include related data in the response</param>
        Task<AstroResult<ResourceSkillDto[]>> RetrieveResourceSkills(int? top = null, int? skip = null, string filter = null, string select = null, string orderby = null, string expand = null);

        /// <summary>
        /// Create a Resource Skill.
        ///
        /// </summary>
        /// <param name="body">The name of the skill to create.</param>
        Task<AstroResult<ResourceSkillDto>> CreateResourceSkill(CreateResourceSkillDto body);

        /// <summary>
        /// Update a Resource Skill.
        ///
        /// </summary>
        /// <param name="skillId">The id of the skill to update.</param>
        /// <param name="body">The data of the skill to update.</param>
        Task<AstroResult<ResourceSkillDto>> UpdateResourceSkill(Guid skillId, UpdateResourceSkillDto body);

        /// <summary>
        /// The endpoint is used to delete a resource skill. Users assigned to this skill will no longer be assigned thereafter.
        ///
        /// </summary>
        /// <param name="resourceSkillId">The Id of the skill to be removed.</param>
        Task<AstroResult<string>> DeleteResourceSkill(Guid resourceSkillId);
    }
}
