#To be ran when the schema changes
#Note that this may fail - SQLite cannot execute all required instructions.
#Run migrate.sh in such a circumstance
NAME="Migration-"`date +'%s'`    #Make a `unique` name based on timestamp
dotnet ef migrations add $NAME   #Generate the migration
dotnet ef database update $NAME  #Apply the migration to the DB
