//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
using CQRSAzure.CommandDefinition;

/// <remarks>
/// Each league will have an unique name
/// </remarks>
namespace Leagues.League.commandDefinition
{



    /// <summary>
    /// Set the email address for the league
    /// </summary>
    public  interface ISet_Email_Address_Definition : ICommandDefinition
    {
        
        /// <summary>
        /// The new enail address for the league
        /// </summary>
        string New_Email_Address
        {
            get;
        }
        
        int Notes
        {
            get;
        }
        
        /// <summary>
        /// The name of the league whose email address is being set
        /// </summary>
        /// <remarks>
        /// This is the unique key for the league aggregate
        /// </remarks>
        string LeagueName
        {
            get;
        }
    }
}
