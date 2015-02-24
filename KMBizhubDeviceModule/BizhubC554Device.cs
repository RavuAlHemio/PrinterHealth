﻿using System.Collections.Generic;

namespace KMBizhubDeviceModule
{
    /// <summary>
    /// Device access class supporting Konica Minolta C454, C554, and C554e.
    /// </summary>
    public class BizhubC554Device : BizhubDevice
    {
        public BizhubC554Device(Dictionary<string, string> parameters)
            : base(parameters)
        {
        }

        public override string ErrorJobsXPath
        {
            get { return "/MFP/JobList/Job[JobStatus/Status='ErrorPrinting']"; }
        }

        public override string AllJobsXPath
        {
            get { return "/MFP/JobList/Job"; }
        }

        public override string ActiveJobsEndpoint
        {
            get { return "/wcd/job_active.xml"; }
        }
    }
}
