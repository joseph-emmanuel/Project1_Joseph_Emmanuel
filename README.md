# Project1_Joseph_Emmanuel
DO5 final project done by individualy
Instructions by professor






Library Project


This project contains a list of 21 required features that you must add to your program.

Do your best to follow all the instruction closely.  Use whatever programming techniques seem appropriate to implement the required features. Do your best to follow the programming principles learned in class whenever they apply.

Name your solution Project1<your name>, and name the project LibraryApp. When you submit,  zip your solution folder and email it to me.

For this project, you must create a WPF application that allows a user to manage a library. Here are the required features of the application:



An abstract Media class that contains the following properties: a string title, a string media type, a unique int serial number, an int for number of times lent, a boolean that indicates whether it is currently borrowed or available, and a string that represents the name of the library member currently borrowing the piece of media
A Book class that inherits from Media and has a page count property
A Magazine class that inherits from Book and has an issue number property
A Movie class that inherits from Media and has a run time property
A LibraryMember class that contains a string name property
A static Library class that contains a collection of all of its media and a list of all its members
Initialize your collection of media in Library to contain 5 books, 5 magazines, and 5 movies (you may pass whatever values you want into their constructors for title, page count, etc.)
Initialize your collection of members in Library to contain 5 library members with names of your choosing.
A DataGrid of all media in the library that shows their title, type, whether they are available or lent out, and who is currently borrowing them.
A DataGrid of all library members in the library that shows their names.
The ability to lend out available media. When media is lent out, a LibraryMember must be selected, and then the media display should reflect who is currently borrowing the media.
The ability to have lent media brought back 
A popup that appears whenever media is lent or brought back, which says what has occurred. If the user tries to lend out an unavailable piece of media or tries to have media brought back that isn’t lent out, the popup should tell the user what went wrong.
A Modify Media button which, if a Media is currently selected when it is clicked, opens a new page. The new page should allow the user to modify the title and media type of the Media. This page should contain a submit button. When the submit button is clicked, the changes made to the title and media type should be applied to the actual Media object in the model, and we should be returned to the main window, where the changes that were made to the Media object should be reflected in the Media data grid.
A Modify Member button which, if a LibraryMember is currently selected when it is clicked, opens a new page. The new page should allow the user to modify the name of the LibraryMember. This page should contain a submit button. When the submit button is clicked, the change made to the name should be applied to the actual LibraryMember object in the model, and we should be returned to the main window, where the changes that were made to the Librarymember object should be reflected in the LibraryMember data grid.
Create a virtual function in Media called MediaInfo that returns a string that details the media’s Title, MediaType, SerialNumber, IsAvailable, TimesLent and CurrentBorrower . Override this function in the Book, Magazine, and Movie classes. In each of these classes, the overridden function should first call the base function, and then add the string the base function returns to an additional string about PageCount, IssueNumber, or RunTime (for Book, Magazine, or Movie, respectively). 
Add a button to the WPF window that allows the user to display the info (the string returned by the function in the previous feature) of the currently-selected media in a popup.
Add a list of Media called borrowHistory to the LibraryMember class. Make it so that whenever some media is lent out, the library member who is borrowing it has a reference to that media added to their borrowHistory list.
Add a list of Media called currentlyBorrowed to the LibraryMember class. Make it so that whenever the library member borrows some media, a reference to that media is added to the currentlyBorrowed list, and when the library member returns some media, the reference to that media is removed from the currentlyBorrowed list.
Add a function to the LibraryMember class called MemberInfo that returns a string that includes the member’s name, as well as a list of all the titles of media this member has ever borrowed, and finally a list of all the media titles the member is currently borrowing.
Add a button to the WPF window that allows the user to display the info (the string returned by the function in the previous feature) of the currently-selected member in a popup.

Bonus: Make your application appear unique by modifying fonts, formatting, colours, styles, alignment, etc, to your own tastes.

