/*
В базе данных MS SQL Server есть продукты и категории. Одному продукту может соответствовать много категорий, в одной категории может быть много продуктов. 
Напишите SQL запрос для выбора всех пар «Имя продукта – Имя категории». 
Если у продукта нет категорий, то его имя все равно должно выводиться.
*/

SELECT p.name AS product, c.name AS category FROM Products AS p
LEFT JOIN ProductsCategories AS pc ON p.id = pc.productId
LEFT JOIN Category AS c ON c.id = pc.categoryId
ORDER BY product;
