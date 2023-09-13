using System;

using R5T.T0131;

using R5T.T0215.Extensions;


namespace R5T.T0215.Z000
{
    /// <inheritdoc cref="Platform.IDotnetPackNames"/>
    [ValuesMarker]
    public partial interface IDotnetPackNames : IValuesMarker
    {
#pragma warning disable IDE1006 // Naming Styles
        public Platform.IDotnetPackNames _Platform => Platform.DotnetPackNames.Instance;
#pragma warning restore IDE1006 // Naming Styles


        /// <inheritdoc cref="Platform.IDotnetPackNames.Microsoft_AspNetCore_App_Ref"/>
        public IDotnetPackName Microsoft_AspNetCore_App_Ref => _Platform.Microsoft_AspNetCore_App_Ref.ToDotnetPackName();

        /// <inheritdoc cref="Platform.IDotnetPackNames.Microsoft_NETCore_App_Host_win_arm"/>
        public IDotnetPackName Microsoft_NETCore_App_Host_win_arm => _Platform.Microsoft_NETCore_App_Host_win_arm.ToDotnetPackName();

        /// <inheritdoc cref="Platform.IDotnetPackNames.Microsoft_NETCore_App_Host_win_arm64"/>
        public IDotnetPackName Microsoft_NETCore_App_Host_win_arm64 => _Platform.Microsoft_NETCore_App_Host_win_arm64.ToDotnetPackName();

        /// <inheritdoc cref="Platform.IDotnetPackNames.Microsoft_NETCore_App_Host_win_x64"/>
        public IDotnetPackName Microsoft_NETCore_App_Host_win_x64 => _Platform.Microsoft_NETCore_App_Host_win_x64.ToDotnetPackName();

        /// <inheritdoc cref="Platform.IDotnetPackNames.Microsoft_NETCore_App_Host_win_x86"/>
        public IDotnetPackName Microsoft_NETCore_App_Host_win_x86 => _Platform.Microsoft_NETCore_App_Host_win_x86.ToDotnetPackName();

        /// <inheritdoc cref="Platform.IDotnetPackNames.Microsoft_NETCore_App_Ref"/>
        public IDotnetPackName Microsoft_NETCore_App_Ref => _Platform.Microsoft_NETCore_App_Ref.ToDotnetPackName();

        /// <inheritdoc cref="Platform.IDotnetPackNames.Microsoft_WindowsDesktop_App_Ref"/>
        public IDotnetPackName Microsoft_WindowsDesktop_App_Ref => _Platform.Microsoft_WindowsDesktop_App_Ref.ToDotnetPackName();

        /// <inheritdoc cref="Platform.IDotnetPackNames.NETStandard_Library_Ref"/>
        public IDotnetPackName NETStandard_Library_Ref => _Platform.NETStandard_Library_Ref.ToDotnetPackName();
    }
}
