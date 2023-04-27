/*********************************************************************************************************

 * Project: PR05 Balanced Tree
 * 
 * File: Balanced Tree Form Class
 * 
 * Langauge: VS C#
 * 
 *
 *
 * Description: This file will implement a balanced binary tree in C#.
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
 * 3/20/2022                - Initial writing.
 * 3/20/2022                - Added regions.
 * 3/20/2022                - Added header.
 * 3/20/2022                - Implemented form, added naming conventions.
 * 3/20/2022                - Added a node class for the tree. Populated elements and added notes.
 * 3/20/2022                - Added a Balanced Tre class. Populated elements and added notes.
 * 3/20/2022                - Added error trapping for textboxes on the form.
 * 3/20/2022                - Added code for each of the button click controls
 *                           
 *                          Notes:
 *                          - Having difficulty implementing and displaying bst contents
 *                          
*********************************************************************************************************/
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ward_PR05_BalancedTrees {
    public partial class BalancedTree : Form {



        #region Constants

        private const int DEFAULT_SEED = 19;
        private const int DEFAULT_NOF_DATA_POINT = 20;

        #endregion Constants

        #region Data Members

        BalancedTreeClass treeList = new BalancedTreeClass();       // creates and empty binary search tree

        int seedValue;
        int nofDataPoints;

        #endregion Data Members

        #region Constructors

        /// <summary>
        /// Constructor for the form
        /// </summary>
        public BalancedTree() {
            InitializeComponent();
        }
        #endregion Constructors

        #region Properties
        #endregion Properties

        #region Events

        /// <summary>
        /// This button calls the count routine, which counts all of the 
        /// values stored in the binary search routine.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonCount_Click(object sender, EventArgs e) {
            // Get the number of values in the binary search tree

            // display the values in the list box
        }

        /// <summary>
        /// This button rebalances the tree based on the color of the
        /// node
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonFlipColor_Click(object sender, EventArgs e) {
            // Search the tree for color imbalances 

            // Split nodes 

            // Display the values in the listbox

        }


        /// <summary>
        /// This button calls the InOrder routine, which displays 
        /// all values in the binary search tree in order
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonInOrder_Click(object sender, EventArgs e) {

            // Get the values from the binary search tree in order

            // display the values in the list box
        }


        /// <summary>
        /// This button calls the generate random numbers routine,
        /// inserts the random values into the binary tree, and  
        /// displays them in the listbox.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonInsertRand_Click(object sender, EventArgs e) {
            int newValue;

            // validate the seed value 
            if (!int.TryParse(textBoxSeedValue.Text, out seedValue)) {
                seedValue = DEFAULT_SEED;
            }

            // validate the size value
            if (!int.TryParse(textBoxSize.Text, out nofDataPoints)) {
                nofDataPoints = DEFAULT_NOF_DATA_POINT;
            }

            //generate random values
            Random random = new Random();
            newValue = random.Next(seedValue, nofDataPoints);

            // Insert the data into the binary search tree
            treeList.Insert(newValue);

            // display the linked list
            treeList.Iterate(treeList.root, listBoxBalancedTree);


        }

        /// <summary>
        /// This button calls the LeftRotate routine, which rotates the 
        /// string anticlockwise 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonLeftRotate_Click(object sender, EventArgs e) {
            // Get the values from the binary search tree in order

            // Rotate the values 

            // display the values in the list box
        }


        /// <summary>
        /// This button calls the Min routine, which finds the smallest value in
        /// the binary search tree
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonMaximum_Click(object sender, EventArgs e) {
            // Get the minimum value from the binary search tree in order

            // display the values in the list box
        }


        /// <summary>
        /// This button calls the Max routine, which finds the largest value in
        /// the binary search tree
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonMinimum_Click(object sender, EventArgs e) {
            // Get the minimum value from the binary search tree in order

            // display the values in the list box
        }


        /// <summary>
        /// This button calls the RightRotate routine, which rotates the 
        /// string anticlockwise 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonRightRotate_Click(object sender, EventArgs e) {
            // Get the values from the binary search tree in order

            // Rotate the values 

            // display the values in the list box

        }


        /// <summary>
        /// This routine will determine if the key pressed is either a control 
        /// character or a digit. All other keys will be rejected.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void textBoxSeedValue_KeyPress(object sender, KeyPressEventArgs e) {
            if (!char.IsControl(e.KeyChar) && (!char.IsDigit(e.KeyChar))) {
                e.Handled = true;
            }
        }

        /// <summary>
        /// This routine will determine if the key pressed is either a control 
        /// character or a digit. All other keys will be rejected.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void textBoxSize_KeyPress(object sender, KeyPressEventArgs e) {
            if (!char.IsControl(e.KeyChar) && (!char.IsDigit(e.KeyChar))) {
                e.Handled = true;
            }
        }

        /// <summary>
        /// This routine will determine if the key pressed is either a control 
        /// character or a digit. All other keys will be rejected.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void textBoxSearch_KeyPress(object sender, KeyPressEventArgs e) {
            if (!char.IsControl(e.KeyChar) && (!char.IsDigit(e.KeyChar))) {
                e.Handled = true;
            }
        }

        #endregion Events

        #region Methods

        /// <summary>
        /// Display the contents of the BST Linked list.
        /// </summary>
        /// <param name="wordList"></param>
        /// <param name="theListBox"></param>
        private void DisplayList(BalancedTreeClass treeList, ListBox theListBox) {
            // clear the list box
            theListBox.Items.Clear();

            // display the contents of the list
            treeList.Iterate(treeList.root, listBoxBalancedTree);

            // display the header
            theListBox.Items.Add(String.Empty);
            theListBox.Items.Add(String.Format("The total word count is: {0}", treeList.Count));

        }

        #endregion Methods



    }
}
