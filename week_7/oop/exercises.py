# 1
# class Dog:
#     def __init__(self,name):
#         self.name=name
        
#     def bark(self):
#         return f"{self.name} says woof"
# d1=Dog("Rex")
# print(d1.bark())
# 2
# class Rectangle:
#     def __init__(self,width,height):
#         self.width=width
#         self.height=height
#     def area(self):
#         return self.width * self.height
# r1=Rectangle(3,4)
# print(r1.area())
# 3
# class Counter:
#     counter=0
#     def __init__(self):
#         pass
#     def increment(self):
#         Counter.counter+=1
#     def value(self):
#         print(Counter.counter)
# c1=Counter()
# c1.increment()
# c1.increment()
# c1.value()
# 4
# class Point:
#     def __init__(self,a,b):
#         self.a=a
#         self.b=b
#     def __str__(self):
#         return f"{self.a},{self.b}"
# p1=Point(1,2)
# print(p1)
# 5
# class BankAccount:
#     balance=0
#     def __init__(self):
#         pass
#     def deposit(self,amount):
#         BankAccount.balance+=amount       
#     def withdraw(self,amount):
#         if amount < BankAccount.balance:
#             BankAccount.balance-=amount
# b1=BankAccount()
# print(b1.balance)
# b1.deposit(254)
# print(b1.balance)
# b1.withdraw(134)
# print(b1.balance)
# 6
# class Temperature:
#     def __init__(self,celsius):
#         self.celsius = celsius
#     def to_fahrenheit(self):
#         return (self.celsius * 1.8) + 32
# t1=Temperature(100)
# print(t1.to_fahrenheit())
# 7
# class Student:
#     def __init__(self,name,school = "Kodcode"):
#         self.name = name
#         self.school = school
# s1=Student("avi")
# s2=Student("david")
# print(s1.name,s1.school)
# print(s2.name,s2.school)
# 8
# class Player:
#     counter=0
#     def __init__(self):
#         Player.counter+=1
# p1=Player()
# p2=Player()
# p3=Player()
# print(p3.counter)
# 9
# class Money:
#     def __init__(self,amount):
#         self.amount=amount

#     def is_more_than(self,other):
#         return other.amount > self.amount
# m1=Money(10)
# m2=Money(15)
# print(m1.is_more_than(m2))
# 10
# class Playlist:
#     def __init__(self,songs):
#         self.songs = songs
#     def add(self,title):
#         self.songs.append(title)
#     def remove(self,title):
#         self.songs.remove(title)
#         return self.songs
#     def count(self):
#         return len(self.songs)
#     def __str__(self):
#         return f"{self.songs}"
    

    





        
        





