#pragma once
#include "memTypes.h"
#include <string>
#include <Windows.h>
#include <TlHelp32.h>
#include <iostream>

class Process
{
	HANDLE procHandle;
	std::string procName;
public:
	Process(std::string procName);
	bool isValid();
	void readMem(ulong address, char* readBuffer, int size);
	ulong sigScan(std::string signature);
};

