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

    // Department
    [Table("Department", Schema = "dbo")]
    [System.CodeDom.Compiler.GeneratedCode("EF.Reverse.POCO.Generator", "2.27.0.0")]
    public partial class Department: BaseEntity
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Column(@"DepartmentID", Order = 1, TypeName = "int")]
        [Required]
        [Display(Name = "Department ID")]
        public int DepartmentId { get; set; } // DepartmentID

        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Column(@"CompanyID", Order = 2, TypeName = "int")]
        [Index(@"PK_Department_1", 1, IsUnique = true, IsClustered = true)]
        [Required]
        [Key]
        [Display(Name = "Company ID")]
        public int CompanyId { get; set; } // CompanyID (Primary key)

        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Column(@"PersonID", Order = 3, TypeName = "int")]
        [Index(@"PK_Department_1", 2, IsUnique = true, IsClustered = true)]
        [Required]
        [Key]
        [Display(Name = "Person ID")]
        public int PersonId { get; set; } // PersonID (Primary key)

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

        // Foreign keys
        [JsonIgnore]
        [ForeignKey("CompanyId")] public virtual Company Company { get; set; } // FK_Department_Company
        [JsonIgnore]
        [ForeignKey("PersonId")] public virtual Person Person { get; set; } // FK_Department_Person

        public Department()
        {
            InitializePartial();
        }

        partial void InitializePartial();
    }

}
// </auto-generated>
