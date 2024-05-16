/*
Products

|   Id  |   Name        | 
_________________________
|   1   |   SomeName    |  
 
Categories

|   Id  |      Name      |
_________________________
|   1   |   SomeName    |

ProductCategories

|  ProductId  |   CategoryId  | 
_______________________________
|      1      |       1       | 

*/

SELECT p.Name, c.Name FROM Products AS p
LEFT JOIN ProductCategories AS pc
ON p.Id = pc.ProductId
JOIN Categories AS c
ON pc.CategoryId = c.Id
