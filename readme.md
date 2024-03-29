# My Movie Catalog Sample Repository

This code repository is intended to test your knowledge of ASP.NET Core Web API projects. It should take approximately 
1-2 hours to complete. 

The purpose of this API is to manage your movie collection.

It doesn't do much yet though! Currently, there is just one stub API Controller and an Entity Framework data context.

You will be asked to complete a few tasks below. You can choose to complete them however
you want, but you must meet the requirements of the task.

## Requirements

First, let's make sure you have the following:

* Visual Studio 2022
* Microsoft SQL Server (installed locally or running in a Docker container)

## Setup

1. Make sure that the connection string in appsettings.Development.json points to a
running instance of Microsoft SQL Server.
1. This project utilizes Entity Framework Core Code-First and Migrations. There is an 
initial migration created for you which seeds data (a catalog of Star Wars movies). 
Run this migration to create the database and seed data.

## Tasks

Again, you can complete these tasks however you like, as long as you 
meet the requirements of each task. 

1. Change the default Get method in MoviesController to return the collection of your movies.

2. Create an API method that allows the creation of a new movie.
   * Make sure that the movie doesn't exist (a movie is considered a duplicate if it has the same title and release year)

3. You want to track how much you liked a movie. 
    * Create a new attribute on the Movie entity called **Stars**
    * **Stars** accepts a critic rating in between 1 and 5
    * Make sure that other developers on the project can easily update their database with this new entity after they pull down your changes

4. Now that you have a new attribute, you notice that you don't have an endpoint to edit a movie. Go ahead and make one.

5. Now, you want to store information about movie directors and the movies in your collection that they directed. It is up to you to determine the architecture and implementation of the below:
    * The storage and retrieval of director data
    * Creating a new director 
    * Adding a director to a movie
        * What happens in the case where a movie has more than one director, like The Matrix?

6. You just sold some of your movies at a garage sale. Create an endpoint to delete a movie.

## Bonus: Unit Tests 

These tasks are optional, but feel free to do them if you would like to display your understanding of writing basic unit tests. Feel free to use the testing library of your choice, so long as the tests can be run in Test Explorer in Visual Studio.

1. Add a unit test for Movies->Get that verifies that:
    * The method returns a collection of movies
    * The method returns the same number of movies as what you have in your mock repository

2. Add a unit test for Movies->Post that verifies that:
    * A new movie object is returned
    * The new movie object matches the data sent in the request body

## Submitting Your Code

As we don't want answers to be public, please zip up your code and send it to josh.greenwald@stratusinnovations.com.

## Disclaimer

None of the code you submit will be used in real-world situations and is purely used for education
and feedback. If you find that it's taking you more than an hour or two to complete, please let us know.
