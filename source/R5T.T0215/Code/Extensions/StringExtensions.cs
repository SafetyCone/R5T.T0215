using System;


namespace R5T.T0215.Extensions
{
    public static class StringExtensions
    {
        /// <inheritdoc cref="IStringOperator.ToDotnetPackName(string)"/>
        public static IDotnetPackName ToDotnetPackName(this string value)
        {
            return Instances.StringOperator_Extensions.ToDotnetPackName(value);
        }
    }
}
