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
    public static class EdmContainerElementKindValues
    {
        public const string None = "None";
        public const string EntitySet = "EntitySet";
        public const string ActionImport = "ActionImport";
        public const string FunctionImport = "FunctionImport";
        public const string Singleton = "Singleton";
    }

    /// <summary>
    /// To prevent enum parsing errors, all enums are rendered as constants.
    /// </summary>
    public static class EdmExpressionKindValues
    {
        public const string None = "None";
        public const string BinaryConstant = "BinaryConstant";
        public const string BooleanConstant = "BooleanConstant";
        public const string DateTimeOffsetConstant = "DateTimeOffsetConstant";
        public const string DecimalConstant = "DecimalConstant";
        public const string FloatingConstant = "FloatingConstant";
        public const string GuidConstant = "GuidConstant";
        public const string IntegerConstant = "IntegerConstant";
        public const string StringConstant = "StringConstant";
        public const string DurationConstant = "DurationConstant";
        public const string Null = "Null";
        public const string Record = "Record";
        public const string Collection = "Collection";
        public const string Path = "Path";
        public const string If = "If";
        public const string Cast = "Cast";
        public const string IsType = "IsType";
        public const string FunctionApplication = "FunctionApplication";
        public const string LabeledExpressionReference = "LabeledExpressionReference";
        public const string Labeled = "Labeled";
        public const string PropertyPath = "PropertyPath";
        public const string NavigationPropertyPath = "NavigationPropertyPath";
        public const string DateConstant = "DateConstant";
        public const string TimeOfDayConstant = "TimeOfDayConstant";
        public const string EnumMember = "EnumMember";
        public const string AnnotationPath = "AnnotationPath";
    }

    /// <summary>
    /// To prevent enum parsing errors, all enums are rendered as constants.
    /// </summary>
    public static class EdmSchemaElementKindValues
    {
        public const string None = "None";
        public const string TypeDefinition = "TypeDefinition";
        public const string Term = "Term";
        public const string Action = "Action";
        public const string EntityContainer = "EntityContainer";
        public const string Function = "Function";
    }

    /// <summary>
    /// To prevent enum parsing errors, all enums are rendered as constants.
    /// </summary>
    public static class EdmTypeKindValues
    {
        public const string None = "None";
        public const string Primitive = "Primitive";
        public const string Entity = "Entity";
        public const string Complex = "Complex";
        public const string Collection = "Collection";
        public const string EntityReference = "EntityReference";
        public const string Enum = "Enum";
        public const string TypeDefinition = "TypeDefinition";
        public const string Untyped = "Untyped";
        public const string Path = "Path";
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
        public const string Fail = "Fail";
    }
}
