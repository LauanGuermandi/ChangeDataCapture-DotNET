CREATE DATABASE REPORTS
GO

USE REPORTS
GO

CREATE TABLE PESSOA(
    NAME VARCHAR(255) NOT NULL
)
GO

EXEC sys.sp_cdc_enable_db;
GO
EXEC sys.sp_cdc_enable_table @source_schema = 'dbo', @source_name = 'PESSOA', @role_name = NULL, @supports_net_changes = 0;
GO
