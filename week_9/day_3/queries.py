import mysql.connector

def get_connection():
    return mysql.connector.connect(
                host="localhost",
                port=3306,
                user="root",
                password="secret",
                database="soldiers_db"
                )
def get_all_soldiers_sorted_by_id()->list:
    '''מחזירה את כל החיילים'''
    conn = get_connection()
    cursor = conn.cursor(dictionary=True)
    sql = "SELECT * FROM soldiers ORDER BY id ASC"
    cursor.execute(sql)
    all_soldiers = cursor.fetchall()
    cursor.close()
    conn.close()
    return all_soldiers

def get_by_rank(rank:str) -> list:
    conn = get_connection()
    cursor = conn.cursor(dictionary=True)

    query = "SELECT * FROM soldiers WHERE soldier_rank = %s"
    cursor.execute(query,(rank,))
    rows = cursor.fetchall()
    cursor.close()
    conn.close()
    return rows

def get_active_sorted_by_name(order:str)->list:
    conn = get_connection()
    cursor = conn.cursor(dictionary=True)
    
    if order.lower() not in ["asc", "desc"]:
        order = "asc"
    query = f"SELECT * FROM soldiers WHERE active = TRUE ORDER BY name {order.upper()}"
    cursor.execute(query)
    rows = cursor.fetchall()
    cursor.close()
    conn.close()
    return rows

def get_distinct_units()-> list:
    conn = get_connection()
    cursor = conn.cursor(dictionary=True)

    query = "SELECT DISTINCT unit FROM soldiers"
    cursor.execute(query)
    rows = cursor.fetchall()
    cursor.close()
    conn.close()
    return rows

def search_by_name(term):
    conn = get_connection()
    cursor = conn.cursor(dictionary=True)

    query = "SELECT * FROM soldiers WHERE name LIKE %s"
    cursor.execute(query,(f"%{term}%",))
    rows = cursor.fetchall()
    cursor.close()
    conn.close()
    if cursor.lastrowid >0:
        return rows 
    else:
        return  None
def get_missing_rank():
    conn = get_connection()
    cursor = conn.cursor(dictionary=True)

    query = "SELECT * FROM soldiers WHERE soldier_rank IS NULL"
    cursor.execute(query)
    rows = cursor.fetchall()
    cursor.close()
    conn.close()
    return rows

def get_by_unit(unit):
    conn = get_connection()
    cursor = conn.cursor(dictionary=True)

    query = "SELECT * FROM soldiers WHERE unit = %s ORDER BY name ASC"
    cursor.execute(query,(unit,))
    rows = cursor.fetchall()
    cursor.close()
    conn.close()
    return rows

    
    





if __name__ == "__main__":

    print(get_by_rank('corporal'))
    print(get_active_sorted_by_name("asc"))
    print(get_distinct_units())
    print(search_by_name("n"))
    print(get_missing_rank())
    print(get_by_unit(8200))