cmake_minimum_required(VERSION 3.20)

project(Action3 LANGUAGES CSharp)
include(CSharpUtilities)

set_property(GLOBAL PROPERTY USE_FOLDERS ON)

set(SOURCES README.md src/Action3.cs)

add_executable(${PROJECT_NAME} ${SOURCES})
set_property(TARGET ${PROJECT_NAME} PROPERTY VS_DOTNET_REFERENCES System System.Drawing System.Windows.Forms)
set_target_properties(${PROJECT_NAME} PROPERTIES FOLDER "mscorelib/Delegates")
