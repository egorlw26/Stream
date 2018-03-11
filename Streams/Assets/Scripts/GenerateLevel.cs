using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class GenerateLevel : MonoBehaviour
{
    List<List<Vector2>> graph;
    List<Vector2> vertecies;

    float left = -8, right = 8, top = 4.5f, bottom = 4.5f;
    // Use this for initialization
    void Start()
    {
        CreateVertecies();
        vertecies = vertecies.OrderBy(v => v.x).ToList();
        for (int i = 0; i < vertecies.Count; i++)
        {
            if (i == 0)
                Instantiate(Resources.Load("StartValve", typeof(GameObject)), vertecies[i], Quaternion.identity);
            else if (i == vertecies.Count - 1)
                Instantiate(Resources.Load("FinishValve", typeof(GameObject)), vertecies[i], Quaternion.identity);
            else
                Instantiate(Resources.Load("Valve", typeof(GameObject)), vertecies[i], Quaternion.identity);
        }

        CreateGraph();
        for (int i = 0; i < vertecies.Count; i++)
        {
            for (int j = 0; j < graph[i].Count; j++)
            {
                float x = (vertecies[i].x + graph[i][j].x) / 2.0f;
                float y = (vertecies[i].y + graph[i][j].y) / 2.0f;
                Vector2 pos = new Vector2(x, y);
                GameObject trumpet = Instantiate(Resources.Load("TrumpetWithAnima", typeof(GameObject)), pos, Quaternion.identity) as GameObject;
                float dy = (graph[i][j].y - vertecies[i].y);
                float dx = (graph[i][j].x - vertecies[i].x);
                float angle = Mathf.Atan2(dy,dx) * 180.0f / Mathf.PI;
                trumpet.transform.Rotate(new Vector3(0,0,angle));
            }
        }
    }

    void CreateVertecies()
    {
        vertecies = new List<Vector2>();
        Vector2 startVertex = new Vector2(-7, 0);
        Vector2 finishVertex = new Vector2(7, 0);
        vertecies.Add(startVertex);
        vertecies.Add(finishVertex);
        while (vertecies.Count < 10)
        {
            Vector2 newVertex = new Vector2(Random.Range(-6, 6), Random.Range(-4, 4));
            bool ok = true;

            foreach (Vector2 vertex in vertecies)
            {
                if (Vector2.Distance(vertex, newVertex) < 3.0f)
                {
                    ok = false;
                    break;
                }
            }

            if (ok) vertecies.Add(newVertex);
        }
    }

    void CreateGraph()
    {
        graph = new List<List<Vector2>>();
        for (int i = 0; i < vertecies.Count; i++)
        {
            graph.Add(new List<Vector2>());
            int c = Random.Range(2, 5);
            for (int j = i + 1; j < vertecies.Count && j - i < c; j++)
            {
                graph[i].Add(vertecies[j]);
            }
        }
    }

    // Update is called once per frame
    void Update()
    {

    }
}
