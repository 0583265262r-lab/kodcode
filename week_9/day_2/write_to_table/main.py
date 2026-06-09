from fastapi import FastAPI, HTTPException
from pydantic import BaseModel
import db1
import uvicorn
app = FastAPI()

class SoldierIn(BaseModel):
    name: str 
    soldier_rank: None 
    unit: None


@app.get("/soldiers")
def get_all_soldiers():
    return {"soldiers":db1.get_all()}

@app.get("/soldiers/{soldier_id}")
def get_soldier_by_id(soldier_id:int):
    soldier = db1.get_by_id(soldier_id)
    if not soldier:
        raise HTTPException(status_code=404,detail="soldier not found")
    return soldier

@app.post("/soldiers")
def add_soldier(body:SoldierIn):
    new_soldier = db1.create(body.name,body.soldier_rank,body.unit)
    return {"new_soldier_id":new_soldier}

@app.put("/soldiers/{soldier_id}")
def edit_soldier(soldier_id,data):
    success_update_soldier= db1.update(soldier_id,data)
    if not success_update_soldier:
        raise HTTPException(status_code=404,detail="soldier not found")
    return f"update soldier {success_update_soldier}"

@app.delete("/soldiers/{soldier_id}")
def delete_soldier(soldier_id):
    success_delete_soldier = db1.delete(soldier_id)
    if not success_delete_soldier:
        raise HTTPException(status_code=404,detail="soldier not found")
    return f"deleted soldier {success_delete_soldier}"

if __name__ == "__main__":
    uvicorn.run(app="main:app",reload=True)








    

