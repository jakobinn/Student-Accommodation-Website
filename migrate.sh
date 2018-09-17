#To be ran when SQLite cannot perform the regular migration
#You probably want to try running migrate-nice.sh first.
sudo rm -rf Migrations/                 #Remove any previous migrations
dotnet ef database drop                 #Drop the database
dotnet ef migrations add InitialCreate  #Generate the migration
dotnet ef database update               #Generate the DB
