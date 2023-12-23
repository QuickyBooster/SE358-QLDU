docker exec -itu root {name}  /bin/bash

/opt/mssql-tools/bin/sqlcmd -S localhost -U SA -P 'yourStrong(!)Password'

/opt/mssql-tools/bin/sqlcmd -S localhost -U SA -P 'yourStrong(!)Password' -Q "USE SE358_SchoolManagement;  SELECT * FROM Users; select * from information"

string connectionString = "Data Source=localhost,1433;Initial Catalog=SE358_SchoolManagement;User ID=SA;Password=yourStrong(!)Password;";