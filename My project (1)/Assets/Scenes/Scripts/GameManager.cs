using UnityEngine;

public class GameManager : MonoBehaviour
{

    [SerializeField] private Player player;
    [SerializeField] private Enemy enemy;
    [SerializeField] private Character character;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        player.Reporthealth();
        Debug.Log(player.CharName);
        enemy.Reporthealth();
        character.Reporthealth();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
