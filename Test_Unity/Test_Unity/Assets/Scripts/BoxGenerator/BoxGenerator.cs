using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoxGenerator : MonoBehaviour
{
    public float TimeCreateNewCube;
    public float Speed;
    public float Distance;
    public GameObject CubePref;
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(CreateNewCube());
    }
    IEnumerator CreateNewCube()
    {
        while (true)
        {
            CubePref.transform.position = new Vector3(-15,0,0);
            CubePref.GetComponent<Box>().Speed = Speed;
            CubePref.GetComponent<Box>().Distance = Distance;
            Instantiate(CubePref);print("spawn new cube");
            yield return new WaitForSeconds(TimeCreateNewCube);
        }
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
