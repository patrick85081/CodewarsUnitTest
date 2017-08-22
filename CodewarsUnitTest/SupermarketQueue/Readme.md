# The Supermarket Queue
[題目來源 : Codewars](https://www.codewars.com/kata/57b06f90e298a7b53d000a86/train/csharp)

這裡是超級市場上自助結帳的排隊。 
您的任務是寫一個函數來計算所有客戶結帳的總時間！

## 規格：

該函數有兩個輸入變量：

``` c# 
public int QueueTime(int[] customers, int number)
```  

customers：代表隊列的正整數的陣列（在範例中的陣列）。 
每個整數代表一個客戶，值是結帳所需要的時間。

number：正整數，結帳櫃台數量。

return：該函數返回一個整數，為所有顧客所需的總時間。

備註：很多人在對這個題目感到困惑。 為了防止更多的疑問，加上以下註解：

只有一個排隊隊列，和隊伍的順序永遠不會改變，假設結帳櫃檯的顧客結束，隊伍中的下一個顧客（即陣列中的第一個元素）一旦達到空閒狀態即進入直到。
在我鏈接到的wiki頁面上的圖表在描述的底部可能是有用的。

## 範例：


``` c#
QueueTime(new int[]{5, 3, 4}, 1);
// should return 12
// because when n=1, the total time is just the sum of the times

QueueTime(new int[]{10, 2, 3, 3}, 2);
// should return 10
// because here n=2 and the 2nd, 3rd, and 4th people in the 
// queue finish before the 1st person has finished.

QueueTime(new int[]{2, 3, 10}, 2);
// should return 12
```

### 備註：您應該假設所有的測試輸入都是有效的，如上所述。

### 附錄：這個情況可以想像成一個線程池(Thread Pool)，更多計算機概論等相關想法，與此同時運行多個進程有關：[Thread Pool](https://en.wikipedia.org/wiki/Thread_pool)   



## 原文：

There is a queue for the self-checkout tills at the supermarket. Your task is write a function to calculate the total time required for all the customers to check out!

The function has two input variables:

customers: an array (list in python) of positive integers representing the queue. Each integer represents a customer, and its value is the amount of time they require to check out.
n: a positive integer, the number of checkout tills.
The function should return an integer, the total time required.

EDIT: A lot of people have been confused in the comments. To try to prevent any more confusion:

There is only ONE queue, and
The order of the queue NEVER changes, and
Assume that the front person in the queue (i.e. the first element in the array/list) proceeds to a till as soon as it becomes free.
The diagram on the wiki page I linked to at the bottom of the description may be useful.
So, for example:

``` python
queueTime([5,3,4], 1)
// should return 12
// because when n=1, the total time is just the sum of the times

queueTime([10,2,3,3], 2)
// should return 10
// because here n=2 and the 2nd, 3rd, and 4th people in the 
// queue finish before the 1st person has finished.

queueTime([2,3,10], 2)
// should return 12
```

### N.B. You should assume that all the test input will be valid, as specified above.

### P.S. The situation in this kata can be likened to the more-computer-science-related idea of a thread pool, with relation to running multiple processes at the same time: https://en.wikipedia.org/wiki/Thread_pool
