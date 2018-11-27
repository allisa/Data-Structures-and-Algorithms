using System;
using System.Collections.Generic;
using System.Text;

namespace Graphs.Classes
{
    public class Graph
    {
        public List<Vertex> Vertices { get; set; }

        /// <summary>
        /// Creates a graph of unconnected nodes
        /// </summary>
        /// <param name="values">A list of values to give the graph nodes</param>
        public Graph(List<object> values)
        {
            Vertices = new List<Vertex>();
            foreach (object value in values)
            {
                Vertices.Add(new Vertex(value));
            }
        }

        /// <summary>
        /// Adds an edge between the two vertices
        /// </summary>
        /// <param name="vertex1">Value of first vertex</param>
        /// <param name="vertex2">Value of second vertex</param>
        /// <param name="weight">Weight of edge between vertices</param>
        public void AddEdge(object vertex1, object vertex2, int weight)
        {
            Vertex v1Ref = Vertices.Find(x => x.Value == (object)vertex1);
            if (v1Ref == null)
            {
                v1Ref = new Vertex(vertex1);
                Vertices.Add(v1Ref);
            }
            Vertex v2Ref = Vertices.Find(x => x.Value == vertex2);
            if (v2Ref == null)
            {
                v2Ref = new Vertex(vertex2);
                Vertices.Add(v2Ref);
            }

            v1Ref.AdjacentVertices.Add(v2Ref, weight);
            v2Ref.AdjacentVertices.Add(v1Ref, weight);
        }

        /// <summary>
        /// Returns a list of the graph's vertices
        /// </summary>
        /// <returns>A list of the graph's vertices</returns>
        public List<Vertex> GetNodes()
        {
            return Vertices;
        }

        /// <summary>
        /// Returns the number of vertices in the graph
        /// </summary>
        /// <returns>The vertex count for the graph</returns>
        public int Size()
        {
            return Vertices.Count;
        }

        /// <summary>
        /// Returns a dictionary of a vertex's neighbors, each key is another vertex,
        /// and each value is the edge weight between the two vertices
        /// </summary>
        /// <param name="value">Vertex value</param>
        /// <returns>Dictionary of neighboring vertices with edge weights as values</returns>
        public Dictionary<Vertex, int> GetNeighbors(object value)
        {
            Vertex vertexRef = Vertices.Find(x => x.Value == value);
            if (vertexRef == null)
            {
                return null;
            }
            return vertexRef.AdjacentVertices;
        }
    }
}
