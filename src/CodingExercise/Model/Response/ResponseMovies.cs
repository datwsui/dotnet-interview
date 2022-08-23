
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;

namespace CodingExercise.Model.Response
{
    [DataContract]
    public class ResponseMovies
    {
        [DataMember(Name = "data")]
        public List<Movie> Movies { get; set; }

        [DataMember(Name = "page")]
        public int Page { get; set; }

        [DataMember(Name = "per_page")]
        public int PerPage { get; set; }

        [DataMember(Name = "total")]
        public int Total { get; set; }

        [DataMember(Name = "total_pages")]
        public int TotalPages { get; set; }
    }
}