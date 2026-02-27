using UnityEngine;

public class MoveLeft : MonoBehaviour
{
    public float speed = 10f;
    private PlayerController player;


    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        GameObject go = GameObject.Find("Player");
        player = go.GetComponent<PlayerController>();
    }

    // Update is called once per frame
    void Update()
    {

        if (!player.isGameOver)
        {
          transform.Translate(Vector3.left *speed  *Time.deltaTime );
        }
        /*GameObject go = GameObject.Find("Player");
        PlayerController player = go.GetComponent<PlayerController>();
        if (player.isGameOver == false)
        {
          transform.Translate(speed * Time.deltaTime * Vector3.left);
        }*/

            
           
    }
}
