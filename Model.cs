using static System.Console;

/* 
[Fashion Wise] 
[Text Game] 
[Marina Pollak]
[03/22/2022] 

Used polimorphism from class demo

*/




namespace FashionWise3
{
    public class Model
    {
        //set the acces modifier for var that insures hereditability
        protected string modelName;
        protected string modelLook;
        protected string modelHeight;
        protected int modelAge;


        public Model()
        {
            modelName = "Models";

            //Height
            modelHeight = "Tall, Medium, Short";

            //set Look name
            modelLook = "Check them out!";


            //set the age
            modelAge = 22;

        }

        //public property to get  value
        public int GetAge
        {
            get { return modelAge; }

        }
        //public property to get name


        public string GetModelName

        {
            get { return modelName; }

        }

        public string GetModelLook
        {
            get { return modelLook; }

        }

        public virtual void ModelInfo()
        {
            WriteLine($"Hopefully you did check out our {modelName}");
        }

    }
}
