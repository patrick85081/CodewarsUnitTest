# [2 kyu] Decode the Morse code, for real
[題目來源 : Codewars](http://www.codewars.com/kata/decode-the-morse-code-for-real/train/csharp)

### 題目簡介

在這個題目裡你必須處理“現實生活”情景，莫爾斯電碼的傳輸速度在整個消息中略有不同，
因為它是由一個非完美的人類發送的。此外，採樣頻率可能不是典型“點”長度的倍數。

例如，可能實際上可以收到以下消息 ```···· · −·−−   ·−−− ··− −·· ·``` ，即是HEY JUDE。

```
0000000011011010011100000110000001111110100111110011111100000000000111011111111011111011111000000101100011111100000111110011101100000100000
```

正如你所看到的，這種傳輸通常是根據標準準確的，但是一些點(.)和破折號(-)和暫停比其他的短或稍長一些。

還要注意的是，與先前的題目相比，估計的平均速率（每點的位數）可能不是整數，
因為發送電報的是人類，並且不知道接收端採樣頻率。

例如，您可以每秒採樣10次 (每次採樣 100ms)，而操作員發送的 點 和 短停頓 為110-170ms長。
每秒取樣10次是足夠的速度 (意思是每個點和暫停都反映在輸出中，沒有任何東西被忽略)，
點將反映為1或 11，但如果你試圖估計速率 (bit / 一點)，它不會是1或 2，它將是大約（110 + 170）/ 2 / 100 = 1.4。
您的演算法應該處理這樣的情況。

另外請記住，每的消息可能被不同的運營商發送，所以它的速率和其他特性將是不同的。
所以你必須獨立地分析每個訊息（即測試），而不依賴於之前的訊息。另一方面，我們假設傳輸特性會在同一則訊息中保持一致，
因此您必須分析整個消息使得解碼正確。
所謂的一致性意表示如果在訊息中“11111”的開頭是一個點(.)，那“111111”是短劃線(-)，那麼在同一則訊息中的任何地方也是如此。
同理“00000”絕對是一個短暫（字符）的暫停，“000000”是一個長（字符間）的暫停。

### 你的任務是實現兩個功能：

1. ```decodeBitsAdvanced(string bits)```方法，應該找到消息的傳輸速率的估計，
   注意消息中可能發生的輕微的速度變化，將消息正確解碼為點，破折號和空格（字符之間的一個，三個字之間），
   並將其作為字符串返回。請注意，一些額外的0可能會自然地發生在消息的開頭和結尾，確保忽略它們。
   如果消息為空或僅包含0，則返回空字符串。此外，如果您遇到困難，如果1的特定順序是點或破折號，
   假設它是一個點。如果卡住了，請查看這個想法。

2. ```decodeMorse（string morseCode）```方法，它將使用前一個函數的輸出，並返回一個人類可讀的英文字符串。
   如果輸入為空字元或空白字元，則返回空字元。


對於c#，摩爾斯碼表預先加載為```Preloaded.MORSE_CODE```的```Dictionary<string, string>```。


```c#
public static class Preloaded
{
    public static Dictionary<string, string> MORSE_CODE { get; }
}
```

當然，並不是所有的消息都可能被完全自動解碼。但是您可能會確定所有的測試字符串都將有效，
以至於可以如上所述可靠地解碼，因此您可以跳過檢查錯誤和異常情況，盡可能地確定消息是什麼！

祝你好運！！


## 原文

In this kata you have to deal with "real-life" scenarios, 
when Morse code transmission speed slightly varies throughout the message as it is sent by a non-perfect human operator. 
Also the sampling frequency may not be a multiple of the length of a typical "dot".
For example, the message ```HEY JUDE```, 
that is ```···· · −·−−   ·−−− ··− −·· ·``` may actually be received as follows:
```
0000000011011010011100000110000001111110100111110011111100000000000111011111111011111011111000000101100011111100000111110011101100000100000
```
As you may see, this transmission is generally accurate according to the standard, 
but some dots and dashes and pauses are a bit shorter or a bit longer than the others.

Note also, that, in contrast to the previous kata, 
the estimated average rate (bits per dot) may not be a whole number – as the hypotetical transmitter is a human and doesn't know anything about the receiving side sampling rate.

For example, you may sample line 10 times per second (100ms per sample), 
while the operator transmits so that his dots and short pauses are 110-170ms long. 
Clearly 10 samples per second is enough resolution for this speed 
(meaning, each dot and pause is reflected in the output, nothing is missed), 
and dots would be reflected as 1 or 11, but if you try to estimate rate (bits per dot), 
it would not be 1 or 2, it would be about (110 + 170) / 2 / 100 = 1.4. 
Your algorithm should deal with situations like this well.

Also, remember that each separate message is supposed to be possibly sent by a different operator, 
so its rate and other characteristics would be different. 
So you have to analyze each message (i. e. test) independently, 
without relying on previous messages. 
On the other hand, we assume the transmission charactestics remain consistent throghout the message, 
so you have to analyze the message as a whole to make decoding right. 
Consistency means that if in the beginning of a message '11111' is a dot and '111111' is a dash, 
then the same is true everywhere in that message. Moreover, 
it also means '00000' is definitely a short (in-character) pause, 
and '000000' is a long (between-characters) pause.

### That said, your task is to implement two functions:

1. Function ```decodeBitsAdvanced(bits)```, 
   that should find an estimate for the transmission rate of the message, 
   take care about slight speed variations that may occur in the message, 
   correctly decode the message to dots ```.```, 
   dashes ```-``` and spaces (one between characters, three between words) and return those as a string. 
   Note that some extra ```0```'s may naturally occur at the beginning and the end of a message, 
   make sure to ignore them. If message is empty or only contains ```0```'s, return empty string. 
   Also if you have trouble discerning if the particular sequence of ```1```'s is a dot or a dash, 
   assume it's a dot. If stuck, check this for ideas.

2. Function ```decodeMorse(morseCode)```, 
   that would take the output of the previous function and return a human-readable string. 
   If the input is empty string or only contains spaces, return empty string.

The Morse code table is preloaded for you as ```MORSE_CODE``` dictionary, feel free to use it. 
(For C, the function 'morse_code' acts like the dictionary. For C++ a map is used.)

``` c++
const char *morse_code (const char *dotsdashes);
```

Of course, not all messages may be fully automatically decoded. 
But you may be sure that all the test strings would be valid to the point that they could be reliably decoded as described above, 
so you may skip checking for errors and exceptions, 
just do your best in figuring out what the message is!

Good luck!