using System;


namespace R5T.T0215.Z000
{
    public class DotnetPackNames : IDotnetPackNames
    {
        #region Infrastructure

        public static IDotnetPackNames Instance { get; } = new DotnetPackNames();


        private DotnetPackNames()
        {
        }

        #endregion
    }
}
