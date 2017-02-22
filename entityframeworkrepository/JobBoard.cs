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

namespace entityframeworkrepository
{
    using entityframeworkrepository.core;
    using System.ComponentModel.DataAnnotations;

    // JobBoard
    [Table("JobBoard", Schema = "dbo")]
    [System.CodeDom.Compiler.GeneratedCode("EF.Reverse.POCO.Generator", "2.27.0.0")]
    public partial class JobBoard: BaseEntity
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Column(@"JobBoardID", Order = 1, TypeName = "int")]
        [Index(@"PK_JobBoard", 1, IsUnique = true, IsClustered = true)]
        [Required]
        [Key]
        [Display(Name = "Job board ID")]
        public int JobBoardId { get; set; } // JobBoardID (Primary key)

        [Column(@"JobBoardName", Order = 2, TypeName = "varchar")]
        [Required]
        [MaxLength(50)]
        [StringLength(50)]
        [Display(Name = "Job board name")]
        public string JobBoardName { get; set; } // JobBoardName (length: 50)

        [Column(@"JobBoardLogo", Order = 3, TypeName = "varchar")]
        [Required]
        [MaxLength(100)]
        [StringLength(100)]
        [Display(Name = "Job board logo")]
        public string JobBoardLogo { get; set; } // JobBoardLogo (length: 100)

        [Column(@"JobBoardTypeID", Order = 4, TypeName = "int")]
        [Required]
        [Display(Name = "Job board type ID")]
        public int JobBoardTypeId { get; set; } // JobBoardTypeID

        [Column(@"JobBoardDescription", Order = 5, TypeName = "varchar")]
        [MaxLength(100)]
        [StringLength(100)]
        [Display(Name = "Job board description")]
        public string JobBoardDescription { get; set; } // JobBoardDescription (length: 100)

        [Column(@"UpdatedBy", Order = 6, TypeName = "int")]
        [Required]
        [Display(Name = "Updated by")]
        public int UpdatedBy { get; set; } // UpdatedBy

        [Column(@"CreatedBy", Order = 7, TypeName = "int")]
        [Required]
        [Display(Name = "Created by")]
        public int CreatedBy { get; set; } // CreatedBy

        [Column(@"DateAdded", Order = 8, TypeName = "datetime")]
        [Required]
        [Display(Name = "Date added")]
        public System.DateTime DateAdded { get; set; } // DateAdded

        [Column(@"DateUpdated", Order = 9, TypeName = "datetime")]
        [Required]
        [Display(Name = "Date updated")]
        public System.DateTime DateUpdated { get; set; } // DateUpdated

        // Reverse navigation
        public virtual System.Collections.Generic.ICollection<JobBoardCredential> JobBoardCredentials { get; set; } // JobBoardCredential.FK_JobBoardCredential_JobBoard

        public JobBoard()
        {
            JobBoardCredentials = new System.Collections.Generic.List<JobBoardCredential>();
            InitializePartial();
        }

        partial void InitializePartial();
    }

}
// </auto-generated>
