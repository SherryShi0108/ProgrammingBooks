# Demo1 if
name='Mary'
if name=='Anna':
    print('Hello Anna')
else:
    print('Hello Mary')

# Demo2 elif
name='Anna'
if name=='Coco':
    print('Hello Coco')
elif name=='Anna':
    print('Hello Anna')
else: print("Oh No!")

# Demo3 while
spam=0
while spam<5:
    print('Hello,World!')
    spam=spam+1

# Demo4 for
print('My name is')
for i in range(5):
    print('this is'+str(i))

# Demo5 break
while True:
    print('Please type your name:')
    name=input()
    if name=='your name':
        break
print('Think you!')

# Demo6 continue
while True:
    print('Please enter your name')
    name=input()
    if name!='Coco':
        continue
    print('Hello Coco,what is your password')
    password=input()
    if(password=='123'):
        break
print('Access')

# Demo7 import
import math,random
for i in range(5):
    print(random.randint(1,100))