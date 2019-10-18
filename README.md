# EAHT-Monitor-App
ARU 2019 Computer Science - Software Engineering | Assignment solution

## Installing and Configuring Workflow Tools

### GitHub

Sign up for an account with [GitHub](https://github.com) and post your name in the group Facebook chat so that you can be added as a collaborator in the project.

(optional) Free GitHub pro if you sign up using your student email address then click the 'Get the pack' button at [this link](https://education.github.com/pack) plus a bunch of other free premium software and cloud services.

### Git (Different from GitHub)

We are using git as our version management software, GitHub is a tool for colaboration that hosts the repository remotely for us so that we can all collaborate on a project.  It also gives us a nice web interface and optional GUI (but I recommend we use GitKraken because it is easy to understand and has more features)

Visit the [git website](https://git-scm.com/downloads), download and install git.

Some short videos that explain what git is and what it does can be found [here](https://git-scm.com/videos).

Codecademy used to have a free short git course but not anymore.

This [guide on TutorialsPoint](https://www.tutorialspoint.com/git/git_basic_concepts.htm) should cover everything you need to know for what we are doing.

### GitKraken (optional but recommended)

visit the [GitKraken website](https://www.gitkraken.com/git-client) and download and install the GUI software

Once you have installed the software, open it and you will be able to sign in to your GitHub account.  There will be an authorisation step, just accept :)

Here is a handy [cheat sheet](https://www.gitkraken.com/downloads/gitkraken-cheat-sheet-jun19.pdf)

## Development Documentation & Best Practice Notes

Please keep UI code in the UI project and use the engine for all other code.  

To use your code classes in the UI project just add the line

`using EAHT_Engine;`

to the top of the UI class file.

Reference classes and methods as you would from any other c# library

For example:
Instantiating an object
`myObject = new EAHT_Engine.MyClass();`
Calling a method on an object
`myObject.MyMethod()`
Calling a static method
`EAHT_Engine.MyClass.MyStaticMethod()`


### UI

### Engine

### Database
