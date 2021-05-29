-- Script Date: 5/29/2021 11:15 PM  - ErikEJ.SqlCeScripting version 3.5.2.87
CREATE TABLE [Words] (
  [WordId] INTEGER NOT NULL
, [BookId] INTEGER NOT NULL
, [FrequencyId] INTEGER NOT NULL
, [Word] TEXT NOT NULL
, CONSTRAINT [PK_Words] PRIMARY KEY ([WordId])
, CONSTRAINT fk_Books
    FOREIGN KEY (BookId)
    REFERENCES Book(BookId)
, CONSTRAINT fk_frequencies
    FOREIGN KEY (FrequencyId)
    REFERENCES Frequency(FrequencyId)
);
