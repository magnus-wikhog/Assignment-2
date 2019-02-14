﻿namespace Assignment.Animals
{

    /*
     * This is the abstract base class for all animal species, and contains common
     * properties for all species.
     */
    public abstract class Animal : IAnimal{

        // Abstract interface methods that need to be implemented by subclasses
        public abstract EaterType GetEaterType();
        public abstract FoodSchedule GetFoodSchedule();
        public abstract string GetSpecies();


        // Public properties common to all animals
        public string ID => id;
        public string Name { get => name; set => name = value; }
        public string Gender { get => gender; set => gender = value; }
        public int age;


        protected string id;
        protected string name;
        protected string gender;



        public Animal(string id){
            this.id = id;
        }



        /*
         * This method will be overriden by subclasses and used to get a string representation
         * of the special characteristics for an animal category and an animal species.
         */
        public virtual string GetSpecialCharacteristics() {
            return "";
        }

    }
}
