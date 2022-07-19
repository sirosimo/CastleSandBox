# CastleSandBox
Simple Application to debug Castle with .Net6

The issue appear when trying to load assemblies that are not referenced or known in the main application assembly.

How to test: 
Build the project and create the People folder in root directory
Make sure to copy the Kid.dll and Adults.dll to the People folder

Run the application and you should see the 2xDLL being registered (ideally)
