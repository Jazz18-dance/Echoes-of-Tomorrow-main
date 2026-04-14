using UnityEngine;

public class Interaction : MonoBehaviour
{
    // This method is called when another collider enters the object's collider
    void OnTriggerEnter(Collider other)
    {
        // Check if the object is interactable and the collider belongs to the player
        if (isInteractable && other.CompareTag("Player"))
        {
            Interact();
        }
    }

    void Interact()
    {
        // Implement interaction logic here
        Debug.Log("Interacting with " + gameObject.name);
    }

}
