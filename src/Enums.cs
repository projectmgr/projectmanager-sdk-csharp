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



namespace ProjectManager.SDK
{

    /// <summary>
    /// To prevent enum parsing errors, all enums are rendered as constants.
    /// </summary>
    public static class DashboardTypeValues
    {
        public const string MySummary = "MySummary";
        public const string PortfolioSummary = "PortfolioSummary";
    }

    /// <summary>
    /// To prevent enum parsing errors, all enums are rendered as constants.
    /// </summary>
    public static class HttpStatusCodeValues
    {
        public const string Continue = "Continue";
        public const string SwitchingProtocols = "SwitchingProtocols";
        public const string Processing = "Processing";
        public const string EarlyHints = "EarlyHints";
        public const string OK = "OK";
        public const string Created = "Created";
        public const string Accepted = "Accepted";
        public const string NonAuthoritativeInformation = "NonAuthoritativeInformation";
        public const string NoContent = "NoContent";
        public const string ResetContent = "ResetContent";
        public const string PartialContent = "PartialContent";
        public const string MultiStatus = "MultiStatus";
        public const string AlreadyReported = "AlreadyReported";
        public const string IMUsed = "IMUsed";
        public const string MultipleChoices = "MultipleChoices";
        public const string MovedPermanently = "MovedPermanently";
        public const string Found = "Found";
        public const string SeeOther = "SeeOther";
        public const string NotModified = "NotModified";
        public const string UseProxy = "UseProxy";
        public const string Unused = "Unused";
        public const string TemporaryRedirect = "TemporaryRedirect";
        public const string PermanentRedirect = "PermanentRedirect";
        public const string BadRequest = "BadRequest";
        public const string Unauthorized = "Unauthorized";
        public const string PaymentRequired = "PaymentRequired";
        public const string Forbidden = "Forbidden";
        public const string NotFound = "NotFound";
        public const string MethodNotAllowed = "MethodNotAllowed";
        public const string NotAcceptable = "NotAcceptable";
        public const string ProxyAuthenticationRequired = "ProxyAuthenticationRequired";
        public const string RequestTimeout = "RequestTimeout";
        public const string Conflict = "Conflict";
        public const string Gone = "Gone";
        public const string LengthRequired = "LengthRequired";
        public const string PreconditionFailed = "PreconditionFailed";
        public const string RequestEntityTooLarge = "RequestEntityTooLarge";
        public const string RequestUriTooLong = "RequestUriTooLong";
        public const string UnsupportedMediaType = "UnsupportedMediaType";
        public const string RequestedRangeNotSatisfiable = "RequestedRangeNotSatisfiable";
        public const string ExpectationFailed = "ExpectationFailed";
        public const string MisdirectedRequest = "MisdirectedRequest";
        public const string UnprocessableEntity = "UnprocessableEntity";
        public const string Locked = "Locked";
        public const string FailedDependency = "FailedDependency";
        public const string UpgradeRequired = "UpgradeRequired";
        public const string PreconditionRequired = "PreconditionRequired";
        public const string TooManyRequests = "TooManyRequests";
        public const string RequestHeaderFieldsTooLarge = "RequestHeaderFieldsTooLarge";
        public const string UnavailableForLegalReasons = "UnavailableForLegalReasons";
        public const string InternalServerError = "InternalServerError";
        public const string NotImplemented = "NotImplemented";
        public const string BadGateway = "BadGateway";
        public const string ServiceUnavailable = "ServiceUnavailable";
        public const string GatewayTimeout = "GatewayTimeout";
        public const string HttpVersionNotSupported = "HttpVersionNotSupported";
        public const string VariantAlsoNegotiates = "VariantAlsoNegotiates";
        public const string InsufficientStorage = "InsufficientStorage";
        public const string LoopDetected = "LoopDetected";
        public const string NotExtended = "NotExtended";
        public const string NetworkAuthenticationRequired = "NetworkAuthenticationRequired";
    }

    /// <summary>
    /// To prevent enum parsing errors, all enums are rendered as constants.
    /// </summary>
    public static class ProjectPermissionValues
    {
        public const string Guest = "Guest";
        public const string Collaborate = "Collaborate";
        public const string Editor = "Editor";
        public const string Manager = "Manager";
    }

    /// <summary>
    /// To prevent enum parsing errors, all enums are rendered as constants.
    /// </summary>
    public static class StateValues
    {
        public const string NotStarted = "NotStarted";
        public const string InProgress = "InProgress";
        public const string Success = "Success";
        public const string Discard = "Discard";
        public const string Fail = "Fail";
    }
}
