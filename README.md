# BookStoreApi
## Addding Migration
    dotnet ef migrations add "migration message" --project src/Infrastructure --startup-project src/Api -o Persistence/Migrations 

## Updating database
    dotnet ef database update  --project src/Infrastructure --startup-project src/Api 
