using learnpro.Debugging;

namespace learnpro
{
    public class learnproConsts
    {
        public const string LocalizationSourceName = "learnpro";

        public const string ConnectionStringName = "Default";

        public const bool MultiTenancyEnabled = true;


        /// <summary>
        /// Default pass phrase for SimpleStringCipher decrypt/encrypt operations
        /// </summary>
        public static readonly string DefaultPassPhrase =
            DebugHelper.IsDebug ? "gsKxGZ012HLL3MI5" : "82cb257b7c4a4f20aab01b0d1dfccb1e";
    }
}
