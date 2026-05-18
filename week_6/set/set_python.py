# 1
# def remove_duplicates(lst):
#     return set(lst)
# print (remove_duplicates([1, 2, 2, 3, 1, 4, 3] ))
# 2
# def count_unique(lst):
#     new_lst=[]
#     for i in lst:
#         if i not in new_lst:
#             new_lst.append(i)
#     return len(new_lst)
# print(count_unique( [1, 2, 2, 3, 1, 4] ))
# 3
# def common_elements(lst1,lst2):
#     return list(set(lst1)&set(lst2))
# print(common_elements( [1, 2, 3, 4], [3, 4, 5, 6] ))
# 4
# def elements_in_only_one(lst1,lst2):
#     return list(set(lst1)^set(lst2))
# print(elements_in_only_one([1, 2, 3, 4], [3, 4, 5, 6]))
# 5
# def is_subset(lst1,lst2):
#     counter=0
#     for i in lst1:
#         if i not in lst2:
#             counter+=1
#     return counter ==0
# print(is_subset( [1, 2, 6], [1, 2, 3, 4, 5]))
# 6
# def unique_characters(text):
#     for i in text:
#         if text.count(i)>  1:
#             return False
#     return True
# print(unique_characters("hello"))
# 7
# def first_repeated_element(lst):
#     for i in lst:
#         if lst.count(i)>1:
#             return i
#     return None
# print(first_repeated_element([1, 2, 3,4 ] ))
# 8
# def distinct_word(text):
#     text=text.lower()
#     return len(set(text.split()))
# print(distinct_word( "The cat and the dog and the bird"))
# 9
# def pair_sum(lst,target):
#     seti=set(lst)
#     for i in lst:
#         if seti.add(target - i):
#             return True
#     return False
# print(pair_sum( [3, 1, 4,5],10))
# 10
# def elements_in_only_one(lst1,lst2):
#     lst=lst1+lst2
#     new_lst=[]
#     for i in lst:
#         if lst.count(i)==1:
#             new_lst.append(i)
#     return new_lst
# print(elements_in_only_one([1, 2, 3, 4], [3, 4, 5, 6]))







