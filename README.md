This is a flower database project that I wrote for cs325 (Software Engineering) at SIUE.

The goal of the project was to creating a GUI and working database model for a 'Researcher'
to store flowers.

They needed to be able to add flowers, edit flowers, delete flowers, and search for flowers
by name, family, and photo (There needed to be a working photo search algorithm).

The project itself isn't fully finished but there's a basic prototype and working GUI/Database.
All basic functionality also functions correctly and met requirements.

I was personally responsible for the folowing classes:
addUser.cs (and GUIs & Controllers)
batchAddUser.cs (and GUIs &  Controllers)
deleteUser.cs (GUIs & Controllers)
editUsers.cs (GUIs & Controllers)
login.cs (GUIs & Controllers)
userController.cs
Much of the database manager (DatabaseManager.cs)
The design of the data structure (flower_database.mdf)
Various other fixes, and design choices.
A function to pull data from a .xlsx file (addBatchUsers)
Salting and Hashing for the database (SaltedHashbrowns.cs)