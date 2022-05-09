using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ButtonMenuScript : MonoBehaviour
{
    public GameObject main;
    public GameObject atk;
    public GameObject item;

    public GameObject Bullet;
    // Main Buttons
    public void AttackButton()
    {
        atk.SetActive(true);
    }

    public void ItemButton()
    {
        item.SetActive(true);
    }

    public void InfoButton()
    {

    }

    public void TeamButton()
    {

    }

    public void ForfeitButton()
    {

    }

    // Attack Buttons
    public void AtkReturn()
    {
        atk.SetActive(false);
    }

    public void Atk1()
    {
        GameObject bulletInstance = Instantiate(Bullet/*, new Vector3(0,0,0), new Quaternion(0,0,0,0)*/);
        bulletInstance.transform.SetParent(GameObject.Find("Canvas").transform,true);
		bulletInstance.transform.position = (GameObject.Find("Canvas").transform.position) + new Vector3(-100,-50,0);
		
    }

    public void Atk2()
    {

    }

    public void Atk3()
    {

    }

    public void Atk4()
    {

    }

    // Item Buttons
    public void ItemReturn()
    {
        item.SetActive(false);
    }

    public void Item1()
    {

    }

    public void Item2()
    {

    }

    public void Item3()
    {

    }

    public void Item4()
    {

    }
}
