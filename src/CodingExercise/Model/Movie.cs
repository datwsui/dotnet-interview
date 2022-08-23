using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;

namespace CodingExercise.Model
{
    [DataContract]
    public class Movie
    {
        [DataMember]
        public string IMDBID { get; set; }

        [DataMember]
        public string Title { get; set; }

        [DataMember]
        public int Year { get; set; }
    }
}