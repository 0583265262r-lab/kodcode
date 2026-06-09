from fastapi import FastAPI, HTTPException
import uvicorn
import queries

app = FastAPI()

@app.get("/soldiers")
def filter_by_query_prams(rank=None, sort=None, unit=None):
    response = []
    if rank:
        response.append({"rank":queries.get_by_rank(rank)})
    if sort:
        response.append({"active_sorted":queries.get_active_sorted_by_name(sort)})
    if unit:
        response.append({"unit":queries.get_by_unit(unit)})
    if not response:
        return queries.get_all_soldiers_sorted_by_id()

    return response

@app.get("/soldiers/units")
def distinct_unit_names():
    distinct_unit = queries.get_distinct_units()
    return distinct_unit

@app.get("/soldiers/search")
def search_name_by_like(term):
    if queries.search_by_name(term):
        return queries.search_by_name(term)
    else:
        raise HTTPException(status_code=404,detail="not found")



if __name__ == "__main__":
    uvicorn.run(app="main:app",reload=True)
