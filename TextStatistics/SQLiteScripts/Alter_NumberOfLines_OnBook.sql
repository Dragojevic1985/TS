-- Script Date: 5/30/2021 10:40 PM  - ErikEJ.SqlCeScripting version 3.5.2.87
-- Adding as column with NOT NULL is not allowed, set a default value or allow NULL
ALTER TABLE [Book] ADD COLUMN [NumberOfLines] INTEGER NOT NULL;
