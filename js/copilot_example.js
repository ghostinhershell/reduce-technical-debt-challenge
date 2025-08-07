# This function works, but could be improved for readability and long-term maintenance.
# Your challenge: reduce technical debt without changing the output.

import requests

def getData(url, value):
    x = requests.get(url)
    d = []
    for i in x.json():
        if value in i['name']:
            d.append(i['name'] + str(i['id']))
    print("Summary:")
    for k in d:
        print(k)
