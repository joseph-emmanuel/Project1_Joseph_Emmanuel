using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryApp
{
    static class Library
    {
        #region Media Lists
        public static List<Media> AllMedia { get; private set; } = new List<Media>()
        {
            #region Book List
            new Book("The Lord of the Rings","Fantasy",1178),
            new Book("The Da Vinci Code","Mystery Thriller",200),
            new Book("One Hundred Years of Solitude","Magic Mealism",125),
            new Book("Make Your Bed","Self-Help",144),
            new Book("He Bridges of Madison County","Romance",342),
            #endregion 
            #region Magazine List
            new Magazine("Road and Track","Auto Mobile",59,4),
            new Magazine("Bloomberg Businessweek","Business & Finance",78,2),
            new Magazine("Wired","Computer & Electronics",120,145),
            new Magazine("Closer","Entertainment & TV",56,7),
            new Magazine("Cowboys & Indians","Fashion & Style",78,12),            
            #endregion 
            #region Movies List
            new Movie("The Avengers","Action",145),
            new Movie("Crouching Tiger Hidden Dragon","Adventure",136),
            new Movie("The Godfather","Crime",180),
            new Movie("Taxi Driver","Drama",156),
            new Movie("Platoon","War",148)
            #endregion
        };
        #endregion
        #region Library Members List
        public static List<LibraryMember> allLibraryMember = new List<LibraryMember>()
        {
            new LibraryMember("Monica Geller"),
            new LibraryMember("Rachel Green"),
            new LibraryMember("Chandler Bing"),
            new LibraryMember("Ross Geller"),
            new LibraryMember("Phoebe Buffay"),
            new LibraryMember("Joey Tribbiani")
        };
        #endregion
        
    }
}
