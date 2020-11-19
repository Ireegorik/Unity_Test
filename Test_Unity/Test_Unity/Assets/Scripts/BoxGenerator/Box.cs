using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Box : MonoBehaviour
{
    public float Distance;
    public float Speed;
    IEnumerator boxMoving(float Distance)
    {
        Vector3 startPosition = gameObject.transform.position;
        Vector3 endPosition = new Vector3(startPosition.x + Distance, startPosition.y, startPosition.z);
        while (gameObject.transform.position.x < endPosition.x)
        {
            yield return new WaitForEndOfFrame();
            transform.Translate(Vector3.right*Speed);
        }
        Destroy(gameObject);
        
    }
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(boxMoving(Distance));
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
