#pragma once
#include <string>
#include <fstream>
#include <iostream>
#include "witcher3-enums.h"

enum FreeCam { fCamOn = 1, fCamOff };
enum DebugConsole {dConsoleOff = 0, dConsoleOn};

class CustomBinding
{
public:
	CustomBinding();
	~CustomBinding();

	bool loadSettings(std::string fName);

	FreeCam fCam;
	DebugConsole dConsole;
	EInputKey cBind;
};


