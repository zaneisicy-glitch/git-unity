using UnityEngine;

public class ClickSpawn : MonoBehaviour
{
    [SerializeField] private GameObject prefabToSpawn;
    [SerializeField] private float spawnOffset = 0.1f;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
          Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            RaycastHit hit;

            if (Physics.Raycast(ray, out hit))
            {
                Vector3 spawnPoint = hit.point + hit.normal * spawnOffset;
                GameObject spawnedObject = Instantiate(prefabToSpawn, spawnPoint, Quaternion.identity);
                Destroy(spawnedObject, 0.3f);
                Debug.Log("Spawned prefab at: " + spawnPoint);
            }
        }
    }
}
