using UnityEngine;

public class Player : MonoBehaviour
{
    [SerializeField] private float _speed = 1.0f;
    [SerializeField] private Transform _playerTransform;
    [SerializeField] private GameObject _plantPrefab;
    [SerializeField] private int _numSeeds = 5; 
    [SerializeField] private PlantCountUI _plantCountUI;

    private int _numSeedsLeft;
    private int _numSeedsPlanted;

    private void Start ()
    {
        
    }

    private void Update()
    {
        float movementX = Input.GetAxisRaw("Horizontal");
        float movementY = Input.GetAxisRaw("Vertical");
        
        Vector2 movement = new Vector2(movementX, movementY);

        transform.Translate(movement * _speed * Time.deltaTime);
        
        //sprite movement WASD and/or arrow keys can be used to move the player.
        //planting seed. instantiating SPACE key plants a seed, which: 
        // needs to have amount of seeds
        // Checks to see if the player has any seeds left. If they do, it performs actions 3-5; otherwise, nothing happens.
    }

    public void PlantSeed ()
    {
        //having a plant to call from 
        // Makes a plant appear at the player’s location.
        //
    }
}
