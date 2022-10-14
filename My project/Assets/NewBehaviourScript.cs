using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        string heroName = "Captain Justice";
        float heroHeight = 2.0f;
        int heroAge = 18;
        string heroSuperPower = "UnbreakableBones";
        string villainName = "Kraken";
        float villainHeight = 3.0f;
        int villainAge = 25;
        string villainSuperPower = "DarkPower";
        print(heroName);
        print(heroHeight);
        print(heroAge);
        print(heroSuperPower);
        print(villainName);
        print(villainHeight);
        print(villainAge);
        print(villainSuperPower);
        print(villainHeight +5);
        string villainSuperPowerChange = villainSuperPower + "None";
        print(villainSuperPowerChange);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
