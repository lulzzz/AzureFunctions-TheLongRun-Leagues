//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
using CQRSAzure.EventSourcing;
using System;
using System.Runtime.Serialization;

/// <remarks>
/// Each league will have an unique name
/// </remarks>
namespace Leagues.League.eventDefinition
{
    /// <summary>
    /// A new league was formed
    /// </summary>
    [Serializable()]
    [DomainNameAttribute("Leagues")]
    [Category("Organisation")]
    [EventAsOfDateAttribute("Date_Incorporated")]
    public partial class Formed :  IFormed
    {
        
        // Version number - always increment this if the event definition changes
        public const int EVENT_VERSION = 0;
        
        #region Private members
        // TODO: Make this property read only
        private System.DateTime _Date_Incorporated;
        
        // TODO: Make this property read only
        private string _Location;
        
        // TODO: Make this property read only
        private string _Notes;
        #endregion
        
        /// <summary>
        /// Empty constructor For serialisation
        /// This should be removed If serialisation Is Not needed
        /// </summary>
        public Formed()
        {
        }
        
        /// <summary>
        /// Create And populate a New instance Of this Class from the underlying Interface
        /// </summary>
        /// <remarks>
        /// This should be called When the Event Is created from an Event stream
        /// </remarks>
        public Formed(IFormed FormedInit)
        {
            _Date_Incorporated = FormedInit.Date_Incorporated;
            _Location = FormedInit.Location;
            _Notes = FormedInit.Notes;
        }
        
        /// <summary>
        /// Create And populate a New instance Of this Class from the underlying properties
        /// </summary>
        /// <remarks>
        /// This should be called When the Event Is created from an Event stream
        /// </remarks>
        /// <param name="Date Incorporated">
        /// The date the new league was officially formed
        /// </param>
        /// <param name="Location">
        /// </param>
        /// <param name="Notes">
        /// General notes
        /// These are just for logging as no business logic should be stored as notes
        /// </param>
        public Formed(System.DateTime Date_Incorporated_In, string Location_In, string Notes_In)
        {
            _Date_Incorporated = Date_Incorporated_In;
            _Location = Location_In;
            _Notes = Notes_In;
        }
        
        /// <summary>
        /// Create And populate a New instance Of this Class from the serialized data
        /// </summary>
        /// <param name="info">
        /// The SerializationInfo passed In containing the values Of this Event
        /// </param>
        /// <param name="context">
        /// Additional StreamingContext On how the Event Is streamed
        /// </param>
        Formed(SerializationInfo info, StreamingContext context)
        {
            _Date_Incorporated = info.GetDateTime("Date_Incorporated");
            _Location = info.GetString("Location");
            _Notes = info.GetString("Notes");
        }
        
        public uint Version
        {
            get
            {
                return EVENT_VERSION;
            }
        }
        
        /// <summary>
        /// The date the new league was officially formed
        /// </summary>
        public System.DateTime Date_Incorporated
        {
            get
            {
                return _Date_Incorporated;
            }
        }
        
        public string Location
        {
            get
            {
                return _Location;
            }
        }
        
        /// <summary>
        /// General notes
        /// </summary>
        /// <remarks>
        /// These are just for logging as no business logic should be stored as notes
        /// </remarks>
        public string Notes
        {
            get
            {
                return _Notes;
            }
        }
        
        /// <summary>
        /// Factory method To create an instance Of this Event
        /// </summary>
        /// <param name="Date Incorporated">
        /// The date the new league was officially formed
        /// </param>
        /// <param name="Location">
        /// </param>
        /// <param name="Notes">
        /// General notes
        /// These are just for logging as no business logic should be stored as notes
        /// </param>
        public static IFormed Create(System.DateTime Date_Incorporated_In, string Location_In, string Notes_In)
        {
            return new Formed(Date_Incorporated_In, Location_In, Notes_In);
        }
        
        /// <summary>
        /// Populates a SerializationInfo with the data needed to serialize this event instance
        /// </summary>
        /// <remarks>
        /// The version number is also to be saved
        /// </remarks>
        public void GetObjectData(SerializationInfo info, StreamingContext context)
        {
            info.AddValue("Date_Incorporated", _Date_Incorporated);
            info.AddValue("Location", _Location);
            info.AddValue("Notes", _Notes);
            info.AddValue("EVENT_VERSION", EVENT_VERSION);
        }
    }
}
