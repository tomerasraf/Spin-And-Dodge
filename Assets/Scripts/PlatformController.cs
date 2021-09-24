using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class PlatformController : MonoBehaviour
{
    public float rotSpeed = 8.0f;
    public Camera cam = null;
    public int _score = 0;
    private Shake shake = null;
    public GameObject effect = null;

    void Awake(){
        shake = GameObject.FindWithTag("ScreenShake").GetComponent<Shake>();
    }
    void Update()
    {
        if (Input.GetMouseButton(0))
        {
            RotateObject();
        }

    }

    void OnCollisionEnter(Collision col){
        if(col.gameObject.CompareTag("Enemy")){
            _score++;
            Instantiate(effect, col.transform.position, Quaternion.identity);
            Destroy(col.gameObject);
            shake.CamShake();
        }
    }

    void RotateObject()
    {
        Vector3 mousePos = Input.mousePosition;

        mousePos.z = cam.transform.position.z - transform.position.y;

        Vector3 mouseWorldPos = cam.ScreenToWorldPoint(mousePos);

        float angle = -Mathf.Atan2
        (transform.position.z - mouseWorldPos.z,
        transform.position.x - mouseWorldPos.x) * Mathf.Rad2Deg;

        transform.rotation = Quaternion.Slerp(transform.rotation,
         Quaternion.Euler(0, angle, 0), rotSpeed * Time.deltaTime);
    }
}
