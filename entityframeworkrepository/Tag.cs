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

    // Tag
    [Table("Tag", Schema = "dbo")]
    [System.CodeDom.Compiler.GeneratedCode("EF.Reverse.POCO.Generator", "2.27.0.0")]
    public partial class Tag: BaseEntity
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Column(@"TagID", Order = 1, TypeName = "int")]
        [Index(@"PK_Tag", 1, IsUnique = true, IsClustered = true)]
        [Required]
        [Key]
        [Display(Name = "Tag ID")]
        public int TagId { get; set; } // TagID (Primary key)

        [Column(@"TagName", Order = 2, TypeName = "varchar")]
        [Required]
        [MaxLength(20)]
        [StringLength(20)]
        [Display(Name = "Tag name")]
        public string TagName { get; set; } // TagName (length: 20)

        [Column(@"JobFormResultID", Order = 3, TypeName = "int")]
        [Required]
        [Display(Name = "Job form result ID")]
        public int JobFormResultId { get; set; } // JobFormResultID

        [Column(@"UpdatedBy", Order = 4, TypeName = "int")]
        [Required]
        [Display(Name = "Updated by")]
        public int UpdatedBy { get; set; } // UpdatedBy

        [Column(@"CreatedBy", Order = 5, TypeName = "int")]
        [Required]
        [Display(Name = "Created by")]
        public int CreatedBy { get; set; } // CreatedBy

        [Column(@"DateAdded", Order = 6, TypeName = "datetime")]
        [Required]
        [Display(Name = "Date added")]
        public System.DateTime DateAdded { get; set; } // DateAdded

        [Column(@"DateUpdated", Order = 7, TypeName = "datetime")]
        [Required]
        [Display(Name = "Date updated")]
        public System.DateTime DateUpdated { get; set; } // DateUpdated

        public Tag()
        {
            InitializePartial();
        }

        partial void InitializePartial();
    }

}
// </auto-generated>
