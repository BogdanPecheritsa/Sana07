using ProductManagement;
using System;

namespace ProductManagement
{
    public class Dumbbell : Product
    {
        protected double weight;
        public double Weight
        {
            get => weight;
            set
            {
                if (value >= 0)
                    weight = value;
                else throw new ArgumentException("Weight cannot be negative.");
            }
        }
        protected string materialType;
        public string MaterialType
        {
            get => materialType;
            set
            {
                if (value == null)
                    throw new ArgumentException("MaterialType cannot be null.");
                else
                    materialType = value;
            }
        }
        protected bool adjustable;
        public bool Adjustable
        {
            get => adjustable;
            set => adjustable = value;
        }
        protected string textureType;
        public string TextureType
        {
            get => textureType;
            set
            {
                if (value == null)
                    throw new ArgumentException("TextureType cannot be empty or whitespace.");
                else
                    textureType = value;
            }
        }

        public Dumbbell(string name, double price, int count, double weight, string materialType, string textureType, bool adjustable)
            : base(name, price, count)
        {
            Weight = weight;
            MaterialType = materialType;
            Adjustable = adjustable;
            TextureType = textureType;
        }

        public override string Display()
        {
            return $"Dumbbell: {Name}, Weight: {Weight} lbs, Material Type: {MaterialType}, Adjustable: {Adjustable}, Texture Type: {TextureType}, " +
                $"Price: {Price}, Count: {Count}";
        }
    }
}