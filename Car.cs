using System;

namespace Properties_Null_Asher
{
    public class Car
    {
        private string model;

        public string Model
        {
            get { return model; }
            set { model = value; }
        }

        public string Make { get; set; }
    }
}