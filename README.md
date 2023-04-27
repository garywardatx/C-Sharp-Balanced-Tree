# C-Sharp-Balanced-Tree
This program uses a binary search tree to implement a red-black tree in C# using a console app.

Red-Black Tree Specification:

Structure: The binary search property is maintained when inserting items into the binary search tree.
The value of a key of a node is greater than the value of a key of any node in its left subtree, and less
than the value of any node in its right subtree. Red-black properties must be maintained.

Object Nodes:
- Parent link
- Key
- Color
- LeftChild link RightChild link


Methods from the Binary Search Tree
- Constructor(s): initializes an instance of the class
- Insert : insert an item into the binary search tree
- InOrder : print the binary search tree in order
- Min : returns the smallest item in the subtree of a given node in the binary search tree
- Max : returns the largest item in the subtree of a given node in the binary search tree
- CountNodes : returns the number of nodes in the binary search tree

Methods added for the Red-Black Tree:
- Flip Color
- Left Rotate
- Right Rotate
- Left Right Rotate
- Right Left Rotate
- Search

The code was tested by generating random numbers until there are 20 unique numbers in the Binary Search Tree. The numbers are printed
in order and include the node color as part of the output. 

Search testing for a number will determine the time reqs.

The min and max values can be printed along with a count of how many nodes are in the tree.

