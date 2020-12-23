using McProp.Objects;
using Memory;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace McProp
{
    class Program
    {
        private static Mem memLib;
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the Minecraft: Bedrock Edition property editor, made by ASM#5667. Jirachi Gang");
            Console.WriteLine("Targeting version 1.16.201");
            Console.WriteLine("Loading...");
            memLib = new Mem();
            if (!memLib.OpenProcess("Minecraft.Windows"))
            {
                MessageBox.Show("Failed to open Minecraft");
                return;
            }
            Console.WriteLine("Searching for ClientInstance...");
            ulong ciPtr = CInstHook.getClientInstance();
            Console.WriteLine("Search complete");

            Console.WriteLine("Creating Explorer...");
            Explorer explorer = new Explorer(ciPtr);
            explorer.populate();

            Application.Run(explorer);
        }

        public static Mem getMem()
        {
            return memLib;
        }
    }
}
