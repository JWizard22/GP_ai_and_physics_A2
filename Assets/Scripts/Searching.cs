using NUnit.Framework;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class Searching : MonoBehaviour
{
    public float radius;
    private Collider[] AdjacentNodesArray;
    public List<GameObject> AdjacentNodes;
    private int QueuedLayerIndex;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        //gets colliders for blank
        AdjacentNodesArray = Physics.OverlapSphere(transform.position, radius, LayerMask.GetMask("Blank"));

        Debug.Log(AdjacentNodesArray);
        Debug.Log(AdjacentNodesArray.Length);
        QueuedLayerIndex = LayerMask.NameToLayer("Queued");

        AdjacentNodes = new List<GameObject>();
       
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void begin()
    {
        for (int i = 0; i < AdjacentNodesArray.Length; i++)
        {
            AdjacentNodes.Add(AdjacentNodesArray[i].gameObject);
        }
        
        for (int i = 0; i < 99 /*AdjacentNodes.Count*/; i++)
        {
            AdjacentNodes[i].TryGetComponent<Node>(out Node node);
            if (node != null) { node.Queued(); }

            //add adjacent nodes to queue
            AdjacentNodesArray = Physics.OverlapSphere(AdjacentNodes[i].transform.position, radius, LayerMask.GetMask("Blank"));
            //if (AdjacentNodesArray.Length > 0)
            for (int a = 0; a < AdjacentNodesArray.Length; a++)
                {
                AdjacentNodes.Add(AdjacentNodesArray[a].gameObject);     //add collider here for each element of array.length
                AdjacentNodesArray[a].gameObject.layer = QueuedLayerIndex;
            }

            if (node != null) { node.Searched(); }

            //AdjacentNodes.Add();
            //    = Physics.OverlapSphere(AdjacentNodes[i].transform.position, radius, LayerMask.GetMask("Blank"));

            //check if node's tag is Goal, if true, then break loop

            //if run out of list elements, say no available path

            //Invoke(nameof(delay), 200.0f);
            //StartCoroutine(Delay());

            Debug.Log(i + 1 + " finished loops");

        }
        //find shortest path to goal


    }

    //IEnumerator Delay()
    //{
    //    yield return new WaitForSeconds(1000f);
    //}

    //private void delay()
    //{
    //    return;
    //}

}
