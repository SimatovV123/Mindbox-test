select p.Name as Product, c.Name as Category
from Products p
left join ProductCats pc
on pc.ProductId = p.Id
left join Categories c
on c.Id = pc.CategoryId
group by p.Name, c.Name