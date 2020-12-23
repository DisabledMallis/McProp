#include "Process.h"

Process::Process(std::string procName) {
    this->procHandle = NULL;
    this->procName = procName;

    PROCESSENTRY32 entry;
    entry.dwSize = sizeof(PROCESSENTRY32);
    HANDLE snapshot = CreateToolhelp32Snapshot(TH32CS_SNAPPROCESS, NULL);
    std::wstring procNameWStr = std::wstring(procName.begin(), procName.end());
    const wchar_t* procNameW = procNameWStr.c_str();

    if (Process32First(snapshot, &entry) == TRUE)
    {
        while (Process32Next(snapshot, &entry) == TRUE)
        {
            if (lstrcmpW(entry.szExeFile, procNameW) == 0)
            {
                this->procHandle = OpenProcess(PROCESS_ALL_ACCESS, FALSE, entry.th32ProcessID);
            }
        }
    }
}

bool Process::isValid()
{
    if (this->procHandle == NULL) {
        return false;
    }
    return true;
}

void Process::readMem(ulong address, char* readBuffer, int size)
{
    ReadProcessMemory(this->procHandle, (void*)address, readBuffer, size, nullptr);
}

ulong Process::sigScan(std::string signature) {
    return result;
}