import pyodbc
import pandas
import os.path
import os

# Some other example server values are
# server = 'localhost\sqlexpress' # for a named instance
# server = 'myserver,port' # to specify an alternate port
def generate_etf():
    server = '.' 
    database = 'ISpanStockPortfolio' 
    username = 'sa5' 
    password = 'sa5' 


    rows = pandas.read_csv('StockList.csv')
    rows = rows[['代號', '名稱', '市場']]
    rows = rows[rows['市場'] == '市']
    print(rows)


    # ENCRYPT defaults to yes starting in ODBC Driver 18. It's good to always specify ENCRYPT=yes on the client side to avoid MITM attacks.
    cnxn = pyodbc.connect('DRIVER={ODBC Driver 18 for SQL Server};SERVER='+server+';DATABASE='+database+';ENCRYPT=no;UID='+username+';PWD='+ password)
    cursor = cnxn.cursor()

    for index, row in rows.iterrows():
        cursor.execute("""INSERT INTO Stocks(StockTypeId, Name, StockSymbol) VALUES (?, ?, ?)""", 1, row[1], row[0])
    cnxn.commit()
    cursor.close()

def generate_users():
    server = '.' 
    database = 'ISpanStockPortfolio' 
    username = 'sa5' 
    password = 'sa5' 


    rows = pandas.read_json('users.json')
    rows = rows[['users']]
    


    # ENCRYPT defaults to yes starting in ODBC Driver 18. It's good to always specify ENCRYPT=yes on the client side to avoid MITM attacks.
    cnxn = pyodbc.connect('DRIVER={ODBC Driver 18 for SQL Server};SERVER='+server+';DATABASE='+database+';ENCRYPT=no;UID='+username+';PWD='+ password)
    cursor = cnxn.cursor()

    for index, row in rows.iterrows():
        record = row["users"]
        cursor.execute("""INSERT INTO Users(Email, Password, CreatedTime) VALUES (?, ?, DEFAULT)""", record['email'], record['password'])

    cnxn.commit()
    cursor.close()

generate_users()