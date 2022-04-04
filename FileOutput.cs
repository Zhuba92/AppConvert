// using System;
// using System.IO;

// namespace AppConvert
// {
//     class FileOutput
//     {
//         StreamWriter sw = null;
//         private string fileName;

//         public FileOutput(string fileName){
//             this.fileName = fileName;
//             try{
//                 sw = new StreamWriter(fileName);
//             } catch(Exception e){
//                 Console.WriteLine("File Open Error: " + fileName + " " + e);
//             }
//         }

//         public void fileWrite(string line){
//             try{
//                 sw.Write(line + "\n");
//             } catch(Exception e){
//                 Console.WriteLine("File Write Error: " + fileName + " " + e);
//             }
//         }

//         public void fileClose() {
//             if (sw != null) {
//                 try {
//                     sw.Close();
//                 } catch (IOException e) {
//                     Console.WriteLine(e.GetBaseException());
//                 }
//             }
//         }
//     }
// }
