﻿using System;
using System.Collections.Generic;

namespace GardenApp
{
    internal class Garden
    {
        List<Flower> flowers = new List<Flower>();
        List<Tree> trees = new List<Tree>();

        internal void AddFlowers(List<Flower> list)
        {
            list.ForEach(item => flowers.Add(item));
        }

        internal void AddTrees(List<Tree> list)
        {
            list.ForEach(item => trees.Add(item));
        }

        internal void DisplayStatusReport()
        {
            Console.WriteLine("Garden Status Report");
            Console.WriteLine("--------------------");
            flowers.ForEach(item => Console.WriteLine(item.DisplayStatusReport()));
            trees.ForEach(item => Console.WriteLine(item.DisplayStatusReport()));
            Console.WriteLine();
        }

        internal void Water(int water)
        {
            Console.WriteLine($"Watering with {water}");
            Console.WriteLine();
        }
    }
}