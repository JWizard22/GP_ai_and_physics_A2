using NUnit.Framework;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class Searching : MonoBehaviour
{
    public float radius;
    private Collider[] AdjacentNodesArray;
    public List AdjacentNodes;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        //gets colliders for blank
        AdjacentNodesArray = Physics.OverlapSphere(transform.position, radius, LayerMask.GetMask("Blank"));
        Debug.Log(AdjacentNodesArray);
        Debug.Log(AdjacentNodesArray.Length);

        List<Collider> AdjacentNodes = new List<Collider>(AdjacentNodesArray);
       
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void begin()
    {
        for (int i = 0; i < AdjacentNodesArray.Length+1; i++)
        {
            AdjacentNodesArray[i].gameObject.TryGetComponent<Node>(out Node node);
            node.Queued();
            //add adjacent nodes to queue
            AdjacentNodesArray = Physics.OverlapSphere(transform.position, radius, LayerMask.GetMask("Blank"));
            for (int a = 0; a < AdjacentNodesArray.Length; a++)
                {
                //AdjacentNodes.Add     add collider here for each element of array.length
                }
            //AdjacentNodes.Add();
            //    = Physics.OverlapSphere(AdjacentNodes[i].transform.position, radius, LayerMask.GetMask("Blank"));

            //check if node's tag is Goal, if true, then break loop

            //if run out of list elements, say no available path

            Debug.Log(i + 1 + " finished loops");
        }
        //find shortest path to goal


    }


}
