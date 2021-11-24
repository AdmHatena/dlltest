@echo off

g++ -c calc.cpp
g++ calc.o -o calc.dll -shared
