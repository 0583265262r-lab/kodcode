def create_grades_file(filename):
    students = [
                ("Dan", [85, 90, 78]),
                ("MOMO", [92, 88, 95]),
                ("Yoni", [70, 65, 80]),
                ("Avi", [100, 95, 98]),
                ("Sara", [60, 72, 68]),
                ]
    with open(filename, 'w') as f:
        for n in students:
            f.write(f'{n[0]}')
            for g in n[1]:
                f.write(f',{str(g)}')
            f.write('\n')
            
            
# create_grades_file("grades.txt")
# 
def calculate_averages(filename):
    grades={}
    with open(filename,"r") as f:
        lines=f.readlines()
        for l in lines:
            sumi=0
            count=0
            l.strip()
            l=l.split(",")
            for i in range(1,len(l)):
                count+=1
                i=l[i].strip()
                sumi += int(i)
            average= sumi/count
            grades[l[0]]=round(average,1)
    return grades
# print(calculate_averages("grades.txt"))
# 
def save_results(averages, output_filename):
    list_of_grades=[]
    with open(output_filename,"w") as of:
        of.write("=== Student Results === \n")
        for g in averages:
            list_of_grades.append([averages[g],g])
        a=sorted(list_of_grades,reverse=True)
        count=1
        for g in a:
            of.write(f"{count}. {g[1]}: {g[0]}\n")
            count+=1
# averages = calculate_averages('grades.txt')
# save_results(averages, 'results.txt')
# 
def statics(filename, data):
    ava_all=sum(data.values()) / len(data)
    high=max(data.values())
    s_high=""
    for s in data:
        if high == data[s]:
            s_high=s
    low=min(data.values())
    s_low=""
    for s in data:
        if low == data[s]:
            s_low=s
    count = 0
    students=len(data)
    for s in data:
        if data[s]>60:
            count+=1
    print(s_high,high)
    print(s_low,low)
    with open(filename,"a") as f:
        f.write("=== Statistics ===\n")
        f.write(f"Class average: {round(ava_all,1)}\n")
        f.write(f"highest: {s_high}({high})\n")
        f.write(f"lowest: {s_low}({low})\n")
        f.write(f"Passing (>=60): {count}/{students}\n")
averages = calculate_averages('grades.txt')
save_results(averages, 'results.txt')
statics('results.txt', averages)

    



            
        


            




