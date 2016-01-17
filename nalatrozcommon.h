#pragma once
#include <string>
#include <fstream>
#include <iostream>
#include "witcher3-enums.h"

enum FreeCam { on = 1, off };

class CustomBinding
{
public:
	CustomBinding();
	~CustomBinding();

	bool loadSettings(std::string fName);
	FreeCam fCam;
	EInputKey cBind;
};


