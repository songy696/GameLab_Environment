using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Demo : MonoBehaviour
{
    public Text outPut;
    public GameObject prefab;
    public int[] numbers;

    // Start is called before the first frame update
    void Start()
    {
        //int a = 1;
        //print(a);
        //a++;

        //string a = "hi";
        ////string b = " there";
        //int b = 5;
        //a += b;

        //float a = 1;
        //float b = 2;
        //a = a / b;
        //int c = (int)Mathf.Ceil(a);
        //Mathf.Round = round the number
        //Mathf.Ceil and Mathf.Floor - also for the calculation

        //bool a = true;
        //a = !(!a != false);
        //outPut.text = a.ToString();
        // == means equavelecy/checking

        //int a = 1;

        //if(a == 1){
        //    outPut.text = "less than 1";
        //}else if(a<2){
        //    outPut.text = "just 1";
        //}else {
        //    outPut.text = "higher than 1";
        //}



        //StartCoroutine(MakeBlocks());


        //outPut.text = numbers[4].ToString();

        //int[] numbers = new int[] { 11, 2, 45, 7 };

        //for (int i = numbers.Length - 1; i >- 1; i--){
        //    outPut.text += numbers[i].ToString() + "\n";
        //}

        //GameObject[] box = GameObject.FindGameObjectsWithTag("box");
        //for (int i = 0; i < box.Length; i++){
        //    Destroy(box[i]);
        //}

        GameObject[] box = GameObject.FindGameObjectsWithTag("box");
        foreach(GameObject boxes in box){
            Destroy(boxes);
        }
    }

    //IEnumerator MakeBlocks(){
    //    for (int i = 0; i < 20; i++)
    //    {
    //        for (int j = 0; j < 10; j++)
    //        {
    //            Vector3 pos = new Vector3(Random.Range(-10, 10), Random.Range(-10, 10), Random.Range(-10, 10));
    //            Instantiate(prefab, pos, Quaternion.identity);
    //        }
    //        yield return null;
    //    }
    //}

    // Update is called once per frame
    void Update()
    {
        
    }
}
