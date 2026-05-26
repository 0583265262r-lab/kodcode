import logging
from logging_setup import get_logger

# 
# logging.basicConfig(level=logging.INFO,format="%(levelname)s|%(message)s")
# logger=logging.getLogger(__name__)
# def process_payment(user_id, amount):
#     logger.info(f'Starting payment for user {user_id}')
#     if amount <= 0:
#         logger.error('ERROR: Invalid amount')
#         return
#     if amount > 10000:
#         logger.warning('WARNING: Large transaction')
#     logger.info(f'Payment of {amount} completed for user {user_id}')
# process_payment(123,14476)
# 
# logger=logging.getLogger("payments")
# logger.setLevel(logging.DEBUG)
# file_handler=logging.FileHandler("payment.log",encoding="utf-8")
# formatter=logging.Formatter("%(asctime)s|%(levelname)s|%(name)s|%(message)s")
# file_handler.setFormatter(formatter)
# logger.addHandler(file_handler)
# def process_payment(user_id, amount):
#     logger.info(f'Starting payment for user {user_id}')
#     if amount <= 0:
#         logger.error('ERROR: Invalid amount')
#         return
#     if amount > 10000:
#         logger.warning('WARNING: Large transaction')
#     logger.info(f'Payment of {amount} completed for user {user_id}')
# process_payment(123,7589548)
# # 
# def read_config(filepath):
#     logger.debug(f"the func trying to open a file by name {filepath}")
#     
#     try:
#         with open(filepath) as f:
#             data = f.read()
#             logger.info(f"the file named {filepath} opened successfully")
        
#         
#         return data
#     except FileNotFoundError:
#         logger.exception(f"the func filed to open the file {filepath}")
#     
#         return None
# read_config("trt.txt")





# logging.basicConfig(level=logging.DEBUG)
# logger = logging.getLogger(__name__)
# def register_user(email, password, age):
#     has_password= bool(password)
#     logger.info('register from the user by email and password')
#     if age < 18:
#         logger.error(f'the user age is {age} and he need to 18')
#         return
#     logger.info('ok email=%s password=%s', email, has_password)
#     logger.info(f"The user's {email} login was successful")
# register_user("acvsv",3563763178,119)
# 
def module1():
    Building_logger=get_logger("Building_logger")
    Building_logger.info("start to build")
    Building_logger.warning("the build is slow")
    Building_logger.error("the build failed")
    
module1()
def check_stock():
    pass

def process_request(request_id, user_id, action):
    pass





