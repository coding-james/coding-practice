#!/bin/bash

# Codecademy.com Linux Off-Platform Project: What's the Hottest City
# Download Codecademy.com modified weather script: wget https://static-assets.codecademy.com/Courses/learn-linux/weather-offplatform-project/weather.sh
# Give excutable permissions: chmod +x weather.sh

cities=("London" "Edinburgh" "Dublin" "Cardiff" "Auckland")
> temperatures.txt

for city in ${cities[@]}
do 
# commands
    sleep 1 #adds a 1 second delay
    # echo $(./weather.sh -s $city | sed 's/+//' | sed 's/°C//') #Test print to ensure it works as expected
    ./weather.sh -s $city | sed 's/+//' | sed 's/°C//' >> temperatures.txt
done

sort -k2 -r temperatures.txt # -k2 sorts file by 2nd value in each line, -r sort in descending order. 