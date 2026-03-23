using UnityEngine;

public class GlowTrigger : MonoBehaviour
{
    public Material playerGlowMaterial;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            playerGlowMaterial.SetFloat("_GlowToggle", 1f);
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            playerGlowMaterial.SetFloat("_GlowToggle", 0f);
        }
    }
}
