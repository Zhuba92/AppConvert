// using System;
// using System.IO;

// namespace AppConvert
// {
//     class FileInput
//     {
//         private StreamReader sr = null;
//         private string fileName;  
        
//         public FileInput(string fileName){
//             this.fileName = fileName;
//             sr = new StreamReader(fileName);
//         }

//         public void fileRead(){
//             string line;
//             while((line = sr.ReadLine()) != null){
//                 Console.WriteLine(line);
//             }
//         }

//         public String fileReadLine() {
//         try {
//             String line = sr.ReadLine();
//             return line;
//         } catch (Exception e) {
//             Console.WriteLine("File Write Error: " + fileName + " " + e);
//             return null;
//         }
//     }

//         public void fileClose() {
//         if (sr != null) {
//             try {
//                 sr.Close();
//             } catch (Exception e) {
//                 Console.WriteLine(e);
//             }
//         }

//     }
//     }
// }