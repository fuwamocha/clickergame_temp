using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EffectBreaker : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        //エフェクト生成から2秒後にオブジェクト削除
        Invoke("BreakEffect", 0.3f);
    }

    //自分自身を削除
    void BreakEffect()
    {
        Destroy(gameObject);
    }
}
