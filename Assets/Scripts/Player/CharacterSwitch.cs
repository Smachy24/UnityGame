using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterSwitch : MonoBehaviour
{
    [SerializeField]
    private GameObject Mage;
    [SerializeField]
    private GameObject Guerrier;

    //private GameObject 
    // Start is called before the first frame update
    void Start()
    {
        Guerrier.SetActive(true);
        //child1 = transform.Find("Mage");
        //child1.active = true;

        //gameObject.transform.GetChild(1).gameObject.SetActive(true);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.O))
        {

            Guerrier.SetActive(false);
            Mage.SetActive(true);
        }

        if (Input.GetKeyDown(KeyCode.P))
        {
            Mage.SetActive(false);
            Guerrier.SetActive(true);
        }
    }
}
