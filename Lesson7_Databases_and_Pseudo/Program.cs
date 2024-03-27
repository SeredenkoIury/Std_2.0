Console.Clear();
Console.WriteLine("Lesson7, Databases and Pseudo");
Console.WriteLine("");

========================================================= Theory with Pseudo Code

Select*from NameOfTheDataBase 
//where - Select - is to chose,
// * -  after select we shoudl choose raws and calums, * means to choose all of them
// From - means where we want to have the info and data
// NameOfTheDataBase - the name of our database

//For example in the task where we wanted to have the name info from OurDatabase, 
//phone number and the comment we could use this code in pseudo
Select Name, Phone number, comment
from OurDataBase

//For the other example  in the task where we wanted to have the name info from OurDatabase, 
//phone number and the comment of the single people. we could use this code in pseudo
Select Name, Phone number, comment
from OurDataBase
Where Status = "single"
// Status is the name of the column, single is the specific name on it

INNER JOIN Люди, телефоны
ON id = чей телефон
// сбор данных из разных таблиц посредством идентификатора