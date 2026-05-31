from fastapi import FastAPI

app = FastAPI()

@app.get("/calc/{a}/{op}/{b}")
def result(a,op,b):
    
    try:
        a=int(a)
        b=int(b)
        if op == "add": 
            return {"operation": f"{op}", "result": f"{a+b}"}
        if op == "sub":
            return {"operation": f"{op}", "result": f"{a-b}"} 
        if op == "mul":
            return {"operation": f"{op}", "result": f"{a*b}"}
        if op == "div":
            try:
                return {"operation": f"{op}", "result": f"{a/b}"}
            except ZeroDivisionError as e:
                print(f"{e}")
            
    except ValueError as e:
        print (f"non integer as {e}")
    
       
    