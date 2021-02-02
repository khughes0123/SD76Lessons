
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07_RepositoryPattern_Repo
{
    public class StreamingContent
    {

        public string Title { get; set; }
        public string Description { get; set; }
        public double StarRating { get; set; }
        public Maturity MaturityRating { get; set; }

        // Make IsFamilyFriendly read-only (only a getter)
        // Based on the MaturityRating
        // MaturityRating should probably be an enum
        public bool IsFamilyFriendly
        {
            get
            {
                // This is ok
                // if (MaturityRating ==Maturity.G)
                // || MaturityRating == Maturity.PG
                // || ...)
                switch (MaturityRating)
                {
                    case Maturity.PG13:
                    case Maturity.PG:
                    case Maturity.G:
                    case Maturity.TVG:
                    case Maturity.TVY7:
                    case Maturity.TVY:
                        return true;
                    default:
                        return false;
                }
            }
        }


        public GenreType GenreType { get; set; }

        public StreamingContent() { }
        public StreamingContent
            (string title, 
            string description, 
            Maturity maturityRating,
            double stars,
            GenreType genre)
        {
            Title = title;
            Description = description;
            StarRating = stars;
            MaturityRating = maturityRating;
            GenreType = genre;


 


    }
}

public enum GenreType { SciFiComedy, Drama, Horror, Comedy, SciFi, Romance, Romans, Action, International }

public enum Maturity { G, PG, R, TVG, PG13, NC17, TVY, TVY7, TVMA, TVPG } }
    


    
            



