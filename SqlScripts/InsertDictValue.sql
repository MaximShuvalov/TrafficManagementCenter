insert into public."ClassAppeal" ("Name") values ('�����������');

insert into public."ClassAppeal" ("Name") values ('���������');

insert into public."ClassAppeal" ("Name") values ('������');

insert into public."TypeAppeal" ("Name") values ('��������');

insert into public."TypeAppeal" ("Name") values ('�������');

insert into public."TypeAppeal" ("Name") values ('��������');

insert into public."SubtypeAppeals" ("Name","TypesId") values
('Item1', (select t1."Key" from public."TypeAppeal" t1 where t1."Name" = '��������'));

insert into public."SubtypeAppeals" ("Name","TypesId") values
('Item2', (select t1."Key" from public."TypeAppeal" t1 where t1."Name" = '��������'));

insert into public."SubtypeAppeals" ("Name","TypesId") values
('Item3', (select t1."Key" from public."TypeAppeal" t1 where t1."Name" = '��������'));

insert into public."SubtypeAppeals" ("Name","TypesId") values
('Item1', (select t1."Key" from public."TypeAppeal" t1 where t1."Name" = '��������'));

insert into public."SubtypeAppeals" ("Name","TypesId") values
('Item2', (select t1."Key" from public."TypeAppeal" t1 where t1."Name" = '��������'));

insert into public."SubtypeAppeals" ("Name","TypesId") values
('Item3', (select t1."Key" from public."TypeAppeal" t1 where t1."Name" = '��������'));

insert into public."SubtypeAppeals" ("Name","TypesId") values
('Item1', (select t1."Key" from public."TypeAppeal" t1 where t1."Name" = '�������'));

insert into public."SubtypeAppeals" ("Name","TypesId") values
('Item2', (select t1."Key" from public."TypeAppeal" t1 where t1."Name" = '�������'));

insert into public."SubtypeAppeals" ("Name","TypesId") values
('Item3', (select t1."Key" from public."TypeAppeal" t1 where t1."Name" = '�������'));