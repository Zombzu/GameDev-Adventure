using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ObjectInteract : MonoBehaviour {

   
    public Text caption;
    public string captionText;

    public string[] Objs = new string[13];
    public int ObjSelector, ObjIndex;
    public string ObjSelected;

    // Use this for initialization
    public void Start()
    {
        caption.text = "";


        //le array
        Objs[0] = "code";
        Objs[1] = "code";
        Objs[2] = "code";
        Objs[3] = "code";
        Objs[4] = "code";
        Objs[5] = "coffee";
        Objs[6] = "drink";
        Objs[7] = "drink";
        Objs[8] = "nothing";
        Objs[9] = "nothing";
        Objs[10] = "nada";
        Objs[11] = "zilch";
        Objs[12] = "rubber duck";

        ObjSelector = Random.Range(0, 12); //selects 1 random obj
        ObjIndex = ObjSelector + 1; //this is the index of the obj
        ObjSelected = Objs[ObjSelector]; //this is the obj that was randomised
    }
        public void PointerEnter()
    {
        caption.text = captionText;
    }

    public void PointerExit()
    {
        caption.text = "";
   
    }

    public void checkContent()
    {

    }
  
	
}
