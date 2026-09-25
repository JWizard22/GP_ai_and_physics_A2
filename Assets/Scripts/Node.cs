using UnityEngine;

public class Node : MonoBehaviour
{
    private SpriteRenderer spriteRend;


    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        spriteRend = GetComponent<SpriteRenderer>();



    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void Queued()
    {
        spriteRend.color = Color.yellow;
        //
    }
    public void Searched()
    {
        spriteRend.color = Color.blue;
        //add adjacent nodes to queue
    }


}
