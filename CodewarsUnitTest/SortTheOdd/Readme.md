# Sort the odd
[題目來源 : Codewars](https://www.codewars.com/kata/578aa45ee9fd15ff4600090d/train/csharp)

你有一個數值的陣列。
你的任務是排列上升的奇數，但是數字必須在他們的地方。

零不是奇數，你不需要移動它。 如果你有一個空陣列，請直接回傳它。

``` c#
SortArray(new int[]{5, 3, 2, 8, 1, 4});
// return int[]{1, 3, 2, 8, 5, 4};
```
  
  
## 原文：

You have an array of numbers.
Your task is to sort ascending odd numbers but even numbers must be on their places.

Zero isn't an odd number and you don't need to move it. If you have an empty array, you need to return it.

Example

``` python
sortArray([5, 3, 2, 8, 1, 4]) == [1, 3, 2, 8, 5, 4]
```