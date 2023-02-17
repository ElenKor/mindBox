# MindBox

1. [Задание 1. C# библиотека](#Задание-1) 
2. [Задание 2. SQL запрос](#Задание-2)


## Задание 1

### Задача
Написать на C# библиотеку для поставки внешним клиентам, которая умеет вычислять площадь круга по радиусу и треугольника по трем сторонам.   
Дополнительно реализовать:
  1. Юнит-тесты
  2. Легкость добавления других фигур
  3. Вычисление площади фигуры без знания типа фигуры в compile-time
  4. Проверку на то, является ли треугольник прямоугольным 
### Реализация
[Библиотека](https://github.com/ElenKor/mindbox/blob/main/SquareCalc/SquareCalc/Class1.cs)  
[Unit-tests](https://github.com/ElenKor/mindbox/blob/main/SqureCalculaton.Tests/SqureCalculaton.Tests/UnitTest1.cs)

## Задание 2
### Задача
В базе данных MS SQL Server есть продукты и категории. 
Одному продукту может соответствовать много категорий, в одной категории может быть много продуктов.
Написать SQL запрос для выбора всех пар «Имя продукта – Имя категории». 
Если у продукта нет категорий, то его имя все равно должно выводиться.
### Реализация
[SQL запрос](https://github.com/ElenKor/mindbox/blob/main/task.sql)
