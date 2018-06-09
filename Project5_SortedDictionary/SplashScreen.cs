////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
//
//      Solution/Project:      Project 5
//      File Name:             SplashScreen.cs
//      Description:           Splash Screen Winform introduces product and programmer info
//      Course:                Data Structures CSCI 2210-001 
//      Author:                Danelle Hennings, hennings@goldmail.etsu.edu
//      Created:               Friday April 22, 2016
//      Copyright:             Danelle Hennings, ETSU, 2016
//
////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
using System;
using System.Windows.Forms;

namespace Project5_SortedDictionary
{
    /// <summary>
    /// Partial class for assembling windows form that presents the user with an introduction to the application
    /// </summary>
    public partial class SplashScreen : Form
    {
        /// <summary>
        /// time left for splash screen to be displayed
        /// </summary>
        public int timeLeft
        {
            get; private set;
        }

        /// <summary>
        /// initialize windows form
        /// </summary>
        public SplashScreen( )
        {
            InitializeComponent( );
        }

        /// <summary>
        /// sets and starts timer for 6 seconds
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SplashScreen_Load(object sender, EventArgs e)
        {
            timeLeft = 6;                  //splash screen will  be display for 8 seconds
            timer.Start( );                //start timer now
        }

        /// <summary>
        /// timer to close splash screen after 6 seconds
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void timer_Tick(object sender, EventArgs e)
        {
            if (timeLeft > 0)                 //if time left is above 0
            {
                timeLeft--;                     //decrement timeLeft
            }
            else
            {
                timer.Stop( );                  //else stop timer    
                Hide( );                        //hide splash screen
                new GeoChallenge( ).Show( );    //show user info box 
            }
        }
    }
}
