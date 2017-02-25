// <auto-generated>
// ReSharper disable ConvertPropertyToExpressionBody
// ReSharper disable DoNotCallOverridableMethodsInConstructor
// ReSharper disable InconsistentNaming
// ReSharper disable PartialMethodWithSinglePart
// ReSharper disable PartialTypeWithSinglePart
// ReSharper disable RedundantNameQualifier
// ReSharper disable RedundantOverridenMember
// ReSharper disable UseNameofExpression
// TargetFrameworkVersion = 4.5
#pragma warning disable 1591    //  Ignore "Missing XML Comment" warning

using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace entityframeworkrepository
{
    using entityframeworkrepository;
    using entityframeworkrepository.core.entity;
    using Newtonsoft.Json;
    using System.Collections.ObjectModel;
    using System.ComponentModel.DataAnnotations;

    // JobFormResultsView
    [Table("JobFormResultsView", Schema = "dbo")]
    [System.CodeDom.Compiler.GeneratedCode("EF.Reverse.POCO.Generator", "2.27.0.0")]
    public partial class JobFormResultsView: BaseEntity
    {
        [Column(@"IsDeleted", Order = 1, TypeName = "tinyint")]
        [Display(Name = "Is deleted")]
        public System.Nullable<byte> IsDeleted { get; set; } // IsDeleted

        [Column(@"JobFormID", Order = 2, TypeName = "int")]
        [Display(Name = "Job form ID")]
        public System.Nullable<int> JobFormId { get; set; } // JobFormID

        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Column(@"CVBankID", Order = 3, TypeName = "int")]
        [Required]
        [Key]
        [Display(Name = "Cvb ank ID")]
        public int CvBankId { get; set; } // CVBankID (Primary key)

        [Column(@"CVBankFilename", Order = 4, TypeName = "varchar")]
        [MaxLength(100)]
        [StringLength(100)]
        [Display(Name = "Cvb ank filename")]
        public string CvBankFilename { get; set; } // CVBankFilename (length: 100)

        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Column(@"CVBankOwnerID", Order = 5, TypeName = "int")]
        [Required]
        [Key]
        [Display(Name = "Cvb ank owner ID")]
        public int CvBankOwnerId { get; set; } // CVBankOwnerID (Primary key)

        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Column(@"JobFormResultID", Order = 6, TypeName = "int")]
        [Required]
        [Key]
        [Display(Name = "Job form result ID")]
        public int JobFormResultId { get; set; } // JobFormResultID (Primary key)

        [Column(@"ApplicantName", Order = 7, TypeName = "varchar")]
        [MaxLength(41)]
        [StringLength(41)]
        [Display(Name = "Applicant name")]
        public string ApplicantName { get; set; } // ApplicantName (length: 41)

        [Column(@"CandidateID", Order = 8, TypeName = "int")]
        [Display(Name = "Candidate ID")]
        public System.Nullable<int> CandidateId { get; set; } // CandidateID

        [Column(@"ApplicantFakeName", Order = 9, TypeName = "varchar")]
        [MaxLength(101)]
        [StringLength(101)]
        [Display(Name = "Applicant fake name")]
        public string ApplicantFakeName { get; set; } // ApplicantFakeName (length: 101)

        [Column(@"DateApplied", Order = 10, TypeName = "datetime")]
        [Display(Name = "Date applied")]
        public System.Nullable<System.DateTime> DateApplied { get; set; } // DateApplied

        [Column(@"JobTitle", Order = 11, TypeName = "varchar")]
        [MaxLength(50)]
        [StringLength(50)]
        [Display(Name = "Job title")]
        public string JobTitle { get; set; } // JobTitle (length: 50)

        [Column(@"JobDescription", Order = 12, TypeName = "varchar")]
        [MaxLength(200)]
        [StringLength(200)]
        [Display(Name = "Job description")]
        public string JobDescription { get; set; } // JobDescription (length: 200)

        [Column(@"JobPosted_Name", Order = 13, TypeName = "varchar")]
        [MaxLength(71)]
        [StringLength(71)]
        [Display(Name = "Job posted name")]
        public string JobPostedName { get; set; } // JobPosted_Name (length: 71)

        [Column(@"JobUpdatedBy_Name", Order = 14, TypeName = "varchar")]
        [MaxLength(71)]
        [StringLength(71)]
        [Display(Name = "Job updated by name")]
        public string JobUpdatedByName { get; set; } // JobUpdatedBy_Name (length: 71)

        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Column(@"JobCreatedByID", Order = 15, TypeName = "int")]
        [Required]
        [Key]
        [Display(Name = "Job created by ID")]
        public int JobCreatedById { get; set; } // JobCreatedByID (Primary key)

        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Column(@"CompanyID", Order = 16, TypeName = "int")]
        [Required]
        [Key]
        [Display(Name = "Company ID")]
        public int CompanyId { get; set; } // CompanyID (Primary key)

        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Column(@"CompanyName", Order = 17, TypeName = "varchar")]
        [Required]
        [MaxLength(200)]
        [StringLength(200)]
        [Key]
        [Display(Name = "Company name")]
        public string CompanyName { get; set; } // CompanyName (Primary key) (length: 200)

        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Column(@"DepartmentID", Order = 18, TypeName = "int")]
        [Required]
        [Key]
        [Display(Name = "Department ID")]
        public int DepartmentId { get; set; } // DepartmentID (Primary key)

        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Column(@"Department", Order = 19, TypeName = "varchar")]
        [Required]
        [MaxLength(50)]
        [StringLength(50)]
        [Key]
        [Display(Name = "Department")]
        public string Department { get; set; } // Department (Primary key) (length: 50)

        public JobFormResultsView()
        {
            InitializePartial();
        }

        partial void InitializePartial();
    }

}
// </auto-generated>