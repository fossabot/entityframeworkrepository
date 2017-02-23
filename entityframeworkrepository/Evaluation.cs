// <auto-generated>
// ReSharper disable ConvertPropertyToExpressionBody
// ReSharper disable DoNotCallOverridableMethodsInConstructor
// ReSharper disable InconsistentNaming
// ReSharper disable PartialMethodWithSinglePart
// ReSharper disable PartialTypeWithSinglePart
// ReSharper disable RedundantNameQualifier
// ReSharper disable RedundantOverridenMember
// ReSharper disable UseNameofExpression
// TargetFrameworkVersion = 4.51
#pragma warning disable 1591    //  Ignore "Missing XML Comment" warning

using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using entityframeworkrepository.core.entity;

namespace entityframeworkrepository
{
    using entityframeworkrepository.core;
    using System.ComponentModel.DataAnnotations;

    // The table 'Evaluation' is not usable by entity framework because it
    // does not have a primary key. It is listed here for completeness.
    // Evaluation
    [NotMapped]
    [System.CodeDom.Compiler.GeneratedCode("EF.Reverse.POCO.Generator", "2.27.0.0")]
    public partial class Evaluation: BaseEntity
    {
        [Column(@"EvaluationID", Order = 1, TypeName = "int")]
        [Display(Name = "Evaluation ID")]
        public int? EvaluationId { get; set; } // EvaluationID

        [Column(@"EvaluationText", Order = 2, TypeName = "varchar")]
        [MaxLength(100)]
        [StringLength(100)]
        [Display(Name = "Evaluation text")]
        public string EvaluationText { get; set; } // EvaluationText (length: 100)

        [Column(@"EvaluationOption", Order = 3, TypeName = "varchar")]
        [MaxLength(20)]
        [StringLength(20)]
        [Display(Name = "Evaluation option")]
        public string EvaluationOption { get; set; } // EvaluationOption (length: 20)

        [Column(@"EvalutionTypeID", Order = 4, TypeName = "int")]
        [Display(Name = "Evalution type ID")]
        public int? EvalutionTypeId { get; set; } // EvalutionTypeID

        [Column(@"JobFormResultID", Order = 5, TypeName = "int")]
        [Display(Name = "Job form result ID")]
        public int? JobFormResultId { get; set; } // JobFormResultID

        [Column(@"StageID", Order = 6, TypeName = "int")]
        [Display(Name = "Stage ID")]
        public int? StageId { get; set; } // StageID

        [Column(@"UpdatedBy", Order = 7, TypeName = "int")]
        [Display(Name = "Updated by")]
        public int? UpdatedBy { get; set; } // UpdatedBy

        [Column(@"CreatedBy", Order = 8, TypeName = "int")]
        [Display(Name = "Created by")]
        public int? CreatedBy { get; set; } // CreatedBy

        [Column(@"DateAdded", Order = 9, TypeName = "datetime")]
        [Display(Name = "Date added")]
        public System.DateTime? DateAdded { get; set; } // DateAdded

        [Column(@"DateUpdated", Order = 10, TypeName = "datetime")]
        [Display(Name = "Date updated")]
        public System.DateTime? DateUpdated { get; set; } // DateUpdated

        public Evaluation()
        {
            InitializePartial();
        }

        partial void InitializePartial();
    }

}
// </auto-generated>
