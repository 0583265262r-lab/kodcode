import requests
# # Send a GET request to a public test API
# response = requests.get("https://jsonplaceholder.typicode.com/posts/1")


# print(response.status_code) # 200
# print(response.json()) # returns a Python dict parsed from JSON
# print(response.text) # returns the raw response as a string



# # Access specific fields
# data = response.json()
# print(data["title"]) # the post title
# print(data["userId"]) # the user who wrote it

# import requests
# new_post = {
# "title": "My First Post",
# "body": "This is the content",
# "userId": 1
# }
# response = requests.post("https://jsonplaceholder.typicode.com/posts",
# json=new_post # json= serializes the dict and sets ContentType header
# )
# print(response.status_code) # 201 Created
# print(response.json()) # the created object, usually with a new id


# update = {"id":1,"title":"new title","body":"new content","userid":1}

# r = requests.put("https://jsonplaceholder.typicode.com/posts/1",json=update)
# print(r.status_code
#       )

# r = requests.delete("https://jsonplaceholder.typicode.com/posts/1")
# print(r.status_code)




# params = {"userId": 1}
# response = requests.get(
# "https://jsonplaceholder.typicode.com/posts",
# params=params # becomes: /posts?userId=1
# )
# posts = response.json()
# print(f"Found {len(posts)} posts for user 1")
# for post in posts[:3]: # print first 3
#     print(f" - {post['title']}")


# response = requests.get("https://jsonplaceholder.typicode.com/posts/1")
# if response.status_code == 200:
#     print("Got data:", response.json())
# elif response.status_code == 404:
#     print("Not found")
# else:
#     print(f"Unexpected status: {response.status_code}")


