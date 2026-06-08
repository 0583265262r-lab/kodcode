import mysql.connector

def get_connection():
    return mysql.connector.connect(
                host="localhost",
                port=3306,
                user="root",
                password="secret",
                database="soldiers_db"
                )

def get_all()->list:
    '''מחזירה את כל החיילים'''
    conn = get_connection()
    cursor = conn.cursor(dictionary=True)
    sql = "SELECT * FROM soldiers"
    cursor.execute(sql)
    all_soldiers = cursor.fetchall()
    cursor.close()
    conn.close()
    return all_soldiers

def get_by_id(soldier_id: int) -> dict | None:
    conn = get_connection()
    cursor = conn.cursor(dictionary=True)
    
    sql = ("SELECT * FROM soldiers WHERE id = %s")
    cursor.execute(sql,(soldier_id,))
    soldier = cursor.fetchone()

    cursor.close()
    conn.close()
    return soldier

def create(name, soldier_rank, unit) -> int:
    conn = get_connection() 
    cursor = conn.cursor()

    sql = "INSERT INTO soldiers (name, soldier_rank, unit) VALUES (%s, %s, %s)"
    values = (name, soldier_rank, unit)
    cursor.execute(sql,values)
    conn.commit()

    new_id = cursor.lastrowid

    cursor.close()
    conn.close()
    return new_id

def update(soldier_id, data: dict) -> bool:
    conn = get_connection()
    cursor = conn.cursor()
    
    set_parts = []
    for key in data.keys():
        set_parts.append(f"{key} = %s")
    set_clause = ", ".join(set_parts)

    sql = "UPDATE soldiers SET" + set_clause + "WHERE id = %s"
    values = list(data.values()) + [soldier_id]
    
    cursor.execute(sql,values)
    conn.commit()

    changed = cursor.rowcount >0
    cursor.close()
    conn.close()

    return changed






if __name__ == "__main__":
    print(get_all())
    print(get_by_id(2))
    print(create("avi","privet","8200"))
    print(update(2,{"name":"moshe"}))







    
