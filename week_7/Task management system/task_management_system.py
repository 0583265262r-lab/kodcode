# task= "1|pending|Leanne python files\n2|pending|Leanne python files\n3|pending|Leanne python files"
# tasks=task.split("\n")
# print(tasks)

def load_tasks(filename):
    list_of_tasks=[]
    try:
        with open (filename,"r") as f:

            for l in f:
                l=l.strip().split("|")
                list_of_tasks.append({"id":l[0],"status":l[1],"description":l[2]})
    except FileNotFoundError as e:
        print(f"file not exist {e}")
    return list_of_tasks
            
# print(load_tasks("tasks.txt"))
# 
def save_tasks(filename, tasks):
    with open(filename,"w") as f:
        tasks=tasks.split("\n")
        for item in tasks:
            f.write(f"{item}\n")
# save_tasks("tasks.txt",task)
# 
def add_task(filename,description):
    with open(filename,"r+") as f:
        lines=f.readlines()
        id=len(lines)+1
        f.write(f"\n{int(id)+1}|pending|{description}")
# add_task("tasks.txt","asd")
# 
def complete_task(filename, task_id):
    task_is_exist=False
    line=[]
    with open(filename,"r") as f:
        f=f.readlines()
        for l in f:
            l=l.strip().split("|")
            if int(l[0]) == task_id:
                l = f"{task_id}|done|{l[2]}"
                line.append(l)
                task_is_exist=True
                continue
            line.append(f"{l[0]}|{l[1]}|{l[2]}")
        with open(filename,"w") as f:
            for i in line:
                f.write(f"{i}\n")
        if not task_is_exist:
            print(f"the ID {task_id} not exist")
# complete_task("tasks.txt",2)
def list_tasks(filename):
    with open (filename,"r") as f:
        line=f.readlines()
        for l in line:
            l=l.strip().split("|")
            if l[1] == "done":
                print(f"{" ".join(l)} [✔️ ]")
            else:
                print(f"{" ".join(l)} [ ]")
# list_tasks("tasks.txt")

def main():
    FILENAME = "tasks.txt"
    while True:
        print('\n=== To-Do List Manager ===')
        print("1.show tasks ")
        print("2.add task ")
        print("3.mark complete task ")
        print("4.exit ")
        choice = input("please enter your choice: ")
        if choice == '1':
           list_tasks(FILENAME)
        elif choice == '2':
            desc = input("please enter a description: ")
            add_task(FILENAME, desc)
            print("task added")
        elif choice == '3':
            task_id = int(input("ID task: "))
            complete_task(FILENAME, task_id)
        elif choice == '4':
            print("goodby")
            break
        else:
            print("invalid choice")




if __name__ == '__main__':
    main()


            
        

            


        




     
