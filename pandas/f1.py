import pandas as pd
df = pd.read_csv("tracks.csv")
df.head()
# df.head(3)
# print(df.info())
# df.describe()
# df.shape
# print(df["speed"] )
# print(df[["id", "speed"]])
# print(df["speed"].mean())
# print(df["speed"].max())

data = {
    "id": ["T1", "T2", "T3"],
    "speed": [412, 95, 250],
    "heading": [120, 45, 270]
}

df = pd.DataFrame(data)
print(df) # מדפיס את כל הטבלה
print(df["speed"]) # מדפיס רק את עמודת המהירות