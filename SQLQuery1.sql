--create Database [Blogging]
--go
--use [Blogging]
--go
create table [Blogger](
	[BloggerID] int not null identity,
	[BloggerName] nvarchar(50) not null,
	[FacebookURL] nvarchar(max) not null
	CONSTRAINT [Blogger_PK] PRIMARY KEY ([BloggerID])
);
create table [Post](
	[PostID] int not null identity,
	[BloggerID] int not null,
	[Content] nvarchar(max),
	[Title] nvarchar(max),
	CONSTRAINT [PK_POST] PRIMARY KEY ([PostID]),
	CONSTRAINT [PK_BLOGGER_ID] FOREIGN KEY ([BloggerID]) References [Blogger] ([BloggerID])  ON DELETE CASCADE
);
select* from Blogger