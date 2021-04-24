#Hello World!

#Steps taken to refactor this soluton
1- I Supposed the current implemented function was correct
2- I have set up two approval tests : 
a) An approval test which will track the items in 31 days (this was already implemented)
b) An approval test which will give me all the possible combinations with actual and expected values which I have chosen
3- A unit test case which tests the targeted function with specific inline input taken mainly from the approval test 2.b
4- Set and generate the approval tests result as the source of truth
5- Refactor the code and test against the tests mentioned above

#Choices I have made
1- Created an interface to define the main function to refactor.
2- Created several Item type classes, each of them have to implement the inteface according their own logic
3- I copy pasted the function body in each of the classes and removed the unnecesary conditions.
4- I improved the code structure so it would be shorter and simpler.
5- I reran the tests to verify the changes