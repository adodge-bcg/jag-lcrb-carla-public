﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Gov.Lclb.Cllb.Public.ViewModels
{
    public class ApplicationType
    {
        public string Id;
        public string ActionText;
        public string Name;
        public LicenseType LicenseType;

        public string Title;
        public string Preamble;
        public string BeforeStarting;
        public string NextSteps;

        public bool? ShowPropertyDetails;
        public bool? ShowCurrentProperty;
        public bool? ShowHoursOfSale;
        public bool? ShowAssociatesFormUpload;
        public bool? ShowFinancialIntegrityFormUpload;
        public bool? ShowSupportingDocuments;
        public bool? ShowDeclarations;
    }
}
