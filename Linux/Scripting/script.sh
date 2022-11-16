#!/bin/bash

# Codecademy Example Build a Build Script - copy files from a Source Folder to Build Folder, apart from secret file

echo "Welcome to the build script"
firstline=$(head -n 1 source/changelog.md) #returns 1st line of file
read -a splitfirstline <<< $firstline
version=${splitfirstline[1]}
echo "You are building version" $version
echo "Do you want to continue? enter 1 to continue, or 0 to exit"
read continue

if [ $continue -eq 1 ]
then
  echo "OK"
  for filename in source/*
  do
    # echo $filename
    if [ "$filename" == "source/secretinfo.md" ] #if file name matches
    then 
      echo $filename " will not be copied"
    else
      echo $filename " copying"
      cp $filename build/. #copies files into build/
    fi
  done
  cd build/ #changes into build/
  echo "Build version $version contains:"
  ls #lists files in build
else
  echo "Please come back when you are ready"
fi