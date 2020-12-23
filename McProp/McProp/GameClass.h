#pragma once
#include <vector>
#include "GameProp.h"
class GameClass
{
	std::vector<GameProp*>* classProperties;
	std::string className;
public:
	GameClass(std::string className);
	void addProperty(GameProp* theProp);
};

