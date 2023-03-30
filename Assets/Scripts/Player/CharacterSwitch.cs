using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterSwitch : MonoBehaviour
{
    [SerializeField]
    private GameObject Mage;
    [SerializeField]
    private GameObject Guerrier;

    public PlayerStats CurrentStats { get; set; }

    //private GameObject 
    // Start is called before the first frame update
    void Start()
    {
        SwitchPlayer(Mage, Guerrier);
        //child1 = transform.Find("Mage");
        //child1.active = true;

        //gameObject.transform.GetChild(1).gameObject.SetActive(true);
    }

    public void SwitchPlayer(GameObject current, GameObject target)
    {
        current.SetActive(false);
        target.SetActive(true);

        CurrentStats = target.GetComponent<PlayerStats>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.O))
        {
            SwitchPlayer(Mage, Guerrier);
        }

        if (Input.GetKeyDown(KeyCode.P))
        {
            SwitchPlayer(Guerrier, Mage);
        }
    }
}
