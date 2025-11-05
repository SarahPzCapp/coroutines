using UnityEngine;
using TMPro;
using System.Collections;
public class scripts : MonoBehaviour



{

    private Coroutine minhacoroutine;

    public TextMeshProUGUI textocontador;

    public GameObject textoMorte;

    public int contador = 10;

    public SpriteRenderer spritePlayer;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        textocontador.text = contador.ToString();

        minhacoroutine = StartCoroutine(DestroyPlayer());

    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.X))
        {
            StopCoroutine(minhacoroutine);
            Debug.Log("Parou!!!");
        }

    }

    void OnMouseDown()
    {

        contador++;
        textocontador.text = contador.ToString();


    }

    IEnumerator DestroyPlayer()
    {

        //yield return new WaitForSeconds(5F);
        //yield return new WaitUntil(() => contador == 15);
        yield return new WaitUntil(() => spritePlayer.color == Color.red);
        Destroy(gameObject);

    }

}
