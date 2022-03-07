#!/bin/bash

curl -i -X POST -H "Accept:application/json" -H  "Content-Type:application/json" http://localhost:8083/connectors/ -d '
{
    "name": "report-connector",
    "config": {
        "connector.class" : "io.debezium.connector.sqlserver.SqlServerConnector",
        "tasks.max" : "1",
        "database.server.name" : "reportserver",
        "database.hostname" : "sqlserver",
        "database.port" : "1433",
        "database.user" : "sa",
        "database.password" : "Secret@1234",
        "database.dbname" : "REPORTS",
        "database.history.kafka.bootstrap.servers" : "kafka:29092",
        "database.history.kafka.topic": "schema-changes.inventory"
    }
}
'
