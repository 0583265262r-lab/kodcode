import mysql.connector
from db1 import get_connection
def create_table():
    conn = get_connection()
    cursor = conn.cursor()

    sql = "CREATE TABLE data_b (id int PRIMERY KET,soldier VARCHAR(100));"
    cursor.execute(sql)

    conn.commit()
    cursor.