# Movie Titles

Write an HTTP GET method to retrieve information from a movie database.

Given a string `substr`, the function `GetTitles` must perform the following tasks:

1. Query `https://jsonmock.hackerrank.com/api/moviesdata/search/?Title=substr` (replace `substr`). 
1. Initialize the `titles` array to store `total` string elements. Store the `Title` from each record returned in the `data` field to the titles array.
1. Sort `titles` in ascending order and return it as the answer.

The query response from the website is a JSON response with the following five fields:

- `page`: The current page
- `per_page`: The maximum number of results per page
- `total`: The total number of records in the search result
- `total_pages`: The total number of pages which must be queried to get all the results
- `data`: An array of JSON objects containing movie information

Each data array object has the following 3 fields:
- `Title`: the movie title
- `Year`: year of release
- `imdbID`: a unique identifier
 
If there are multiple pages to retrieve, the query should read `https://jsonmock.hackerrank.com/api/moviesdata/search/?Title=substr&page=pageNumber`, replacing substr and pageNumber.

## Function Description

Complete the `GetTitles` function in the editor below.

`GetTitles` has the following parameter(s):
    - `substr`: a string
and returns:
    - `List<string>`: a list of strings, titles sorted in ascending order

## Sample Case
**Sample input**
substr = 'spiderman'

**Sample output**
```
Fighting, Flying and Driving: The Stunts of Spiderman 3
Italian Spiderman
Spiderman
Spiderman 5
Spiderman in Cannes
Superman, Spiderman or Batman
```

**Explanation**
For this example, all titles that contain the substring `spiderman` should be displayed. The response for the query `https://jsonmock.hackerrank.com/api/moviesdata/search/?Title=spiderman&page=1` is:

```json
{
  "page": 1,
  "per_page": 10,
  "total": 6,
  "total_pages": 1,
  "data": [
    {
      "Title": "Italian Spiderman",
      "Year": 2007,
      "imdbID": "tt2705436"
    },
    {
      "Title": "Superman, Spiderman or Batman",
      "Year": 2011,
      "imdbID": "tt2084949"
    },
    {
      "Title": "Spiderman",
      "Year": 1990,
      "imdbID": "tt0100669"
    },
    {
      "Title": "Fighting, Flying and Driving: The Stunts of Spiderman 3",
      "Year": 2007,
      "imdbID": "tt1132238"
    },
    {
      "Title": "Spiderman 5",
      "Year": 2008,
      "imdbID": "tt3696826"
    },
    {
      "Title": "Spiderman in Cannes",
      "Year": 2016,
      "imdbID": "tt5978586"
    }
  ]
}
```

Note: Since there are only 6 titles, there is nothing on page 2.


The values of the `Title` field for each record in the order received are:
```
Italian Spiderman
Superman, Spiderman or Batman
Spiderman
Fighting, Flying and Driving: The Stunts of Spiderman 3
Spiderman 5
Spiderman in Cannes
```

Sort the array in ascending order, and return it as the answer.