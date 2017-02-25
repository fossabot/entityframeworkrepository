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

    // JobForm
    [Table("JobForm", Schema = "dbo")]
    [System.CodeDom.Compiler.GeneratedCode("EF.Reverse.POCO.Generator", "2.27.0.0")]
    public partial class JobForm: BaseEntity
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Column(@"JobFormID", Order = 1, TypeName = "int")]
        [Index(@"PK_JobForm", 1, IsUnique = true, IsClustered = true)]
        [Required]
        [Key]
        [Display(Name = "Job form ID")]
        public int JobFormId { get; set; } // JobFormID (Primary key)

        [Column(@"JobID", Order = 2, TypeName = "int")]
        [Required]
        [Display(Name = "Job ID")]
        public int JobId { get; set; } // JobID

        [Column(@"ShowFirstName", Order = 3, TypeName = "bit")]
        [Required]
        [Display(Name = "Show first name")]
        public bool ShowFirstName { get; set; } // ShowFirstName

        [Column(@"ShowLastName", Order = 4, TypeName = "bit")]
        [Required]
        [Display(Name = "Show last name")]
        public bool ShowLastName { get; set; } // ShowLastName

        [Column(@"ShowEmail", Order = 5, TypeName = "bit")]
        [Required]
        [Display(Name = "Show email")]
        public bool ShowEmail { get; set; } // ShowEmail

        [Column(@"ShowHeadline", Order = 6, TypeName = "bit")]
        [Required]
        [Display(Name = "Show headline")]
        public bool ShowHeadline { get; set; } // ShowHeadline

        [Column(@"ShowTelephone", Order = 7, TypeName = "bit")]
        [Required]
        [Display(Name = "Show telephone")]
        public bool ShowTelephone { get; set; } // ShowTelephone

        [Column(@"ShowAddress", Order = 8, TypeName = "bit")]
        [Required]
        [Display(Name = "Show address")]
        public bool ShowAddress { get; set; } // ShowAddress

        [Column(@"ShowPhoto", Order = 9, TypeName = "bit")]
        [Required]
        [Display(Name = "Show photo")]
        public bool ShowPhoto { get; set; } // ShowPhoto

        [Column(@"ShowVideo", Order = 10, TypeName = "bit")]
        [Required]
        [Display(Name = "Show video")]
        public bool ShowVideo { get; set; } // ShowVideo

        [Column(@"ShowEducation", Order = 11, TypeName = "bit")]
        [Required]
        [Display(Name = "Show education")]
        public bool ShowEducation { get; set; } // ShowEducation

        [Column(@"ShowExperience", Order = 12, TypeName = "bit")]
        [Required]
        [Display(Name = "Show experience")]
        public bool ShowExperience { get; set; } // ShowExperience

        [Column(@"ShowSummary", Order = 13, TypeName = "bit")]
        [Required]
        [Display(Name = "Show summary")]
        public bool ShowSummary { get; set; } // ShowSummary

        [Column(@"ShowCV", Order = 14, TypeName = "bit")]
        [Required]
        [Display(Name = "Show cv")]
        public bool ShowCv { get; set; } // ShowCV

        [Column(@"ShowCoverLetter", Order = 15, TypeName = "bit")]
        [Required]
        [Display(Name = "Show cover letter")]
        public bool ShowCoverLetter { get; set; } // ShowCoverLetter

        [Column(@"QuestionAnswerXML", Order = 16, TypeName = "varchar(max)")]
        [Display(Name = "Question answer xml")]
        public string QuestionAnswerXml { get; set; } // QuestionAnswerXML

        [Column(@"UpdatedBy", Order = 17, TypeName = "int")]
        [Required]
        [Display(Name = "Updated by")]
        public int UpdatedBy { get; set; } // UpdatedBy

        [Column(@"CreatedBy", Order = 18, TypeName = "int")]
        [Required]
        [Display(Name = "Created by")]
        public int CreatedBy { get; set; } // CreatedBy

        [Column(@"DateAdded", Order = 19, TypeName = "datetime")]
        [Required]
        [Display(Name = "Date added")]
        public System.DateTime DateAdded { get; set; } // DateAdded

        [Column(@"DateUpdated", Order = 20, TypeName = "datetime")]
        [Required]
        [Display(Name = "Date updated")]
        public System.DateTime DateUpdated { get; set; } // DateUpdated

        // Foreign keys
        [JsonIgnore]
        [ForeignKey("JobId")] public virtual Job Job { get; set; } // FK_JobForm_Job

        public JobForm()
        {
            InitializePartial();
        }

        partial void InitializePartial();
    }

}
// </auto-generated>
