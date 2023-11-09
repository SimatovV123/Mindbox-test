# Mindbox-test
Тестовое задание Mindbox <br>
1. "Вычисление площади фигуры без знания типа фигуры в compile-time". Сначала полагал что в задании опечатка и имеется ввиду run-time. Но просто добавил уровень абстракции <br> Figure, чтобы апкастить к нему фигуры и вычислять площадь, без знания что это конкретно за фигура. Надеюсь условие задания выполнено:) <br>
2. Для выполнения и проверки второго задания создал тестовую базу, таблицы и наполнил их данными продуктового магазина. Скрипт для заполнения тестовыми данными и скрины таблиц
находятся в корне проекта (TestData.sql, products_table.PNG, categories_table.PNG, productcats_table.PNG) <br>
"Если у продукта нет категорий, то его имя все равно должно выводиться." Нужно ли создавать и выводить категории, у которых нет продуктов, в задании не говорится. Поэтому
взял таблицу продуктов как главную и использовал LEFT JOIN. Скрипт находится в файле ProductsQuery.sql, результаты на скрине result.PNG.

