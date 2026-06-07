from fastapi import FastAPI
import requests
# import uvicorn

app = FastAPI()

@app.get("/ping")
def read_root():
    return {"status": "pong"}

# @app.get("/greet/{name}")

# def return_name(name:str):
#     return  {"message": f"Hello,{name}!"}

# response = requests.get("http://localhost:8000/ping")
# print(response.json())

