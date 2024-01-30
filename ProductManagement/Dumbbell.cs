using ProductManagement;
using System;

namespace ProductManagement
{
    public class Dumbbell : Product
    {
        public double Weight { get; set; }
        public string MaterialType { get; set; }
        public bool Adjustable { get; set; }
        public string TextureType { get; set; }

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