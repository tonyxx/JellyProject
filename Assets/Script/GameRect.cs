using UnityEngine;
using System.Collections;

public class GameRect : BaseBrick {

   
	// 位置数组
    Vector3[,] posArr;

	// 所有位置点的根节点 
	GameObject posRoot;

	void Start ()
	{
        // 所有位置根节点 
        posRoot = GameObject.Find("POSRoot") as GameObject;


		// 生成所有位置
        posArr = SetEmitterPos();
        Debug.Log("COUNT -> " + posArr.Length);

	}



	// 生成位置 (横排 10 位置)
	Vector3[,] SetEmitterPos()
	{
        Vector3[,] arr = new Vector3[20,10];

        int posCount = 10;
        float length = posRoot.transform.localScale.x / posCount;
        Vector3 startPos = new Vector3(this.BottomL.x + length/2, this.BottomL.y + length/2, this.BottomL.z);

        for(int n=0; n<posCount*2; n++)
        {
            for(int i=0; i<posCount; i++)
            {
                float offsetX = length * i;
                float offsetY = length * n;
                float s = 0.39f;

                GameObject obj = GameObject.CreatePrimitive(PrimitiveType.Cube);
                obj.transform.localScale = new Vector3(s,s,s);
                obj.transform.localPosition = new Vector3(startPos.x + offsetX, startPos.y + offsetY, startPos.z);

                arr[n, i] = obj.transform.localPosition;
            }
        }

		return arr;
	}






}
