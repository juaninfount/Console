using System.Collections.Generic;
using System.Linq;
using System;

namespace Utilities
{

    #region "Internal classes"

    public class CourseChoice
    {
        public CourseChoice()
        {
        }
        public int StudentId { get; set; }
        public string Category { get; set; }
        public int Number { get; set; }
    }

    public class Course
    {
        public string Title { get; set; }
        public string Category { get; set; }
        public int Number { get; set; }
        public DateTime PublicationDate { get; set; }
        public TimeSpan Duration { get; set; }

        public override string ToString()
        {
            return  String.Format($"Course => Title: {this.Title}, Category: {this.Category}, " +
                                  $"Number: {this.Number}, PublicationDate: {this.PublicationDate.ToShortDateString()}, " + 
                                  $"Duration: {this.Duration.ToString()}");
        }
    }

    #endregion  TestJoin

    
    public class LinqSamples
    {
        public static readonly Course[] Catalog =
        {
            new Course
            {
            Title = "Elements of Geometry",
            Category = "MAT", Number = 101, Duration = TimeSpan.FromHours(3),
            PublicationDate = new DateTime(2009, 5, 20)
            },
            new Course
            {
            Title = "Squaring the Circle",
            Category = "MAT", Number = 102, Duration = TimeSpan.FromHours(7),
            PublicationDate = new DateTime(2009, 4, 1)
            },
             new Course
            {
            Title = "2013 Book Modelling Computing Systems",
            Category = "CSE", Number = 112, Duration = TimeSpan.FromHours(9),
            PublicationDate = new DateTime(2013, 1, 09)
            },
            new Course
            {
            Title = "Recreational Organ Transplantation",
            Category = "BIO", Number = 305, Duration = TimeSpan.FromHours(4),
            PublicationDate = new DateTime(2002, 7, 19)
            },
            new Course
            {
            Title = "Hyperbolic Geometry",
            Category = "MAT", Number = 207, Duration = TimeSpan.FromHours(5),PublicationDate = new DateTime(2007, 10, 5)
            },
            new Course
            {
            Title = "Oversimplified Data Structures for Demos",
            Category = "CSE", Number = 104, Duration = TimeSpan.FromHours(2),
            PublicationDate = new DateTime(2019, 9, 21)
            },
            new Course
            {
            Title = "Introduction to Human Anatomy and Physiology",
            Category = "BIO", Number = 201, Duration = TimeSpan.FromHours(12),
            PublicationDate = new DateTime(2001, 4, 11)
            }
        };

        ///
        /// JOIN OPERATIONS BETWEEN TWO COLLECTIONS
        ///
        public void joinOperations()
        {
            var beers = new List<(int IdBrand, string Name)>
            {
            (12,"Pilsen"),
            (12,"Cristal"),
            (12,"Barena"),
            (12,"Ice"),
            (9,"Lowenbraun" ),
            (9,"Brahma"),
            (9, "Budweiser")
            };

            var brand = new List<(int IdBrand, string Name)>
            {
            (9,"Ambev"),
            (12,"Backus"),
            };

            var list = (from x in beers
                        join y in brand on x.IdBrand equals y.IdBrand
                        select new
                        {
                            BeerName = x.Name,
                            BrandName = y.Name
                        }).ToList();
            /*
          var list = beers.Join(brand, x=>x.IdBrand, y => y.IdBrand, (beer, brand) =>
          {
              return new { BeerName = beer.Name, BrandName = brand.Name };
          }); */

            foreach (var item in list)
            {
                Console.WriteLine($"{item.BeerName} {item.BrandName}");
            }
        }
        
        // MULTIPLE ORDERING CRITERIA 
        public void multipleOrderingCriteria()
        {            
            CourseChoice[] choices =
            {
            new CourseChoice { StudentId = 1, Category = "MAT", Number = 101 },
            new CourseChoice { StudentId = 1, Category = "MAT", Number = 102 },
            new CourseChoice { StudentId = 1, Category = "MAT", Number = 207 },
            new CourseChoice { StudentId = 2, Category = "MAT", Number = 101 },
            new CourseChoice { StudentId = 2, Category = "BIO", Number = 201 },
            };

            
            var result = from course in LinqSamples.Catalog
                    orderby course.PublicationDate ascending, course.Duration descending
                    select course;

            foreach(var item in result)
            {
                Console.WriteLine($" {item.PublicationDate.ToShortDateString()} {item.Title} ");
            }
            
        }

        public void groupByCriteria(){
            var result = (from course in Catalog
                        group course by new { course.Category } into gc 
                        select new 
                        {
                            Category = gc.Key.Category,
                            Courses = gc.ToList()
                        });

             foreach(var item in result)
            {
                string courses = string.Join(", " ,(from c in Catalog where c.Category == item.Category select c.Title));
                Console.WriteLine($"Category: {item.Category}, Courses: " + courses);
            }
        }
    }
}