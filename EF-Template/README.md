# Entity Framework
## Code First Usage Example

This is a brief example which shows how Entity Framework could be used in your project. 

Think about it only like about an example no rules only ideas.

To start using *Sample Project* you need to have on PC:
- *Microsoft SQL Server/Express 2008 R2* or higher with *Management Studio*
- Visual Studio 2013

Follow steps below:

1) In *Management Studio* create Database 'ORM'. Current system user should be an owner

2) On Visual Studio in Package Manager Console type command: 
```
Update-Database -project:ORM.DAL.Core -Force -Verbose
```
3) Run ORM.Web project