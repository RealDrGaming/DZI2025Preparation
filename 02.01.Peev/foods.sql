CREATE DATABASE [foodsdb]
USE [foodsdb]

/* 1 */

CREATE TABLE [Types]
(
	[ID] INT NOT NULL PRIMARY KEY IDENTITY(1, 1),
	[Type] VARCHAR(20) NOT NULL
)

CREATE TABLE [Foods] 
(
	[ID] INT NOT NULL PRIMARY KEY IDENTITY(1, 1),
	[Type_id] INT NOT NULL FOREIGN KEY REFERENCES [Types]([Id]),
	[Food] VARCHAR(30) NOT NULL,
	[Quantity] BIGINT NOT NULL,
	[Price] DECIMAL(5, 2) NOT NULL,
)

/* 2 */

INSERT INTO [Types] ([Type])
VALUES
    ('Fruits'),
    ('Vegetables'),
    ('Grains'),
    ('Dairy'),
    ('Meats'),
    ('Nuts'),
    ('Seeds'),
    ('Legumes');

INSERT INTO [Foods] ([Type_id], [Food], [Quantity], [Price])
VALUES
    (1, 'apples', 1000, 8.45),
    (1, 'bananas', 1000, 9.70),
    (1, 'oranges', 1000, 9.71),
    (1, 'strawberries', 100, 11.55),
    (1, 'blueberries', 100, 11.69),
    (2, 'broccoli', 250, 7.75),
    (2, 'spinach', 100, 4.14),
    (2, 'carrots', 1000, 7.04),
    (2, 'tomatoes', 1000, 4.25),
    (2, 'potatoes', 1000, 3.08),
    (3, 'oranges', 1000, 4.95),
    (3, 'rice', 1000, 4.48),
    (3, 'wheat', 1000, 8.20),
    (3, 'oats', 1000, 6.23),
    (3, 'barley', 1000, 4.39),
    (3, 'quinoa', 1000, 10.43),
    (4, 'milk', 1000, 5.17),
    (4, 'cheese', 1000, 4.87),
    (4, 'yogurt', 1000, 9.27),
    (4, 'butter', 1000, 8.58),
    (5, 'beef', 1000, 11.31),
    (5, 'chicken', 1000, 6.04),
    (5, 'pork', 1000, 5.58),
    (5, 'lamb', 1000, 10.49),
    (5, 'fish', 1000, 11.09),
    (6, 'almonds', 200, 3.33),
    (6, 'walnuts', 200, 3.32),
    (6, 'pistachios', 200, 6.85),
    (6, 'cashews', 200, 6.38),
    (7, 'almonds', 200, 9.72),
    (7, 'walnuts', 200, 10.52),
    (7, 'pistachios', 200, 10.21),
    (7, 'cashews', 200, 3.78),
    (8, 'beans', 1000, 9.18),
    (8, 'lentils', 1000, 5.43),
    (8, 'peas', 1000, 7.09),
    (8, 'chickpeas', 1000, 11.01),
    (8, 'soybeans', 250, 10.32);

/* 3 */

SELECT f.[Food], t.[Type], f.Price FROM [Foods] as f
JOIN [Types] AS t ON t.[ID] = f.[Type_id]
WHERE f.[Food] LIKE '_a%'
ORDER BY f.[Price] ASC

/* 4 */

UPDATE [Types]
SET [ID] = 10
WHERE [Type] = 'Meats'

SELECT f.[ID], f.[Type_id], f.[Food], f.[Quantity], f.[Price] FROM [Foods] AS f
JOIN [Types] AS t ON t.[ID] = f.[Type_id]
WHERE t.[Type] = 'Meats'

/* 5 */

SELECT t.[Type], COUNT(f.[Type_id]) AS [cnt], SUM(f.[Price]) AS [price_sum] FROM [Foods] AS f
JOIN [Types] AS t ON t.[ID] = f.[Type_id]
GROUP BY t.[Type]
HAVING SUM(f.[Price]) > 30
ORDER BY [price_sum] DESC

/* 6 */

