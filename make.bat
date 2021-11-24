@echo off

g++ -c main.cpp
g++ main.o calc/calc.dll -o main.exe
