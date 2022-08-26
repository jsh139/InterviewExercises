# InterviewExercises

## C#Exercises
Contains a solution (DevSamples.sln) that has two patterns and two exercises. These patterns/exercises are designed to be shown to the candidate during a live interview. The two exercises require the user to share their screen and write some code.

The first pattern (Pattern1) contains a single file called SearchProvider.cs.  The idea here is to have the candidate walk through the code line-by-line and point out anything interesting that they see.  We're also looking for them to explain what is happening.  

- The ideal candidate would remark that this is an abstract class (cannot be directly instantiated), using dependency injection (ICacheManager). 
- It has one method called GetData that uses generics (T), takes in a request parameter that implements the ISearchRequest interface, and another parameter that is a delegate function which takes in two parameters and returns an object of the same type (T) that was used as the generic. The generic must be a class that implements the ISearchResults interface.  
- We'd like them to remark that GetData checks for data in the cache (using the ICacheManager dependency).  If the data comes back as null (cache expired or data was never set) then we call the delegate function (getDataFunc) that was passed in. It then takes that data and puts it into cache with a sliding expiration of 15 minutes. 
- Sliding expiration means that each time the data is accessed, the cache expiration time is reset to 15 minutes.  After 15 minutes of no activity, the data in the cache is expired.

The second pattern (Pattern2) is just a series of classes describing a search algorithm using various software design patterns.

- The SearchPreparer has a dependency on in an implementation of the ISearchAdapterFactory.  The factory is used to return a list of SearchAdapter objects (implemented from ISearchAdapter).  It has a method called Prepare that takes in a search request.  There may be many implementations of the ISearchRequest interface.
- The adapters use a chain of responsibility pattern to check if the search request is of a particular type.  If the type matches, some changes are done to the search request object.
- There is also a CommonSearchAdapter that makes changes to the request object regardless of its type.

The first exercise resides in the Exercises project.  In the Exercise1 folder.  It contains a text description of what we'd like the candidate to do.  We're looking for a few specific things out of this exercise.

- We'd like the candidate to realize that two classes are needed. One to hold the list of Products, and one for the Product itself.
- Good coding design (separate files, good indenting/spacing, etc).
- Use an enum for the product type instead of a string.
- Use a LINQ statement to get the product having the lowest price. Preferably a Where() clause, followed by an OrderBy(), followed by a FirstOrDefault().

The second exercise resides in the ParenTester project.  It contains a simple class (ParenTester) that checks to see if parentheses are balanced in a given string and a Tests.cs file to test the ParenTester.

- The object is to get all of the tests in the Tests.cs file to pass by modifying the ParenTester class (Test-Driven Design).
- Candidates will likely get the first few tests to pass using if statements, but as the tests get harder and brackets and curley braces are introduced, we'd like them to think outside the box.
- The ideal solution uses a Stack<T> rather than a bunch of variables.

## CleaningProductExercise

This exercise is designed to be a take-home assignment. It contains a text file describing the assignment and a JSON file containing data. The idea is to injest the data in the file, validate the data, discard data that is invalid, and transform/sort the rest into a CSV file.  The output should be two files.  GoodData.csv and BadData.json.

- Since this is a take-home assignment, ideally we'd like the candidate to spend at least an hour on it.  We'd like to see good design and implementation with classes and services separated into multiple files. 
- Using dependency injection would be nice, as well as maybe some unit tests.
- And, it obviously needs to run and sort the data properly!

## ReactNativeInterview

Contains two exercises designed to be given to a candidate during a live interview.

The first (react.js) asks the user to walk through the code line-by-line and point out anything interesting that they see.  We're also looking for them to explain what is happening.  

- We'd like them to realize that we are importing a series of components to be used.
- We'd like them to explain the ...props spread operator that is being used for the Field method.
- We'd like them to realize that the View on the form is basically utilizing a generic component based on the type that is passed into the Field method.

The second (GroceryListExercise.docx) is an exercise is designed to be given to a candidate during a live interview. We'd like the candidate to share their screen and write some code. It contains a small assignment of creating React Native components on a form. The components function together as a simple shopping list.  Sample solutions are included in the exercise.js file.

## UIInterview

This folder contains four JS files.  Each one tests various JavaScript knowledge.  It is designed to be shown to the candidate during a live interview.

- The first file (evaluate.js) asks the candidate what the output would be from the various situations. The output should be "1 3 5".
- The second file (mistake.js) asks the candidate to find and fix the bug in the JS code.
- The third file (react.js) is the same file in the ReactNativeInterview folder. In case the candidate is looking for a hybrid role.
- The fourth file (scope.js) asks the candidate to figure out the output given a scenario.  We'd like them to understand the various scopes.  Output is in the file.
