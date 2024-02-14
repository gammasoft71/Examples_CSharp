cmake_minimum_required(VERSION 3.20)

project(ConsoleColor LANGUAGES CSharp)
include(CSharpUtilities)

set_property(GLOBAL PROPERTY USE_FOLDERS ON)

set(SOURCES README.md src/ConsoleColor.cs)

add_executable(${PROJECT_NAME} ${SOURCES})
set_target_properties(${PROJECT_NAME} PROPERTIES FOLDER "mscorelib/Console")
