import logging


def get_logger(name):

    logger=logging.getLogger(name)
    logger.setLevel(logging.DEBUG)
    stream_handler=logging.StreamHandler()
    file_handler=logging.FileHandler("payment.log",encoding="utf-8")
    formatter=logging.Formatter("%(asctime)s|%(levelname)s|%(name)s|%(message)s")
    stream_handler.setFormatter(formatter)
    file_handler.setFormatter(formatter)
    logger.addHandler(file_handler)
    logger.addHandler(stream_handler)
    return logger




