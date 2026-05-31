from fastapi import FastAPI
import datetime

app = FastAPI()
@app.get("/status")
def information():
     return (f"time:{datetime.datetime.now()} server_name:avi")