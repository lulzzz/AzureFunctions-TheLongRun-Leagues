//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
using CQRSAzure.QueryDefinition;
using CQRSAzure.EventSourcing;

/// <remarks>
/// Each league will have an unique name
/// </remarks>
namespace Leagues.League.queryDefinition
{

    [DomainNameAttribute("Leagues")]
    [Category("Organisation")]
    public partial class Get_League_Summary_Definition : 
        QueryDefinitionBase<IGet_League_Summary_Return>, 
        IGet_League_Summary_Definition
    {
        
        /// <summary>
        /// The unique name of this query
        /// Get League Summary
        /// </summary>
        public override string QueryName
        {
            get
            {
                return "Get League Summary";
            }
        }
        
        /// <summary>
        /// The league for which we want to get the summary information
        /// </summary>
        [CQRSAzure.EventSourcing.AggregateKey()]
        public string League_Name
        {
            get
            {
                return base.GetParameterValue<string>("League Name", 0);
            }
            set
            {
                base.SetParameterValue("League Name", 0, ref value);
            }
        }
    }
}
