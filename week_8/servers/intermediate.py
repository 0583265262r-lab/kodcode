from fastapi import FastAPI
import uvicorn

app = FastAPI()

@app.get("/users/admin")
def admin():
    return {"role": "admin", "access": "full"}

@app.get("/")
def read_root():
    return {"service":"my-api","version":"1.0"}

@app.get("/users/{user_id}")
def get_user_id(user_id):
    return {"id":f"{user_id}","name":"avi","email":"moshe"}































