// <auto-generated />
namespace CodeFirstExistingDatabase.Migrations
{
    using System.CodeDom.Compiler;
    using System.Data.Entity.Migrations;
    using System.Data.Entity.Migrations.Infrastructure;
    using System.Resources;
    
    [GeneratedCode("EntityFramework.Migrations", "6.1.3-40302")]
    public sealed partial class RenameTitleToNameInCourseTable : IMigrationMetadata
    {
        private readonly ResourceManager Resources = new ResourceManager(typeof(RenameTitleToNameInCourseTable));
        
        string IMigrationMetadata.Id
        {
            get { return "202005050901138_RenameTitleToNameInCourseTable"; }
        }
        
        string IMigrationMetadata.Source
        {
            get { return null; }
        }
        
        string IMigrationMetadata.Target
        {
            get { return Resources.GetString("Target"); }
        }
    }
}
