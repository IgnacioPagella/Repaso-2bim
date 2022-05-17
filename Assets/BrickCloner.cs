using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BrickCloner : MonoBehaviour
{
    public GameObject brickPrefact;
    public float xOffset;
    public Text userOffset;
    int counter = 0 ;

    // Start is called before the first frame update
    void Start()
    {
     
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void CloneBrick() {
        xOffset = float.Parse(userOffset.text);
        if (counter < 5)
        {
            GameObject clon;
            clon = Instantiate(brickPrefact);
            clon.transform.position = new Vector3 (float.Parse(userOffset.text), 0, 0);
            xOffset += 1.1f;
            counter++;
        }

        

    }
}
