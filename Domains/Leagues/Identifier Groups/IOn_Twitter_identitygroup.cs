//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

/// <remarks>
/// Each league will have an unique name
/// </remarks>
namespace Leagues.League.identitygroup
{
    using System;
    using CQRSAzure.EventSourcing;
    using Leagues.League;
    
    
    /// <summary>
    /// Leagues that have a twitter presence
    /// </summary>
    public partial interface IOn_Twitter : 
        CQRSAzure.IdentifierGroup.IIdentifierGroup<ILeague>
    {
    }
}
