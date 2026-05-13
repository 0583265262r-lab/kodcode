# תרגיל 1
def get_adult_and_active_members(members_info):
    adult_active_members_names = []
    for member in members_info:
        name=member[0]
        age=member[1]
        is_adult=age >= 18
        is_active=member[2]
        if is_adult and is_active:
            adult_active_members_names.append(name)
    return adult_active_members_names

members_info = [
    ["Dan", 25, True],
    ["Noa", 16, True],
    ["Yael", 30, False],
]

print(get_adult_and_active_members(members_info))
# תרגיל 2
def is_valid_email(email):
    if not email:
        return False
    return True

def is_quantity_fits(quantity,stock):
    return quantity > 0 and quantity<stock

def calculate_price(product_price,quantity):
    return product_price*quantity

def discount_price(full_price,quantity):
    if quantity >= 50:
        return full_price*0.85
    if quantity >= 10:
        return full_price *0.9
    return full_price
def update_stock(stock,quantity):
    return stock-quantity
def print_invalid_message(invalid_data):
    print(f"invalid {invalid_data}")

def print_order_info(order_user,order_product,order_quantity,order_total,order_status):
    print(f"Order {order_status}: {order_user} bought {order_quantity}x {order_product} for ${order_total}")
    
def main(user_email,product_name,product_price,stock,quantity):
    if not is_valid_email(user_email):
        print_invalid_message('user')
        return None
    if not is_quantity_fits(quantity,stock):
        print_invalid_message('quantity')
        return None
    price=calculate_price(product_price,quantity)
    price=discount_price(price,quantity)
    stock=update_stock(stock,quantity)
    
    order_user = user_email
    order_product = product_name
    order_quantity = quantity
    order_total = price
    order_status = "confirmed"
    print_order_info(order_user, order_product, order_quantity, order_total, order_status)
    return order_user, order_product, order_quantity, order_total, order_status
# תרגיל 3
def manage_students(names, grades, new_name, new_grade):
    # validation
    if not new_name or len(new_name) < 2:
        print("Error: invalid name")
        return grades
    if new_grade < 0 or new_grade > 100:
        print("Error: grade must be 0-100")
        return grades

    # add student
    grades.append(new_grade)

    # calculate stats
    total = sum(grades)
    average = total / len(grades)
    top_count = sum(1 for g in grades if g >= 90)
    failing_count = sum(1 for g in grades if g < 56)

    # print report
    print("=== Student Report ===")
    for i in range(len(names)):
        print(f"  {names[i]}: {grades[i]}")
    print(f"Average: {average:.1f}")
    print(f"Top students: {top_count}")
    print(f"Failing: {failing_count}")

    # save to file
    with open("students.txt", "w") as f:
        for i in range(len(names)):
            f.write(f"{names[i]},{grades[i]}\n")

    return names, grades

def validation(new_name,new_grade):
    if not new_name or len(new_name) < 2:
        print("Error: invalid name")
        # return grades
    if new_grade < 0 or new_grade > 100:
        print("Error: grade must be 0-100")
        # return grades














        
        