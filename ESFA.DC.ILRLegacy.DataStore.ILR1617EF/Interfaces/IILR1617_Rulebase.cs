using System.Data.Entity;

namespace ESFA.DC.ILRLegacy.DataStore.ILR1617EF.Interfaces
{
    public interface IILR1617_Rulebase
    {
        DbSet<AE_LearningDelivery> AE_LearningDelivery { get; set; }
         DbSet<AE_LearningDelivery_Period> AE_LearningDelivery_Period { get; set; }
         DbSet<AE_LearningDelivery_PeriodisedValues> AE_LearningDelivery_PeriodisedValues { get; set; }
         DbSet<AEC_ApprenticeshipPriceEpisode> AEC_ApprenticeshipPriceEpisode { get; set; }
         DbSet<AEC_ApprenticeshipPriceEpisode_Period> AEC_ApprenticeshipPriceEpisode_Period { get; set; }
         DbSet<AEC_ApprenticeshipPriceEpisode_PeriodisedValues> AEC_ApprenticeshipPriceEpisode_PeriodisedValues { get; set; }
         DbSet<AEC_LearningDelivery> AEC_LearningDelivery { get; set; }
         DbSet<AEC_LearningDelivery_Period> AEC_LearningDelivery_Period { get; set; }
         DbSet<AEC_LearningDelivery_PeriodisedTextValues> AEC_LearningDelivery_PeriodisedTextValues { get; set; }
         DbSet<AEC_LearningDelivery_PeriodisedValues> AEC_LearningDelivery_PeriodisedValues { get; set; }
         DbSet<ALB_global> ALB_global { get; set; }
         DbSet<ALB_Learner_Period> ALB_Learner_Period { get; set; }
         DbSet<ALB_Learner_PeriodisedValues> ALB_Learner_PeriodisedValues { get; set; }
         DbSet<ALB_LearningDelivery> ALB_LearningDelivery { get; set; }
         DbSet<ALB_LearningDelivery_Period> ALB_LearningDelivery_Period { get; set; }
         DbSet<ALB_LearningDelivery_PeriodisedValues> ALB_LearningDelivery_PeriodisedValues { get; set; }
         DbSet<DV_global> DV_global { get; set; }
         DbSet<DV_Learner> DV_Learner { get; set; }
         DbSet<DV_LearningDelivery> DV_LearningDelivery { get; set; }
         DbSet<EFA_global> EFA_global { get; set; }
         DbSet<EFA_Learner> EFA_Learner { get; set; }
         DbSet<EFA_SFA_global> EFA_SFA_global { get; set; }
         DbSet<EFA_SFA_Learner_Period> EFA_SFA_Learner_Period { get; set; }
         DbSet<EFA_SFA_Learner_PeriodisedValues> EFA_SFA_Learner_PeriodisedValues { get; set; }
         DbSet<ESF_DPOutcome> ESF_DPOutcome { get; set; }
         DbSet<ESF_global> ESF_global { get; set; }
         DbSet<ESF_LearningDelivery> ESF_LearningDelivery { get; set; }
         DbSet<ESF_LearningDeliveryDeliverable> ESF_LearningDeliveryDeliverable { get; set; }
         DbSet<ESF_LearningDeliveryDeliverable_Period> ESF_LearningDeliveryDeliverable_Period { get; set; }
         DbSet<ESF_LearningDeliveryDeliverable_PeriodisedValues> ESF_LearningDeliveryDeliverable_PeriodisedValues { get; set; }
         DbSet<ESFVAL_global> ESFVAL_global { get; set; }
         DbSet<SFA_global> SFA_global { get; set; }
         DbSet<SFA_LearningDelivery> SFA_LearningDelivery { get; set; }
         DbSet<SFA_LearningDelivery_Period> SFA_LearningDelivery_Period { get; set; }
         DbSet<SFA_LearningDelivery_PeriodisedValues> SFA_LearningDelivery_PeriodisedValues { get; set; }
         DbSet<TBL_global> TBL_global { get; set; }
         DbSet<TBL_LearningDelivery> TBL_LearningDelivery { get; set; }
         DbSet<TBL_LearningDelivery_Period> TBL_LearningDelivery_Period { get; set; }
         DbSet<TBL_LearningDelivery_PeriodisedValues> TBL_LearningDelivery_PeriodisedValues { get; set; }
         DbSet<TBLVAL_global> TBLVAL_global { get; set; }
         DbSet<VAL_global> VAL_global { get; set; }
         DbSet<VALDP_global> VALDP_global { get; set; }
         DbSet<ESFVAL_ValidationError> ESFVAL_ValidationError { get; set; }
         DbSet<TBLVAL_ValidationError> TBLVAL_ValidationError { get; set; }
         DbSet<VAL_ValidationError> VAL_ValidationError { get; set; }
         DbSet<VALDP_ValidationError> VALDP_ValidationError { get; set; }
         DbSet<VALFD_ValidationError> VALFD_ValidationError { get; set; }
    }
}