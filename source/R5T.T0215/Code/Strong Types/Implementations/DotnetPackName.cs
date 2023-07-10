using System;

using R5T.T0178;
using R5T.T0179;


namespace R5T.T0215
{
    /// <inheritdoc cref="IDotnetPackName"/>
    [StrongTypeImplementationMarker]
    public class DotnetPackName : TypedBase<string>, IStrongTypeMarker,
        IDotnetPackName
    {
        public DotnetPackName(string value)
            : base(value)
        {
        }
    }
}