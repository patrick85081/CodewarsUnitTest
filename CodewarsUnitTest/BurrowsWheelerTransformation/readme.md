# [4 kyu] Burrows-Wheeler-Transformation
[題目來源 : Codewars](https://www.codewars.com/kata/54ce4c6804fcc440a1000ecb/train/csharp)

## 動機



## 原文

### Motivation

When compressing sequences of symbols, 
it is useful to have many equal symbols follow each other, 
because then they can be encoded with a run length encoding.
```
rleEncode "aaaabbbccc" == [(4, 'a'), (3, 'b'), (3, 'c')]
```
(Look [here][1] for learning more about the run-length-encoding.)

### Transformation

There even exists a transformation, 
which brings equal symbols closer together, 
it is called the Burrows-Wheeler-Transformation. 
The forward transformation works as follows: 
Let's say we have a sequence with length n, 
first write every shift of that string into a _n x n_ matrix:

```
Input: "bananabar"

b a n a n a b a r
r b a n a n a b a
a r b a n a n a b
b a r b a n a n a
a b a r b a n a n
n a b a r b a n a
a n a b a r b a n
n a n a b a r b a
a n a n a b a r b
```

Then we sort that matrix by its rows. 
The output of the transformation then is the last column and the row 
index in which the original string is in:

```
               .-.
a b a r b a n a n
a n a b a r b a n
a n a n a b a r b
a r b a n a n a b
b a n a n a b a r <- 4
b a r b a n a n a
n a b a r b a n a
n a n a b a r b a
r b a n a n a b a
               '-'

Output: ("nnbbraaaa", 4)
```
Of course we want to restore the original input, 
therefore you get the following hints:

The output contains the last matrix column.
The first column can be acquired by sorting the last column.
For every row of the table: 
Symbols in the first column follow on symbols in the last column, 
in the same way they do in the input string.
You don't need to reconstruct the whole table to get the input back.

### Goal

The goal of this Kata is to write both, 
the ```encode``` and ```decode``` functions. 
Together they should work as the identity function on lists. 
(Note: For the empty input, the row number is ignored.)

### Further studies

You may have noticed that symbols are not always consecutive, 
but just in proximity, after the transformation. 
If you're interested in how to deal with that, 
you should have a look at [this Kata][2].

[1]:(http://www.codewars.com/kata/run-length-encoding/)
[2]:(http://www.codewars.com/kata/move-to-front-encoding/)