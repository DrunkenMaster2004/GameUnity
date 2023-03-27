using UnityEngine;

public class bg3 : MonoBehaviour
{
    public float spd = 0.1f;
    private float os;
    private Material layer;
    // Start is called before the first frame update
    void Start()
    {
        layer = GetComponent<Renderer>().material;
    }

    // Update is called once per frame
    void Update()
    {
        if ((int)Input.GetAxis("Horizontal") != 0){
            int s = -1;
            if(Input.GetKey(KeyCode.RightArrow)) s=1;
                os+=s*(Time.deltaTime*spd)/10f;
                layer.SetTextureOffset("_MainTex", new Vector2(os, 0));
                // Debug.Log();
        }
    }
}
