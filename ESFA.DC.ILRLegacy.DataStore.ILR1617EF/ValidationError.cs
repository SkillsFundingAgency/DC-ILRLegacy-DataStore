﻿using System;
using System.Collections.Generic;

namespace ESFA.DC.ILRLegacy.DataStore.ILR1617EF
{
    public partial class ValidationError
    {
        public int Id { get; set; }
        public int? Ukprn { get; set; }
        public string Source { get; set; }
        public string LearnAimRef { get; set; }
        public long? AimSeqNum { get; set; }
        public string SwsupAimId { get; set; }
        public string ErrorMessage { get; set; }
        public string FieldValues { get; set; }
        public string LearnRefNumber { get; set; }
        public string RuleName { get; set; }
        public string Severity { get; set; }
        public int? FileLevelError { get; set; }
    }
}
