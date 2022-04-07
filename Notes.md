The entries for the routing should be made in the /ui/Startup.cs file

Helpful link: https://docs.microsoft.com/en-us/aspnet/core/fundamentals/routing?view=aspnetcore-5.0#route-constraint-reference

Thoughts:
  getlocation view
    GET or POST without location 
  
  nearby view
    GET /34.22657833393346/-77.87778723394148
    GET /home/34.22657833393346/-77.87778723394148
    GET /nearby/34.22657833393346/-77.87778723394148
    POST /report/34.22657833393346/-77.87778723394148
    GET /truck/34.22657833393346/-77.87778723394148
    POST /find/searchTerm **** With list of trucks that match searchTerm

  report view
    GET /report/34.22657833393346/-77.87778723394148

  find view
    GET /find/34.22657833393346/-77.87778723394148

  truck details view
    GET /truck/5
  
  https://www.tutorialsteacher.com/mvc/routing-in-mvc#:~:text=Configure%20a%20Route,route%20in%20the%20RouteConfig%20class%20.
  

Nearby:
  Index 
  






