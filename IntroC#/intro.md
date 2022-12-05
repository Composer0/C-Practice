# What is ASP.NET

## ASP.NET is an open-source, server-side web-application framework designed for web development to produce web pages.

### ASP stands for Active Server Pages.

- Users request resources through a URL. (get action)
- Users post a form to the Server. (post action)
- Pages are rendered on the server and returned to the users.
- Routes are determined at runtime. ( Less worry and concern about building routes. )
- C# is the language used to build complex Web applications. ( Type safe language vs JavaScript which is dynamic. Let Var Const force JavaScript to determine type ahead of time. )


## ASP. NET is an open-source, server-side web-application framework designed for web developement to produce dynamic web pages. It has everything we need in the box!

- Page templating with Razor Pages.
- Routing Engine ( Creates routes )
- Database Access through the Entity Framework. ( Is used with enterprise databases. )
- Security with Identity.
- Type Safe Lanugage Support C#, F#, VB. (VB is not used much anymore.)

## Pattern-Based Building

ASP.NET MVC gives you a powerfule, patterns-based way to build dynamic websites that enables a clean separation f concerns that gives you full control over markup for enjoyable, agile development. ASP.NET MVC includes many features that enable fast, development for creating sophisticated applications that use the latest web standards.

# What is MVC?
A design pattern used to build web application.
- Model - Logic (data)
- View - What is Seen (user interface) - Commonly used as a web page.
- Control - Process to handle input. Interface between the Model and the View. Listen for requests and interact with the Database using the Model. Returns the Model to the View to be displayed.

Controller is what is activated first when an address is inputed. Listens for request and fetches to display. URL using HTTP is the request that the controller sees. It goes tot the Database/API and takes that information to place within a Model. The information of the Model is moved into a View(User Interface) and is then displayed to the user.

## What is a Model?
The Model corresponds to the data that the application works with. (One entity)

Models are represented in code by using Classes. A class is set of properties or methods that describes an object. Typically corresponds to database Table.

A ViewModel (Multiple entities) corresponds to Multiple datasets that derive data from more than one table or object. 

Defining models with classes in C#.

public class Person
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string PhoneNumber { get; set; }
    }


## What is a Controller?
- The Controller in MVC handles any incoming URL request.
- Controller contain public methods called Actions.
- Controller and its action method handles incoming browser requests, tretrieves necessary model data and returns appropriate responses to the view.
- A controller is a class that is inherited from AspNetCore.Mvc.Controller
- Every controller class name must end with a word "Controller". (Going back to types)
- For example, the home page controller name must be Named HomeController.
- Also, every controller class must be located in the Controller folder of the MVC folder structture.

## What is Inheritances?
- It is a mechanism where you can derive a class from another class so that they share a set of attributes and methods. For example...

Interview Question: 
The base controller creates listeners for handling requests and responses over HTTP automatically. Allows us to use low-level code and its properties without having to write it out every single time.
Supports authorization and authentication.
Supports transmission of data to and from the server to the client with JSON. (The great thing is that it works without having to write and rewrite a lot of code. It allows you to just work as you need).

## What is a View?
- The view handles the app's data presentation and user interaction.
- A view is an HTML template with embedded Razor markup.
- Views are rendered on the Server and sent to the client.
- Razor markup is code that interacts with HTML markup to produce a webpage that's sent to the client.
- Every view name must match the name of Controller Action.
- For example, the home page controller has a action named Index. the View must be named... 

Index.cshtml

- Also, every view must be located in the Views folder and in a folder named after the controller.

## What is MVC Routing?
Allows our users to enter urls into browser and it routes the user to the correct resource.

Out of the Box the URL is Broken up into 3 parts.
- Controller - The controller that will handle the request.
- Action - The method in the controller.
- ID - Not required to but is used to query a database.

Note: We request a Controllers Actions not Views!


### MVC on Visual Studio runs on Bootstrap and can automatically create a nav bar and general layout without any additional work.

### Converting what I'm seeing.

THe true html file is in the Shared folder in the _layut.cshtml file. The Home Index.cshtml that is being used is similar to react/js where we use snippets to import into the main document.

@RenderBody() is what props the desired page with the information located elsewhere in the Views folder.

The layout page is create for establishing a template first and builidng consitency across the webpages.

The reason that Visual Studio is slow is because everything is being rendered from the server rather than the client. This explains why errors are easier to be made in VSCode. It is due to the code not having to pass through a server initially which is where the true issues begin to emmerge.