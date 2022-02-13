using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BrickManager : MonoBehaviour
{
    public int rows;
    public int columns;
    public float spacing;
    public GameObject Brick;

    private List<GameObject> bricks = new List<GameObject>();

    // Start is called before the first frame update
    void Start()
    {
        ResetLevel();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void ResetLevel() {
        foreach(GameObject brick in bricks) {
            Destroy(brick);
        }
        bricks.Clear();

        for(int x = 0; x < columns; x++) {
            for(int y = 0; y < rows; y++) {
                Vector2 spawnPosition = (Vector2)transform.position + new Vector2(
                        x * (Brick.transform.localScale.x + spacing),
                        -y * (Brick.transform.localScale.y + spacing)
                    );
                GameObject brick = Instantiate(Brick, spawnPosition, Quaternion.identity);
                bricks.Add(brick);
            }
        }
    }

    public void RemoveBrick(Brick brick) {
        bricks.Remove(brick.gameObject);
        if (bricks.Count == 0) {
            ResetLevel();
        }
    }
}
