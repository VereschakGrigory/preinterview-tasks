CREATE TABLE [Categories] (
	[CategoryId] int NOT NULL IDENTITY,
	[Name] nvarchar(max) NOT NULL,
	CONSTRAINT [PK_Categories] PRIMARY KEY ([CategoryId])
);

CREATE TABLE [Products] (
	[ProductId] int NOT NULL IDENTITY,
	[Name] nvarchar(max) NOT NULL,
	CONSTRAINT [PK_Products] PRIMARY KEY ([ProductId])
);

CREATE TABLE [ProductCategory] (
	[ProductId] int NOT NULL,
	[CategoryId] int NOT NULL,
	CONSTRAINT [PK_ProductCategory] PRIMARY KEY ([ProductId], [CategoryId]),
	CONSTRAINT [FK_ProductCategory_Categories_CategoryId] FOREIGN KEY ([CategoryId]) REFERENCES [Categories] ([CategoryId]) ON DELETE CASCADE,
	CONSTRAINT [FK_ProductCategory_Products_ProductId] FOREIGN KEY ([ProductId]) REFERENCES [Products] ([ProductId]) ON DELETE CASCADE
);