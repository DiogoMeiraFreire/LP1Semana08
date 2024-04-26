/*
 * This Source Code Form is subject to the terms of the Mozilla Public
 * License, v. 2.0. If a copy of the MPL was not distributed with this
 * file, You can obtain one at https://mozilla.org/MPL/2.0/.

    Author:     Steven Hall 
    contact:    stevenbryanb.work@gmail.com

    Comply with the terms of the MPL 2.0!
 */

namespace AnimalKingdom {
    /// <summary>
    /// Represents a very basic cat
    /// </summary>
    public class Cat : Animal, IMammal
    {//                    implementação 

        //
        public int NumberOfNipples { get; } // gets property
                    
        // ------------------------------------------------------------------ //

        /// <summary>
        /// Defines a cat, initializes with 6 nipples
        /// Inherits from Animal and implements IMammal
        /// </summary>
        public Cat()
        {

            NumberOfNipples = 6; // set number of nipples to 6
            
        }

        /// <summary>
        /// Overrides sound adding base + miau
        /// </summary>
        /// <returns></returns>
        public override string Sound() // overrides sound
        {
            return $"{base.Sound()} Miau";
        }
    }
}
// -----------------------------------------------------------------------------
