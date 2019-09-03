# GP.Saldeo-Synchronizator

### Instruction to change the database model
1. Open the entity which you want to modify in the **GP.SS.Domain** project.
2. Modify the entity as you want by adding/removing column or modifing the datatypes of the columns.
3. Open the NuGet Package Manager console (*Tools -> NuGet Package Manager -> Package Manager Console*).
4. Type `Add-migration name_of_the_migration` and select the **GP.SS.Database** as default project in the Package Manager Console window and press enter. Migration should created a migration file with success.
5. After this type `Update-Database` and hit enter. After this the real database (in this case Oracle) will be updated.
