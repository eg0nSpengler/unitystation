﻿using UnityEngine;
using System.Collections;


namespace UI {

    public class ItemAttributes: MonoBehaviour {

        public enum Size {
            Small, Medium, Large
        }

        //reference numbers for item on  inhands spritesheet. should be one corresponding to player facing down
        public int inHandReferenceRight; 
        public int inHandReferenceLeft;

        //this and other reference ints should be read in from the master dictionary once we get all that shit figured out - for now it's hard coded
        //change values manually in the inspector -- wealth

        public Size size; //Small - can fit into any container Med - can fit into large containers but not pockets Large - can't fit in any container
                            //This can easily be modified later - just adding a foundation upon which we can build


        // Use this for initialization
        void Start() {

        }

        // Update is called once per frame
        void Update() {

        }
    }
}