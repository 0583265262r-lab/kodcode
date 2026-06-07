from fastapi import FastAPI

app = FastAPI()
grades = {"1":{"name":"Moshe","grade":88},
          "2":{"name":"Avi","grade":98},
          "3":{"name":"David","grade":77},
          "4":{"name":"Aharon","grade":100}
           }

@app.get("/students")
def grade():
    return grades

@app.get("/students/top")
def grade():
    high = 0
    top_student={}
    for student in grades:
        if grades[student]["grade"] > high:
            high = grades[student]["grade"]
            top_student = grades[student]
    return top_student

@app.get("/students/average")
def grade():
    count = 0
    average = 0
    for student in grades:
        average += grades[student]["grade"]
        count +=1

    return average / count


@app.get("/students/count")
def grade():
    count = 0
    
    for student in grades:
        
        count +=1
    return count

@app.get("/students/{student_id}")
def grade(student_id):
    return grades[student_id]


