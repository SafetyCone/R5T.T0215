using System;

using R5T.T0178;
using R5T.T0179;


namespace R5T.T0215
{
    /// <summary>
    /// Strongly-types a string as the name of a .NET core library pack.
    /// Example: Microsoft.NETCore.App.Ref
    /// <para>
    /// These names can be found in the dotnet packs directory: C:\Program Files\dotnet\packs.
    /// </para>
    /// </summary>
    [StrongTypeMarker]
    public interface IDotnetPackName : IStrongTypeMarker,
        ITyped<string>
    {
    }
}