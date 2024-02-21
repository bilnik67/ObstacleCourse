using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFadeBehavior : MonoBehaviour
{
    private ObjectFader _fader;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        GameObject player = GameObject.FindGameObjectWithTag("Player");

        if (player != null)
        {
            Vector3 dir = player.transform.position - transform.position;
            Ray ray = new Ray(transform.position, dir);
            RaycastHit hit;
            if (Physics.Raycast(ray, out hit))
            {
                if(hit.collider == null)
                {
                    return;
                }
                if (hit.collider.gameObject == player)
                {
                    //Nothing is in front of player
                    if (_fader != null)
                    {
                        _fader.isFading = false;
                    }
                }
                else
                {
                    _fader = hit.collider.gameObject.GetComponent<ObjectFader>();
                    if (_fader != null)
                    {
                        _fader.isFading = true;
                    }
                }
            }
        }
    }
}
