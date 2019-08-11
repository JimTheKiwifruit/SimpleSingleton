using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace JimTheKiwifruit.Singleton {

    public abstract class Singleton<T> : MonoBehaviour where T : MonoBehaviour {

        static T instance;
        public static T Instance {
            get {
                if (!instance)
                    instance = FindObjectOfType<T>();

                if (!instance)
                    instance = new GameObject(typeof(T).Name).AddComponent<T>();

                return instance;
            }
        }

        protected virtual void Awake() {
            var dis = this as T;
            if (instance != null && instance != dis) {
                Destroy(gameObject);
                return;
            }

            instance = dis;
        }

    }

}
