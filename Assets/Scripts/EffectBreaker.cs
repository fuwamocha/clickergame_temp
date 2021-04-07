using UnityEngine;

public class EffectBreaker : MonoBehaviour
{
    void Start() {

        //エフェクト生成から2秒後にオブジェクト削除
        Invoke(nameof(BreakEffect), 0.3f);
    }

    //自分自身を削除
    void BreakEffect() {

        Destroy(gameObject);
    }
}
