#pragma once
#include <string>
class GameProp
{
	std::string propName;
	int offset;
public:
	GameProp(std::string propName, int offset);
	std::string getName();
	int getOffset();
};

