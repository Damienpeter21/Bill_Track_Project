namespace Bill_Track.FrameWork
{
    public static class CommonVariable
    {
        public abstract class DefaultValues
        {
            public static int Zero = 0;
            public static int ONE = 1;
            public static int TWO = 2;
            public static int THREE = 3;
            public static int FOUR = 4;
            public static int FIVE = 5;
            public static int SIX = 6;
            public static int SEVEN = 7;
            public static int EIGHT = 8;
            public static int TEN = 10;
            public static string TRUE = "True";
            public static string FALSE = "False";
        }

        //GemBox (Excel Export) Details
        public static class GemBoxSettings
        {
            public const string LicenseKey = "EDWG-UK8O-D78A-OMUQ";
        }

        public class StroredProc
        {
            public class UserDetail
            {
                
                public const string UserAuthenticate = "UserAuthentication";
                public const string ManageUserDetails = "ManageUserDetails";
                public const string UserDetails_Delete = "UserDetails_Delete";
                public const string UserDetails_GetData = "UserDetails_GetData"; 
                public const string UserDetails_Save = "UserDetails_Save";
            }

            public class UserRole
            {
                public const string ManageUserRoles = "[dbo].[ManageUserRoles]";
                public const string GetUserRole = "[dbo].[ManageUserRoles]";
                public const string SaveuserRole = "[dbo].[ManageUserRoles]";
            }
            public class UserRight
            {
                //User Rights
                public const string ManageUserRights = "[dbo].[ManageUserRights]";
                public const string GetUserRights = "[dbo].[GetUserRightsByRoleID]";
                public const string SaveUserRights = "[dbo].[SaveUserRights]";
            }
            public class SupportDetails
            {
                public const string SaveSupportData = "[SupportData].[SaveSupportData]";
                public const string GetSupportData = "[SupportData].[GetSupportData]";
                public const string DeleteSupportData = "[SupportData].[DeleteSupportData]";
            }




 

        }

        /// <summary>
        /// To handle common session variable
        /// </summary>
        public static class SessionField
        {
            public const string UserId = "UserId";
            public const string UserName = "UserName";
            public const string FirstName = "FirstName";
            public const string LastName = "LastName";
            public const string RoleId = "RoleId";
            public const string Token = "Token";
            public const string HMenusJson = "HMenusJson";
            public const string VMenusJson = "VMenusJson";
            public const string Email = "Email";
            public const string FullName = "FullName";

            public const string UserRights = nameof(UserRights);
            public const string ImagePath = nameof(ImagePath);

            public const string ExportContent = "ExportContent";
            public const string ExportType = "ExportType";
            public const string ExportFileName = "ExportFileName";
        }

        public static class AreaName
        {
            public const string Administration = nameof(Administration);
            public const string SystemMaintenanc = nameof(SystemMaintenanc);
            public const string Projects = nameof(Projects);
            public const string PSRReport = nameof(PSRReport);
        }

        public static class ControllerName
        {
            public const string Home = nameof(Home);
            public const string Authentication = nameof(Authentication);
        }

        public static class ActionName
        {
            public const string Index = nameof(Index);
            public const string AccessDenied = nameof(AccessDenied);
        }

        /// <summary>
        /// To handle common MenuCodes variable
        /// </summary>
        public static class MenuCodes
        {
            //Main Modules
            public const string Dashboard = "lidashboard";
             
            public const string Logout = "lilogout";
        }

        public static class Parameter
        {
            public const string ActionId = nameof(ActionId);
            public const string FinancialYear = nameof(FinancialYear);

            public static class UserDetails
            {
                public const string Name = nameof(Name);
                public const string UserName = nameof(UserName);
                public const string pUsername = nameof(pUsername);
                public const string UserId = nameof(UserId);
                public const string pUserId = nameof(pUserId);
                public const string Email = nameof(Email);
                public const string Password = nameof(Password);
                public const string MailId = nameof(MailId);
            }

            public static class UserRights
            {
                public const string ModuleNo = nameof(ModuleNo);
                public const string UserId = nameof(UserId);
                public const string RoleId = nameof(RoleId);
                public const string ParentId = nameof(ParentId);
                public const string FetureIds = nameof(FetureIds);
                public const string Rights = nameof(Rights);
            }

            public static class UserRole
            {
                public const string RoleId = nameof(RoleId);
                public const string RoleName = nameof(RoleName);
                public const string Descriptions = nameof(Descriptions);
                public const string CreatedOn = nameof(CreatedOn);
            }

            public static class SupportData
            {
                //Support Data
                public const string GeneralId = nameof(GeneralId);
                public const string FieldID = nameof(FieldID);
                public const string FieldName = nameof(FieldName);
                public const string Fk_FieldID = nameof(Fk_FieldID);
            }


        }
    }
}