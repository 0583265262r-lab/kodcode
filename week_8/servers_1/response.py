import requests
response = requests.get("http://127.0.0.1:8000/calc/5/add/15")
print(response.json())