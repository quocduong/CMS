# Migration
- Install Microsoft.EntityFrameworkCore.Tools package
- in CMS.Web.Mvc (web project) install Microsoft.EntityFrameworkCore.Design package
- Make sure in project has migration MUST HAVE a DbContext file

Open Package Manager Console run command:
# Add Migration:
Add-Migration MigrationName (Ex: add-migration addTableXxx)
# Update database
Update-database