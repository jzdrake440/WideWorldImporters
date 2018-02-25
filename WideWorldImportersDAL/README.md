## Scaffolding
Scaffold-DbContext "Server=.;Database=WideWorldImporters;Trusted_Connection=True;" Microsoft.EntityFrameworkCore.SqlServer -OutputDir DAL -Verbose -Force

Do not use -DataAnnotations because these do not fully support many-to-many keys.