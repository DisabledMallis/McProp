#include "Main.h"

Process* process;
HANDLE hProcess;
void Main::main() {
    process = new Process("Minecraft.Windows.exe");
    if (!process->isValid()) {
        MessageBoxA(NULL, "No Minecraft process was found, and as a result, McProp could not load.", "Failed to find process!", MB_OK);
        exit(0);
    }
    process->sigScan("89 ?? ?? ?? ?? 54 ?? ?? 53 55 56 57 41 ?? 48 81");
}

Process* Main::getProcess()
{
    return process;
}
