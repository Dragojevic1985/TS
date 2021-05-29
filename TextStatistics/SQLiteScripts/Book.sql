-- Script Date: 5/29/2021 11:11 PM  - ErikEJ.SqlCeScripting version 3.5.2.87
CREATE TABLE [Book] (
  [BookId] INTEGER NOT NULL
, [Title] TEXT NOT NULL
, [AuthorId] INTEGER NOT NULL
, CONSTRAINT [PK_Book] PRIMARY KEY ([BookId])
,CONSTRAINT Authors
    FOREIGN KEY (AuthorId)
    REFERENCES Author(AuthorId)
);
