/*********************************************************************************************************

 * Project: Balanced Tree
 * 
 * File: Balanced Tree Class
 * 
 * Langauge: VS C#
 * 
 *
 *
 * Description: This is the balanced tree class.
 * 
 *
 *
 * College: Husson University
 * 
 * Course:  IT 326
 * 
 * Author: Gary Edward Ward
 * 
 * 
 * 
 * Change Log:
 * 
 * Date                         Description of Change
 * 
 * ---------------           ----------------------------------------------------------------------------
 * 
 * 3/20/2022               - Initial writing
 * 3/20/2022               - Added regions
 * 3/20/2022               - Added properties
 * 3/20/2022               - Added constructor
 * 3/20/2022               - Added methods:
 *                              - Constructor
 *                              - Insert
 *                              - InOrder
 *                              - Min
 *                              - Max
 *                              - CountNodes
 *                              - FlipColor
 *                              - Left Rotate
 *                              - Right Rotate
 * 
 * 
 * 
 * 
*********************************************************************************************************/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ward_PR05_BalancedTrees {
    class BalancedTreeClass {


        #region Constants
        #endregion Constants

        #region Data Members
        #endregion Data Members

        #region Properties                        

        public int Count;                            // the number of nodes in the BST
        public TreeNode root { get; set; }           // pointer to the root node in the binary tree


        #endregion Properties

        #region Constructor

        /// <summary>
        /// Constructor for the binary search tree.
        /// </summary>
        public BalancedTreeClass() {
            root = null;
            Count = 0;
        }

        #endregion Constructor

        #region Events

        #endregion Events

        #region Methods

        /// <summary>
        /// This routine scans the RB tree for color errors and 
        /// corrects them.
        /// </summary>
        /// <param name="data"></param>
        private void FlipColor(TreeNode data) {
            
            //Checks Red-Black Tree properties
            while (data != root && data.Parent.Colour == TreeNode.Color.Red) {
                
                // we have an error
                if (data.Parent == data.Parent.Parent.LeftChild) {
                    TreeNode Y = data.Parent.Parent.RightChild;
                    if (Y != null && Y.Colour == TreeNode.Color.Red)//Case 1: uncle is red
                    {
                        data.Parent.Colour = TreeNode.Color.Black;
                        Y.Colour = TreeNode.Color.Black;
                        data.Parent.Parent.Colour = TreeNode.Color.Red;
                        data = data.Parent.Parent;
                    } else {

                        // Case 2: uncle is black
                        
                        if (data == data.Parent.RightChild) {
                            data = data.Parent;
                            LeftRotate(data);
                        }
                        
                        // Case 3: change the colors and rotate

                        data.Parent.Colour = TreeNode.Color.Black;
                        data.Parent.Parent.Colour = TreeNode.Color.Red;
                        RightRotate(data.Parent.Parent);
                    }

                } else {
                    
                    // mirror image of the code above
                    TreeNode X = null;

                    X = data.Parent.Parent.LeftChild;
                    if (X != null && X.Colour == TreeNode.Color.Black)//Case 1
                    {
                        data.Parent.Colour = TreeNode.Color.Red;
                        X.Colour = TreeNode.Color.Red;
                        data.Parent.Parent.Colour = TreeNode.Color.Black;
                        data = data.Parent.Parent;
                    } else {

                        // Case 2 again

                        if (data == data.Parent.LeftChild) {
                            data = data.Parent;
                            RightRotate(data);
                        }

                        // Case 3: change the colors and rotate
                        data.Parent.Colour = TreeNode.Color.Black;
                        data.Parent.Parent.Colour = TreeNode.Color.Red;
                        LeftRotate(data.Parent.Parent);

                    }

                }
                root.Colour = TreeNode.Color.Black;     //re-color the root black as necessary
            }
        
        }

        /// <summary>
        /// Inserts an item into the binary search tree
        /// </summary>
        /// <param name="item"></param>
        public void Insert(int data) {
            // Create a node for the item being inserted
            // Set the key of the new node to the item being inserted
            TreeNode newNode = new TreeNode(data);

            // Check if the tree is empty
            if (root is null) {
                root = newNode;
                root.Colour = TreeNode.Color.Black;
                return;

            } else {
                
                TreeNode Y = null;
                TreeNode X = root;

                while (X != null) {
                    Y = X;
                    if (newNode.Data < X.Data) {
                        X = X.LeftChild;

                    } else {
                        X = X.RightChild;

                    }
                }

                newNode.Parent = Y;

                if (Y == null) {
                    root = newNode;

                } else if (newNode.Data < Y.Data) {
                    Y.LeftChild = newNode;

                } else {
                    Y.RightChild = newNode;
                
                }

                newNode.LeftChild = null;
                newNode.RightChild = null;
                newNode.Colour = TreeNode.Color.Red;
                FlipColor(newNode);     // check to make sure there are
                                        // not any errors in the RB tree.

            }

        }

        

        /// <summary>
        /// This routine iterates through the ordered link list.
        /// </summary>
        /// <param name="start"></param>
        /// <param name="theListBox"></param>
        public void Iterate(TreeNode Root, ListBox theListBox) {
            TreeNode current = Root;

            // clear the listBox
            theListBox.Items.Clear();

            if (current is null) {
                theListBox.Items.Add("The starting node is null");

            } else {
                while (current != null) {
                    // display the current node
                    theListBox.Items.Add(current.ToString());

                    // move to the next node
                    current = current.Parent;

                }
            }



            /*
            
            if (current != null) {
                IterateInOrder(current.LeftChild, theListBox);
               

            }
              
            // clear the listBox
            theListBox.Items.Clear();

            // walk down the link list and display each node
            if (Root is null) {
                theListBox.Items.Add("The starting node is null");

            } else {
                while (current != null) {
                    // display the current node
                    theListBox.Items.Add(current.ToString());

                    // move to the next node
                    current = current.Parent;

                }
            }
            */

        }

        /// <summary>
        /// This routine facilitates a left rotation.
        /// </summary>
        /// <param name="X"></param>
        private void LeftRotate(TreeNode X) {

            TreeNode Y = X.RightChild;      // set the Y node
            X.RightChild = Y.LeftChild;     // Turn Y's left subtree into X's right subtree

            if (Y.LeftChild != null) {
                Y.LeftChild.Parent = X;
            }
            if (Y != null) {
                Y.Parent = X.Parent;        //link X's parent to Y
            }
            if (X.Parent == null) {
                root = Y;
            }
            if (X == X.Parent.LeftChild) {
                X.Parent.LeftChild = Y;
            } else {
                X.Parent.RightChild = Y;
            }
            Y.LeftChild = X;                //put X on Y's left
            if (X != null) {
                X.Parent = Y;
            }
        }

        /// <summary>
        /// Returns the largest item in the subtree of a given node in the 
        /// binary search tree
        /// </summary>
        /// <param name="node"></param>
        /// <returns></returns>
        public int Max(TreeNode node) {
            while (node.RightChild != null) {
                node = node.RightChild;

            }
            return node.Data;
        }

        /// <summary>
        /// Returns the smallest item in the subtree of a given node in the 
        /// binary search tree
        /// </summary>
        /// <param name="node"></param>
        /// <returns></returns>
        public int Min(TreeNode node) {
            while (node.LeftChild != null) {
                node = node.LeftChild;

            }
            return node.Data;
        }

        /// <summary>
        /// Returns the number of nodes in the binary search tree
        /// </summary>
        /// <param name="node"></param>
        /// <returns></returns>
        public int nodeCount(TreeNode root) {
            if (root is null) {
                return 0;
            } else {
                return nodeCount(root.LeftChild) + nodeCount(root.RightChild) + 1;
            }
        }

        /// <summary>
        /// This routine facilitates a right rotation.
        /// </summary>
        /// <param name="Y"></param>
        private void RightRotate(TreeNode Y) {
            
            // right rotate is mirrored code from left rotation code.
            TreeNode X = Y.LeftChild;
            Y.LeftChild = X.RightChild;

            if (X.RightChild != null) {
                X.RightChild.Parent = Y;
            }

            if (X != null) {
                X.RightChild = Y.Parent;
            }

            if (Y.Parent == null) {
                root = X;
            }

            if (Y == Y.Parent.RightChild) {
                Y.Parent.RightChild = X;
            }

            if (Y == Y.Parent.LeftChild) {
                Y.Parent.LeftChild = X;
            }

            X.RightChild = Y;       //put Y on X's right

            if (Y != null) {
                Y.Parent = X;
            }
        }



        #endregion Methods


    }
}
