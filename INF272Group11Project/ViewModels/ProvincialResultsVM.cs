﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Collections.Generic;
using INF272Group11Project.Models;

namespace INF272Group11Project.ViewModels
{
    public class ProvincialResultsVM
    {
        public List<Party> Parties;
        public List<Candidate> Candidates;
        public List<ProvincialResult> Results;
        public NationalResultsVM resultsView;

        public StaffGUIDControl StaffView;
    }
}