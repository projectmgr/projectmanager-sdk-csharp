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
    /// API methods related to Tag
    /// </summary>
    public interface ITagClient
    {

        /// <summary>
        /// Retrieve a list of Tags that match an [OData formatted query](https://www.odata.org/).
        ///
        /// A Tag is a named categorization you can use to distinguish objects from each other. Tags each have a unique identifier, a name, and a color.
        ///
        /// </summary>
        /// <param name="top">The number of records to return</param>
        /// <param name="skip">Skips the given number of records and then returns $top records</param>
        /// <param name="filter">Filter the expression according to oData queries</param>
        /// <param name="select">Specify which properties should be returned</param>
        /// <param name="orderby">Order collection by this field.</param>
        /// <param name="expand">Include related data in the response</param>
        Task<AstroResult<TagDto[]>> QueryTags(int? top = null, int? skip = null, string filter = null, string select = null, string orderby = null, string expand = null);

        /// <summary>
        /// Creates a new Tag based on information you provide.
        ///
        /// A Tag is a named categorization you can use to distinguish objects from each other. Tags each have a unique identifier, a name, and a color.
        ///
        /// </summary>
        /// <param name="body">The information for the new Tag to create</param>
        Task<AstroResult<TagDto>> CreateTag(TagCreateDto body);

        /// <summary>
        /// Updates a new Tag based on information you provide.
        ///
        /// A Tag is a named categorization you can use to distinguish objects from each other. Tags each have a unique identifier, a name, and a color.
        ///
        /// </summary>
        /// <param name="tagId">The id of the tag</param>
        /// <param name="body">The information to update the tag</param>
        Task<AstroResult<TagDto>> UpdateTag(Guid tagId, TagUpdateDto body);
    }
}
