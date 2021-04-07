using UnityEngine;

public class BlockManager : MonoBehaviour {

    [SerializeField] GameManager gameManager;

    public GameObject fillblock1;
    public GameObject fillblock2;
    public GameObject fillblock3;
    public GameObject fillblock4;
    public GameObject fillblock5;
    public GameObject enemyblock;

    void Update() {
        NewMethod();

        if (!gameManager.enemy1) {

            Destroy(fillblock1.gameObject);
            Destroy(fillblock2.gameObject);
            Destroy(fillblock3.gameObject);
            Destroy(fillblock4.gameObject);
            Destroy(fillblock5.gameObject);
            //Destroy(gameObject);
            //Destroy(enemyblock.gameObject);
        }
    }

    private void NewMethod() {

        if (gameManager.count - 1 >= 0) {
            fillblock1.SetActive(true);
        }
        if (gameManager.count - 2 >= 0) {
            fillblock2.SetActive(true);
        }
        if (gameManager.count - 3 >= 0) {
            fillblock3.SetActive(true);
        }
        if (gameManager.count - 4 >= 0) {
            fillblock4.SetActive(true);
        }
        if (gameManager.count - 5 >= 0) {
            fillblock5.SetActive(true);
        }
    }
}