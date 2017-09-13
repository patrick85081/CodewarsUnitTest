# Catching Car Mileage Numbers
[題目來源 : Codewars](https://www.codewars.com/kata/52c4dd683bfd3b434c000292/train/csharp)

> 「7777...8 !?!?!?」Bob大叫，「我又再次錯過了！」每次有趣的數字接近，他會開始注意這個數字，但是每次都會錯過。
> 誰不喜歡抓住這些一次性有趣的里程數字？讓我們讓Bob永遠不會錯過另一個有趣的數字。
> 我們已經入侵他的汽車的電腦，我們有個盒子掛起來讀取儀錶板里程數。
> 盒子黏在他的儀表板上，發出黃光或綠光，取決於它是否分別接收1或2。

這取決於你，無畏的戰士，請將需求整合合在一起。編寫分析里程數的函數，
如果這是個“有趣”的數字（見下文）返回``2``，如果在接下來的兩英里內出現有趣的數字則返回``1``，如果數字不感興趣則返回``0``。

##### 注意：在Haskell中，我們使用``No``，``Almost``和``Yes``代替``0``, ``1``和 ``2``。

## “有趣”的數字

有趣的數字是符合以下一個或多個標準的3位或更多位數字：

* 第一個數字之後全部都是零：100,90000
* 每個數字都是相同數字：1111
* 數字是照順序排列：1234
* 數字是逆向排列：4321
* 數字是一個回文：1221或73837
* 數字與 ``感興趣`` 數組中的一個值匹配

> 對於遞增數列，0應該在9之後，而不是在1之前，如7890所示。  
> 對於遞減數列，0應該在1之後，而不是在9之前，如3210所示。  

``` c#
// "boring" numbers
Kata.IsInteresting(3, new List<int>() { 1337, 256 });       // 0
Kata.IsInteresting(3236, new List<int>() { 1337, 256 });    // 0

// progress as we near an "interesting" number
Kata.IsInteresting(11207, new List<int>() { });   // 0
Kata.IsInteresting(11208, new List<int>() { });   // 0
Kata.IsInteresting(11209, new List<int>() { });   // 0  <= 應該是原文筆誤  應該要回傳1
Kata.IsInteresting(11210, new List<int>() { });   // 0  <= 應該是原文筆誤  應該要回傳1
Kata.IsInteresting(11211, new List<int>() { });   // 0  <= 應該是原文筆誤  應該要回傳2

// nearing a provided "awesome phrase"
Kata.IsInteresting(1335, new List<int>() { 1337, 256 });   // 1
Kata.IsInteresting(1336, new List<int>() { 1337, 256 });   // 1
Kata.IsInteresting(1337, new List<int>() { 1337, 256 });   // 2
```

## 錯誤檢查

* 一個數字只有99以上才有意思！
* 輸入將始終為大於0，小於1,000,000,000的整數。
* 將永遠提供awesomePhrases數組，並且將始終為數組，但可能為空。 （不是每個人都認為數字拼寫有趣的話...）
* 你只能輸出0，1或2。

## 原文

> "7777...8?!??!", exclaimed Bob, "I missed it again! Argh!" 
Every time there's an interesting number coming up, he notices and then promptly forgets. 
Who doesn't like catching those one-off interesting mileage numbers?  

Let's make it so Bob never misses another interesting number. 
We've hacked into his car's computer, and we have a box hooked up that reads mileage numbers. 
We've got a box glued to his dash that lights up yellow or green depending on whether it receives a ``1`` or a ``2`` (respectively).

It's up to you, intrepid warrior, to glue the parts together. 
Write the function that parses the mileage number input, 
and returns a ``2`` if the number is "interesting" (see below), 
a ``1`` if an interesting number occurs within the next two miles, 
or a ``0`` if the number is not interesting.

Note: In Haskell, we use ``No``, ``Almost`` and ``Yes`` instead of ``0``, ``1`` and ``2``.

## "Interesting" Numbers

Interesting numbers are 3-or-more digit numbers that meet one or more of the following criteria:

* Any digit followed by all zeros: 100, 90000
* Every digit is the same number: 1111
* The digits are sequential, incementing†: 1234
* The digits are sequential, decrementing‡: 4321
* The digits are a palindrome: 1221 or 73837
* The digits match one of the values in the awesomePhrases array

> † For incrementing sequences, 0 should come after 9, and not before 1, as in 7890.  
> ‡ For decrementing sequences, 0 should come after 1, and not before 9, as in 3210.
So, you should expect these inputs and outputs:

``` c#
// "boring" numbers
Kata.IsInteresting(3, new List<int>() { 1337, 256 });    // 0
Kata.IsInteresting(3236, new List<int>() { 1337, 256 });    // 0

// progress as we near an "interesting" number
Kata.IsInteresting(11207, new List<int>() { });   // 0
Kata.IsInteresting(11208, new List<int>() { });   // 0
Kata.IsInteresting(11209, new List<int>() { });   // 0
Kata.IsInteresting(11210, new List<int>() { });   // 0
Kata.IsInteresting(11211, new List<int>() { });   // 0

// nearing a provided "awesome phrase"
Kata.IsInteresting(1335, new List<int>() { 1337, 256 });   // 1
Kata.IsInteresting(1336, new List<int>() { 1337, 256 });   // 1
Kata.IsInteresting(1337, new List<int>() { 1337, 256 });   // 2
```

## Error Checking

A number is only interesting if it is greater than ``99``!
Input will always be an integer greater than ``0``, and less than ``1,000,000,000``.
The ``awesomePhrases`` array will always be provided, and will always be an array, but may be empty. 
(Not everyone thinks numbers spell funny words...)
You should only ever output ``0``, ``1``, or ``2``.