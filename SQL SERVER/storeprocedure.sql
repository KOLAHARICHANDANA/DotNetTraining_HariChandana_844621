
Use Northwind;
Create Procedure GetCustomersByCountry
(@country varchar(30))
As
Select CustomerID,ContactName,CompanyName,Address,Country from Customers Where Country = @country; 
Go

Execute GetCustomersByCountry 'USA';
Create Procedure GetProductsByCategoryID
(@categoryID int)
As
Select P.ProductID,P.ProductName,P.UnitPrice,P.QuantityPerUnit,C.CategoryID,C.CategoryName from Products p INNER JOIN Categories c ON p.CategoryID =c.CategoryID AND c.CategoryID=@categoryID;
Execute GetProductsByCategoryID '5';

--Declaring Local variables
Declare @country as varchar(30);
Set @country = 'France';
Select * from Customers Where Country = @country;


 Alter Procedure GetTotalOrdersByDates
(@date1 date,@date2 date,@countOrder int output)
As
Select @countOrder = Count(OrderID) from Orders Where OrderDate Between @date1 And @date2;
Go


Declare @count as int;
Declare @date1 as date, @date2 as date;
Set @date1 = '01/01/1990';
Set @date2 = '12/31/1998';

Execute GetTotalOrdersByDates @date1,@date2,@count output;

Print 'Total number of orders placed:'+ Convert(varchar(10),@count);
Print GetDate();
Select * from Orders;
--Creating functions
--by default this function is stored inside the default schema known as 'dbo' which stands for database owner
Create function Multiply(@n1 int,@n2 int)
Returns bigint
As
Begin
Declare @prod as bigint;
Set @prod = @n1*@n2;
Return @prod;
End
Select dbo.Multiply(50,80) as Product;
--Table valued function
Create function GetCustomers(@country varchar(30)) Returns Table
As
 Return Select * from Customers Where Country = @country;
 Go
 Select  * from dbo.GetCustomers('Germany');
 Create function GetAllProductsByCategoryID(@categoryID int) Returns Table
 As
 Return Select  P.ProductID,P.ProductName,P.UnitPrice,P.QuantityPerUnit,C.CategoryID,C.CategoryName from Products p INNER JOIN Categories c ON p.CategoryID =c.CategoryID AND c.CategoryID=@categoryID;
 Select * from dbo.GetAllProductsByCategoryID(5);



 --subqueries
 Select ProductID,ProductName,UnitPrice,QuantityPerUnit,CategoryID from Products Where UnitPrice>(Select AVG(UnitPrice) from Products)Order By UnitPrice;
 Select * from Orders;
 Select OrderID,CustomerID,EmployeeID,OrderDate,ShippedDate from Orders Where OrderID =(Select OrderID from Orders Where EmployeeID=5 AND CustomerID='VINET'); 
---cORRELATED SUBQUERIES
---a CORRELATED SUBQUERY DOESNT RETURN ANY DATA BACK TO MAIN QUERY.BUT IT ALWAYS RETURNS A BOOLEAN VALUE OF TRUE OR FALSE AND ACCORDINGLY THE MAI QUERY GETS EXECUTED IF IT RECEIVES A BOOLEAN VALUE OF TRUE.OTHERWISE THE MAIN QUERY WILL NOT BE EXECUTED.
----tHESE CORRELATED SUBQUERIES MAKE USE OF EXISTS or NOT EXISTS operators as a part of main query

Select CustomerID,CompanyName,Address,Country from Customers Where  EXISTS(Select ContactName from Customers Where Country in ('UK', 'USA'));
Select CustomerID,CompanyName,Address,Country from Customers Where NOT EXISTS(Select ContactName from Customers Where Country ='Russia');
