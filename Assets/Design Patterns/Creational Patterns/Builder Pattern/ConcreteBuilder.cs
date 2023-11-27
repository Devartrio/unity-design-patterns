using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace DesignPatterns.Builder
{
    public class ConcreteBuilder : IBuilder
    {
        private Product product = new Product();

        public ConcreteBuilder()
        {
            this.Reset();
        }

        public void Reset()
        {
            this.product = new Product();
        }

        public void BuildPartA()
        {
            product.Add("PartA1");
        }

        public void BuildPartB()
        {
            product.Add("PartB1");
        }

        public void BuildPartC()
        {
            product.Add("PartC1");
        }

        public Product GetProduct()
        {
            Product result = this.product;

            Reset();

            return result;
        }
    }
}
