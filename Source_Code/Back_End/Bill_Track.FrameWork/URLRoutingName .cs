namespace Bill_Track.FrameWork
{
    public static class URLRoutingName
    {

        public static class Login
        {
            public const string Authenticate = "authenticate";
            public const string Logout = "logout";
        }

        public static class Dashboard
        {
            public const string Index = "dashboard";
            public const string AccessDenied = "access-denied";
            public const string CustomError = "custom-error";

        }


        public static class UserDetails
        {
            public const string ViewUserDetails = "~/user-details";
            public const string AddUserDetails = "~/user-details-add";
            public const string Profile = "~/profile";
            public const string ChangePassword = "~/change-password";
            public const string ViewUserRole = "~/user-role";
            public const string UserRights = "~/user-rights";
            public const string SupportData = "~/support-data";


        }

        public static class Authentication
        {
            public const string Authenticate = "authenticate";
            public const string ForgetPassword = "forget-password";

            public const string Signup = "signup";
            public const string Login = "login";
            public const string LogOut = "logout";
        }


       


    }
}