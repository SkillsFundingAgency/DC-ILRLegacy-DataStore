using System;
using System.Collections.Generic;

namespace ESFA.DC.ILRLegacy.DataStore.ILR1617EF
{
    public partial class SourceFile
    {
        public int Id { get; set; }
        public int Ukprn { get; set; }
        public string SourceFileName { get; set; }
        public DateTime? FilePreparationDate { get; set; }
        public string SoftwareSupplier { get; set; }
        public string SoftwarePackage { get; set; }
        public string Release { get; set; }
        public string SerialNo { get; set; }
        public DateTime? DateTime { get; set; }
    }
}
