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
            {

            }
            else
                Instantiate(Resources.Load("Valve", typeof(GameObject)), vertecies[i], Quaternion.identity);
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

    // Update is called once per frame
    void Update()
    {

    }
}
