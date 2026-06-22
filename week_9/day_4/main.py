from fastapi import FastAPI, HTTPException
from aggregation import * 
import uvicorn
# import reports
app = FastAPI()

@app.get("/stats/summary")
def stats_summary():
    return get_summary()

@app.get("/stats/units")
def list_count_units():
    return count_by_unit()

@app.get("/stats/understaffed")
def units_with_multiple_soldiers():
    return get_units_with_multiple_soldiers()

@app.get("/soldiers/missing-rank")
def missing_rank():
    return get_missing_data()





if __name__ == "__main__":
    uvicorn.run(app="main:app",reload=True)

