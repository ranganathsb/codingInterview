Coding Interview Frameworks
================

Sample C# solutions to form a basis of code interviews

## Shapes Interview (Basic C#) ##
This solution is designed to test very basic knowledge of C#, it does use unit tests using nunit but the candidate need not really know about unit testing or nunit to do this.

**First**: get them to create a square class to fix the failing test.

**Second**: un-ignore the next test and create a service or something (its upto them) to fix this test also.

**Third**: ask the candidate to add a new method to the service to calculate the perimeter of a shape. 

- Add the property '(double) Perimeter' to the IShape interface, and add also to the square class (but throw a not implemented exception).
- include in project the test file ShapeServiceTests. This might need modification depending on how the candidate did the second part.
- Then ask them to use a mocking framework to test drive the creation of a totalPerimeter method so that no actual squares are used. (this should test basic knowledge of what mocking frameworks are and how to use nuget)