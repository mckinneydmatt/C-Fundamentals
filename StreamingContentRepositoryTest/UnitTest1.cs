using Microsoft.VisualStudio.TestTools.UnitTesting;
using RepositoryPatterns;
using System;
using System.Collections.Generic;

namespace StreamingContentRepositoryTest
{
    [TestClass]
    public class UnitTest1
    {
        //we want to test the add method in the repo
        [TestMethod]
        public void AddToDirectory_ShouldGetCorrectBoolean()
        {
            //AAA - Arrange, Act, Assert

            //Arrange - overall setup
            StreamingContent content = new StreamingContent();
            StreamingContentRepository repository = new StreamingContentRepository();

            //act - get/run code to test
            bool addResult = repository.AddContentToDirectory(content);

            //assert - used to get the expected outcome of a test
            Assert.IsTrue(addResult);
        }
        //Testing the read method
        [TestMethod]
        public void GetDirectory_ShouldReturnCorrectCollection()
        {
            //AAA rules apply
            //arrange

            //creating the content
            StreamingContent content = new StreamingContent();
            //creating the repo
            StreamingContentRepository repo = new StreamingContentRepository();
            //adding to the repo(content)
            repo.AddContentToDirectory(content);

            //act
            //our plan is to store the list of streaming content w/n a variable
            List<StreamingContent> listOfMovies = repo.GetContent();

            bool directoryHasContent = listOfMovies.Contains(content);

            //assert
            Assert.IsTrue(directoryHasContent);
        }

        //start with private fields
        private StreamingContentRepository _repo;
        private StreamingContent _content;

        [TestInitialize]
        public void Arrange()
        {
            _repo = new StreamingContentRepository();
            //we make a new movie here
            _content = new StreamingContent("Rubber", "A care tire comes to life with power.",
                                             MaturityRating.R, GenreType.Drama, 5.8);
            
            //now add the movie to our database list
            _repo.AddContentToDirectory(_content);

        }

        //retrieve content by title
        [TestMethod]
        public void GetByTitle_ShouldReturnCorrectContent()
        {
            //Arrange - already done above

            //Act

            StreamingContent searchResult = _repo.GetContentByTitle("Rubber");

            //assert
            Assert.AreEqual(_content, searchResult);

        }

        //test update method
        [TestMethod]
        public void UpdateExistingContent_ShouldReturnTrue()
        {
            //Arrange - Updated version of our movie
            StreamingContent newContent = new StreamingContent("Rubber Part 2", "A care tire comes to life with power.",
                                             MaturityRating.R, GenreType.Drama, 9.8);

            //act
            bool updateResult = _repo.UpdateExistingContent("Rubber", newContent);

            //assert
            Assert.IsTrue(updateResult);
        }

        [TestMethod]
        public void DeleteExistingContent_ShouldReturnTrue()
        {
            //Arrange
            StreamingContent content = _repo.GetContentByTitle("Rubber");

            //act
            bool removeResult = _repo.DeleteExistingContent(content);

            //assert
            Assert.IsTrue(removeResult);

        }


    }
}
