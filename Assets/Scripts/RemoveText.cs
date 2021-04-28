using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RemoveText : MonoBehaviour
{
    public GameObject IntroText;
    public bool TextOn = true;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    public void Update()
    {
        if (Input.GetKeyDown(KeyCode.F)){
            Destroy(IntroText);
            TextOn = false;
        }
        else if (InventoryEx.explanationOn == true && TextOn == true){
            Destroy(IntroText);
            TextOn = false;
        }
    }
}
