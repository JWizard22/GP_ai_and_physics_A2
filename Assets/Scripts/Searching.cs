using UnityEngine;

public class Searching : MonoBehaviour
{
    public float radius;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Collider[] AdjacentNodes = Physics.OverlapSphere(transform.position, radius, LayerMask.GetMask("Blank"));
        Debug.Log(AdjacentNodes);
        Debug.Log(AdjacentNodes.Length);

        //foreach (var AdjacentNode in AdjacentNodes)
        //{

        //}

        for (int i = 0; i < AdjacentNodes.Length; i++)
        {
            AdjacentNodes[i].gameObject.TryGetComponent<Node>(out Node node);
            node.Queued();
            //Check for target object within raycast range and move towards target object
            //RaycastHit2D hit = Physics2D.CircleCast(transform.position, radius, Vector2.zero, LayerMask.GetMask("Blank"));

            //AdjacentNodes[i].transform.position += new Vector3(0, 10, 0);
            Debug.Log(i + " finished loops");
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }




}
