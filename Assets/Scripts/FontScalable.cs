using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[ExecuteInEditMode]
public class FontScalable : MonoBehaviour
{

    [Range(1, 6)]
    public float fontScale = 1;
    TextMesh textMesh;

    // Start is called before the first frame update
    void Start()
    {
        textMesh = GetComponent<TextMesh>();        
    }

    // Update is called once per frame
    void Update()
    {
        Vector2 defaultScale = new Vector2(1, 1) * fontScale;
        int fontSize = textMesh.fontSize;
        fontSize = fontSize == 0 ? 12 : fontSize;

        float scale = 0.1f * 128 / fontSize;
        transform.localScale = defaultScale * scale;
    }
}
