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

    // InterviewKitAnswer
    [Table("InterviewKitAnswer", Schema = "dbo")]
    [System.CodeDom.Compiler.GeneratedCode("EF.Reverse.POCO.Generator", "2.27.0.0")]
    public partial class InterviewKitAnswer: BaseEntity
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Column(@"InterviewKitAnswerID", Order = 1, TypeName = "int")]
        [Index(@"PK_InterviewKitAnswer", 1, IsUnique = true, IsClustered = true)]
        [Required]
        [Key]
        [Display(Name = "Interview kit answer ID")]
        public int InterviewKitAnswerId { get; set; } // InterviewKitAnswerID (Primary key)

        [Column(@"JobID", Order = 2, TypeName = "int")]
        [Display(Name = "Job ID")]
        public int? JobId { get; set; } // JobID

        [Column(@"UpdatedBy", Order = 3, TypeName = "int")]
        [Required]
        [Display(Name = "Updated by")]
        public int UpdatedBy { get; set; } // UpdatedBy

        [Column(@"CreatedBy", Order = 4, TypeName = "int")]
        [Required]
        [Display(Name = "Created by")]
        public int CreatedBy { get; set; } // CreatedBy

        [Column(@"DateAdded", Order = 5, TypeName = "datetime")]
        [Required]
        [Display(Name = "Date added")]
        public System.DateTime DateAdded { get; set; } // DateAdded

        public InterviewKitAnswer()
        {
            InitializePartial();
        }

        partial void InitializePartial();
    }

}
// </auto-generated>
