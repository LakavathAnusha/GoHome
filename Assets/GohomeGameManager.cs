using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GohomeGameManager : MonoBehaviour
{
    public int initialPosition;
    [SerializeField]
    private int homeposition;
    private int distance;
    // Start is called before the first frame update
    void Start()
    {
        print("Hello welcome To My Game GoHome");
        print("Instructions how to play the game");
        print("Press up-arrow to move to forward /n Press down-arrow to move backword");
        print("my start position is " + initialPosition);
        print("My home postion" + homeposition);
        distance = homeposition - initialPosition;
        if (distance > 0)
            print("To move to forword");
        else if (distance < 0)
            print("To move backword");
        else if (distance == 0)
            print("You reached the home");
    }

    // Update is called once per frame
    void Update()
    {
     if(Input.GetKeyDown(KeyCode.UpArrow))
        {
            // arrow is pressed;
            initialPosition++;
            distance = homeposition - initialPosition;
            print("distance to home is" + distance);
            if (distance == 0)
                print("you reached home");

        }
        if (Input.GetKeyDown(KeyCode.DownArrow))
        {
            // arrow is pressed;
            initialPosition--;
            distance = homeposition - initialPosition;
            print("distance to home is" + distance);
            if (distance == 0)
                print("you reached home");

        }
    }
}
