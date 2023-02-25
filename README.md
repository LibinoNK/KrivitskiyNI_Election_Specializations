***Задача**: Написать программу, которая из имеющегося массива строк формирует массив из строк, длина которых меньше либо равна 3 символа. Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма. При решении не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами.*

С самого начала задаем несколько методов: **Ввода массива с клавиатуры**, **Метод для выделения из массива элементов, состоящих из 3 или меньше символов**, **Метод печати массива**.

# МЕТОДЫ

## Метод ввода массива с клавиатуры
Просим пользователя ввести количество элементов массива, после чего вводим массив заполненный нулями с размерностью, заданной пользователем. После чего через цикл *for* просим пользователя вводить по очереди элементы массива до нужной размерности.

    Важно!!!

    Пользователя просят вводить номерные, а не индексные элементы массива (то есть 1, 2, 3 и т.д., а не 0, 1, 2...), поскольку пользователь может не знать, что индексы элементов в массиве в программировании начинаются с 0, а не с 1, что может его смутить и в целом смотрится не очень красиво.

После прохождения цикла, метод возвращает массив.

##  Метод для выделения из массива элементов, состоящих из 3 или меньше символов
Этот метод - непосредственно само решение поставленной задачи.
Метод принимает на вход массив, который необходимо некоторым образом отсортировать (отделить элементы состоящие из 3 и менее символов).
Изначально вводим два элемента - максимальную длину элемента (3) и количество элементов соответствующее условию задачи (numberOfElement - переменная счетчик, которая в конечном счете укажет нам сколько элементов массива соотвтетсвуют нашему условию).

    Введение второго элемента необходимо нам для последующего создания массива нужной размерности, поскольку в С# невозможно вложить новые элементы в новый массив, в том числе в пустой (не содержащий элементов), без использования, например, команды Resize или без использования коллекций вместо массивов.

После чего через цикл for с условием (если количество символов в элементе меньше или равно максимальной длины элемента) внутри находим количество соответствующих условию задачи чисел, увеличивая это число при соответсвии элемента массива условию внутри цикла.

Далее задаем массив, наполненный нулями с размерностю, сооответствующей количеству элементов первоначального массива, в которых количество символов меньше или равно 3.
Также вводим переменную-индекс (*numberEl*) и далее, через цикл for с условием (если количество символов в элементе меньше или равно максимальной длины элемента) внутри, еще раз проходим первоначальный массив, но теперь при соответствии элемента массива условию внутри цикла мы записываем его на место в созданном (наполненном нулями) массиве на места с индексами, указаными в переменной-индексе, кроме того, при соответствии условию, увеличиваем переменную-индекс на 1, чтобы записывать следующие элементы в другие ячейки массива.

В конце возвращаем новый массива, наполенный отсортированными элементами.

## Метод печати массива
Метод печати массива через *Console.Writline* и использование *string.Join* - простейший вывод без изобретения велосипеда :).

# Основной код
В рамках основного кода сделаны 2 варианта решения задачи:
* Массив задается пользователем с клавиатуры
* Массив задается внутри кода

В **первом варианте** используются методы ввода первого (сортируемого массива), а также создается новый массив с использованием метода для выделения из массива элементов, состоящих из 3 или меньше символов. Также используется метод печати обоих массивов для наглядности "было/стало".
Кроме того реализован красивый вывод результата.

Во **втором варианте** массив задается внутри кода, и, также как и в первом варианте, используется метод печати массивов,  создается новый массив с использованием метода для выделения из массива элементов, состоящих из 3 или меньше символов.
Красивый вывод также реализован.