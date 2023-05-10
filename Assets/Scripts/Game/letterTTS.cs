using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class letterTTS : MonoBehaviour
{
    public AudioClip[] letter;
    static AudioClip[] letters;
    public AudioSource click;
    static AudioSource clicks;

    void Start(){
        clicks = click;
        letters = new AudioClip[26];

        for(int i=0; i<26;i++){
            letters[i] = letter[i];
        }
    }

    //Handle TTS for each letter
    
    public static void TTSLetter(string letterText){
        switch (letterText){
                case "A":
                    clicks.PlayOneShot(letters[0]);
                    break;
                case "B":
                    clicks.PlayOneShot(letters[1]);
                    break;
                case "C":
                    clicks.PlayOneShot(letters[2]);
                    break;
                case "D":
                    clicks.PlayOneShot(letters[3]);
                    break;
                case "E":
                    clicks.PlayOneShot(letters[4]);
                    break;
                case "F":
                    clicks.PlayOneShot(letters[5]);
                    break;
                case "G":
                    clicks.PlayOneShot(letters[6]);
                    break;
                case "H":
                    clicks.PlayOneShot(letters[7]);
                    break;
                case "I":
                    clicks.PlayOneShot(letters[8]);
                    break;
                case "J":
                    clicks.PlayOneShot(letters[9]);
                    break;
                case "K":
                    clicks.PlayOneShot(letters[10]);
                    break;
                case "L":
                    clicks.PlayOneShot(letters[11]);
                    break;
                case "M":
                    clicks.PlayOneShot(letters[12]);
                    break;
                case "N":
                    clicks.PlayOneShot(letters[13]);
                    break;
                case "O":
                    clicks.PlayOneShot(letters[14]);
                    break;
                case "P":
                    clicks.PlayOneShot(letters[15]);
                    break;
                case "Q":
                    clicks.PlayOneShot(letters[16]);
                    break;
                case "R":
                    clicks.PlayOneShot(letters[17]);
                    break;
                case "S":
                    clicks.PlayOneShot(letters[18]);
                    break;
                case "T":
                    clicks.PlayOneShot(letters[19]);
                    break;
                case "U":
                    clicks.PlayOneShot(letters[20]);
                    break;
                case "V":
                    clicks.PlayOneShot(letters[21]);
                    break;
                case "W":
                    clicks.PlayOneShot(letters[22]);
                    break;
                case "X":
                    clicks.PlayOneShot(letters[23]);
                    break;
                case "Y":
                    clicks.PlayOneShot(letters[24]);
                    break;
                case "Z":
                    clicks.PlayOneShot(letters[25]);
                    break;
                default:
                    break;
            }
        }
        }
