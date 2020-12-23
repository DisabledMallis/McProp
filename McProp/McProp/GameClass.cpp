#include "GameClass.h"

GameClass::GameClass(std::string className)
{
	this->className = className;
	this->classProperties = new std::vector<GameProp*>();
}

void GameClass::addProperty(GameProp* theProp)
{
	this->classProperties->push_back(theProp);
}