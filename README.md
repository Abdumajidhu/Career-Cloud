# CareerCloud
This is a job search portal for job seekers and recruiters to connect on one common platform developed. The project written in C# and SQLServer.

## Technologies Used
ASP.Net, MVC, C#, MS SQL Server 2017, ADO.NET, Entity Framework, LINQ, REST WEB API, Git

## Project Architecture
POCOs Layer  
Repository Layer  
Business Logic Layer  
API Layer  
User Interface

### Project Architecture Description
● Designed and developed the POCOs layer of the project with data classes built using C#.  
● Developed interfaces and classes in the repository layer where each class uses ADO.Net to
perform CRUD operations on data objects.  
● Implemented repository layer classes with DML functionality to perform data opperations.  
● Implemented the main IDataRepository interface 


```bash
public interface IDataRepository<T>
    {
        IList<T> GetAll(params Expression<Func<T, object>>[] navigationProperties);
        IList<T> GetList(Expression<Func<T, bool>> where, params Expression<Func<T, object>>[] navigationProperties);
        T GetSingle(Expression<Func<T, bool>> where, params Expression<Func<T, object>>[] navigationProperties);
        void Add(params T[] items);
        void Update(params T[] items);
        void Remove(params T[] items);
        void CallStoredProc(string name, params Tuple<string, string>[] parameters);
    }
```

## Database  
A database of 19 tables based on SQL Server Database was used for this project.

```c#
# database used

SQL Server Management Studio 2018 (15.0.18118.0 – May 2019)
```

## License
[MIT](https://choosealicense.com/licenses/mit/)
