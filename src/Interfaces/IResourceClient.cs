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
    /// API methods related to Resource
    /// </summary>
    public interface IResourceClient
    {

        /// <summary>
        /// Create a new Resource within your Workspace.
        ///
        /// A Resource represents a person, material, or tool that is used within your Projects.
        /// When you attach a Resources to more than one Task, the software will schedule the usage
        /// of your Resource so that it is not allocated to more than one Task at the same time.
        /// The users in your Workspace are also considered Resources.  To invite a new User to your
        /// Workspace, create a new Resource for that user.
        /// </summary>
        /// <param name="body">The details for the new Resource to create</param>
        Task<AstroResult<ResourceDto>> CreateResource(ResourceCreateDto body);

        /// <summary>
        /// Retrieve a list of Resources that match an [OData formatted query](https://www.odata.org/).
        ///
        /// A Resource represents a person, material, or tool that is used within your Projects.
        /// When you attach a Resources to more than one Task, the software will schedule the usage
        /// of your Resource so that it is not allocated to more than one Task at the same time.
        /// The users in your Workspace are also considered Resources.  To invite a new User to your
        /// Workspace, create a new Resource for that user.
        /// </summary>
        /// <param name="top">The number of records to return</param>
        /// <param name="skip">Skips the given number of records and then returns $top records</param>
        /// <param name="filter">Filter the expression according to oData queries</param>
        /// <param name="orderby">Order collection by this field.</param>
        /// <param name="expand">Include related data in the response</param>
        Task<AstroResult<ResourceDto[]>> QueryResources(int? top = null, int? skip = null, string filter = null, string orderby = null, string expand = null);

        /// <summary>
        /// Updates an existing Resource based on information you provide.
        ///
        /// A Resource represents a person, material, or tool that is used within your Projects.
        /// When you attach a Resources to more than one Task, the software will schedule the usage
        /// of your Resource so that it is not allocated to more than one Task at the same time.
        /// The users in your Workspace are also considered Resources.  To invite a new User to your
        /// Workspace, create a new Resource for that user.
        /// </summary>
        /// <param name="resourceId">The id of the resource</param>
        /// <param name="body">The information to update the resource</param>
        Task<AstroResult<ResourceDto>> UpdateResource(Guid resourceId, ResourceUpdateDto body);

        /// <summary>
        /// Retrieve the Resource matching the specified unique ID.
        ///
        /// A Resource represents a person, material, or tool that is used within your Projects.
        /// When you attach a Resources to more than one Task, the software will schedule the usage
        /// of your Resource so that it is not allocated to more than one Task at the same time.
        /// The users in your Workspace are also considered Resources.  To invite a new User to your
        /// Workspace, create a new Resource for that user.
        /// </summary>
        /// <param name="resourceId">The id of the Resource</param>
        Task<AstroResult<ResourceDto>> RetrieveResource(Guid resourceId);

        /// <summary>
        /// Deletes an existing Resource based on information you provide.
        ///
        /// A Resource represents a person, material, or tool used within your Projects.
        /// When you attach a Resources to more than one Task, the software will schedule the usage
        /// of your Resource so that it is not allocated to more than one Task at the same time.
        /// The users in your Workspace are also considered Resources.  To invite a new User to your
        /// Workspace, create a new Resource for that user.
        /// </summary>
        /// <param name="resourceId">The id of the resource</param>
        Task<AstroResult<ResourceDto>> DeleteResource(Guid resourceId);

        /// <summary>
        /// Create new Resources within your Workspace.
        ///
        /// A Resource represents a person, material, or tool that is used within your Projects.
        /// When you attach a Resources to more than one Task, the software will schedule the usage
        /// of your Resource so that it is not allocated to more than one Task at the same time.
        /// The users in your Workspace are also considered Resources.  To invite a new User to your
        /// Workspace, create a new Resource for that user.
        /// </summary>
        /// <param name="body">The details for the new Resources to create</param>
        Task<AstroResult<ResourcesDto>> CreateManyResources(ResourcesCreateDto body);

        /// <summary>
        /// Resend Invite Email to a Resource within your Workspace.
        ///
        /// When you create a Resource that is a person, ProjectManager sends that person an email inviting them to join
        /// your Workspace.  If that email is accidentally deleted or sent to a spam folder, you can request this email
        /// be sent again using this API.
        /// </summary>
        /// <param name="resourceId">The unique identifier of the Resource to send an invitation email</param>
        Task<AstroResult<string>> ResendInviteEmail(Guid resourceId);
    }
}
