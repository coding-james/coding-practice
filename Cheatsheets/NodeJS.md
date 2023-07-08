# Node.js

## Overview
Node.js is an open-source, cross-platform JavaScript runtime environment.

- Install
- NVM
- Key Commands

## Install
Install Node.js from https://nodejs.org/en
Install NVM from https://github.com/coreybutler/nvm-windows/release

## NVM
Node.js version manager for Windows (or NVM), manages multiple installations of node.js on a Windows computer.

### NVM Commands
`nvm current` = current version of node in use
`nvm ls` = list installed versions on machine
`nvm ls available` = list versions of node that can be installed
`nvm install <version>` = specify which version to install
`nvm use <version>` = specify which version to use 

## Key Commands

Initialise project   
`npm init -y`

Install a package   
`npm install <package name>`

Install a package to dev   
`npm install --save-dev <package name>`

## Running Tests
add / edit scripts in `package.json` to run tests

default test
`npm test`

### Run a single test based on an argument

update `package.json`

````
"scripts": {
    "test:single": "func() { mocha unit/**/${1}.test.js; }; func"
    },
````
run with `npm run test:single <file name>`

Windows users will need to configure bash to use Windows
In terminal run: `npm config set script-shell "C:\\Program Files\\Git\\bin\\bash.exe"`   
This will add an entry to the following file on your machine  `C:\users\<username>\.npmrc`   
If you want to go back to not using git bash, you can remove this line from the file.   