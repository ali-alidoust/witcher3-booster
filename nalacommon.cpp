#include "nalatrozcommon.h"
CustomBinding::CustomBinding()
{
	cBind = IK_F4;
	fCam = off;
}
CustomBinding::~CustomBinding()
{

}
bool CustomBinding::loadSettings(std::string fName)
{
	std::string line;
	std::string cLoadStr;
	int cBindInt = 0;
	int fCamEnabled = 0;
	int i = 0;
	std::ifstream bindSetting;
	bindSetting.open(fName);
	if (bindSetting.is_open())
	{
		while (std::getline(bindSetting, line))
		{
			i++;

			cLoadStr = line.c_str();

			if (i == 1)
			{
				cBindInt = atoi(cLoadStr.c_str());
			}
			else if (i == 2)
			{
				fCamEnabled = atoi(cLoadStr.c_str());
			}
			else
				return false;
		}
		bindSetting.close();
	}

	cBind = static_cast<EInputKey>(cBindInt);
	fCam = static_cast<FreeCam>(fCamEnabled);
	return true;
}