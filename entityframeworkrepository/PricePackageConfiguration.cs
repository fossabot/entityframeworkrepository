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

    // PricePackage
    [System.CodeDom.Compiler.GeneratedCode("EF.Reverse.POCO.Generator", "2.27.0.0")]
    public partial class PricePackageConfiguration : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<PricePackage>
    {
        public PricePackageConfiguration()
            : this("dbo")
        {
        }

        public PricePackageConfiguration(string schema)
        {
            Property(x => x.PricePackageName).IsUnicode(false);
            Property(x => x.Price).HasPrecision(19,4);
            Property(x => x.Description).IsOptional().IsUnicode(false);
            Property(x => x.Description2).IsOptional().IsUnicode(false);
            Property(x => x.Discount).IsOptional().HasPrecision(19,4);
            InitializePartial();
        }
        partial void InitializePartial();
    }

}
// </auto-generated>
