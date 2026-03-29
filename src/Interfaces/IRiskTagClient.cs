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



using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using ProjectManager.SDK.Models;


namespace ProjectManager.SDK.Interfaces
{
    /// <summary>
    /// API methods related to RiskTag
    /// </summary>
    public interface IRiskTagClient
    {

        /// <summary>
        /// Replaces the existing tags on a Risk with a newly provided list.
        /// A tag is a connection between a Risk and a Tag. Each Risk can have zero, one or many tags.
        /// </summary>
        /// <param name="riskId">The unique identifier of the Risk</param>
        /// <param name="body">The replacement list of tags for this Risk</param>
        Task<AstroResult<TaskTagDto[]>> ReplaceRiskTags(Guid riskId, NameDto[] body);

        /// <summary>
        /// Add one or more tags to a Risk.
        /// </summary>
        /// <param name="riskId">The unique identifier of the Risk</param>
        /// <param name="body">The tags to add</param>
        Task<AstroResult<TaskTagDto[]>> AddTagsToRisk(Guid riskId, NameDto[] body);

        /// <summary>
        /// Removes one or more tags from a Risk.
        /// </summary>
        /// <param name="riskId">The unique identifier of the Risk</param>
        /// <param name="body">The tags to remove</param>
        Task<AstroResult<string>> RemoveTagsFromRisk(Guid riskId, NameDto[] body);

        /// <summary>
        /// Returns the list of tags assigned to the specified Risk.
        /// </summary>
        /// <param name="riskId">The unique identifier of the Risk</param>
        Task<AstroResult<TaskTagDto[]>> RetrieveTagsForARisk(Guid riskId);
    }
}
