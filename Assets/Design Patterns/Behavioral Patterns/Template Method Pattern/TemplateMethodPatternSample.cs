using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

namespace DesignPatterns.TemplateMethod
{
    public class TemplateMethodPatternSample : MonoBehaviour
    {
        void Start()
        {
            HouseBuilder woodenHouseBuilder = new WoodenHouseBuilder();
            woodenHouseBuilder.BuildHouse();

            HouseBuilder stoneHouseBuilder = new StoneHouseBuilder();
            stoneHouseBuilder.BuildHouse();
        }
    }


    public abstract class HouseBuilder
    {
        public void BuildHouse()
        {
            if(this is WoodenHouseBuilder)
                Debug.Log("Building new Wooden House.");
            else if(this is StoneHouseBuilder)
                Debug.Log("Building new Stone House.");

            BuildFoundation();
            BuildPillars();
            BuildWalls();
            BuildWindows();

            if (this is WoodenHouseBuilder)
                Debug.Log("Wooden House is built.");
            else if (this is StoneHouseBuilder)
                Debug.Log("Stone House is built.");

        }

        public abstract void BuildFoundation();
        public abstract void BuildPillars();
        public abstract void BuildWalls();
        public abstract void BuildWindows();

    }

    public class WoodenHouseBuilder : HouseBuilder
    {
        public override void BuildFoundation()
        {
            Debug.Log("Wooden House: Foundation with cement, iron rods and sand");
        }

        public override void BuildPillars()
        {
            Debug.Log("Wooden House: Pillars with Wood coating");
        }

        public override void BuildWalls()
        {
            Debug.Log("Wooden House: Walls with Wood coating");
        }

        public override void BuildWindows()
        {
            Debug.Log("Wooden House: Windows with Wood coating");
        }
    }

    public class StoneHouseBuilder : HouseBuilder
    {
        public override void BuildFoundation()
        {
            Debug.Log("Stone House: Foundation with cement, iron rods and sand");
        }

        public override void BuildPillars()
        {
            Debug.Log("Stone House: Pillars with Stone");
        }

        public override void BuildWalls()
        {
            Debug.Log("Stone House: Walls with Stone");
        }

        public override void BuildWindows()
        {
            Debug.Log("Stone House: Windows with Stone");
        }
    }

}