import json

DATA_FILE = "data.json" 

def load_data()->dict:
    try:
        with open(DATA_FILE,"r",encoding="utf-8") as f:
            return json.load(f)
    except FileNotFoundError:
        return {}

def save_data(data:dict) -> None:
    with open(DATA_FILE,"w",encoding="utf-8") as f:
        json.dump(data,f,ensure_ascii=False,indent=2)
