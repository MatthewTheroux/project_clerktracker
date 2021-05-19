## [0]. ABOUT
# project_clerktracker

'Having a hard time keeping track of those courtesy clerks?
Now, keep track of them, in tasks, places, times, and lunches, with "Clerk Tracker."
(continue soundbyte)....

## [I].  USE CASES
##  [ADVANCED] 00 
##  00.  an Administrator; i.e., "us," should be able to 

- launch the application
- add the (initial) Head CSM
- debug code, when needed
- update code, when needed

##   [ADVANCED] 02
##    02.  the Head CSM should be able to 

- launch the application
- update the Head CSM
- add other CSMs
- perform all other CSM tasks

##   03.  a CSM, (Customer Service Manager), should be able to 

- launch the application
- add other CSMs
- add other Clerks
- pair other Clerks' devices

- (Daily)
- add or update the daily clerk plan, (see diagram)
- track clerks' positions, scheduled tasks, reported tasks, break times
- send a clerk a direct message
  - e.g., "Please report to the Customer Service Desk."

- send *all* clerks an APB message
  - e.g., "<!> Spill in Aisle __." [advanced: "Code 3: Liquid."]
  - e.g., "<!> Change bottle bins." 
  - e.g., "<!> Run Garbage."
  - A Clerk can respond with the "I got it." button.

##   04.  a (Courtesy) Clerk should be able to 
- pair personal device with the desk's.

- (Daily)
- launch the application.
- view scheduled tasks for the day.
- receive a notification on the next scheduled task.
- confirm a scheduled task is being attended.
- notify (to the CSM) a change in current task work.
  - e.g., 

  

## [II].  Architecture (using C# / .NET)

+ [solution] ClerkTracker.sln

  + [project - mvc] ClerkTracker.Client.csproj

  + [project - classlib] ClerkTracker.Domain.csproj
    + [folder] Abstracts
    + [folder] Interfaces, (if needed)
    + [folder] Models

  + [project - classlib ] ClerkTracker.Storage.csproj
    + [file] ClerkTrackerContext.cs
    + [folder] Repositories
      + [file] CSMRepository
      + [file] ClerkRepository


  + [project - xunit] ClerkTracker.Testing.csproj
    + [folder] Tests
      + [folder] UnitTests
      + [file] CSMTests.cs
      + [file] ClerkTests.cs
      + [file] RepositoryTests.cs
      + [file] TaskTests.cs





## [III].  Requirements

The application is centered around the interaction of 5 main objects:
- CSM
- Clerk
- Task
- Plan
- Message



## [IV].  Timelines

- We will have a code-freeze on May-27 at 09:55 EDT, 08:55 CDT 
- We will have a code-freeze on May-27 at 09:55 EDT, 08:55 CDT 

- We will have a code-freeze on May-27 at 09:55 EDT, 08:55 CDT 
  Try to implement as many requirements as you can.
  Whatever is working by then will have to be enough.
- Presentaion work will take place on May-27.
- We will present our project on May-28, starting at 9.30a Central, (10:30 EDT)


## [V]. Minimum Viable Product
- as an mvp (minimum viable product) status, the application should be able to
  - create at least one (1) CSM and one (1) Coutesy Clerk.
  - pair at least one (1) courtesy clerk for tasks.
  - at least assign a task schedule for one day.
  - at least show a courtesy clerk his scheduled tasks for the day.

  - at least have 10 total validation unit tests for Customer, Order, Pizza, Store

> The goal is to try to complete as many reqs as you can in the time alloted. :)
'Gook Luch, 
--"Mad Matt."
