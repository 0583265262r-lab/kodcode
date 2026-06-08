from fastapi import FastAPI, HTTPException
from pydantic import BaseModel
import db 

app = FastAPI()

class SoldierIn(BaseModel):
    name: str
    rank: str
    unit: str

