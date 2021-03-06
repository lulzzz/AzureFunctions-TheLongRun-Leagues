//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
using System;
using CQRSAzure.EventSourcing;

/// <remarks>
/// Each league will have an unique name
/// </remarks>
namespace Leagues.League
{

    /// <summary>
    /// A league to which clubs may belong
    /// </summary>
    /// <remarks>
    /// Each league will have an unique name
    /// </remarks>
    [DomainNameAttribute("Leagues")]
    public partial class League :  ILeague
    {
        
        private string _Name;
        
        /// <summary>
        /// Empty constructor for serialisation
        /// This should be removed if serialisation is not needed
        /// </summary>
        public League()
        {
        }
        
        /// <summary>
        /// Create an instance of the aggregate from its key identifier
        /// </summary>
        public League(string Name_In)
        {
            _Name = Name_In;
        }
        
        /// <summary>
        /// Returns the unique identifier of this League
        /// </summary>
        public string GetAggregateIdentifier()
        {
            return _Name;
        }
        
        /// <summary>
        /// Returns the unique identifier of this League
        /// </summary>
        public string GetKey()
        {
            return _Name;
        }
        
        /// <summary>
        /// Sets the unique identifier of this League
        /// </summary>
        public void SetKey(string Name_In)
        {
            _Name = Name_In;
        }
    }
}
