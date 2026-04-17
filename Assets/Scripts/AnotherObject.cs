using UnityEngine;

public class AnotherObject : MonoBehaviour
{
    private void Start()
    {
        Debug.Log(GameSetting.volume);
        GameSetting.volume = 50;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.A))
        {
            PersistentObject.staticPublicDebugText = "A was pressed";
        }
        else if (Input.GetKeyDown(KeyCode.B))
        {
            Debug.Log(PersistentObject.staticPublicDebugText);
        }
        else if (Input.GetKeyDown(KeyCode.C))
        {
            PersistentObject.SetStaticPrivateText("C was pressed");
        }
        else if (Input.GetKeyDown(KeyCode.D))
        {
            var go = GameObject.Find("PersistentObject");
            var p = go.GetComponent<PersistentObject>();
            p.SetInstancePrivateText("D was pressed");
        }
        else if (Input.GetKeyDown(KeyCode.E))
        {
            PersistentObject.GetInstance().SetInstancePrivateText("E was pressed");
            PersistentObject.GetInstance().gameObject.name = "Biggus";
        }
    }
}
