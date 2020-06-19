using UnityEngine;

public class EndTrigger : MonoBehaviour
{
    public Game_Manager game_Manager;

    private void OnTriggerEnter(Collider other)
    {
        game_Manager.Completelevel();
    }
}
