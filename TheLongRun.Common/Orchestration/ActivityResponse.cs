﻿using System;
using System.Collections.Generic;
using System.Text;

namespace TheLongRun.Common.Orchestration
{
    /// <summary>
    /// A class to give feedback from a durable function 
    /// </summary>
    public class ActivityResponse
    {

        /// <summary>
        /// The name of the function that was called
        /// </summary>
        /// <remarks>
        /// This is just for logging - it would not be advisable to use this for any 
        /// branch logic as it is up to the developer to set it correctly
        /// </remarks>
        public string FunctionName { get; set; }

        /// <summary>
        /// A message returned from the activity that can be logged
        /// </summary>
        public string Message { get; set; }

        /// <summary>
        /// The activity had a fatal error and the calling orchestrator should be terminated 
        /// </summary>
        public bool FatalError { get; set; }

    }
}
