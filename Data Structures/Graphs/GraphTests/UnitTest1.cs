using Graphs.Classes;
using System;
using System.Collections.Generic;
using Xunit;


namespace GraphTests
{
    public class UnitTest1
    {
        //Test AddEdge()
        [Theory]
        [InlineData("Seattle", "LA", 10)]
        [InlineData("Seattle", "Denver", 2)]
        [InlineData("Denver", "LA", 5)]
        public void TestAddEdge(object v1, object v2, int weight)
        {
            List<object> cities = new List<object>()
            {
                "Seattle",
                "LA",
                "Denver"
            };
            //Set up the graph
            Graph graph = new Graph(cities);
            //Add edge
            graph.AddEdge(v1, v2, weight);
            //Assert success - that v1 is in the adjacency list of v2 and vice versa
            Dictionary<Vertex, int> v1Neighbors = graph.GetNeighbors(v1);
            Dictionary<Vertex, int> v2Neighbors = graph.GetNeighbors(v2);
            Assert.True(v1Neighbors.ContainsValue(weight) && v2Neighbors.ContainsValue(weight));
        }

        //Test GetNeighbors()
        [Theory]
        [InlineData(5, 1)]
        [InlineData(-4, 10)]
        [InlineData(100, -1)]
        public void TestGetNeighbors(int weight1, int weight2)
        {
            List<object> cities = new List<object>()
            {
                "Seattle",
                "LA",
                "Denver"
            };
            //Set up the graph
            Graph graph = new Graph(cities);
            //Add edge
            graph.AddEdge(cities[0], cities[1], weight1);
            graph.AddEdge(cities[2], cities[0], weight2);

            Dictionary<Vertex, int> seattleNeighbors = graph.GetNeighbors("Seattle");
            Assert.True(seattleNeighbors.ContainsValue(weight1) && seattleNeighbors.ContainsValue(weight2));
        }

        //Test Size


    }
}
