using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMeleeAttack : MonoBehaviour
{
    [SerializeField]
    private GameObject _swordZonePrefab;
    private float cooldown;
    private float cooldownInitialValue = 0.4f;

    public AudioClip sound;

    public AudioClip sound;

    // Start is called before the first frame update
    void Start()
    {
        cooldown = cooldownInitialValue;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.L) && cooldown <= 0) // droite
        {
            AudioManager.instance.PlayClipAt(sound,transform.position);
            Debug.Log("atk droite");
            Instantiate(_swordZonePrefab, gameObject.transform);
            _swordZonePrefab.transform.position = new Vector2(1,0);
            cooldown = cooldownInitialValue;
        }
        if (Input.GetKeyDown(KeyCode.J) && cooldown <= 0) // gauche
        {
            AudioManager.instance.PlayClipAt(sound, transform.position);
            Debug.Log("atk gauche");
            Instantiate(_swordZonePrefab, gameObject.transform);
            _swordZonePrefab.transform.position = new Vector2(-1, 0);
            cooldown = cooldownInitialValue;
        }
        if (Input.GetKeyDown(KeyCode.I) && cooldown <= 0) // haut
        {
            AudioManager.instance.PlayClipAt(sound, transform.position);
            Debug.Log("atk haut");
            Instantiate(_swordZonePrefab, gameObject.transform);
            _swordZonePrefab.transform.position = new Vector2(0, 1);
            cooldown = cooldownInitialValue;
        }
        if (Input.GetKeyDown(KeyCode.K) && cooldown <= 0) // bas
        {
            AudioManager.instance.PlayClipAt(sound, transform.position);
            Debug.Log("atk bas");
            Instantiate(_swordZonePrefab, gameObject.transform);
            _swordZonePrefab.transform.position = new Vector2(0, -1);
            cooldown = cooldownInitialValue;
        }

        cooldown -= Time.deltaTime;
    }
}
