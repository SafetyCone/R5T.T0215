using System;

using R5T.T0131;


namespace R5T.T0215.Z000.Platform
{
    /// <summary>
    /// These are names of .NET core library packs, names that were found as the directory names in the dotnet packs diretory.
    /// Example: C:\Program Files\dotnet\packs\Microsoft.NETCore.App.Ref => "Microsoft.NETCore.App.Ref"
    /// </summary>
    [ValuesMarker]
    public partial interface IDotnetPackNames : IValuesMarker
    {
        /// <summary>
        /// "Microsoft.AspNetCore.App.Ref"
        /// </summary>
        public string Microsoft_AspNetCore_App_Ref => "Microsoft.AspNetCore.App.Ref";

        /// <summary>
        /// "Microsoft.NETCore.App.Host.win-arm"
        /// </summary>
        public string Microsoft_NETCore_App_Host_win_arm => "Microsoft.NETCore.App.Host.win-arm";

        /// <summary>
        /// "Microsoft.NETCore.App.Host.win-arm64"
        /// </summary>
        public string Microsoft_NETCore_App_Host_win_arm64 => "Microsoft.NETCore.App.Host.win-arm64";

        /// <summary>
        /// "Microsoft.NETCore.App.Host.win-x64"
        /// </summary>
        public string Microsoft_NETCore_App_Host_win_x64 => "Microsoft.NETCore.App.Host.win-x64";

        /// <summary>
        /// "Microsoft.NETCore.App.Host.win-x86"
        /// </summary>
        public string Microsoft_NETCore_App_Host_win_x86 => "Microsoft.NETCore.App.Host.win-x86";

        /// <summary>
        /// "Microsoft.NETCore.App.Ref"
        /// </summary>
        public string Microsoft_NETCore_App_Ref => "Microsoft.NETCore.App.Ref";

        /// <summary>
        /// "Microsoft.WindowsDesktop.App.Ref"
        /// </summary>
        public string Microsoft_WindowsDesktop_App_Ref => "Microsoft.WindowsDesktop.App.Ref";

        /// <summary>
        /// "NETStandard.Library.Ref"
        /// </summary>
        public string NETStandard_Library_Ref => "NETStandard.Library.Ref";
    }
}
