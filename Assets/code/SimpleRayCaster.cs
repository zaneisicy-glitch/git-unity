using UnityEngine;

public class SimpleRayCaster : MonoBehaviour
{

    // Update is called once per frame
    void Update()
    { 
        if (Input.GetMouseButtonDown(0))
        {
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            RaycastHit hit;
            if (Physics.Raycast(ray, out hit)) 
            {
                Debug.Log("hit:" + hit.collider.gameObject.name);
            }
            else
            {
                Debug.Log("Nothing hit");
            }
        }  
    }
}
