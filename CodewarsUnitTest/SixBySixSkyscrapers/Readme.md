# 6 By 6 Skyscrapers
[題目來源 : Codewars](http://www.codewars.com/kata/6-by-6-skyscrapers/train/csharp)

需要在 6 x 6的網格中放置摩天大樓，有以下條件：

1. 摩天大樓高度在1到6之間
2. 同一行或同一列中摩天大樓的高度都不相同
3. 唯一的線索是來外部，提示那一列或那一行可以看到的摩天大樓數量
4. 高樓層的摩天大樓會遮住低樓層的摩天大樓

你能寫一個可以解決6 x 6摩天大樓的程式嗎？

## 範例
要了解運作方式，這是一個有兩條線索的例子。 從左邊看到有6棟建築可見，從右側看只有1：

<table>
<tr><th>6</th> <th></th> <th></th> <th></th> <th></th> <th></th> <th></th> <th>1</th></tr>
</table>

只有一種方式可以安置摩天大樓。 從左到右，所有六個建築物必須可見，沒有建築物可能隱藏在另一棟建築物後面：
<table>
<tr><th>6</th> <th>6</th> <th>5</th> <th>4</th> <th>3</th> <th>2</th> <th>1</th> <th>1</th></tr>
</table>

這是一個 6 x 6 問題的範例: 

<table>
<tr><th></th> <th>0</th> <th>0</th> <th>0</th> <th>2</th> <th>2</th> <th>0</th> <th></th></tr>
<tr><th>0</th> <th></th> <th></th> <th></th> <th></th> <th></th> <th></th> <th>0</th></tr>
<tr><th>0</th> <th></th> <th></th> <th></th> <th></th> <th></th> <th></th> <th>0</th></tr>
<tr><th>3</th> <th></th> <th></th> <th></th> <th></th> <th></th> <th></th> <th>0</th></tr>
<tr><th>0</th> <th></th> <th></th> <th></th> <th></th> <th></th> <th></th> <th>6</th></tr>
<tr><th>4</th> <th></th> <th></th> <th></th> <th></th> <th></th> <th></th> <th>3</th></tr>
<tr><th>4</th> <th></th> <th></th> <th></th> <th></th> <th></th> <th></th> <th>0</th></tr>
<tr><th></th> <th>0</th> <th>0</th> <th>0</th> <th>0</th> <th>4</th> <th>0</th> <th></th></tr>
</table>

解答

<table>
<tr><th> </th> <th>0</th> <th>0</th> <th>0</th> <th>2</th> <th>2</th> <th>0</th> <th> </th></tr>
<tr><th>0</th> <th>5</th> <th>6</th> <th>1</th> <th>4</th> <th>3</th> <th>2</th> <th>0</th></tr>
<tr><th>0</th> <th>4</th> <th>1</th> <th>3</th> <th>2</th> <th>6</th> <th>5</th> <th>0</th></tr>
<tr><th>3</th> <th>2</th> <th>3</th> <th>6</th> <th>1</th> <th>5</th> <th>4</th> <th>0</th></tr>
<tr><th>0</th> <th>6</th> <th>5</th> <th>4</th> <th>3</th> <th>2</th> <th>1</th> <th>6</th></tr>
<tr><th>4</th> <th>1</th> <th>2</th> <th>5</th> <th>6</th> <th>4</th> <th>3</th> <th>3</th></tr>
<tr><th>4</th> <th>3</th> <th>4</th> <th>2</th> <th>5</th> <th>1</th> <th>6</th> <th>0</th></tr>
<tr><th> </th> <th>0</th> <th>0</th> <th>0</th> <th>0</th> <th>4</th> <th>0</th> <th> </th></tr>
</table>

最後:
``` c#
public static int[][] SolvePuzzle(int[] clues)
```
通過一系列24個項目的線索。 線索在陣中：
<table>
<tr><th>  </th> <th>0</th> <th>1</th> <th>2</th> <th>3</th> <th>4</th> <th>5</th> <th></th></tr>
<tr><th>23</th> <th></th> <th></th> <th></th> <th></th> <th></th> <th></th> <th> 6</th></tr>
<tr><th>22</th> <th></th> <th></th> <th></th> <th></th> <th></th> <th></th> <th> 7</th></tr>
<tr><th>21</th> <th></th> <th></th> <th></th> <th></th> <th></th> <th></th> <th> 8</th></tr>
<tr><th>20</th> <th></th> <th></th> <th></th> <th></th> <th></th> <th></th> <th> 9</th></tr>
<tr><th>19</th> <th></th> <th></th> <th></th> <th></th> <th></th> <th></th> <th>10</th></tr>
<tr><th>18</th> <th></th> <th></th> <th></th> <th></th> <th></th> <th></th> <th>11</th></tr>
<tr><th>  </th> <th>17</th> <th>16</th> <th>15</th> <th>14</th> <th>13</th> <th>12</th> <th></th></tr>
</table>

如果沒有線索可用，請添加值0，每個難題只有一個可能的解決方案
SolvePuzzle() 返回陣列 int[][]。 第一個索引器是針對列的第二個索引器。
  
# 原文
In a grid of 6 by 6 squares you want to place a skyscraper in each square with only some clues:

1. The height of the skyscrapers is between 1 and 6
2. No two skyscrapers in a row or column may have the same number of floors
3. A clue is the number of skyscrapers that you can see in a row or column from the outside
4. Higher skyscrapers block the view of lower skyscrapers located behind them

Can you write a program that can solve each 6 by 6 puzzle? 

## Example: 

To understand how the puzzle works, this is an example of a row with 2 clues. Seen from the left there are 6 buildings visible while seen from the right side only 1: 
```
6	  	  	  	  	  	  	1
```
There is only one way in which the skyscrapers can be placed. From left-to-right all six buildings must be visible and no building may hide behind another building: 
```
6	1	2	3	4	5	6	1
```
Example of a 6 by 6 puzzle with the solution: 
```
  	0  	0  	0  	2	2	0  	  
0  	  	  	  	  	  	  	0 
0  	  	  	  	  	  	  	0 
3	  	  	  	  	  	  	0 
0  	  	  	  	  	  	  	6
4	  	  	  	  	  	  	3
4	  	  	  	  	  	  	0 
  	0 	0 	0 	0 	4	0 	  
```
```
  	0 	0 	0 	2	2	0 	  
0 	5	6	1	4	3	2	0 
0 	4	1	3	2	6	5	0 
3	2	3	6	1	5	4	0 
0 	6	5	4	3	2	1	6
4	1	2	5	6	4	3	3
4	3	4	2	5	1	6	0 
  	0 	0 	0 	0 	4	0 	  
```
Task: 

Finish:
public static int[][] SolvePuzzle(int[] clues)
Pass the clues in an array of 24 items. The clues are in the array around the clock. Index: 
```
0	1	2	3	4	5	
23							6
22							7
21							8
20							9
19							10
18							11
17	16	15	14	13	12	
```
If no clue is available, add value 0
Each puzzle has only one possible solution
SolvePuzzle() returns matrix int[][]. The first indexer is for the row, the second indexer for the column. Python returns a 6-tuple of 6-tuples, Ruby a 6-Array of 6-Arrays.