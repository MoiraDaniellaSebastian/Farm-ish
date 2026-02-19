using UnityEngine;

public class TreeCuttable : ToolHit
{
    [SerializeField] GameObject pickupDrop;
    [SerializeField] int dropCount = 5;
    [SerializeField] float spread = 0.7f;


    public override void Hit()
    {

        while (dropCount > 0)
        {

            dropCount -= 1;
            Vector3 position = transform.position;
            position.x += spread * UnityEngine.Random.value - spread / 2;
            position.y += spread * UnityEngine.Random.value - spread / 2;

            GameObject go = Instantiate(pickupDrop);
            go.transform.position = position;  
        }

        // Destroy the original tree
        Destroy(gameObject);
    }
}