using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class moveCamera : MonoBehaviour
{

    public Chomper player;

    public float height;

    public float bottom;

    public float defaultRotaX;

    public float defaultRotaY;

    private float defaultPosY;

    public float moveCameraBottomPosY;
    public float moveCameraBottomRotaX;
    public float moveCameraBottomPosX;
    
    public float moveCameraTopPosY;
    public float moveCameraTopRotaX;


    private float addToRotaY;
    private float addToRotaX;
    private float addToPosY;
    private float addToPosZ;
    private float addToPosX;

    // Start is called before the first frame update
    void Start()
    {
        defaultPosY = height;
        
    }

    // Update is called once per frame
    void Update()
    {
        float moveInputVertical = Input.GetAxis("SecondVertical");
        float moveInputHorizontal = Input.GetAxis("SecondHorizontal");

        addToRotaY = 0;
        addToRotaX = 0;
        addToPosY = 0;
        addToPosZ = 0;
        addToPosX = 0;
        
        if (moveInputVertical > 0)
        {
            addToRotaX = moveInputVertical * moveCameraTopRotaX;
            addToPosY = moveInputVertical * moveCameraTopPosY;
            addToPosZ = moveInputVertical * -bottom;
        }

        else
        {
            addToPosY = moveInputVertical * moveCameraBottomPosY;
            addToRotaX = moveInputVertical * moveCameraBottomRotaX;
            addToPosX = moveInputVertical * moveCameraBottomPosX;
        }
        
        Vector3 posVector = new Vector3(player.transform.position.x + addToPosX, (player.transform.position.y + height + addToPosY), player.transform.position.z + bottom + addToPosZ);
        transform.position = posVector;
        Vector3 rotaVector = new Vector3(defaultRotaX + addToRotaX, defaultRotaY, transform.rotation.z);
        transform.rotation = Quaternion.Euler(rotaVector);






    }
}
