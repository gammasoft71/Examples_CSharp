cmake_minimum_required(VERSION 3.12)

project(Console LANGUAGES CSharp)

add_executable(Console Console.cs)
set_property(TARGET Console PROPERTY VS_DOTNET_TARGET_FRAMEWORK_VERSION "v4.6.1")
set_property(TARGET Console PROPERTY VS_DOTNET_REFERENCES
  System
)
