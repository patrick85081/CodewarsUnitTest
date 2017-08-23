# RGB To Hex Conversion
[題目來源 : Codewars](https://www.codewars.com/kata/513e08acc600c94f01000001/train/csharp)

Rgb() 方法尚未完成，請完成該方法，
使得傳入RGB十進位數值，回傳十六進制表示。  
RGB的表示範圍在0-255，任何超出該範圍之數值，應使用最接近的值表示。

範例
``` c#
Rgb(255, 255, 255) // returns FFFFFF
Rgb(255, 255, 300) // returns FFFFFF
Rgb(0,0,0) // returns 000000
Rgb(148, 0, 211) // returns 9400D3
```

## 原文:

The rgb() method is incomplete. Complete the method so that passing in RGB decimal values will result in a hexadecimal representation being returned. The valid decimal values for RGB are 0 - 255. Any (r,g,b) argument values that fall out of that range should be rounded to the closest valid value.

The following are examples of expected output values:
``` python
Rgb(255, 255, 255) # returns FFFFFF
Rgb(255, 255, 300) # returns FFFFFF
Rgb(0,0,0) # returns 000000
Rgb(148, 0, 211) # returns 9400D3
```