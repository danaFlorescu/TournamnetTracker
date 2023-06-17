﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrackerLibrary
{

    /// <summary>
    /// Represents one person.
    /// </summary>
    public class PersonModel
    {
        /// <summary>
        /// The first name of the person.
        /// </summary>
        public string  FirstName { get; set; }

        /// <summary>
        /// The last name of the person.
        /// </summary>
        public string LastName { get; set; }

        /// <summary>
        /// The email adress of the person.
        /// </summary>
        public string EmailAdress { get; set; }

        /// <summary>
        /// The cell phone of the person.
        /// </summary>
        public string CellPhoneNumber { get; set; }

    }
}
