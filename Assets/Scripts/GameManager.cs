using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    private int apple;
    private int banana;
    [SerializeField] GameObject congratsScreen;
    [SerializeField] List<GameObject> gameObjects;

    private void Start()
    {
        apple = 0;
        banana = 0;
    }

    public void increaseApple()
    {
        apple++;
    }

    public void decreaseApple()
    {
        apple--;
    }

    public void increaseBanana()
    {
        banana++;
    }

    public void decreaseBanana()
    {
        banana--;
    }

    private void Update()
    {
        if (apple == 16 && banana == 16)
        {
            congratsScreen.SetActive(true);
            foreach(GameObject i in gameObjects)
            {
                i.SetActive(false);
            }
        }
    }
}
