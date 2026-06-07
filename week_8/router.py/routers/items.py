from fastapi import APIRouter, HTTPException
from storage import load_data,save_data

router = APIRouter()

@router.get("/items")
def get_all():
    data = load_data()
    return data

@router.get("/items/{item_id}")
def get_one(item_id: str):
    data = load_data()
    if item_id not in data:
        raise HTTPException(status_code=404, detail="Item not found")
    return {"id": item_id, **data[item_id]}
@router.post("/items/{item_id}")
def create(item_id: str, body: dict):
    data = load_data()
    if item_id in data:
        raise HTTPException(status_code=409, detail="Item already exists")
    data[item_id] = body
    save_data(data)
    return {"id": item_id, **body}