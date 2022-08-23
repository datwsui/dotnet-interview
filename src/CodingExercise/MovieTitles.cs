using CodingExercise.Model.Response;
using Microsoft.AspNetCore.Http;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Linq;
using System.Threading.Tasks;

namespace CodingExercise
{
    public class MovieTitles
    {
        public static List<string> GetTitles(string substr)
        {
            List<string> result = new List<string>();

            if (!string.IsNullOrEmpty(substr))
            {
                //System.Net.HttpWebRequest request = System.Net.WebRequest.Create()

                try
                {
                    var response = SearchMovie(substr, 1);
                    if (response != null)
                    {
                        if (response.Movies != null && response.Movies.Count > 0)
                            result = result.Concat(response.Movies.Select(x => x.Title)).ToList();

                        if (response.TotalPages > 1)
                        {
                            for (int i = 2; i <= response.TotalPages; i++)
                            {
                                response = SearchMovie(substr, i);
                                if (response != null && response.Movies != null && response.Movies.Count > 0)
                                    result = result.Concat(response.Movies.Select(x => x.Title)).ToList();
                            }
                        }
                    }
                }
                catch (Exception e)
                {
                    throw e;
                }
            }
            else
                throw new Exception("Keyword is mandatory.");

            return result.OrderBy(x => x).ToList();
        }

        private static ResponseMovies SearchMovie(string substr, int page)
        {
            string queryUrl = @"https://jsonmock.hackerrank.com/api/moviesdata/search/?Title={0}&page={1}";
            ResponseMovies response = new ResponseMovies();
            try
            {
                HttpClient searchReq = new HttpClient();
                string searchResult = searchReq.GetStringAsync(string.Format(queryUrl, substr, page)).Result;

                if (!string.IsNullOrEmpty(searchResult))
                {
                    response = JsonConvert.DeserializeObject<ResponseMovies>(searchResult);
                }

            }
            catch (Exception e)
            {
                throw e;
            }

            return response;
        }
    }
}
