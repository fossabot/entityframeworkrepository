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

    // Company
    [Table("Company", Schema = "dbo")]
    [System.CodeDom.Compiler.GeneratedCode("EF.Reverse.POCO.Generator", "2.27.0.0")]
    public partial class Company: BaseEntity
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Column(@"CompanyID", Order = 1, TypeName = "int")]
        [Index(@"PK_Company", 1, IsUnique = true, IsClustered = true)]
        [Required]
        [Key]
        [Display(Name = "Company ID")]
        public int CompanyId { get; set; } // CompanyID (Primary key)

        [Column(@"CompanyName", Order = 2, TypeName = "varchar")]
        [Required]
        [MaxLength(200)]
        [StringLength(200)]
        [Display(Name = "Company name")]
        public string CompanyName { get; set; } // CompanyName (length: 200)

        [Column(@"CompanyURL", Order = 3, TypeName = "varchar")]
        [MaxLength(200)]
        [StringLength(200)]
        [Display(Name = "Company url")]
        public string CompanyUrl { get; set; } // CompanyURL (length: 200)

        [Column(@"CompanySubDomain", Order = 4, TypeName = "varchar")]
        [MaxLength(200)]
        [StringLength(200)]
        [Display(Name = "Company sub domain")]
        public string CompanySubDomain { get; set; } // CompanySubDomain (length: 200)

        [Column(@"CompanyLogo", Order = 5, TypeName = "varchar")]
        [MaxLength(200)]
        [StringLength(200)]
        [Display(Name = "Company logo")]
        public string CompanyLogo { get; set; } // CompanyLogo (length: 200)

        [Column(@"CompanyProfile", Order = 6, TypeName = "varchar")]
        [Required]
        [MaxLength(200)]
        [StringLength(200)]
        [Display(Name = "Company profile")]
        public string CompanyProfile { get; set; } // CompanyProfile (length: 200)

        [Column(@"CompanyTelephone", Order = 7, TypeName = "varchar")]
        [MaxLength(20)]
        [StringLength(20)]
        [Display(Name = "Company telephone")]
        public string CompanyTelephone { get; set; } // CompanyTelephone (length: 20)

        [Column(@"CompanyTheme", Order = 8, TypeName = "varchar")]
        [MaxLength(100)]
        [StringLength(100)]
        [Display(Name = "Company theme")]
        public string CompanyTheme { get; set; } // CompanyTheme (length: 100)

        [Column(@"FirstName", Order = 9, TypeName = "varchar")]
        [MaxLength(20)]
        [StringLength(20)]
        [Display(Name = "First name")]
        public string FirstName { get; set; } // FirstName (length: 20)

        [Column(@"LastName", Order = 10, TypeName = "varchar")]
        [MaxLength(20)]
        [StringLength(20)]
        [Display(Name = "Last name")]
        public string LastName { get; set; } // LastName (length: 20)

        [Column(@"VATNo", Order = 11, TypeName = "varchar")]
        [MaxLength(50)]
        [StringLength(50)]
        [Display(Name = "Vatn o")]
        public string VatNo { get; set; } // VATNo (length: 50)

        [Column(@"Address", Order = 12, TypeName = "varchar")]
        [MaxLength(200)]
        [StringLength(200)]
        [Display(Name = "Address")]
        public string Address { get; set; } // Address (length: 200)

        [Column(@"PostCode", Order = 13, TypeName = "varchar")]
        [MaxLength(20)]
        [StringLength(20)]
        [Display(Name = "Post code")]
        public string PostCode { get; set; } // PostCode (length: 20)

        [Column(@"IsDeleted", Order = 14, TypeName = "int")]
        [Display(Name = "Is deleted")]
        public int? IsDeleted { get; set; } // IsDeleted

        [Column(@"CountryID", Order = 15, TypeName = "int")]
        [Display(Name = "Country ID")]
        public int? CountryId { get; set; } // CountryID

        [Column(@"City", Order = 16, TypeName = "int")]
        [Required]
        [Display(Name = "City")]
        public int City { get; set; } // City

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

        // Reverse navigation
        public virtual System.Collections.Generic.ICollection<Department> Departments { get; set; } // Many to many mapping

        public Company()
        {
            Departments = new System.Collections.Generic.List<Department>();
            InitializePartial();
        }

        partial void InitializePartial();
    }

}
// </auto-generated>
