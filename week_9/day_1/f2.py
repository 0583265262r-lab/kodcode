from fastapi import FastAPI
from uvicorn import *
from pydantic import BaseModel


app =FastAPI()

@app.get("/")
def get_print():
    return "hello world"

class GetStr(BaseModel):
    get_str: str

@app.post("/printer")
def get_str(the_str:GetStr):
    return the_str.get_str









if __name__ == "__main__":
    run(app)