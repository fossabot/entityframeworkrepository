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

    // JobBoardCredential
    [System.CodeDom.Compiler.GeneratedCode("EF.Reverse.POCO.Generator", "2.27.0.0")]
    public partial class JobBoardCredentialConfiguration : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<JobBoardCredential>
    {
        public JobBoardCredentialConfiguration()
            : this("dbo")
        {
        }

        public JobBoardCredentialConfiguration(string schema)
        {
            Property(x => x.JobBoardUserName).IsUnicode(false);
            Property(x => x.JobBoardPassword).IsUnicode(false);
            Property(x => x.JobBoardUrl).IsUnicode(false);

            InitializePartial();
        }
        partial void InitializePartial();
    }

}
// </auto-generated>
