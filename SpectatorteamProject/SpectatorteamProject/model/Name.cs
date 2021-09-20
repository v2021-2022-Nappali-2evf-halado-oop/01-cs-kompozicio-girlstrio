using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpectatorteamProject.model
{
    class Name
    {
        
            private string firstName;//rejtett adattag
            private string lastName;//rejtett adattag
            /// <summary>
            /// osztály konstruktor
            /// </summary>
            /// <param name="firstName"></param>
            /// <param name="lastName"></param>
            public Name(string firstName, string lastName)
            {
                this.FirstName = firstName;
                this.LastName = lastName;
            }

            public string FirstName { get => firstName; set => firstName = value; }
            public string LastName { get => lastName; set => lastName = value; }

            public string FullName
            {
                get
                {
                    return lastName + " " + firstName;
                }
            }
            public override string ToString()
            {
                return "\nNéző neve: " + FullName;
            }
        }
        /// <summary>
        /// hitelkártya osztály
        /// </summary>
    
}
