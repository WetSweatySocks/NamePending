using UnityEngine;

public class watch : MonoBehaviour
{
    public int topPos = -18;
    public int bottomPos = -614;

    public int pos = -614;
    void Start()
    {
        
    }

    void Update()
    {
        if (Input.GetKeyUp(KeyCode.Space))
        {
            pos = topPos;
        }
        else
        {
            pos = bottomPos;
        }

        if (transform.position.y > pos)
        {
            
        }
    }
}
