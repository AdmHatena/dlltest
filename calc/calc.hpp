#ifndef _CALC_
#define _CALC_

#define DLLEXPORT extern "C" __declspec(dllexport)

DLLEXPORT int __stdcall add(int x, int y);
DLLEXPORT int __stdcall sub(int x, int y);

#endif