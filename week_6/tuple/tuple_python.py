# תרגיל 1
# def sum_num(tup):
#     sumi=0
#     for i in tup:
#         sumi+=i
#     return sumi
# print(sum_num( (1, 2, 3, 4, 5)))
# תרגיל 2
# def maximom(tup):
#     maxi=0
#     for i in tup:
#         if i >maxi:
#             maxi=i
#     return maxi
# print(maximom( (3, 7, 2, 8, 5)))
# תרגיל 3
# def count_digit(tup,value):
#     counter=0
#     for i in tup:     
#         if i == value:
#             counter+=1
#     return counter
# print(count_digit((1, 2, 3, 2, 4, 2),2))
# 4
# def revers_tup(tup):
#     new_tup=[]
#     for i in tup:
#         new_tup.insert(0,i)
#     return tuple(new_tup)
# print(revers_tup( (1, 2, 3, 4)))
# 5
# def swap_pairs(tup):
#     new_tup=[]
#     for i in range(len(tup)):
#         if i % 2 == 0:
#             new_tup.append(tup[i])
#         else:
#             new_tup.insert(i-1,tup[i])
#     return tuple(new_tup)
# print(swap_pairs( (1, 2, 3, 4, 5, 6) ))
# 6
# def get_min_and_max(tup):
#     maxi=0
#     mini=0
#     for i in range(len(tup)):
#        if i ==0:
#            maxi=tup[i]
#            mini=tup[i]
#        if tup[i] > maxi:
#            maxi=tup[i]
#        if tup[i] < mini:
#            mini =tup[i]
#     return (mini,maxi)
# print(get_min_and_max( (4, 1, 7, 3, 5)))
# 7
# def distance_between_points(tp1, tp2):
#     return (((tp2[0] - tp1[1])**  2) + ((tp2[1] - tp1[0]) ** 2)) ** 0.5
# print(distance_between_points((0, 0), (3, 4)))
# 8
# def marge_tup(tup1,tup2):
#     new_tup = tup1 + tup2
#     new_tup=sorted(list(new_tup))
#     return tuple(new_tup)
# print (marge_tup( (3, 1, 4), (1, 5, 9) ))
# 9
# def count_chars(tup):
#     new_dict={}
#     for i in tup:
#         if i in new_dict:
#             new_dict[i]+=1
#         else:
#             new_dict[i]=1
#     return tuple(new_dict.items())
# print(count_chars( ("a", "b", "a", "c", "b", "a") ))
# 10
# def rotate_a_lst(tup,k):
#     new_lst=[]
#     if k > len(tup):
#         k = k % len(tup)
#     for i in range(len(tup)):
#         new_lst.append(tup[-k+i])
#     return tuple(new_lst)
# print(rotate_a_lst( (1, 2, 3, 4, 5) ,2))



