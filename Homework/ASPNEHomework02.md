# ASP.NET MVC
#CH 01, In Context

### Michelle Caballero
##### 20 February 2019


Describe what a controller does in the MVC design pattern. acts as the traffic cop
What is the ASP.NET MVC convention in naming controllers? What does HomeController.cs do? controller names should always end with controller
What is the name of the routing configuration file? Where is it located? RouteConfig.cs; located in App_Start folder
What is Razor? How does Razor treat an expression beginning with the at symbol (@)? Engine that produces the HTML; @ tells razor that its the code that needs to be executed
How do View methods work? runs a method on a specific view as opposed to simply printing to the browser
What is the purpose of MVC models? Containers that represent data elements and business rules
What is a strongly typed view and why do we use strongly typed views? views intended to render a specific domain type; creates shortcuts
What is the purpose of setting a start page URL? So when you create an app, it will start from the top
Describe the differences between HTTP GET and HTTP POST. HTTP GET: Visible to the world, data is limited; everything is in the URL HTTP POST: amount of data you can send back is unlimited and its not visible to the world
Describe the two approaches to validation in web applications. Validate client-side (user friendly, but can be spoofed) AND Validate server-side (can't be spoofed but not friendly to user)
What is the role of Cascading Style Sheets (CSS) in web development? Styles the presentation
