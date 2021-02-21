using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomChunkPlacer : MonoBehaviour
{
    public Transform Player;
    public Chunk[] ChunkPref;
    public Chunk FirstChunk;

    private List<Chunk> spawnedChunks = new List<Chunk>();
    //Создание и удаление чанков
    void Start()
    {
        spawnedChunks.Add(FirstChunk);
    }
    void Update()
    {
        if (Player.position.x > spawnedChunks[spawnedChunks.Count - 1].End.position.x - 25f)
        {
            SpawnChunk();
        }
    }
    void SpawnChunk()
    {
        Chunk newChunk = Instantiate(ChunkPref[Random.Range(0, ChunkPref.Length)]);
        newChunk.transform.position = spawnedChunks[spawnedChunks.Count - 1].End.position - newChunk.Begin.localPosition;
        spawnedChunks.Add(newChunk);
        if (spawnedChunks.Count > 3)
        {
            Destroy(spawnedChunks[0].gameObject);
            spawnedChunks.RemoveAt(0);
        }
    }
}
