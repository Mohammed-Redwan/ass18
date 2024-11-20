using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace as18 {
    public class GameContainer<T> 
    {
        private T item;

        public T Item {
            get {
                return this.item;
            }
            set {
                this.item = value;
            }
        }
    }
}