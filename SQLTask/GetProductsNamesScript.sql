SELECT [p].[Name] as [ProductName], [pc].[CategoryName]
	FROM [Products] as [p] LEFT JOIN (
		SELECT  [ProductCategory].[ProductId] AS [ProductId], [Categories].[Name] AS [CategoryName] 
		FROM [Categories] JOIN [ProductCategory] ON [Categories].[CategoryId] = [ProductCategory].[CategoryId]
	) AS [pc] ON [p].ProductId = [pc].[ProductId];