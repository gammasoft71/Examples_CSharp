cmake_minimum_required(VERSION 3.20)

set_property(GLOBAL PROPERTY USE_FOLDERS ON)

project(Action1 LANGUAGES CSharp)
include(CSharpUtilities)
set(SOURCES
  src/Action1.cs
)

add_executable(${PROJECT_NAME} ${SOURCES})
set_target_properties(${PROJECT_NAME} PROPERTIES FOLDER "mscorelib/Action")
set_property(TARGET ${PROJECT_NAME} PROPERTY VS_DOTNET_REFERENCES
  System
  System.Drawing
  System.Windows.Forms
)
