using UnityEngine;

public class GameManager : MonoBehaviour {

    //enemy格納
    public GameObject enemy1;
    public GameObject enemy2;
    //player格納
    public GameObject player;
    //クリック回数（戦闘力？）
    public int count = 0;
    //テキスト表示
    [SerializeField] GameObject gameClearText;
    //SE
    [SerializeField] AudioClip clickSE;
    [SerializeField] AudioClip clearSE;
    AudioSource audioSource;
    // クリア判定の変数
    public int enemy_count = 0;

    void Start() { 

        //敵の総数
        enemy_count = 2;
        audioSource = GetComponent<AudioSource>();
    }

    // 敵の数が0になったときにクリアメッセージ表示
    public void GameClear() {

        //gameClearText.SetActive(true);
        //audioSource.Stop();
        //audioSource.PlayOneShot(clearSE);
        Debug.Log("ゲームクリア！");
    }
}

   