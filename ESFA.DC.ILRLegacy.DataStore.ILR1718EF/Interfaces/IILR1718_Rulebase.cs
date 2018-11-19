using System.Data.Entity;

namespace ESFA.DC.ILRLegacy.DataStore.ILR1718EF.Interfaces
{
    public interface IILR1718_Rulebase
    {
        DbSet<AEC_ApprenticeshipPriceEpisode> AEC_ApprenticeshipPriceEpisode { get; set; }
         DbSet<AEC_ApprenticeshipPriceEpisode_Period> AEC_ApprenticeshipPriceEpisode_Period { get; set; }
         DbSet<AEC_ApprenticeshipPriceEpisode_PeriodisedValues> AEC_ApprenticeshipPriceEpisode_PeriodisedValues { get; set; }
         DbSet<AEC_HistoricEarningOutput> AEC_HistoricEarningOutput { get; set; }
         DbSet<AEC_LearningDelivery> AEC_LearningDelivery { get; set; }
         DbSet<AEC_LearningDelivery_Period> AEC_LearningDelivery_Period { get; set; }
         DbSet<AEC_LearningDelivery_PeriodisedTextValues> AEC_LearningDelivery_PeriodisedTextValues { get; set; }
         DbSet<AEC_LearningDelivery_PeriodisedValues> AEC_LearningDelivery_PeriodisedValues { get; set; }
         DbSet<ALB_Cases> ALB_Cases { get; set; }
         DbSet<ALB_global> ALB_global { get; set; }
         DbSet<ALB_Learner_Period> ALB_Learner_Period { get; set; }
         DbSet<ALB_Learner_PeriodisedValues> ALB_Learner_PeriodisedValues { get; set; }
         DbSet<ALB_LearningDelivery> ALB_LearningDelivery { get; set; }
         DbSet<ALB_LearningDelivery_Period> ALB_LearningDelivery_Period { get; set; }
         DbSet<ALB_LearningDelivery_PeriodisedValues> ALB_LearningDelivery_PeriodisedValues { get; set; }
         DbSet<DV_Learner> DV_Learner { get; set; }
         DbSet<DV_LearningDelivery> DV_LearningDelivery { get; set; }
         DbSet<EFA_Cases> EFA_Cases { get; set; }
         DbSet<EFA_global> EFA_global { get; set; }
         DbSet<EFA_Learner> EFA_Learner { get; set; }
         DbSet<EFA_SFA_Cases> EFA_SFA_Cases { get; set; }
         DbSet<EFA_SFA_global> EFA_SFA_global { get; set; }
         DbSet<EFA_SFA_Learner_Period> EFA_SFA_Learner_Period { get; set; }
         DbSet<EFA_SFA_Learner_PeriodisedValues> EFA_SFA_Learner_PeriodisedValues { get; set; }
         DbSet<ESF_DPOutcome> ESF_DPOutcome { get; set; }
         DbSet<ESF_LearningDelivery> ESF_LearningDelivery { get; set; }
         DbSet<ESF_LearningDeliveryDeliverable> ESF_LearningDeliveryDeliverable { get; set; }
         DbSet<ESF_LearningDeliveryDeliverable_Period> ESF_LearningDeliveryDeliverable_Period { get; set; }
         DbSet<ESF_LearningDeliveryDeliverable_PeriodisedValues> ESF_LearningDeliveryDeliverable_PeriodisedValues { get; set; }
         DbSet<ESFVAL_Cases> ESFVAL_Cases { get; set; }
         DbSet<SFA_Cases> SFA_Cases { get; set; }
         DbSet<SFA_global> SFA_global { get; set; }
         DbSet<SFA_LearningDelivery> SFA_LearningDelivery { get; set; }
         DbSet<SFA_LearningDelivery_Period> SFA_LearningDelivery_Period { get; set; }
         DbSet<SFA_LearningDelivery_PeriodisedValues> SFA_LearningDelivery_PeriodisedValues { get; set; }
         DbSet<TBL_Cases> TBL_Cases { get; set; }
         DbSet<TBL_global> TBL_global { get; set; }
         DbSet<TBL_LearningDelivery> TBL_LearningDelivery { get; set; }
         DbSet<TBL_LearningDelivery_Period> TBL_LearningDelivery_Period { get; set; }
         DbSet<TBL_LearningDelivery_PeriodisedValues> TBL_LearningDelivery_PeriodisedValues { get; set; }
         DbSet<VAL_Cases> VAL_Cases { get; set; }
         DbSet<VAL_global> VAL_global { get; set; }
         DbSet<VAL_Learner> VAL_Learner { get; set; }
         DbSet<VAL_LearningDelivery> VAL_LearningDelivery { get; set; }
         DbSet<VALDP_Cases> VALDP_Cases { get; set; }
         DbSet<VALDP_global> VALDP_global { get; set; }
         DbSet<AEC_Cases> AEC_Cases { get; set; }
         DbSet<DV_Cases> DV_Cases { get; set; }
         DbSet<ESF_Cases> ESF_Cases { get; set; }
         DbSet<VAL_ValidationError> VAL_ValidationError { get; set; }
         DbSet<VALDP_ValidationError> VALDP_ValidationError { get; set; }
         DbSet<VALFD_ValidationError> VALFD_ValidationError { get; set; }
    }
}