using UnityEngine;

public class RedCube : MonoBehaviour
{
    [SerializeField] GameObject gameManager;

    private void OnCollisionEnter(Collision2D collision)
    {
        if (collision.transform.tag == "Apple")
        {
            gameManager.GetComponent<GameManager>().increaseApple();
        }
    }

    private void OnCollisionExit(Collision collision)
    {
        if (collision.transform.tag == "Apple")
        {
            gameManager.GetComponent<GameManager>().decreaseApple();
        }
    }
}
