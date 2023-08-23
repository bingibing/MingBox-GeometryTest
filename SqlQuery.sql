create table category (
   id int IDENTITY(1,1) primary key,
   name varchar(50) not null
);

insert INTO category (name) VALUES
  ('Напитки'),
  ('Хлебобулочные изделия'),
  ('Хозяйственные товары')

create table product (
  id int IDENTITY(1,1) PRIMARY KEY,
  name varchar(50) not null,
  id_category int not null
);

INSERT into product (name, id_category) values
  ('Mountain Dew', 1),
  ('Coca-Cola', 1),
  ('Слойка с сыром', 2),
  ('Средство для мытья посуды', 3),
  ('баллистическая ракета', 0)

select p.Name, c.Name from product as p
  left join category as c ON p.id_category = c.id;