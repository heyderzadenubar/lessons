/*Homework 3:
AdventureWorks2017 database'ində aşağıdakı məlumatları almaq üçün lazım olan select sorğularını yazın.
Store adlı table'dan bütün column'ları select edin.
Product adlı table'dan bütün column'ları select edin.
ProductCategory adlı table'dan sadəcə ProductCategoryID və Name column'larını select edin.
AddressType adlı table'dan sadəcə AddressTypeID və Name column'larını select edin.
Document adlı table'dan sadəcə Title, FileName, ChangeNumber və Status column'larını select edin.
*/
use AdventureWorks2017;  --ayrica elan etmek de olar

select * from AdventureWorks2017.Sales.Store;
select * from AdventureWorks2017.Production.Product;
select ProductCategoryID, Name from AdventureWorks2017.Production.ProductCategory;
select AddressTypeID, Name from AdventureWorks2017.Person.AddressType;
select Title, FileName, ChangeNumber, Status from AdventureWorks2017.Production.Document;

