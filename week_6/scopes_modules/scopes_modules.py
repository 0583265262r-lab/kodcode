# 1
# counter=0
# def bump():
#    global counter
#    counter +=1
# def value():
#    return counter

# bump()
# bump()
# bump()
# c= value()
# print(c)
# 2
# def make_counter():
#     n = 0
#     def count():
#         nonlocal n
#         n += 1
#         return n
#     return count
# c = make_counter()
# print(c)
# print(c)
# print(c)
# 3
# x = "global"
# def outer():
#    x = "enclosing"
#    def inner():
#        x = "local"
#        print(x)
#    inner()
#    print(x)
# outer()
# print(x)
# 4
# list1 = [1, 2, 3]
# print(list(range(5)))
# הbuilt in כי בקוד הראשוני לפני התיקון השם משתנה דורס את 
# 5
# import mathutils
# print(mathutils.square(5))
# print(mathutils.cube(3))
# 
# from mathutils import square,cube
# print(square(5))
# print(cube(3))
# 6
# import tools
# 7
# from datetime import datetime as dt
# print(dt.now())
# 8
# import math
# def public_names(m):
#     return sorted([name for name in dir(m) if not name.startswith('_')])
# print(public_names(math))
# 9
# def add_item(item, bag=[]):
#     # שינוי
#     if not bag:
#         bag=[]
#     # 
#     bag.append(item)
#     return bag
# print(add_item("a"))
# print(add_item("b",[1,2]))
# 10
# import geometry.circle as circle
# import geometry.rectangle as rectangle
# print(circle.area(5))
# print(rectangle.area(4,6))





