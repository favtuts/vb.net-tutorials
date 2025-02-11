# Basic CRUD Operation in Profiling System in VB.NET with Source Code
* Original Article: https://www.sourcecodester.com/visual-basic-net/13436/basic-crud-operation-profiling-system.html

This article demo CRUD for Studen Profile information based on VB.NET and SQL Server database.
We will base on this and make the changes for using Oracle Database

# Prepare StudentInfo table on Oracle database

We already have the script file `Scripts.txt` to create table StudentInfo on MS SQL Server database
```sql
CREATE TABLE [dbo].[StudentInfo] (
    [Id]            INT            NOT NULL IDENTITY,
    [LastName]      NVARCHAR (20)  NULL,
    [FirstName]     NVARCHAR (20)  NULL,
    [MiddleName]    NVARCHAR (20)  NULL,
    [Gender]        NVARCHAR (7)   NULL,
    [Birthday]      DATETIME       NULL,
    [ContactNumber] NVARCHAR (11)  NULL,
    [Address]       NVARCHAR (200) NULL,
    [Course]        NVARCHAR (100) NULL,
    [Year]          NVARCHAR (50)  NULL,
    [Section]       NVARCHAR (50)  NULL,
    [SchoolAddress] NVARCHAR (200) NULL,
    [Created]       DATETIME       NULL,
    PRIMARY KEY CLUSTERED ([Id] ASC)
);
```

We will use the [`SQLines.com`](https://www.sqlines.com/online) tool for coverting script from SQL Server to Oracle
```sql
CREATE TABLE StudentInfo (
    Id            NUMBER(10)            NOT NULL,
    LastName      NVARCHAR2 (20)  NULL,
    FirstName     NVARCHAR2 (20)  NULL,
    MiddleName    NVARCHAR2 (20)  NULL,
    Gender        NVARCHAR2 (7)   NULL,
    Birthday      TIMESTAMP(3)       NULL,
    ContactNumber NVARCHAR2 (11)  NULL,
    Address       NVARCHAR2 (200) NULL,
    Course        NVARCHAR2 (100) NULL,
    Year          NVARCHAR2 (50)  NULL,
    Section       NVARCHAR2 (50)  NULL,
    SchoolAddress NVARCHAR2 (200) NULL,
    Created       TIMESTAMP(3)       NULL,
    PRIMARY KEY (Id)
);

-- Generate ID using sequence and trigger
CREATE SEQUENCE StudentInfo_seq START WITH 1 INCREMENT BY 1;

CREATE OR REPLACE TRIGGER StudentInfo_seq_tr
 BEFORE INSERT ON StudentInfo FOR EACH ROW
 WHEN (NEW.Id IS NULL)
BEGIN
 SELECT StudentInfo_seq.NEXTVAL INTO :NEW.Id FROM DUAL;
END;
/
```