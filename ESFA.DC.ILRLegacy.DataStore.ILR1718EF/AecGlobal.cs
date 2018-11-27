using System;
using System.Collections.Generic;

namespace ESFA.DC.ILRLegacy.DataStore.ILR1718EF
{
    public partial class AecGlobal
    {
        public int Id { get; set; }
        public int? Ukprn { get; set; }
        public string Larsversion { get; set; }
        public string RulebaseVersion { get; set; }
        public string Year { get; set; }
    }
}
