# [5 kyu] Product of consecutive Fib numbers
[題目來源 : Codewars](https://www.codewars.com/kata/5541f58a944b85ce6d00006a/train/csharp)

斐波那契數字是以下整數序列（Fn）中的數字：
```
0, 1, 1, 2, 3, 5, 8, 13, 21, 34, 55, 89, 144, 233, ...
```
如
```
F(n) = F(n-1) + F(n-2) with F(0) = 0 and F(1) = 1.
```
給一個數字(prod)，找出兩個斐波那契數字 F(n) 和 F(n+1) 符合此規則
```F(n) * F(n+1) = prod.```

你的函式 ProductFib 輸入一個數字(prod) 回傳一組陣列

如果你的數字符合規則則回傳此陣列
```[F(n), F(n+1), true] or {F(n), F(n+1), 1} or (F(n), F(n+1), True)```

如果你的數字不符合```F(m) * F(m+1) = prod```則回傳
```
[F(m), F(m+1), false] or {F(n), F(n+1), 0} or (F(n), F(n+1), False)
```
你的 F(m) 為最接近且大於的數組```F(m) * F(m+1) > prod```.


範例

``` c#
ProductFib(714) // should return {21, 34, 1}, 
                // since F(8) = 21, F(9) = 34 and 714 = 21 * 34

ProductFib(800) // should return {34, 55, 0}, 
                // since F(8) = 21, F(9) = 34, F(10) = 55 and 21 * 34 < 800 < 34 * 55
```

提示：在這裡可能沒有用，但告訴妳們如何去取得F(n)，
我們可以使用"黃金比例"(phi)，
```phi = (1 + sqrt(5)) / 2```，
F(n)趨近於```phi ^ n / sqrt(5)```，
這樣可以讓你抓到F(n)的數值。

請參考範例的測試

參考

http://en.wikipedia.org/wiki/Fibonacci_number

http://oeis.org/A000045


## 原文：

The Fibonacci numbers are the numbers in the following integer sequence (Fn):

```
0, 1, 1, 2, 3, 5, 8, 13, 21, 34, 55, 89, 144, 233, ...
```
such as

```
F(n) = F(n-1) + F(n-2) with F(0) = 0 and F(1) = 1.
```
Given a number, say prod (for product), we search two Fibonacci numbers F(n) and F(n+1) verifying

```F(n) * F(n+1) = prod.```
Your function productFib takes an integer (prod) and returns an array:

```
[F(n), F(n+1), true] or {F(n), F(n+1), 1} or (F(n), F(n+1), True)
```
depending on the language if F(n) * F(n+1) = prod.

If you don't find two consecutive F(m) verifying ```F(m) * F(m+1) = prod``` you will return

```
[F(m), F(m+1), false] or {F(n), F(n+1), 0} or (F(n), F(n+1), False)
```
F(m) being the smallest one such as ```F(m) * F(m+1) > prod```.

Examples

``` python
productFib(714) # should return {21, 34, 1}, 
                # since F(8) = 21, F(9) = 34 and 714 = 21 * 34

productFib(800) # should return {34, 55, 0}, 
                # since F(8) = 21, F(9) = 34, F(10) = 55 and 21 * 34 < 800 < 34 * 55
```

Notes: Not useful here but we can tell how to choose the number n up to which to go: we can use the "golden ratio" phi which is (1 + sqrt(5))/2 knowing that F(n) is asymptotic to: phi^n / sqrt(5). That gives a possible upper bound to n.

You can see examples in "Example test".

References

http://en.wikipedia.org/wiki/Fibonacci_number

http://oeis.org/A000045