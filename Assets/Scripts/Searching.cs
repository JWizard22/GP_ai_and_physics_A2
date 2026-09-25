using UnityEngine;

public class Searching : MonoBehaviour
{
    public float radius;
    private Collider[] AdjacentNodes;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        //gets colliders for blank
        AdjacentNodes = Physics.OverlapSphere(transform.position, radius, LayerMask.GetMask("Blank"));
        Debug.Log(AdjacentNodes);
        Debug.Log(AdjacentNodes.Length);
       
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void begin()
    {
        for (int i = 0; i < AdjacentNodes.Length+1; i++)
        {
            AdjacentNodes[i].gameObject.TryGetComponent<Node>(out Node node);
            node.Queued();
            //add adjacent nodes to queue
            //AdjacentNodes.Add();
            //    = Physics.OverlapSphere(AdjacentNodes[i].transform.position, radius, LayerMask.GetMask("Blank"));

            //check if node's tag is Goal, if true, then break loop

            //if out of array bounds, say no available path

            Debug.Log(i + 1 + " finished loops");
        }
        //find shortest path to goal


    }


}
