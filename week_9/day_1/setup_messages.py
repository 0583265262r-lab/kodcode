import mysql.connector

def get_connection():
    return mysql.connector.connect(
    host="localhost",
    port=3306,
    user="root",
    password="secret",
    database="soldiers_db"
    )
def create_schema():
    conn = get_connection()
    cursor = conn.cursor()
    create_table_sql = '''
    CREATE TABLE IF NOT EXISTS intel_messages (
    id INT PRIMARY KEY AUTO_INCREMENT,
    unit VARCHAR(100) NOT NULL,
    classification ENUM('unclassified','confidential','secret','top_secret'),
    content TEXT NOT NULL,
    source VARCHAR(100),
    created_at DATETIME DEFAULT NOW()
    )'''
    cursor.execute(create_table_sql)
    conn.commit()
    print("Table created successfully.")
    cursor.close()
    conn.close()

def get_schema(name) -> list:
    conn = get_connection()
    cursor = conn.cursor()
    cursor.execute(f"DESCRIBE {name}")
    rows = cursor.fetchall()
    cursor.close()
    conn.close()
    # each row is (Field, Type, Null, Key, Default, Extra)
    return [{"column": row[0], "type": row[1]} for row in rows]
    


if __name__ == "__main__":
    create_schema()


