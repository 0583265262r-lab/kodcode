from fastapi import FastAPI
import uvicorn
import db
import setup_messages
app = FastAPI()
@app.post("/setup")
def run_setup():
# In real code this would call setup logic
# For now just confirm
    return {"status": "setup triggered"}
@app.get("/soldiers_db/{table_name}")
def get_schema(table_name:str):
    columns = setup_messages.get_schema(table_name)
    return {"columns": columns}
@app.get("/soldiers")
def get_all_soldiers():
    return {"soldiers": []}

@app.post("/intel_messages")
def create_schema():
    setup_messages.create_schema()
    return "Table created successfully."

@app.get("/messages")
def get_all_messages():
    return {"messages": []}


if __name__ == "__main__":
    uvicorn.run(app)