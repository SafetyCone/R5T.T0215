using System;


namespace R5T.T0215.Z000
{
    public class DotnetPackNameSets : IDotnetPackNameSets
    {
        #region Infrastructure

        public static IDotnetPackNameSets Instance { get; } = new DotnetPackNameSets();


        private DotnetPackNameSets()
        {
        }

        #endregion
    }
}
