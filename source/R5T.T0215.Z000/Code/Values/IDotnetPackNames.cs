using System;

using R5T.T0131;

using R5T.T0215.Extensions;


namespace R5T.T0215.Z000
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
        public IDotnetPackName Microsoft_AspNetCore_App_Ref => "Microsoft.AspNetCore.App.Ref".ToDotnetPackName();

        /// <summary>
        /// "Microsoft.NETCore.App.Host.win-arm"
        /// </summary>
        public IDotnetPackName Microsoft_NETCore_App_Host_win_arm => "Microsoft.NETCore.App.Host.win-arm".ToDotnetPackName();

        /// <summary>
        /// "Microsoft.NETCore.App.Host.win-arm64"
        /// </summary>
        public IDotnetPackName Microsoft_NETCore_App_Host_win_arm64 => "Microsoft.NETCore.App.Host.win-arm64".ToDotnetPackName();

        /// <summary>
        /// "Microsoft.NETCore.App.Host.win-x64"
        /// </summary>
        public IDotnetPackName Microsoft_NETCore_App_Host_win_x64 => "Microsoft.NETCore.App.Host.win-x64".ToDotnetPackName();

        /// <summary>
        /// "Microsoft.NETCore.App.Host.win-x86"
        /// </summary>
        public IDotnetPackName Microsoft_NETCore_App_Host_win_x86 => "Microsoft.NETCore.App.Host.win-x86".ToDotnetPackName();

        /// <summary>
        /// "Microsoft.NETCore.App.Ref"
        /// </summary>
        public IDotnetPackName Microsoft_NETCore_App_Ref => "Microsoft.NETCore.App.Ref".ToDotnetPackName();

        /// <summary>
        /// "Microsoft.WindowsDesktop.App.Ref"
        /// </summary>
        public IDotnetPackName Microsoft_WindowsDesktop_App_Ref => "Microsoft.WindowsDesktop.App.Ref".ToDotnetPackName();

        /// <summary>
        /// "NETStandard.Library.Ref"
        /// </summary>
        public IDotnetPackName NETStandard_Library_Ref => "NETStandard.Library.Ref".ToDotnetPackName();
    }
}
