using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Tree : MonoBehaviour
{
    [SerializeField]private GameObject fruit;
    [SerializeField]private List<Transform> fruitspawn;
    [SerializeField] private float spawnTime=5.0f;

    struct FruitList
    {
        public Vector3 fruitSpawn;
        public GameObject Listfruit;
    }
    private List<FruitList> fruits;
    float timer;



    private void Awake()
    {
        fruits = new List<FruitList>();
    }
    void Start()
    {
        for (int i = 0; i < fruitspawn.Count; i++)
        {
            FruitList temp;
            temp.fruitSpawn = fruitspawn[i].position;
            temp.Listfruit = null;
          
            fruits.Add(temp);
        }
    }

    // Update is called once per frame
    void Update()
    {
        timer += Time.deltaTime;

        if (timer > spawnTime)
        {
            
            for (int i = 0; i < fruits.Count; i++)
            {
             
                    if (fruits[i].Listfruit == null)
                    {
                        GameObject temp = Instantiate(fruit, fruits[i].fruitSpawn, new Quaternion(0, 0, 0, 0));
                        fruits.Remove(fruits[i]);

                        FruitList Fr;
                        Fr.fruitSpawn = fruitspawn[i].position;
                        Fr.Listfruit = temp;
                        fruits.Add(Fr);


                        break;
                    }
                
            

            }
            timer = 0.0f;
        }

        if (timer > spawnTime) 
        {
     
            timer = 0.0f;
        }
    }
       

}
