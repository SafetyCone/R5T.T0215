using System;

using R5T.T0132;


namespace R5T.T0215.Extensions
{
    [FunctionalityMarker]
    public partial interface IStringOperator : IFunctionalityMarker
    {
        /// <inheritdoc cref="IDotnetPackName"/>
        public IDotnetPackName ToDotnetPackName(string value)
        {
            var output = new DotnetPackName(value);
            return output;
        }
    }
}
