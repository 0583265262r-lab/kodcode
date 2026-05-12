# שאלה 1
# def is_even(n):
#     if n%2 ==0:
#         return True
#     else:
#         return False
# print(is_even(5))
# שאלה 2
# def factorial(n):
#     multi=1
#     for i in range(1,n+1):
#         multi*=i
#     return multi
# print(factorial(4))    
# שאלה 3
# def is_palindrome(s):
#     p=s[::-1]
#     if p==s:
#         return True
#     else:
#         return False
# print(is_palindrome("tas"))
# שאלה 4
# def sum_digits(n):
#     number1=0
#     while n!=0:
#         digit=n%10
#         number1+=digit
#         n=n//10
#         # print(number1)
#     while number1>=10:
#         x=sum_digits1(number1)
#         number1=x
#         if x<10:
#            return x
#     return number1
# def sum_digits1(n):
#     number1=0
#     while n!=0:
#         digit=n%10
#         number1+=digit
#         n=n//10
#     return number1
# print(sum_digits(99995))
# שאלה 5
# def count_digits(n):
#     count=0
#     while n!=0:
#         count+=1
#         n=n//10
#     return count
# print(count_digits(1))
# שאלה 6
# def reverse_integer(n):
#     number1=0
#     while n!=0:
#         number1*=10
#         digit=n%10
#         number1+=digit
#         n=n//10
#     return number1
# print(reverse_integer(7100))
# שאלה 7
# def move_zero_to_the_end(arr):
#     len_arr=len(arr)
#     count=0
#     while len_arr-1!=0:
#         if arr[count]==0:
#             x=arr.pop(count)
#             arr.append(x)
#             count-=1
#         count+=1
#         len_arr-=1
#     return arr
# print(move_zero_to_the_end([1,2,3,0,0,4]))
# שאלה 8
# def stat(listi):
#     return sum(listi),max(listi),min(listi),sum(listi)/len(listi)
# שאלה 9
# def reversi(listi):
#     for i in range(len(listi)-1):
#         x=listi.pop()
#         listi.insert(i,x)
#     return listi
# print(reversi([1, 2, 3, 4, 5]))
# שאלה 10
# def list_order(listi):
#     listi1=[]
#     for i in listi:
#         if i in listi1:
#             continue
#         else:
#             listi1.append(i)
#     return listi1
# print(list_order([3, 1, 4, 1, 5, 9, 2, 6, 5, 3]))


    







