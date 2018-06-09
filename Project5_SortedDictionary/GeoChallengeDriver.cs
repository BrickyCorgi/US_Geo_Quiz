////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
//
//      Solution/Project:      Project 5 Associative Containers
//      File Name:             GeoChallengeDriver.cs
//      Description:           Driver class for enabling and running the GeoChallenge winform  
//      Course:                Data Structures CSCI 2210-001 
//      Author:                Danelle Hennings, hennings@goldmail.etsu.edu
//      Created:               Tuesday April 19, 2016
//      Copyright:             Danelle Hennings, ETSU, 2016
//
////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
using System;
using System.Windows.Forms;

namespace Project5_SortedDictionary
{
    /// <summary>
    /// Enables and runs the Geography Challenge Application
    /// </summary>
    static class GeoChallengeDriver
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main( )
        {
            Application.EnableVisualStyles( );
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new SplashScreen( ));   //opens main GeoChallenge form on close
        }
    }
}
