import mysql.connector

def get_connection():
    return mysql.connector.connect(
                host="localhost",
                port=3306,
                user="root",
                password="secret",
                database="soldiers_db"
                )

def get_message_by_id(message_id: int) -> dict | None:
    conn = get_connection()
    cursor = conn.cursor(dictionary=True)
   
    sql = "SELECT * FROM intel_messages WHERE id = %s"
    cursor.execute(sql,(message_id,))
    message = cursor.fetchone()
    cursor.close()
    conn.close()
    return message

def create_message(unit: str, classification: str, content: str, source:str | None) -> int:
    conn = get_connection()
    cursor = conn.cursor()

    sql = "INSERT INTO intel_messages (unit,classification,content,source) VALUES (%s,%s,%s,%s)"
    values = (unit,classification,content,source)
    cursor.execute(sql,values)
    conn.commit()
    new_id = cursor.lastrowid
    cursor.close()
    conn.close()
    return new_id

def update_message(message_id: int, data: dict) -> bool:
    conn = get_connection()
    cursor = conn.cursor()
    
    set_parts = []
    for 






if __name__ == "__main__":
    print(create_message("8200","unclassified","iru","rhyr"))
    print(get_message_by_id(1))







