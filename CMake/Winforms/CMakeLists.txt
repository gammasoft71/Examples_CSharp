cmake_minimum_required(VERSION 3.12)

project(Winforms LANGUAGES CSharp)

add_executable(Winforms Winforms.cs)
set_property(TARGET Winforms PROPERTY VS_DOTNET_TARGET_FRAMEWORK_VERSION "v4.6.1")
set_property(TARGET Winforms PROPERTY WIN32_EXECUTABLE TRUE)
set_property(TARGET Winforms PROPERTY VS_DOTNET_REFERENCES
  System
  System.Drawing
  System.Windows.Forms
)
