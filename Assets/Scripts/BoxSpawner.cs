using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoxSpawner : MonoBehaviour
{
    public Rigidbody2D boxTemplates;
    private float boxTemplateHeight = 7f;
    private float boxTemplateWidth = 15f;

    private List<GameObject> spawnedBox;

    private void Start()
    {
        spawnedBox = new List<GameObject>(0);

        //GenerateBox
        int boxCount = Random.Range(10, 30);
        for (int i = 0; i <= boxCount; i++)
        {
            float posX = Random.Range(-7.5f, 7.5f);
            float posY = Random.Range(-3.5f, 3.5f);
            SpawnBox(posX, posY);
        }
    }

    private void SpawnBox(float posX, float posY)
    {
        GameObject newBox = Instantiate(boxTemplates.gameObject, transform);
        newBox.transform.position = new Vector2(posX, posY);
        spawnedBox.Add(newBox);
    }

    private void OnDrawGizmos()
    {
        Debug.DrawLine(transform.position + new Vector3(7.5f, boxTemplateHeight / 2, 0), transform.position + new Vector3(7.5f, -boxTemplateHeight / 2, 0), Color.green);
        Debug.DrawLine(transform.position + new Vector3(-7.5f, boxTemplateHeight / 2, 0), transform.position + new Vector3(-7.5f, -boxTemplateHeight / 2, 0), Color.green);
        Debug.DrawLine(transform.position + new Vector3(boxTemplateWidth / 2, 3.5f), transform.position + new Vector3(-boxTemplateWidth / 2, 3.5f), Color.green);
        Debug.DrawLine(transform.position + new Vector3(boxTemplateWidth / 2, -3.5f), transform.position + new Vector3(-boxTemplateWidth / 2, -3.5f), Color.green);
    }
}
