﻿using System;

namespace ESFA.DC.ILRLegacy.DataStore.ILR1617EF
{
    public partial class CollectionDetails
    {
        public int Ukprn { get; set; }
        public string Collection { get; set; }
        public string Year { get; set; }
        public DateTime? FilePreparationDate { get; set; }
    }
}
