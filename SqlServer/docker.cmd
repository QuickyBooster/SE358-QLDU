docker ps 
// ra id, lay id thay vao
docker exec -itu root {id}  /bin/bash

/opt/mssql-tools/bin/sqlcmd -S localhost -U SA -P 'yourStrong(!)Password' -i "SchoolManagement.sql"
