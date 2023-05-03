using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class letterList
{
    static char[] letters = {'a','a','a','a','a','a','a','a','a','b','b','c','c','c','d','d','d','d','e','e','e','e','e','e','e','e','e','e','e','e',
                 'f','f','g','g','g','h','h','i','i','i','i','i','i','i','i','i','j','k','l','l','l','l','m','m','n','n','n','n','n','n',
                 'o','o','o','o','o','o','o','o','p','p','p','q','r','r','r','r','r','r','s','s','s','s','t','t','t','t','t','t','u','u',
                 'u','u','v','v','w','w','x','y','y','z'};
    
    public static char randomLetter(){
        int randomCharIndex = Random.Range(0,100);
        return letters[randomCharIndex];
    }
}
