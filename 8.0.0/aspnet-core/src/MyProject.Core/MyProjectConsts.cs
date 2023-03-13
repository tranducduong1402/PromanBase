using MyProject.Debugging;

namespace MyProject
{
    public class MyProjectConsts
    {
        public const string LocalizationSourceName = "MyProject";

        public const string ConnectionStringName = "Default";

        public const bool MultiTenancyEnabled = true;


        /// <summary>
        /// Default pass phrase for SimpleStringCipher decrypt/encrypt operations
        /// </summary>
        public static readonly string DefaultPassPhrase =
            DebugHelper.IsDebug ? "gsKxGZ012HLL3MI5" : "1a8ac1aceb1646c5a95a4ecfe0e71c59";
    }
}
