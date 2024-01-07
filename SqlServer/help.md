1. run ```docker-compose up -d```

2. run ```docker ps```

3. select the id of the sqlserver
run this command```docker exec -itu root {id}  /bin/bash```

4. run ```/opt/mssql-tools/bin/sqlcmd -S localhost -U SA -P 'yourStrong(!)Password' -i "SchoolManagement.sql"```

5. go to `Visual Studio`

6. server explorer

7. connect to sqlserver

8. host: `localhost,1433`

9. sql authen: `SA` - `yourStrong(!)Password`

10. select SE358 table

11. DONE