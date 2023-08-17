using UnityEngine;
using System.Collections;
using UnityEditor.SearchService;
//this script can be found in the Component section under the option Intro RPG/Player/Interact
[AddComponentMenu("Game Systems/Player/Interact")]
public class Interact : MonoBehaviour
{
    #region Update   
    void Update()
    {
        //if our interact key is pressed
        if (Input.GetKeyDown(KeyCode.E))
        {
            //create a ray
            Ray interactRay;
            //this ray is shooting out from the main cameras screen point center of screen
            interactRay = Camera.main.ScreenPointToRay(new Vector2(Screen.width / 2, Screen.height / 2));
            //create hit info
            RaycastHit hitInfo;
            //if this physics raycast hits something within 10 units
            if (Physics.Raycast(interactRay, out hitInfo, 10))
            {
                #region NPC tag
                //and that hits info is tagged NPC
                if (hitInfo.collider.tag == "NPC")
                {
                    Debug.Log("HIT NPC");
                    //Debug that we hit a NPC 
                    if(hitInfo.collider.GetComponent<Dialogue>())
                    {
                        hitInfo.collider.GetComponent<Dialogue>().OpenDialogue();
                    }
                }
                #endregion
                #region Item
                //and that hits info is tagged Item
                if (hitInfo.collider.tag == "Item")
                {
                    Debug.Log("HIT Item");
                    //Debug that we hit a Item 
                }
                #endregion
                #region Chest
                //and that hits info is tagged Chest
                if (hitInfo.collider.tag == "Chest")
                {
                    Debug.Log("HIT Chest");
                    //Debug that we hit a Chest 
                }
                #endregion
            }
        }
    }

    #endregion
}






