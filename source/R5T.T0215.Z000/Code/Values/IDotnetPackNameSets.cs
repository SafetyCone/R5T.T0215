using System;

using R5T.T0131;


namespace R5T.T0215.Z000
{
    [ValuesMarker]
    public partial interface IDotnetPackNameSets : IValuesMarker
    {
        /// <summary>
        /// This is all .NET pack names present at:
        /// C:\Program Files\dotnet\packs\
        /// </summary>
        public IDotnetPackName[] All => new[]
        {
            Instances.DotnetPackNames.Microsoft_AspNetCore_App_Ref,
            Instances.DotnetPackNames.Microsoft_NETCore_App_Host_win_arm,
            Instances.DotnetPackNames.Microsoft_NETCore_App_Host_win_arm64,
            Instances.DotnetPackNames.Microsoft_NETCore_App_Host_win_x64,
            Instances.DotnetPackNames.Microsoft_NETCore_App_Host_win_x86,
            Instances.DotnetPackNames.Microsoft_NETCore_App_Ref,
            Instances.DotnetPackNames.Microsoft_WindowsDesktop_App_Ref,
            Instances.DotnetPackNames.NETStandard_Library_Ref,
        };

        /// <summary>
        /// This is the useful subset of .NET pack names.
        /// </summary>
        public IDotnetPackName[] Useful => new[]
        {
            Instances.DotnetPackNames.Microsoft_AspNetCore_App_Ref,
            Instances.DotnetPackNames.Microsoft_NETCore_App_Ref,
            Instances.DotnetPackNames.Microsoft_WindowsDesktop_App_Ref,
            Instances.DotnetPackNames.NETStandard_Library_Ref
        };

        /// <summary>
        /// This is the subset of .NET pack names used for .NET 6.
        /// </summary>
        public IDotnetPackName[] ForNet6 => new[]
        {
            Instances.DotnetPackNames.Microsoft_AspNetCore_App_Ref,
            Instances.DotnetPackNames.Microsoft_NETCore_App_Ref,
            Instances.DotnetPackNames.Microsoft_WindowsDesktop_App_Ref,
        };
    }
}
