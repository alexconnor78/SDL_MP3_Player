using SDL2;
using System;
using System.IO.Enumeration;

namespace sdl_mp3_player;
public class Program 
{


static void Main(string[] args) {
   string filename = @"C:\Music\test.mp3";
   
   using (System.IO.StreamWriter writer = new System.IO.StreamWriter(filename,true)) {
    using (FileStream fs = File.OpenRead(filename)) 
    {
        byte[] b = new byte[50];

        while (fs.Read(b,0,b.Length) > 0) 
        {
            writer.WriteLine(BitConverter.ToString(b).Replace("-", " "));
        }
    }
   }
}
}
   

