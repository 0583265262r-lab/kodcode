import random
# תרגיל 1
# def safe_int(s):
#     try:
#         intiger=int(s)
#         return intiger
#     except ValueError:
#         return None

# תרגיל 2 
# def safe_divide(a, b):
#     try:
#         return a/b
#     except ZeroDivisionError:
#         return "undefined"
# תרגיל 3
# def get_value(d, key):
#     try:
#         return d[key]
#     except KeyError:
#         return "missing"
# print(get_value({"s":4},"a"))
# תרגיל 4
# def parse_ints(values):
#     int_list=[]
#     for i in values:
#         try:
#             int_list.append(int(i))
#         except ValueError:
#             continue
#     return int_list
# print(parse_ints( ["1", "2", "x", "3", "y"]))
# תרגיל 5
# def set_age(age):
#     if  age <0 or age >150:
#        raise ValueError
#     return age
# תרגיל 6
# def func():
#     arr =[2,0]

#     return 10/random.choice(arr)

# lst_funcs=[func for i in range(5)]
# def retry(func, n):
#     while n>0:
#         n-=1
#         try:
#             return func()
#         except Exception:
#             if n == 0:
#                 raise

# print(retry(func,6))
# תרגיל 7
# def count_errors(funcs):
#     count=0
#     for f in funcs:
#         try:
#             f()
#         except:
#             count+=1
#     return count
# print(count_errors(lst_funcs))
# תרגיל 8 
# def load_config(path):
#     with open(path,"r") as p:
#         try:
            
#             first_line=p.readline()
#             return int(first_line.strip())
                
#         except Exception as e:
#             raise RuntimeError("failed to load config") from e

# print(load_config("exception.txt"))





