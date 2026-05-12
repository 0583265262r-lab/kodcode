# שאלה 1
# for i in range(1,11):
#     if i == 7:
#         break
#     if i%2==0:
#         continue
#     else:
#         print(i)
# שאלה 2
# while True:
#     password=int(input("please enter password: "))
#     saved_password=1234
#     if password == saved_password:
#         print("Welcome!")
#         break
#     else:
#         print("try again")
# שאלה 3
# producti=""
# arr=[]
# while producti != "done":
#     product= input("please enetr product: ")
#     if product=="done":
#         producti=product
#     if product!= "done":
#        arr.append(product)
# print(arr)
# שאלה 4
# for i in range (1,4):

#     for j in range(1,4):
#         print(i,j)
#         if j == 2:
#             break
# שאלה 5
# string=input()
# vowle=["A","a","E","e","I","i","O","o","U","u"]
# conut=0
# for i in string:
#     if i in vowle:
#         conut+=1
# print(conut)
# שאלה 6
# for i in range(1,6):
#     for j in range(1,6):
#         print(f"{i}*{j}={i*j}")
# שאלה 7
# string=input()
# string1=""
# for i in range(len(string)):
#     string1+=string[len(string)-i-1]
# print(string1)
# שאלה 8
# num= int(input())
# str_num=str(num)
# count=0
# for i in range(len(str(num))):
#     num1=int(str_num[i])
#     if num1%2==0:
#         count +=1
# print (count)
# שאלה 9
# string=input()
# string1=""
# for i in string:
#     string1+=i*2
# print(string1)
# שאלה 10 
# stop=1
# big_num=0
# while stop != 0:
#     num=int(input())
#     stop=num
#     if num >big_num:
#         big_num=num
# print(big_num)
# שאלה 11
# string=input()
# booli=True
# for i in string:
#     if i.isalpha() or i.isdigit():
#         continue
#     else:
#         booli=False
# print(booli)
# שאלה 12
number=int(input("enter number "))
number1=0
while number!=0:
    number1*=10
    digit=number%10
    number1+=digit
    number=number//10
print(number1)





    


    














