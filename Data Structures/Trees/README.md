# Trees
## Binary Tree & Binary Search Tree

# Challenge
Define a method for each of the depth first traversals called preOrder, inOrder, and postOrder which takes in a root node, and returns an array of the nodes.
Define a method named add that adds a new node in the correct location in the binary search tree.
Define a method named search that brings in a value of node, and returns the node with the desired value.

#Approach & Efficiency
Binary Tree
Big O:
Space: O(n)
Time: O(h)

Binary Search Tree Insertion and Search
Big O: O(log n)

The Big O space for a node insertion using breadth first will be an O(w)

# Methods
Preorder:
Root, Left, Right
Inorder:
Left, Root, Right
Postorder:
Left, Right, Root
AddNode: Adds node to bianry search tree
Search: Method to search bianry tree for value. Compares value to the root and searches right or left depending on if the value is less than or greater than

#Visual
![console_app_image](https://user-images.githubusercontent.com/17580143/47672711-e4b94500-db6f-11e8-8396-80891d3e524c.png)


