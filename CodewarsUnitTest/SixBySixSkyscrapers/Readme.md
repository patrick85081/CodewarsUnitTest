# 6 By 6 Skyscrapers
[題目來源 : Codewars](http://www.codewars.com/kata/6-by-6-skyscrapers/train/csharp)

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
0	1	2	3	4	5	
23							6
22							7
21							8
20							9
19							10
18							11
17	16	15	14	13	12	
If no clue is available, add value 0
Each puzzle has only one possible solution
SolvePuzzle() returns matrix int[][]. The first indexer is for the row, the second indexer for the column. Python returns a 6-tuple of 6-tuples, Ruby a 6-Array of 6-Arrays.