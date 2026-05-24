# חלק א
with open("diary.txt","w",encoding="utf-8") as f:
    f.write("15-01-2026: was bassy day \n16-01-2026: I study about file handling in python \n17-01-2026: completed first task")
    print("the diary successfully created")
with open("diary.txt","r",encoding="utf-8") as f:
    file=f.read()
    print(file)
# חלק ב
def add_entry(filename, date, content):
    with open(filename,"a",encoding="utf-8") as f:
        f.write(f"{date}: {content}")
add_entry("diary.txt","\n18-01-2026","what a nice day")
# חלק ג
def search_diary(filename, keyword):
    list_lins=[]
    with open(filename,"r",encoding="utf-8") as f:
        # line=f.readlines()
        for l in f:
            if keyword in l:
                list_lins.append(l.strip())
    return list_lins
print(search_diary("diary.txt","day"))
# בונוס
def safe_read_diary(filename):
    try:
        with open(filename) as f:
            f.read()
    except FileNotFoundError as e:
        print(f"file not exist {e}")
