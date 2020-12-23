using Memory;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace McProp
{
    class CInstHook
    {
        public static ulong getClientInstance()
        {
            Mem memLib = Program.getMem();

            long result = memLib.AoBScan("?? 89 ?? ?? ?? ?? 54 ?? ?? 53 55 56 57 41 ?? 48 81", false, true).Result.FirstOrDefault();

            Console.WriteLine(result.ToString("X"));

            ulong codecave = (ulong)memLib.CreateCodeCave(result.ToString("X"), new byte[] { 0x48, 0x89, 0x0D, 0x0C, 0x00, 0x00, 0x00, 0x83, 0x2D, 0x05, 0x00, 0x00, 0x00, 0x70, 0xE9, 0x10, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x44, 0x89, 0x44, 0x24, 0x18, 0x89, 0x54, 0x24, 0x10, 0x53, 0x55, 0x56, 0x57, 0x41, 0x56 }, 15);

            if(codecave == 0)
            {
                MessageBox.Show("Failed to allocate for hook!");
                return 0;
            }

            Thread.Sleep(2000);

            ulong clientInstancePtrPtr = codecave+0x13;
            Console.WriteLine("ClientInstance**: "+clientInstancePtrPtr.ToString("X"));
            ulong clientInstancePtr = (ulong)memLib.ReadLong(clientInstancePtrPtr.ToString("X"));
            Console.WriteLine("Client Instance*: " + clientInstancePtr.ToString("X"));

            memLib.WriteBytes(result.ToString("X"), new byte[] { 0x44, 0x89, 0x44, 0x24, 0x18, 0x89, 0x54, 0x24, 0x10, 0x53, 0x55, 0x56, 0x57, 0x41, 0x56 });

            return clientInstancePtr;
        }
    }
}
