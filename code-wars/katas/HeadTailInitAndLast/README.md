Haskell has some useful functions for dealing with lists:

$ ghci
GHCi, version 7.6.3: http://www.haskell.org/ghc/  :? for help
? head [1,2,3,4,5]
1
? tail [1,2,3,4,5]
[2,3,4,5]
? init [1,2,3,4,5]
[1,2,3,4]
? last [1,2,3,4,5]
5
Your job is to implement these functions in your given language. Make sure it doesn't edit the array; that would cause problems! Here's a cheat sheet:

| HEAD | <----------- TAIL ------------> |
[  1,  2,  3,  4,  5,  6,  7,  8,  9,  10]
| <----------- INIT ------------> | LAST |

head [x] = x
tail [x] = []
init [x] = []
last [x] = x
Here's how I expect the functions to be called in your language:

new List<int> {1, 2, 3, 4, 5}.Head() => 1
new List<int> {1, 2, 3, 4, 5}.Tail() => new List<int> {2, 3, 4, 5}
Most tests consist of 100 randomly generated arrays, each with four tests, one for each operation. There are 400 tests overall. No empty arrays will be given. Haskell has QuickCheck tests

PLEASE NOTE: C#'s Last function shall be called Last_ to prevent name clashes.