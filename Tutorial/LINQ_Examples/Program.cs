using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQ_Examples
{
    class Program
    {
        static void Main(string[] args)
        {

            // Specify the data source.
            int[] scores = new int[] { 97, 92, 81, 60 };

            // Define the query expression.
            // A query expression must begin with a from clause and must end with a select or group clause. 
            // Between the first from clause and the last select or group clause, 
            // it can contain one or more of these optional clauses: where, orderby, join, let and even additional from clauses. 
            // You can also use the into keyword to enable the result of a join or group clause 
            // to serve as the source for additional query clauses in the same query expression.
            IEnumerable<int> scoreQuery = //query variable
                from score in scores //required
                where score > 80 // optional
                orderby score descending // optional
                select score; //must end with select or group

            // Execute the query to produce the results
            foreach (int testScore in scoreQuery)
            {
                Console.WriteLine(testScore);
            }

            Console.WriteLine();

            // =================================================
            int highestScore =
                (from score in scores
                 select score).Max();

            // or split the expression
            IEnumerable<int> scoreQuery2 =
                from score in scores
                select score;
            int highScore = scoreQuery2.Max();

            // the following returns the same result
            int highScore2 = scores.Max();

            //=================================================
            List<Country> countries = new List<Country>();

            List<City> largeCitiesList =
                (from country in countries
                 from city in country.Cities
                 where city.Population > 10000
                 select city)
                   .ToList();

            // or split the expression
            IEnumerable<City> largeCitiesQuery =
                from country in countries
                from city in country.Cities
                where city.Population > 10000
                select city;

            List<City> largeCitiesList2 = largeCitiesQuery.ToList();

        }
    }

    class City
    {
        private string _name;

        public string Name
        {
            get
            {
                return _name;
            }

            set
            {
                _name = value;
            }
        }

        public int Population
        {
            get
            {
                return _population;
            }

            set
            {
                _population = value;
            }
        }

        private int _population;
    }

    class Country
    {
        private List<City> _cities;

        internal List<City> Cities
        {
            get
            {
                return _cities;
            }

            set
            {
                _cities = value;
            }
        }
    }
}
