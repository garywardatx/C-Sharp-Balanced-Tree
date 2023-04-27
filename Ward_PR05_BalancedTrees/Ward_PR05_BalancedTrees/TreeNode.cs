/*********************************************************************************************************

 * Project: Balanced Tree
 * 
 * File: Tree Node Class
 * 
 * Langauge: VS C#
 * 
 *
 *
 * Description: This is the node class for the balanced tree.
 * 
 *  /// <summary>
 *
 *      /// The formal rules that define a red-black binary search tree are the following:
 *      ///
 *      ///     1. Every node is colored either red or black.
 *      ///     2. The root node is always black.
 *      ///     3. Every external node (null child of a leaf node) is black.
 *      ///     4. If a node is red, both of its children are black.
 *      ///     5. Every path from the root to an external node contains the same number of black nodes.
 *      ///     
 *      /// </summary>
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
 * 3/20/2022               - Added method
 * 
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
    class TreeNode {


        #region Constants
        #endregion Constants

        #region Data Members

        #endregion Data Members

        #region Properties                        

        public enum Color {                         // Enumeration of constants for black and red
            Red = 0,
            Black = 1
        }

        public int Data;                            // The data held by the node in the BST.

        public Color Colour;                        // Pointer to the enumeration of the color property

        public TreeNode LeftChild { get; set; }     // Pointer to the left child of the parent
        public TreeNode RightChild { get; set; }    // Pointer to the right child of the parent

        public TreeNode Parent { get; set; }        // Pointer to the parent node.

        public TreeNode Next { get; set; }        // Pointer to the next node.

        #endregion Properties

        #region Constructor

        public TreeNode(int data) {
            Data = data;

        }

        public TreeNode(Color color) {
            Colour = color;

        }

        /// <summary>
        /// Constructor for the red-black tree node
        /// </summary>
        /// <param name="data"></param>
        /// <param name="left"></param>
        /// <param name="right"></param>
        public TreeNode(int data, Color color, TreeNode left, TreeNode right, TreeNode parent, TreeNode next) {
            Data = data;
            Colour = color;
            LeftChild = left;
            RightChild = right;
            Parent = null;
            Next = null;

            
        }


        #endregion Constructor

        #region Events

        #endregion Events

        #region Methods

        /// <summary>
        /// This routine outputs a Node in a default format
        /// </summary>
        /// <returns></returns>
        public override string ToString() {
            return String.Format("[data] = {0}, [color] = {1}", Data, Colour);

        }

        #endregion Methods


    }
}
