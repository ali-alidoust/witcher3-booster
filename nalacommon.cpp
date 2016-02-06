#include "nalatrozcommon.h"
CustomBinding::CustomBinding()
{
	cBind = IK_F4;
	fCam = fCamOff;
	dConsole = dConsoleOff;
}
CustomBinding::~CustomBinding()
{

}
bool CustomBinding::loadSettings(std::string fName)
{
	std::string line;
	std::vector<std::string> vLoad;
	std::vector<int> vInt;
	std::ifstream bindSetting;

	bindSetting.open(fName);

	if (bindSetting.is_open())
	{
		while (std::getline(bindSetting, line))
		{
			vLoad.push_back(line);
		}
		bindSetting.close();
	}

	std::transform(vLoad.begin(), vLoad.end(), std::back_inserter(vInt),
		[](const std::string& str) { return std::stoi(str);});

	if (vInt.empty())
	{
		return false;
	}
	cBind = static_cast<EInputKey>(vInt[0]);
	fCam = static_cast<FreeCam>(vInt[1]);
	dConsole = static_cast<DebugConsole>(vInt[2]);

	return true;
}