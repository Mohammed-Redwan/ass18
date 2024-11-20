using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace as18
{
    public class Inventory
    {
        public List<string> names;
        
        public void AddItem(string item) {
            this.names.Add(item);
        }
        public void ShowItems() {
            for(int i = 0; i < this.names.Count; i++) {
                Debug.Log(this.names[i]);
            }
        }
        // to combine tow inventories names  they must have the same size to combine correctly 
        public static List<string> operator + (Inventory i1, Inventory i2) {
            
            List<string> combinationList = new List<string>();
            combinationList.AddRange(i1.names);
            combinationList.AddRange(i2.names);
            for(int i = 0; i < combinationList.Count; i++) {
                Debug.Log(combinationList[i]);
            }
            return combinationList;
        }
            
    }
}
