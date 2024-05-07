--последнее время на Postgre пишу запросы, но думаю, что на SQL Server синтаксис плюс-минус такой же

select p.Name, c.Name from products p
left join category c on p.CategoryId = c.Id

