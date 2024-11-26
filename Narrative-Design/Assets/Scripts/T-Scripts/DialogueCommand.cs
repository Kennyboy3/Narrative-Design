// using System;
// using UnityEngine;
// using Yarn.Unity;
// public class DialogueCommands : MonoBehaviour
// {
//     void Start()
//     {
//         // Đăng ký lệnh "choice"
//         DialogueRunner dialogueRunner = FindObjectOfType<DialogueRunner>();
//         dialogueRunner.AddCommandHandler("choice", ChoiceCommand);
//     }


//     // Hàm xử lý lệnh "choice"
//     private Coroutine ChoiceCommand(string[] parameters)
//     {
//         Debug.Log("Choice command triggered with parameters: " + string.Join(", ", parameters));
//     }
// }
