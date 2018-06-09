////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
//
//      Solution/Project:      Project 5
//      File Name:             GeoChallenge.cs
//      Description:           Windows form application that presents the user with a US Geography Challenge to try 
//                               and match the provided state to its capital city. Implements a sorted dictionary 
//                              with the state as the key and the city as the value.
//      Course:                Data Structures CSCI 2210-001 
//      Author:                Danelle Hennings, hennings@goldmail.etsu.edu
//      Created:               Tuesday April 19, 2016
//      Copyright:             Danelle Hennings, ETSU, 2016
//
////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace Project5_SortedDictionary
{
    /// <summary>
    /// Partial class for assembling windows form that presents the user with 
    /// a Geography state/capital matching game, handles all events raised by user's actions
    /// </summary>
    public partial class GeoChallenge : Form
    {
        //instantiate a Sorted Dictionary object with state as key and city as value
        private SortedDictionary<String, String> statesDict = new SortedDictionary<string, string>( );
        private StreamReader statesFile;        //initialize streamReader variable for dictionary file
        private int timeLeft,                   //time left in countdown
                    numIncorrect = 0,           //number of incorrect answers
                    numCorrect = 0;             //number of correct answers
        private string randomState,             //random state to display for challenge
                       correctCapital;          //correct state capital
        private Random ran = new Random( );     //random object used for selecting random state
        private KeyValuePair<string, string> stateCapital;   //key value pair for state and capital

        /// <summary>
        /// Presents user with a randomly selected state and provides a list of capitals
        /// for them to choose from and countdown timer to limit the amount of time to answer.
        /// Each question presented increases the number of attempts, and every question answered 
        /// correctly increases the number correct and presents and messagebox saying correct.
        /// When user clicks end game or simply exits the window, an exit message with their score is presented
        /// </summary>
        public GeoChallenge( )
        {
            InitializeComponent( );

            //instantiate dictionary file streamreader using states.txt
            statesFile = new StreamReader("states.txt");

			try //try to parse city and state from text file
			{
                while (statesFile.Peek( ) != -1)//while something was read in from states.txt
                {
                    //read line into fields array, use comma as delimiter for splitting line
                    string[ ] fields = statesFile.ReadLine( ).Split(',');
					//add to dictionary, key<-state  value<-city
					statesDict.Add(fields[1], fields[0]);
                }//end while
            }//end try
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                if (statesFile != null)     //if file was able to be opened
                    statesFile.Close( );    //close the streamreader 
            }//end finally
            //add all state capitals in alphabetical order to listBox
            capitalsListBox.DataSource = statesDict.Values.ToList( );
        }//end GeoChallenge()

        /// <summary>
        /// When the form loads, call on ResetForm to display a random state name 
        /// and set the timer to begin counting down from 15 seconds
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void GeoChallenge_Load(object sender, EventArgs e)
        {
            resetForm( );       //setup form for state to be matched with its capital city
        }

        /// <summary>
        /// Sets up form with new state to be paired with its capital
        /// initializes and starts countdown from 15 seconds
        /// increments total number of attempts regardless of whether they answer before time expires
        /// and displays the total in text box for number of attempts
        /// </summary>
        private void resetForm( )
        {
			lblNumIncorrect.Text = numIncorrect.ToString();//assign number of attempts to corresponding textbox
			lblNumCorrect.Text = numCorrect.ToString(); //assign number correct to corresponding textbox

			btnSubmit.Enabled = true;           //re-enable sumbit button
			timeLeft = 15;                      //set time left to be 15 seconds
            txtTimerCount.Text = "15";          //make time count show 15 for a second before counting down
            capitalsListBox.Enabled = true;     //enable list box
            capitalsListBox.SelectedIndex = 0;  //pre-select the first state capital as default
            countdown.Enabled = true;           //enable timer
            countdown.Start( );                 //start timer 

            //get another random state capital pair from dictionary of 50 states
            stateCapital = statesDict.ElementAt(ran.Next(50));
            randomState = stateCapital.Key;         //get string for random state name
            lblState.Text = randomState;            //make state label on form the random state
            correctCapital = stateCapital.Value;    //get correctCapital string value
        }

        /// <summary>
        /// For every second that passes, the countdown textbox is updated
        /// displays messagebox when time runs out and stops timer
        /// the listbox controls and countdown timer are disabled
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void countdown_Tick(object sender, EventArgs e)
        {
            timeLeft--;         //decrement time left on countodwn
            txtTimerCount.Text = timeLeft.ToString( );   //display time left in timerCount text box

            if (timeLeft == 0)       //if time runs out
            {
                countdown.Stop( );                  //stop timer
                capitalsListBox.Enabled = false;    //disable list box controls
                countdown.Enabled = false;          //disable countdown timer
				MessageBox.Show("Time's up!" +
					"\nThe capital of " + randomState + " is " + correctCapital);
				numIncorrect++;
			}
        }//end countdown

		/// <summary>
		/// When submit is pressed, the timer stops, listbox controls are disabled
		/// and the currently selected city is compared to the correct answer.
		/// The corresponding correct/incorrect counter is updated.
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void btnSubmit_Click(object sender, EventArgs e)
		{
			countdown.Stop();                   //stop timer
			capitalsListBox.Enabled = false;    //disable list box controls
			countdown.Enabled = false;          //disable countdown timer
			btnSubmit.Enabled = false;          //disable sumbit button

			//did user select correct capital
			if (capitalsListBox.SelectedItem.ToString() == correctCapital)
			{
				MessageBox.Show("CORRECT!");
				numCorrect++;                   //increment number of correct attempts
			}
			else
			{
				MessageBox.Show("\tINCORRECT!" +
					"\nThe capital of " + randomState + " is " + correctCapital);
				numIncorrect++;                      //increment total number of attempts
			}

			lblNumIncorrect.Text = numIncorrect.ToString();//assign number of attempts to corresponding textbox
			lblNumCorrect.Text = numCorrect.ToString(); //assign number correct to corresponding textbox
		}

		/// <summary>
		/// If a letter of the alphabet is entered, advance to the first
		/// city that begins with that letter, for quicker searching
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void capitalsListBox_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
		{
			if (e.KeyCode < Keys.A || e.KeyCode > Keys.Z)
				return;         //just return if not a letter of the alphabet
			else
			{
				int index = capitalsListBox.FindString(e.KeyCode.ToString()) - 1;
				if(index < 0)
				{
					capitalsListBox.SelectedIndex = 0;
				}
				else
				{
					//advance selection to first city that begins with the letter entered at keyboard
					capitalsListBox.SelectedIndex = index;
				}
			}
		}
		/// <summary>
		/// call on ResetForm to display a random state name 
		/// and set the timer to begin counting down from 15 seconds
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void btnNextQ_Click(object sender, EventArgs e)
		{
			resetForm();       //reset form with new question 
		}

		/// <summary>
		/// Calls on ExitApplication to handle exiting the program
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void btnEndGame_Click(object sender, EventArgs e)
		{
			//method displays thank you message with score and number of attempted questions
			ExitApplication();
		}

        /// <summary>
        /// Calls on ExitApplication to handle exiting the program
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void GeoChallenge_FormClosed(object sender, FormClosedEventArgs e)
        {
            //exit method displays thank you message with score and number of attempted questions
            ExitApplication( );
        }

        /// <summary>
        /// Displays message box thanking user and displays their score and number of questions attempted
        /// then exits the application
        /// </summary>
        private void ExitApplication( )
        {
			double score;
			double total = numCorrect + numIncorrect;

			if (total == 0)
			{
				score = 0;
			}
			else
			{
				score = numCorrect / total;    //calculate score
			}

			MessageBox.Show(string.Format("Thank you for playing the State Capital Matching Game!"
				+ "\n\n\tYour score was {0:0.0%} for {1} questions.", score, numCorrect + numIncorrect));

			//gracefully exit application
			Environment.Exit(0);
        }

    }//end class GeoChallenge() Form
}//end Project5

