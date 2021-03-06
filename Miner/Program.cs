﻿using System;


namespace Guytp.BurstSharp.Miner
{
    /// <summary>
    /// This class contains the main entry point to the application.
    /// </summary>
    public class Program
    {
        /// <summary>
        /// The main entry point to the application.
        /// </summary>
        /// <param name="args">
        /// Any command line arguments.
        /// </param>
        public static void Main(string[] args)
        {
            try
            {
                using (Miner miner = new Miner())
                {
                    miner.Run();
                }
            }
            catch (Exception ex)
            {
                ConsoleUi.WriteLine(ex.ToString());
            }
        }
    }
}