# Итоговая проверочная работа

*Данная работа необходима для проверки ваших знаний и навыков по итогу прохождения первого блока обучения на программе Разработчик. Мы должны убедится, что базовое знакомство с IT прошло успешно.*

Задача алгоритмически не самая сложная, однако для полноценного выполнения проверочной работы необходимо:

1. Создать репозиторий на GitHub
2. Нарисовать блок-схему алгоритма (можно обойтись блок-схемой основной содержательной части, если вы выделяете её в отдельный метод)
3. Снабдить репозиторий оформленным текстовым описанием решения (файл README.md)
4. Написать программу, решающую поставленную задачу
5. Использовать контроль версий в работе над этим небольшим проектом (не должно быть так, что всё залито одним коммитом, как минимум этапы 2, 3, и 4 должны быть расположены в разных коммитах)

**Задача: Написать программу, которая из имеющегося массива строк формирует новый массив из строк, длина которых меньше, либо равна 3 символам. Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма. При решении не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами.**

Примеры:   
[“Hello”, “2”, “world”, “:-)”] → [“2”, “:-)”]   
[“1234”, “1567”, “-2”, “computer science”] → [“-2”]   
[“Russia”, “Denmark”, “Kazan”] → []

## Описание решения задачи.

1. Вводим длину первоначального массива. Проверяем введенные данные. В случае если введено не целое число, то повторно запрашиваем ввод данных. Если введено отрицательное число или 0, то повторно запрашиваем ввод данных.

2. Вводим максимальную длину строки. Проверяем введенные данные. В случае если введено не целое число, то повторно запрашиваем ввод данных. Если введено отрицательное число или длина строки меньше 4-х символов, то повторно запрашиваем ввод данных. Если максимальная длина меньше 4-х символов, то все сгенерированные строки будут удовлетворять условию формирования второго массива и получим копию первого массива.

3. Создаем первоначальный массив заданной длины.

4. Заполняем массив строками. Используем метод генерации строки длиной от 1 до максимальной длины (см. пункт 2) состоящей из случайных символов Основной латиницы в Юникоде. (Тут не понятный момент, можно выставить чтобы генерировались и строки с нулевой длиной, и тогда они как удовлетворяющие условию будут переносится во второй массив и выводиться в консоль).

5. Выводим получившийся первоначальный массив (как понял из приведенных примеров).

6. Вычисляем количество строк массива удовлетворяющих условию (длина меньше, либо равна 3 символам).

7. Исходя из полученного количества создаем конечный массив.

8. В цикле переносим удовлетворяющие условию строки из первого массива во второй.

9. Выводим полученный конечный массив в консоль.

Помимо папки задача залита на Github: [Ссылка на github.com/tolyan-yalta/Final_Test_First_Term](https://github.com/tolyan-yalta/Final_Test_First_Term.git)

Блок схема алгоритма на app.diagrams.net : [Ссылка на app.diagrams.net](https://viewer.diagrams.net/?tags=%7B%7D&highlight=0000ff&edit=_blank&layers=1&nav=1&title=%D0%98%D1%82%D0%BE%D0%B3%D0%BE%D0%B2%D0%B0%D1%8F%20%D0%BF%D1%80%D0%BE%D0%B2%D0%B5%D1%80%D0%BE%D1%87%D0%BD%D0%B0%D1%8F%20%D1%80%D0%B0%D0%B1%D0%BE%D1%82%D0%B0.drawio#R7Vxtc%2BI2EP41zLQfyPgFG%2FMxkOR6uVwnN7lemn7pCKyAE2MRIxLor69ebVk2YJLYPi6eYTzWWpKl3X12VyuZjj2arz%2FFYDH7inwYdizDX3fss45lmT3L6tCf4W84pe8IwjQOfFEpJdwE%2F0FBNAR1FfhwmamIEQpxsMgSJyiK4ARnaCCO0Uu22j0Ks29dgCnMEW4mIMxTbwMfzzjVs%2Fop%2FQ8YTGfyzaY74E%2FmQFYWM1nOgI9eFJJ93rFHMUKY383XIxhS5km%2B3H7e3IZXj%2B6ny2%2FLJ%2FDX8Mv3P390eWcXhzRJphDDCL%2B660vvbrF5iq%2B%2FrB5e%2Fukj2P%2F272nXdHjfzyBcCYaJyeKN5CD0CUNFEcV4hqYoAuF5Sh3GaBX5kL7HIKW0zhVCC0I0CfEBYrwR2gFWGBHSDM9D8fQeRXiEQhSTsg%2FvwSrEgnoB5kFIVe8TRPE0AITMB0hHpUl4D3tEvSVaxRO4gydC3BjEU4h38S7RAQIeiOYQxxvSLoYhwMFzdnBAaPE0qZdKitwIYR0gOCMntxsyYJwXXhgSpFEhvcwCDG8WgM39hYA9K4JnGOOAwOY0DKYRoc0D32fC3SkF2gquXyGHPN9kL56YmrA3PVF8ScFrSkTOFODKeu%2FOadNtIVKo%2BiUg4jQJEbNAbi7jmh88k9spZpxyE0ZKGnE7gA6z4wzZ9UxWGsd6MzIwtaVCzrxDUxfiSRb0lsgDhCEM0TQGc1JxAeOAzB3G%2BrPr9ME%2BHN8HayjdsNk8fBOsNoZf22kCroSH8eZv2v7EkcU70R0rnK0zpY0oFcO8ajzbZV3eoElA22UA%2FUAhSx8axjY05tpgOF%2FkmxWifRess0qzD6f14tKxdLdagEu3Tlx6rVvVWdIrCUO3Ubfqtfb0vQRp9puUZK%2BMPQ0Uw0gZZzCC5YI5NWiCmwYLmU6uYDSlxkRUG7LfQRHRDK4BUQwtFhLUJAqyDg%2BDQjCG4RBMHqdMFYshf6AhqCB66mWttOXlrbRl1Lr6KVKSD26mnZLo7jUJ7nxiJ2TovAgI39Vg54iCmCRA2WhQaCyIKcoN5BeUkrZcgIjUnoRgyQfiPq1o9nD443OwCdIiqROCaJqpAiP1eWG%2FPsCgG63mYxh30X13MYvBEmZfZGZewhrwat2ASH2dqWvk69JRrcAUdjHq4hhES6LJtCmFq9IyXu1oeo%2FiLgiJFY8YCpY7ZlnAqcurp8vemDwazb4%2BGuO9PMn38K0XnN5O8g35qt9JXBxd9uuOjmHG3rlA4O99IzmrPDpCZ2g%2BXi33ozNJWMtAqACqlCzdJHWrQKT%2FJgSnLN2wxDF6TFLnJufsJGDa6aal78yQE5NXH%2FpttyT6vcqco5kTTq2hcCYQTuPig0LhhnxovyYfypqeioSerLBAxGQtlZ6vKSHVNC2HJdfOF%2BWq24ahaRZ%2Ff6pnyURer3r9fe7dEtYqr6LH5OGdxj283MdsA%2BCUJ4OS4G10dTvYGpqpC1Eij0GPXodb04WasInGY83PMhcppROhiG2bBWGokXK%2BdeueWxEosypUMy6T7XyZPizYliuCpV0ZLO1GXW9SeIvrhesAJ36c3N%2FJjsl92hEtyH6qBrZp1YTsV7nlJGet5bC3%2BWW9vubHq3HMkoWq3aFG5owZGadDJOzlPciHNCq2tidh9xs2Kna71b8lRV3CJNhNOnszHw%2B3iZhjTsQk6xh%2BBqPC%2FIq%2Bbmq15ii1Zt8xnRrycj%2Fxulrf%2Fk9cb2PrarsgTvrwvrbswtpq9ASA1IljPgHws0vYbvSklVkqedIeDahzsaQdDXAKdj%2FqPRpg9z68wVa%2BA3lDHiSfuNBkbRq6ELn9EM1SOR6aUXG0dHvf3Z1R0esnA6s0pSJjFcUa0ROb0qZs3aVt90255dCFXDb2q2zf1M4LtDUlZb%2BpsBrdVZEdt9sq7wHNnrat4hVsd9aaAZVAbLPXBy%2Bp%2B3bDsrOLvo%2F46FbVLWtV3xrJvQ12288RbvtMJfuRWnJi7Rf8dEWPX9yiT0LrzV0VOcGPjrSy%2B0SW1yjS2o2iXybln98oqjLbbzx02u2ho9UVcZybuU7uR9u9opL%2B1it7zroyf2sNmnCv73vOunL%2F65X0v2%2F%2Bhvt1Z7e2pTS3pRr1w0EHN3C8OlKTRV8xF32Trm54%2FNLR%2BaBxa2HnQ7wbTDCfMyHH9tc4roahfhGr6%2F1vjaP6Fjw5b8ubiRO3xsmgs%2BvMLS0o%2F7%2ByP9VU4d90lN49bjRHLIepAPA65rb6N5m50M53sejs95wyyb1fH01Wc8bDfVgdc%2BW6GjdkDnWMFiYrijBa2WZLb3vGnoeoCsNl1EwfdJcMf6ekguku1txbpcH7PZhk20je5kPvNIFssOsFu3osmWxKOkss0%2BuI6oOoRor8%2FpxdbYXCryN5JXS7YyVtT2Ur3m1ybyivu5CVPXbtZ4sjJePN2w4khY8k6dPM9jZSXmEqc%2BTdWnJTRK1g5WZ6Kiv0coMfKdwzxMQzyXle7UzpjffPBDEclB1nAXN2DzhhPh%2FzUGl%2Bpsx6t3T4OMnVyY7Tkf0wDaFXT9DT96pvNEW3YtiqzljakGxlbpr4LWWGQ1XtTsou9H6OrZGqrF3%2Bi4ycsbOLYr%2FEAh5g7Ugx%2Fa9NHr%2Bn%2F1hqn%2F8P)
