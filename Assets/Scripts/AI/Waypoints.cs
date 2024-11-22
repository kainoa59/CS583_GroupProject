using System.Collections.Generic;
using UnityEngine;

public class Waypoints : MonoBehaviour
{
    public float sphereRadius = 1f;
    public Color waypointColor = Color.red;
    public Color lineColor = Color.blue;

    private List<Transform> waypointsList = new List<Transform>();

    private void OnDrawGizmos()
    {
        if (!Application.isPlaying)
        {
            Gizmos.color = waypointColor;
        }
        else
        {
            Gizmos.color = Color.clear;
        }

        waypointsList.Clear();

        foreach (Transform t in transform)
        {
            waypointsList.Add(t);
            Gizmos.DrawWireSphere(t.position, sphereRadius);
        }

        if (!Application.isPlaying)
        {
            Gizmos.color = lineColor;

            for (int i = 0; i < waypointsList.Count - 1; i++)
            {
                Gizmos.DrawLine(waypointsList[i].position, waypointsList[i + 1].position);
            }
        }
    }
}
