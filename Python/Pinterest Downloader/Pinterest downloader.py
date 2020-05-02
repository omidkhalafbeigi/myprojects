from selenium import webdriver
import requests
chrome = webdriver.Chrome('/snap/bin/chromium.chromedriver')
chrome.get('https://www.pinterest.com/pin/389209592794524274/')
tags = chrome.find_elements_by_tag_name('img')
with open('/media/omid/Multimedia/Pinterest.png', 'wb') as file:
    get_address = tags[0].get_attribute('src')
    print(get_address)
    image_content = requests.get(get_address).content
    file.write(image_content)
    file.close()

print('Done')