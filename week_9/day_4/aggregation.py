import mysql.connector
def get_connection():
    return mysql.connector.connect(
                host="localhost",
                port=3306,
                user="root",
                password="secret",
                database="soldiers_db"
                )
def get_summary():
    conn = get_connection()
    cursor = conn.cursor(dictionary=True)

    sql = "SELECT COUNT(*) as total FROM soldiers"
    cursor.execute(sql)
    total = cursor.fetchone()["total"]
    query = "SELECT COUNT(*) as active FROM soldiers WHERE active = True"
    cursor.execute(query)
    active = cursor.fetchone()["active"]
    cursor.close()
    conn.close()
    return {"total":total,"active":active,"nonactive":total - active}

def count_by_unit():
    conn = get_connection()
    cursor = conn.cursor(dictionary=True)

    sql = "SELECT unit, COUNT(*) AS total FROM soldiers GROUP BY unit ORDER BY total DESC"
    cursor.execute(sql)
    total_unit = cursor.fetchall()
    cursor.close()
    conn.close()
    
    return total_unit
def get_missing_data():
    conn = get_connection()
    cursor = conn.cursor(dictionary=True)

    sql = "SELECT * FROM soldiers  WHERE soldier_rank IS NULL;"
    cursor.execute(sql)
    soldier_rank = cursor.fetchall()
    cursor.close()
    conn.close()
    return soldier_rank

def get_units_with_multiple_soldiers():
    conn = get_connection()
    cursor = conn.cursor(dictionary=True)
    sql = "SELECT unit,COUNT(*) AS total FROM soldiers GROUP BY unit HAVING total > 1 "
    cursor.execute(sql)
    unit_with_more_then_1 = cursor.fetchall()
    cursor.close()
    conn.close()
    return unit_with_more_then_1






if __name__ == "__main__":
    # print(get_summary())
    # print(count_by_unit())
    # print(get_missing_data())
    print(get_units_with_multiple_soldiers())