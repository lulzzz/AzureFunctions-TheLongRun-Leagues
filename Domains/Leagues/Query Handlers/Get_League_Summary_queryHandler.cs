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
namespace Leagues.League.queryHandler
{
    using CQRSAzure.QueryHandler;
    using Leagues.League.queryDefinition;


    [CQRSAzure.EventSourcing.DomainNameAttribute("Leagues")]
    [CQRSAzure.EventSourcing.Category("Organisation")]
    public partial class Get_League_Summary_Handler : 
        QueryHandlerBase<IGet_League_Summary_Definition, IGet_League_Summary_Return>, 
        IGet_League_Summary_Handler
    {
        
        /// <summary>
        /// Handle the query definition
        /// Get League Summary
        /// </summary>
        /// <param name="qryToHandle">
        /// The instance of the query definition to handle and return data for
        /// </param>
        public override IGet_League_Summary_Return HandleQuery(IGet_League_Summary_Definition qryToHandle)
        {
            IGet_League_Summary_Return queryReturn = null;
            // TODO : Populate the query return value
            return queryReturn;
        }


    }
}
