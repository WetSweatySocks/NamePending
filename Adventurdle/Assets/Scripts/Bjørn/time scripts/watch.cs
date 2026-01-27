using UnityEngine;

public class watch : MonoBehaviour
{
    public int topPos = -18;
    public int bottomPos = -614;

    public int pos = -614;

    public int spd = 5;
    void Start()
    {
        
    }

    void Update()
    {
        if (Input.GetKey(KeyCode.Space))
        {
            pos = topPos;
        }
        else
        {
            pos = bottomPos;
        }

        if (transform.position.y > pos)
        {
            transform.position = transform.position + new Vector3(0,-spd,0);
        }
        if (transform.position.y < pos)
        {
            transform.position = transform.position + new Vector3(0, spd, 0);
        }
    }
}
