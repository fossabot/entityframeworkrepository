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
    using System.ComponentModel.DataAnnotations;

    // TokenManager
    [System.CodeDom.Compiler.GeneratedCode("EF.Reverse.POCO.Generator", "2.27.0.0")]
    public class TokenManagerConfiguration : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<TokenManager>
    {
        public TokenManagerConfiguration()
            : this("dbo")
        {
        }

        public TokenManagerConfiguration(string schema)
        {
            Property(x => x.Token).IsOptional().IsUnicode(false);
            Property(x => x.Email).IsOptional().IsUnicode(false);
            Property(x => x.IpAddress).IsOptional().IsUnicode(false);
            Property(x => x.DateAdded).IsOptional();
        }
    }

}
// </auto-generated>