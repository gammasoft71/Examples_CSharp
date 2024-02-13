cmake_minimum_required(VERSION 3.20)

project(HelloWorld2 LANGUAGES CSharp)
include(CSharpUtilities)

set_property(GLOBAL PROPERTY USE_FOLDERS ON)

set(SOURCES README.md src/HelloWorld2.cs)

add_executable(${PROJECT_NAME} ${SOURCES})
set_target_properties(${PROJECT_NAME} PROPERTIES FOLDER "mscorelib/HelloWorlds")
