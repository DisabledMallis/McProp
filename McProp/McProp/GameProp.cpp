#include "GameProp.h"

GameProp::GameProp(std::string propName, int offset)
{
	this->propName = propName;
	this->offset = offset;
}

std::string GameProp::getName()
{
	return this->propName;
}

int GameProp::getOffset()
{
	return this->offset;
}
