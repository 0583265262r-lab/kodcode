# תרגיל 1
# def sum_of_list(arr):
#     sumi=0
#     for i in arr:
#         sumi+=i
#     return sumi
# print(sum_of_list( [1, 2, 3, 4, 5]))
# תרגיל 2
# def maximum(arr):
#     max_num=0
#     for i in arr:
#         if i> max_num:
#             max_num=i
#     return max_num
# print(maximum( [3, 7, 2, 8, 5]))
# תרגיל 3
# def count_num(arr,num):
#     count=0
#     for i in arr:
#         if i== num:
#             count+=1
#     return (count,num)
# print(count_num( [1, 2, 3, 2, 4, 2],2))
# תרגיל 4
# def reverse(arr):
#     rvs_listi=[]
#     for i in arr:
#         rvs_listi.insert(0,i)
#     return rvs_listi
# print(reverse( [1, 2, 3, 4]))
# תרגיל 5
# def remove_duplicate(arr):
#     new_list=[]
#     for i in arr:
#         if i not in new_list:
#             new_list.append(i)
#     return new_list
# print(remove_duplicate( [1, 2, 2, 3, 1, 4, 3] ))
# תרגיל 6
# def second_largest(arr):
#     new_lst=sorted(set(arr))
#     if len(new_lst)>1:
#         return new_lst[-2]
#     else:
#         return None
# print(second_largest([10, 10, 10] ))
# תרגיל 7
# def merge_to_sorted_lst(lst1,lst2):
#     new_lst=lst1+lst2
#     return sorted(new_lst)
# print(merge_to_sorted_lst([1, 3, 5], [2, 4, 6] ))
# תרגיל 8
# def rotate_a_lst(lst,k):
#     new_lst=[]
#     if k > len(lst):
#         k = k % len(lst)
#     for i in range(len(lst)):
#         new_lst.append(lst[-k+i])
#     return new_lst
# print(rotate_a_lst( [1, 2, 3, 4, 5],1))















