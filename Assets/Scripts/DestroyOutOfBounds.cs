using UnityEngine;
using UnityEngine.SceneManagement;

public class DestroyOutOfBounds : MonoBehaviour
{
    private float topBound = 30;
    private float lowerBound = -10;

    void Update()
    {
        // If an animal gets past the players veiw, Remove the animal
        if(transform.position.z > topBound)
        {
            Destroy(gameObject);
        }
        else if(transform.position.z < lowerBound)
        {
            // if an animal gets past the players veiw, Game over screen apears
            SceneManager.LoadScene("GameOver");
            Destroy(gameObject);
            GameObject.FindWithTag("Player").GetComponent<PlayerController>().enabled = false;


        }
    }
}
