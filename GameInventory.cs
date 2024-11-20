using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace as18 {
    
public class GameInventory : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
            Inventory i1 = new Inventory();
            i1.AddItem("healing potion");
            i1.AddItem("strength potion");

            Inventory i2 = new Inventory();
            i1.AddItem("Elixir");
            i1.AddItem("Dark Elixir");

            

    }

}
}