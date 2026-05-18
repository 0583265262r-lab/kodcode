# 1
# def sum_digit(dct):
#     sumi=0
#     for i in dct:
#         sumi+=dct[i]
#     return sumi
# print(sum_digit( {"a": 1, "b": 2, "c": 3}))
# 2
# def max_digit(dct):
#     maxi=""
#     max1=0

#     for i in dct:
#         if dct[i]> max1:
#            max1=dct[i]
#            maxi=i
#     return maxi
# print (max_digit( {"a": 3, "b": 7, "c": 5}))
# 3
# def count_chars(text):
#     new_dict={}
#     for i in text:
#         if i in new_dict:
#             new_dict[i]+=1
#         else:
#             new_dict[i]=1
#     return new_dict
# print(count_chars( "banana"))
# 4
# def swap_key_and_value(dct):
#      new_dict={}
#      for i in dct:
#           new_dict[dct[i]]=i
#      return new_dict
# print(swap_key_and_value( {"a": 1, "b": 2, "c": 3}))
# 5
# def merge_two_dict(dct1,dct2):
#     for i in dct2:
#         dct1[i]=dct2[i]
#     return dct1
# print(merge_two_dict( {"a": 1, "b": 2}, {"b": 20, "c": 30}))
# 6
# def filter_by_value(dct,value):
#     new_dict={}
#     for i in dct:
#         if dct[i]>value:
#             new_dict[i]=dct[i]
#     return new_dict
# print(filter_by_value( {"a": 1, "b": 5, "c": 3, "d": 8},3))
# 7
# def grop_by_first_letter(lst):
#     new_dict={}
#     for i in lst:
#         if i[0] in new_dict:
#             new_dict[i[0]].append(i)
#         else:
#             new_dict[i[0]]=[i]
#     return new_dict
# print(grop_by_first_letter(["apple", "ant", "banana", "berry", "cherry"]))
# 8
# def count_words(text):
#     text=text.split()
#     new_dict={}
#     for i in text:
#         if i in new_dict:
#             new_dict[i]+=1
#         else:
#             new_dict[i]=1

#     return new_dict
# print(count_words("the cat sat on the mat" ))
# 9
# def commen_keys(dct1,dct2):
#     lst=list(dct1)+list(dct2)
#     lst1=[]
#     for i in lst:
#         if lst.count(i)>1:
#             lst1.append(i)
#     return list(set(lst1))
# print(commen_keys( {"a": 1, "b": 2, "c": 3}, {"b": 9, "c": 8, "d": 7} ))
# 10
# def most_commen_value(dct):
#     new_dict={}
#     for i in dct:
#         if dct[i] in new_dict:
#             new_dict[dct[i]]+=1
#         else:
#             new_dict[dct[i]]=1
#     return max(new_dict,key=new_dict.get)
# print(most_commen_value( {"a": 1, "b": 2, "c": 1, "d": 3, "e": 1} ))


    



