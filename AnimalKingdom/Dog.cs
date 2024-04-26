/*
 * This Source Code Form is subject to the terms of the Mozilla Public
 * License, v. 2.0. If a copy of the MPL was not distributed with this
 * file, You can obtain one at https://mozilla.org/MPL/2.0/.

    Author:     Steven Hall 
    Contact:    stevenbryanb.work@gmail.com

    Comply with the terms of the MPL 2.0!
 */

namespace AnimalKingdom {

    /// <summary>
    /// Represents a basic Dog with 8 nipples.
    /// Inherits from Animal and implements IMammal
    /// </summary>
    public class Dog : Animal, IMammal
    {
        // Number of nipples this animal
        // Gets & sets with constructor
        public int NumberOfNipples { get; }          // gets property

        // ------------------------------------------------------------------ //

        /// <summary>
        /// Initializes a new instance of the Dog class.
        /// Inherits from Animal and implements IMammal
        /// </summary>
        public Dog()
        {   
            // initializes dog with 8 nipples
            NumberOfNipples = 8;
        }

        /// <summary>
        /// Overrides the Sound method from Animal with a Dog sound.
        /// </summary>
        /// <returns>
        /// Base string + "Woof!" in string format.
        /// </returns>
        public override string Sound()
        {
            return $"{base.Sound()} Woof!";
        }
    }
}
// -----------------------------------------------------------------------------
